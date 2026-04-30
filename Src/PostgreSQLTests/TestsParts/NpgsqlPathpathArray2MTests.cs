

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02631047266402764d, y: 0.6960701807773048d), new NpgsqlTypes.NpgsqlPoint(x: 0.10807498097386459d, y: 0.09131344121968799d), new NpgsqlTypes.NpgsqlPoint(x: 0.4290533237503523d, y: 0.6958270066418368d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9868535977380628d, y: 0.9716347258312737d), new NpgsqlTypes.NpgsqlPoint(x: 0.9992186432804543d, y: 0.5515928442060694d), new NpgsqlTypes.NpgsqlPoint(x: 0.650202524364449d, y: 0.32685189781482193d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.035555768260881804d, y: 0.9083009677425361d), new NpgsqlTypes.NpgsqlPoint(x: 0.7225530579288038d, y: 0.0929110519069738d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474970414638708d, y: 0.2955603189499787d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38790031231464106d, y: 0.5943888714996002d), new NpgsqlTypes.NpgsqlPoint(x: 0.05703429131966886d, y: 0.4450426691364956d), new NpgsqlTypes.NpgsqlPoint(x: 0.1914349666895463d, y: 0.9605714085442216d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19651468600603417d, y: 0.7382911651402777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7909821159117779d, y: 0.222618910653697d), new NpgsqlTypes.NpgsqlPoint(x: 0.5013300599608582d, y: 0.6928231713795403d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17229419604175178d, y: 0.9441439808680503d), new NpgsqlTypes.NpgsqlPoint(x: 0.6088600721540479d, y: 0.28344503511596775d), new NpgsqlTypes.NpgsqlPoint(x: 0.27597913997986345d, y: 0.5859429450507677d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12503783893116072d, y: 0.03537118725338395d), new NpgsqlTypes.NpgsqlPoint(x: 0.8558795285054118d, y: 0.8435099202750869d), new NpgsqlTypes.NpgsqlPoint(x: 0.8625731199732166d, y: 0.9841228166508345d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5357797475470383d, y: 0.184676371843994d), new NpgsqlTypes.NpgsqlPoint(x: 0.15962737055238718d, y: 0.6450932374796935d), new NpgsqlTypes.NpgsqlPoint(x: 0.6196243223669956d, y: 0.6014886736366443d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06140941668961086d, y: 0.25996379705989847d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569583937592395d, y: 0.10166937708557322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9568586148195248d, y: 0.9924559125229266d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5094516178265933d, y: 0.611119491980112d), new NpgsqlTypes.NpgsqlPoint(x: 0.7682728740429546d, y: 0.5067274580012389d), new NpgsqlTypes.NpgsqlPoint(x: 0.013249896636114866d, y: 0.04653236879370237d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0028762180696872974d, y: 0.26236738810201643d), new NpgsqlTypes.NpgsqlPoint(x: 0.3638163427469784d, y: 0.25899394895966565d), new NpgsqlTypes.NpgsqlPoint(x: 0.02484985437945053d, y: 0.41570804860298927d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13988028039751366d, y: 0.1119036395886378d), new NpgsqlTypes.NpgsqlPoint(x: 0.5930311099208913d, y: 0.186279585006075d), new NpgsqlTypes.NpgsqlPoint(x: 0.1438318329998558d, y: 0.48872110331178464d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8771879076161098d, y: 0.17211627240929017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7523158351017244d, y: 0.14308937207071903d), new NpgsqlTypes.NpgsqlPoint(x: 0.7836104371502229d, y: 0.8862937748175074d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7343895103849553d, y: 0.4315725883701643d), new NpgsqlTypes.NpgsqlPoint(x: 0.31667483044998357d, y: 0.31563462367797324d), new NpgsqlTypes.NpgsqlPoint(x: 0.9287250958300249d, y: 0.41425859147552424d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7059740188681032d, y: 0.03328797669180794d), new NpgsqlTypes.NpgsqlPoint(x: 0.45720278052641516d, y: 0.1590720901254401d), new NpgsqlTypes.NpgsqlPoint(x: 0.6604040544043365d, y: 0.4720148278814934d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8788122526171873d, y: 0.8555970669908672d), new NpgsqlTypes.NpgsqlPoint(x: 0.8782215473160031d, y: 0.38898340094159223d), new NpgsqlTypes.NpgsqlPoint(x: 0.289522450816874d, y: 0.0604601576898437d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8108742634560062d, y: 0.5576357481595267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6412251697274348d, y: 0.8753857918541399d), new NpgsqlTypes.NpgsqlPoint(x: 0.8732555051925497d, y: 0.426312322254805d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2944280747994298d, y: 0.5856763684286792d), new NpgsqlTypes.NpgsqlPoint(x: 0.2788792662190853d, y: 0.7543629474178525d), new NpgsqlTypes.NpgsqlPoint(x: 0.9057549111876333d, y: 0.9513026262611018d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5420970936170342d, y: 0.056004707798392284d), new NpgsqlTypes.NpgsqlPoint(x: 0.09138579237526867d, y: 0.49767864538112405d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307830105057041d, y: 0.656356230561935d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2619869839395752d, y: 0.09469134099982057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5072491611127853d, y: 0.29921122074629625d), new NpgsqlTypes.NpgsqlPoint(x: 0.44233631956481667d, y: 0.755229037131707d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4788480602536994d, y: 0.8684706870603347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7885626726502852d, y: 0.7752655773216063d), new NpgsqlTypes.NpgsqlPoint(x: 0.4260114706866883d, y: 0.5880291585136999d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6290867899339969d, y: 0.8161597876306341d), new NpgsqlTypes.NpgsqlPoint(x: 0.6222107956222668d, y: 0.7056458116953706d), new NpgsqlTypes.NpgsqlPoint(x: 0.7787945505830774d, y: 0.49063128110083165d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7536939556744856d, y: 0.5575189108096238d), new NpgsqlTypes.NpgsqlPoint(x: 0.007742688998690794d, y: 0.32578250336796843d), new NpgsqlTypes.NpgsqlPoint(x: 0.5148922529330531d, y: 0.5210425231722572d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5139889851806532d, y: 0.04117393344931175d), new NpgsqlTypes.NpgsqlPoint(x: 0.09099851122402236d, y: 0.4054242043926848d), new NpgsqlTypes.NpgsqlPoint(x: 0.19351869471380745d, y: 0.6785315588366635d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8647908267028864d, y: 0.3992873755334534d), new NpgsqlTypes.NpgsqlPoint(x: 0.915432260757518d, y: 0.6228291002239252d), new NpgsqlTypes.NpgsqlPoint(x: 0.7854323362181888d, y: 0.0692704196625501d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.337920080442873d, y: 0.29058656190946874d), new NpgsqlTypes.NpgsqlPoint(x: 0.24370984052253863d, y: 0.15817163915177934d), new NpgsqlTypes.NpgsqlPoint(x: 0.6837012132925152d, y: 0.2590093195053338d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7270826012311831d, y: 0.29809522121042353d), new NpgsqlTypes.NpgsqlPoint(x: 0.5834404701833752d, y: 0.5669361774324805d), new NpgsqlTypes.NpgsqlPoint(x: 0.4367537031985823d, y: 0.13923685166266575d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6798770844674246d, y: 0.5594021108113428d), new NpgsqlTypes.NpgsqlPoint(x: 0.33519012526589675d, y: 0.6838866385959594d), new NpgsqlTypes.NpgsqlPoint(x: 0.6850819448107404d, y: 0.8682321768413767d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5969814120655872d, y: 0.3113062830656499d), new NpgsqlTypes.NpgsqlPoint(x: 0.6375418643638103d, y: 0.5780032666381344d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334033976248579d, y: 0.838368961478665d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5086442978047934d, y: 0.8980716502282426d), new NpgsqlTypes.NpgsqlPoint(x: 0.4761730623833298d, y: 0.9637222352728775d), new NpgsqlTypes.NpgsqlPoint(x: 0.3612506957593046d, y: 0.5041621064738422d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8028945078249519d, y: 0.3657574041037924d), new NpgsqlTypes.NpgsqlPoint(x: 0.4196796742759017d, y: 0.7465268605357278d), new NpgsqlTypes.NpgsqlPoint(x: 0.4751286427259257d, y: 0.3057169963747013d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4295504556803761d, y: 0.7931376897402457d), new NpgsqlTypes.NpgsqlPoint(x: 0.11710574099814819d, y: 0.18846604014208646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9048431520737779d, y: 0.7241674101551633d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7685324714197646d, y: 0.6872880967011936d), new NpgsqlTypes.NpgsqlPoint(x: 0.2784778539631847d, y: 0.03111495895529881d), new NpgsqlTypes.NpgsqlPoint(x: 0.028811161426372522d, y: 0.047009064811389445d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8891772269187762d, y: 0.192417601402464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6261841453886328d, y: 0.9037182852013469d), new NpgsqlTypes.NpgsqlPoint(x: 0.5071825547229472d, y: 0.5149576264053912d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9392942638603986d, y: 0.49839274257224064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5916605103609233d, y: 0.8079734671861509d), new NpgsqlTypes.NpgsqlPoint(x: 0.5694402828327032d, y: 0.5039523801903327d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5223230137806916d, y: 0.030127843654625064d), new NpgsqlTypes.NpgsqlPoint(x: 0.18134348788327015d, y: 0.864871096076777d), new NpgsqlTypes.NpgsqlPoint(x: 0.6764670909702923d, y: 0.5786186565343254d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1089961342786927d, y: 0.9089172189520509d), new NpgsqlTypes.NpgsqlPoint(x: 0.03563430125802014d, y: 0.9987121231395772d), new NpgsqlTypes.NpgsqlPoint(x: 0.9191678197278521d, y: 0.28015176326265834d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6431998857436262d, y: 0.09294584374334847d), new NpgsqlTypes.NpgsqlPoint(x: 0.07270342605105895d, y: 0.7530964702528132d), new NpgsqlTypes.NpgsqlPoint(x: 0.8832043410008059d, y: 0.39245875908327066d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.897633476199556d, y: 0.7426156956817029d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927274776981043d, y: 0.6060441703915547d), new NpgsqlTypes.NpgsqlPoint(x: 0.052464763218784016d, y: 0.04501801517021298d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24488564677041313d, y: 0.3164398986821495d), new NpgsqlTypes.NpgsqlPoint(x: 0.5159804959288226d, y: 0.255094786343373d), new NpgsqlTypes.NpgsqlPoint(x: 0.7954168802967364d, y: 0.30977979644350073d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14680453751187394d, y: 0.9618203589363066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7866566241637377d, y: 0.3251295028354888d), new NpgsqlTypes.NpgsqlPoint(x: 0.5402321071987076d, y: 0.32025309189019413d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0857889316496413d, y: 0.5465004330027725d), new NpgsqlTypes.NpgsqlPoint(x: 0.01654215413773852d, y: 0.9006720313992185d), new NpgsqlTypes.NpgsqlPoint(x: 0.2773654415821517d, y: 0.0497831500598489d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9936942029814724d, y: 0.08827182173759007d), new NpgsqlTypes.NpgsqlPoint(x: 0.6694390650686872d, y: 0.6047787942624196d), new NpgsqlTypes.NpgsqlPoint(x: 0.8092433647121183d, y: 0.08865875052880834d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36429300662537756d, y: 0.4842341332621125d), new NpgsqlTypes.NpgsqlPoint(x: 0.5256213809056917d, y: 0.6006989611086283d), new NpgsqlTypes.NpgsqlPoint(x: 0.6074670593032533d, y: 0.4318998366273663d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8458980641746986d, y: 0.1549433532719624d), new NpgsqlTypes.NpgsqlPoint(x: 0.3850063260905511d, y: 0.8803676703925247d), new NpgsqlTypes.NpgsqlPoint(x: 0.14373585881508455d, y: 0.6401694047843502d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7549885871846543d, y: 0.8610237151529364d), new NpgsqlTypes.NpgsqlPoint(x: 0.18056781402558508d, y: 0.5203658615209237d), new NpgsqlTypes.NpgsqlPoint(x: 0.12063420265634561d, y: 0.4630007958141321d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6316347960884324d, y: 0.5343367773406278d), new NpgsqlTypes.NpgsqlPoint(x: 0.4072210724516564d, y: 0.42211596269480234d), new NpgsqlTypes.NpgsqlPoint(x: 0.17371406293527514d, y: 0.1906501575060332d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1897221354436568d, y: 0.08022398240922046d), new NpgsqlTypes.NpgsqlPoint(x: 0.39418147588163777d, y: 0.6581817645832659d), new NpgsqlTypes.NpgsqlPoint(x: 0.7090924667703189d, y: 0.8802107608726398d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15665791253883787d, y: 0.1782076166614841d), new NpgsqlTypes.NpgsqlPoint(x: 0.18912328565216563d, y: 0.11064936990071672d), new NpgsqlTypes.NpgsqlPoint(x: 0.5439880172661976d, y: 0.1770842137676787d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38301848826548646d, y: 0.1853157932916627d), new NpgsqlTypes.NpgsqlPoint(x: 0.39103840513436106d, y: 0.5922277529340436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5914598736449685d, y: 0.7253233743987707d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36198512801692306d, y: 0.898502168981977d), new NpgsqlTypes.NpgsqlPoint(x: 0.3970271169431768d, y: 0.30230315071696057d), new NpgsqlTypes.NpgsqlPoint(x: 0.8178037617577844d, y: 0.8110394405693482d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26375712960482667d, y: 0.8178381246344589d), new NpgsqlTypes.NpgsqlPoint(x: 0.6651191291178414d, y: 0.18572749465487326d), new NpgsqlTypes.NpgsqlPoint(x: 0.25004527800421994d, y: 0.9874120555893103d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010385378399517586d, y: 0.9432957252199775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7190978114509693d, y: 0.09880790095412184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5546313982010278d, y: 0.06263411575213884d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2837821391388189d, y: 0.7446679876548064d), new NpgsqlTypes.NpgsqlPoint(x: 0.8459397318132744d, y: 0.8535738067428593d), new NpgsqlTypes.NpgsqlPoint(x: 0.7482518363392023d, y: 0.027144131117899706d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31059500724539624d, y: 0.48624760939704337d), new NpgsqlTypes.NpgsqlPoint(x: 0.8039266552820585d, y: 0.5744478264764358d), new NpgsqlTypes.NpgsqlPoint(x: 0.07725013150679838d, y: 0.05799632273269928d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.72516853230671d, y: 0.49327891682128533d), new NpgsqlTypes.NpgsqlPoint(x: 0.7996656798144314d, y: 0.9494333259089017d), new NpgsqlTypes.NpgsqlPoint(x: 0.06700335809022462d, y: 0.15201609557759288d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5716084531514974d, y: 0.6776845910614263d), new NpgsqlTypes.NpgsqlPoint(x: 0.008433840491595679d, y: 0.7714246945424119d), new NpgsqlTypes.NpgsqlPoint(x: 0.05224751926001847d, y: 0.5340105841819913d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16210324792626274d, y: 0.16301337614361977d), new NpgsqlTypes.NpgsqlPoint(x: 0.46664946952618214d, y: 0.21688591351792175d), new NpgsqlTypes.NpgsqlPoint(x: 0.06650033046002668d, y: 0.6358340274214503d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9351505979816663d, y: 0.8681518102721334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7044700549167396d, y: 0.412960015088393d), new NpgsqlTypes.NpgsqlPoint(x: 0.25652422060487745d, y: 0.307434154446784d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3623122698434875d, y: 0.2424710772106068d), new NpgsqlTypes.NpgsqlPoint(x: 0.8673614723141677d, y: 0.5486517631841803d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298450524155017d, y: 0.994025711438041d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23877916635366425d, y: 0.42820634938967894d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989152189106439d, y: 0.8273423965475144d), new NpgsqlTypes.NpgsqlPoint(x: 0.9521876111653687d, y: 0.9452197445206386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0019102439816887085d, y: 0.5916865505351391d), new NpgsqlTypes.NpgsqlPoint(x: 0.20624354274562562d, y: 0.02823571467134789d), new NpgsqlTypes.NpgsqlPoint(x: 0.7938460016960674d, y: 0.7448035690369397d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11952578794666324d, y: 0.8943814402607159d), new NpgsqlTypes.NpgsqlPoint(x: 0.12394358341323841d, y: 0.1761350908561503d), new NpgsqlTypes.NpgsqlPoint(x: 0.952912707440208d, y: 0.6731158063865271d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7101758361912467d, y: 0.48413191853103454d), new NpgsqlTypes.NpgsqlPoint(x: 0.9346141289376553d, y: 0.28028913324048266d), new NpgsqlTypes.NpgsqlPoint(x: 0.04240700981546042d, y: 0.3278419830401442d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7284399166514958d, y: 0.8877869929775014d), new NpgsqlTypes.NpgsqlPoint(x: 0.50924895210801d, y: 0.19135364653690112d), new NpgsqlTypes.NpgsqlPoint(x: 0.9287733777772721d, y: 0.7175408754659259d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2803172495328359d, y: 0.9509350030325302d), new NpgsqlTypes.NpgsqlPoint(x: 0.954572647815509d, y: 0.8991234501359215d), new NpgsqlTypes.NpgsqlPoint(x: 0.6539315524443969d, y: 0.5905529027366857d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024441928225983678d, y: 0.4807534773540497d), new NpgsqlTypes.NpgsqlPoint(x: 0.956193578705244d, y: 0.700956224335167d), new NpgsqlTypes.NpgsqlPoint(x: 0.8339645254519623d, y: 0.0910815533882613d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49408964613495043d, y: 0.6604436391523739d), new NpgsqlTypes.NpgsqlPoint(x: 0.6045082159187107d, y: 0.35869135333321045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8503456001853075d, y: 0.2795276851882845d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14166634105197984d, y: 0.3194025300827388d), new NpgsqlTypes.NpgsqlPoint(x: 0.56201187630124d, y: 0.13417493434291283d), new NpgsqlTypes.NpgsqlPoint(x: 0.8518840041176698d, y: 0.9179918927609922d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2883708686208356d, y: 0.7565064788611504d), new NpgsqlTypes.NpgsqlPoint(x: 0.2405254892733808d, y: 0.5653467763286232d), new NpgsqlTypes.NpgsqlPoint(x: 0.32005931308468083d, y: 0.5508230983716204d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5766654545529476d, y: 0.8705751186019124d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651178324263398d, y: 0.37224934824128d), new NpgsqlTypes.NpgsqlPoint(x: 0.34387146743577945d, y: 0.16659402908072174d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9995563138416983d, y: 0.06228872711666489d), new NpgsqlTypes.NpgsqlPoint(x: 0.24490106624723051d, y: 0.3309020160904659d), new NpgsqlTypes.NpgsqlPoint(x: 0.039230774234927046d, y: 0.8380888464315279d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03570085870946216d, y: 0.12295291596390734d), new NpgsqlTypes.NpgsqlPoint(x: 0.5590484586096125d, y: 0.4186666000680581d), new NpgsqlTypes.NpgsqlPoint(x: 0.26682671657247914d, y: 0.06902116459025465d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.992007386918929d, y: 0.20147288404553731d), new NpgsqlTypes.NpgsqlPoint(x: 0.9264062494773607d, y: 0.6632493403147631d), new NpgsqlTypes.NpgsqlPoint(x: 0.018247217704624674d, y: 0.9047244146842169d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9478291004707433d, y: 0.4885203502483503d), new NpgsqlTypes.NpgsqlPoint(x: 0.631416289894314d, y: 0.04599790627090505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6514468044726545d, y: 0.7388959875090215d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7866020367133184d, y: 0.18538060829479497d), new NpgsqlTypes.NpgsqlPoint(x: 0.4170099034349035d, y: 0.750582193241096d), new NpgsqlTypes.NpgsqlPoint(x: 0.20641336137116073d, y: 0.7483170759458295d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5761245939651789d, y: 0.6911869958154826d), new NpgsqlTypes.NpgsqlPoint(x: 0.677628424984799d, y: 0.6271810704348925d), new NpgsqlTypes.NpgsqlPoint(x: 0.12678311772834172d, y: 0.8043130487456596d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24085367696769933d, y: 0.062291963272220086d), new NpgsqlTypes.NpgsqlPoint(x: 0.5618556141659556d, y: 0.5057328932256199d), new NpgsqlTypes.NpgsqlPoint(x: 0.6362060661091973d, y: 0.5811020836743382d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16352284238119363d, y: 0.04697945344481924d), new NpgsqlTypes.NpgsqlPoint(x: 0.9250890516201542d, y: 0.4547048283346793d), new NpgsqlTypes.NpgsqlPoint(x: 0.6097017988704627d, y: 0.9366031461862871d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29920038711456265d, y: 0.24703175807252686d), new NpgsqlTypes.NpgsqlPoint(x: 0.7418977051003633d, y: 0.7287046533031427d), new NpgsqlTypes.NpgsqlPoint(x: 0.5900388651619923d, y: 0.9618711088195178d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1566138716397325d, y: 0.7479826306903248d), new NpgsqlTypes.NpgsqlPoint(x: 0.9024773406187803d, y: 0.7264273407635534d), new NpgsqlTypes.NpgsqlPoint(x: 0.24640291151613092d, y: 0.049209020286919314d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5488396552987592d, y: 0.7395537411107981d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786842406935745d, y: 0.28504753302599173d), new NpgsqlTypes.NpgsqlPoint(x: 0.5619670487640674d, y: 0.6419646640728779d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12040856156767088d, y: 0.05143945436464781d), new NpgsqlTypes.NpgsqlPoint(x: 0.29671122099563296d, y: 0.9242189089858474d), new NpgsqlTypes.NpgsqlPoint(x: 0.4791030470482953d, y: 0.4184672465082643d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2548546844126126d, y: 0.5024589771891043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494925416725167d, y: 0.41199731451117716d), new NpgsqlTypes.NpgsqlPoint(x: 0.47775250795660007d, y: 0.26101650568043755d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33249491764255135d, y: 0.10719832010185892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8697994678680402d, y: 0.04853492776021051d), new NpgsqlTypes.NpgsqlPoint(x: 0.24783272278499857d, y: 0.7232924488791308d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5460591477772156d, y: 0.6051197594767866d), new NpgsqlTypes.NpgsqlPoint(x: 0.8550417940111127d, y: 0.8005085652384769d), new NpgsqlTypes.NpgsqlPoint(x: 0.6985755813484036d, y: 0.11395546263048095d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.951963973393869d, y: 0.849443673236379d), new NpgsqlTypes.NpgsqlPoint(x: 0.014288614410176592d, y: 0.4774319634399461d), new NpgsqlTypes.NpgsqlPoint(x: 0.9625951303458795d, y: 0.7297231567567226d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016304112806680093d, y: 0.26478327143633207d), new NpgsqlTypes.NpgsqlPoint(x: 0.780588721455737d, y: 0.45939778781818563d), new NpgsqlTypes.NpgsqlPoint(x: 0.5171839768767676d, y: 0.02427361141731832d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2766737942853592d, y: 0.6234340308693157d), new NpgsqlTypes.NpgsqlPoint(x: 0.4608315659930807d, y: 0.23569896864273887d), new NpgsqlTypes.NpgsqlPoint(x: 0.6029287909647031d, y: 0.13248044613476773d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6971596559420192d, y: 0.058405510323261356d), new NpgsqlTypes.NpgsqlPoint(x: 0.8922676025072082d, y: 0.12136745486589251d), new NpgsqlTypes.NpgsqlPoint(x: 0.7990341789478778d, y: 0.5547707832163573d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3087724759500251d, y: 0.542573640483753d), new NpgsqlTypes.NpgsqlPoint(x: 0.5676480115938959d, y: 0.7258188532411687d), new NpgsqlTypes.NpgsqlPoint(x: 0.6607562861522589d, y: 0.1423272226213187d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.852944100077046d, y: 0.8111642622981158d), new NpgsqlTypes.NpgsqlPoint(x: 0.5808082047787835d, y: 0.7439819911030733d), new NpgsqlTypes.NpgsqlPoint(x: 0.32873316682869924d, y: 0.8502862336369376d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2303843145473602d, y: 0.6892506283920365d), new NpgsqlTypes.NpgsqlPoint(x: 0.4809894339905634d, y: 0.8522950796642861d), new NpgsqlTypes.NpgsqlPoint(x: 0.9671389926765036d, y: 0.11359897691223964d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06454304568013902d, y: 0.0783539486908521d), new NpgsqlTypes.NpgsqlPoint(x: 0.6371382207454361d, y: 0.12153996584682758d), new NpgsqlTypes.NpgsqlPoint(x: 0.9901683575645194d, y: 0.6407767584887587d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17474354514593715d, y: 0.44695206176217395d), new NpgsqlTypes.NpgsqlPoint(x: 0.6425231573936778d, y: 0.9985928382448181d), new NpgsqlTypes.NpgsqlPoint(x: 0.6057124635441993d, y: 0.09981839124104719d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3131631894811949d, y: 0.8202398248417194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730627512788259d, y: 0.1073636624363109d), new NpgsqlTypes.NpgsqlPoint(x: 0.17891975185965703d, y: 0.7611374752970622d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1618681789549249d, y: 0.9422540914416302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7594888658190265d, y: 0.1242664230588536d), new NpgsqlTypes.NpgsqlPoint(x: 0.5775218219557567d, y: 0.3884536170160945d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.550381103781347d, y: 0.6003838744664551d), new NpgsqlTypes.NpgsqlPoint(x: 0.7566294067026831d, y: 0.4791483133500566d), new NpgsqlTypes.NpgsqlPoint(x: 0.6565001232608244d, y: 0.5792501159581843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6596807194149428d, y: 0.9448541381242404d), new NpgsqlTypes.NpgsqlPoint(x: 0.4232902527951784d, y: 0.5455458627112644d), new NpgsqlTypes.NpgsqlPoint(x: 0.4704176975953095d, y: 0.7790967739715884d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8976537943984825d, y: 0.6496403688901894d), new NpgsqlTypes.NpgsqlPoint(x: 0.3905565391406739d, y: 0.5830601526189974d), new NpgsqlTypes.NpgsqlPoint(x: 0.07568774838372172d, y: 0.422171386832618d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6254509555873783d, y: 0.43269286850283584d), new NpgsqlTypes.NpgsqlPoint(x: 0.12017250569912552d, y: 0.6101815966217837d), new NpgsqlTypes.NpgsqlPoint(x: 0.08532882282029242d, y: 0.7641680708472253d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42499124105023434d, y: 0.13692769693312123d), new NpgsqlTypes.NpgsqlPoint(x: 0.06687477487454474d, y: 0.8306387491824656d), new NpgsqlTypes.NpgsqlPoint(x: 0.222326458590709d, y: 0.07978659769701368d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7888405772377406d, y: 0.5544929289447925d), new NpgsqlTypes.NpgsqlPoint(x: 0.40977479520340465d, y: 0.25853878519698803d), new NpgsqlTypes.NpgsqlPoint(x: 0.9918213108357468d, y: 0.650260754566489d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6633234808001333d, y: 0.06435658224408058d), new NpgsqlTypes.NpgsqlPoint(x: 0.2932760978122393d, y: 0.10651795023035326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5047003595299193d, y: 0.901209792338516d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0004450856617871368d, y: 0.3365984233204302d), new NpgsqlTypes.NpgsqlPoint(x: 0.49051034649562464d, y: 0.1540671940760574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5413094347972341d, y: 0.14355381756394847d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5755718109968383d, y: 0.9980303538816744d), new NpgsqlTypes.NpgsqlPoint(x: 0.35852285484846036d, y: 0.7657076488065225d), new NpgsqlTypes.NpgsqlPoint(x: 0.40288380212823793d, y: 0.4058783232065969d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7310744754379177d, y: 0.9860227559516802d), new NpgsqlTypes.NpgsqlPoint(x: 0.04094826046901323d, y: 0.01618876551569881d), new NpgsqlTypes.NpgsqlPoint(x: 0.30974179455406325d, y: 0.059967615081506165d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33402002803383257d, y: 0.03479209613110423d), new NpgsqlTypes.NpgsqlPoint(x: 0.1768334372976802d, y: 0.5400990403748596d), new NpgsqlTypes.NpgsqlPoint(x: 0.2717403584563959d, y: 0.13420342285887954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.897267838263085d, y: 0.7829269986900728d), new NpgsqlTypes.NpgsqlPoint(x: 0.7268592955638409d, y: 0.2790132689767346d), new NpgsqlTypes.NpgsqlPoint(x: 0.03575673281828684d, y: 0.23488094970490248d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.776647410363444d, y: 0.48498667229159953d), new NpgsqlTypes.NpgsqlPoint(x: 0.07562966032449991d, y: 0.495105693109416d), new NpgsqlTypes.NpgsqlPoint(x: 0.8306334246562276d, y: 0.5973208599409734d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2316204523746599d, y: 0.4939356487960187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7898481025339655d, y: 0.7575607641266623d), new NpgsqlTypes.NpgsqlPoint(x: 0.7732531900739502d, y: 0.8097607161850032d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22817105229010104d, y: 0.44811506393547695d), new NpgsqlTypes.NpgsqlPoint(x: 0.3078711030743917d, y: 0.9743481246535284d), new NpgsqlTypes.NpgsqlPoint(x: 0.572385381212041d, y: 0.791501627044907d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3855328021313521d, y: 0.6035814339859729d), new NpgsqlTypes.NpgsqlPoint(x: 0.08289622433267196d, y: 0.9221500909681588d), new NpgsqlTypes.NpgsqlPoint(x: 0.28848555902306294d, y: 0.7918138275743732d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5105989837610406d, y: 0.8624952843267023d), new NpgsqlTypes.NpgsqlPoint(x: 0.15704074910394406d, y: 0.3113112662237705d), new NpgsqlTypes.NpgsqlPoint(x: 0.9741907627255395d, y: 0.4607640874064678d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.017702089237595975d, y: 0.7615709795323861d), new NpgsqlTypes.NpgsqlPoint(x: 0.00909204923256568d, y: 0.7631057041494156d), new NpgsqlTypes.NpgsqlPoint(x: 0.10885395070654746d, y: 0.7242870254908795d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8289351389751325d, y: 0.48796083974451376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9802485663112313d, y: 0.054527714926681514d), new NpgsqlTypes.NpgsqlPoint(x: 0.5404702870632271d, y: 0.16930806741477422d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49709393295021553d, y: 0.4137852018840824d), new NpgsqlTypes.NpgsqlPoint(x: 0.5777229849319417d, y: 0.9527317747236178d), new NpgsqlTypes.NpgsqlPoint(x: 0.386820371978041d, y: 0.5562085159427417d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31844218580393724d, y: 0.028870880443685243d), new NpgsqlTypes.NpgsqlPoint(x: 0.6790505166847777d, y: 0.2181976342138784d), new NpgsqlTypes.NpgsqlPoint(x: 0.7444841447143946d, y: 0.5331601030958001d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41209748555099235d, y: 0.05288599606296274d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492795226871371d, y: 0.00771855256727616d), new NpgsqlTypes.NpgsqlPoint(x: 0.9402751614804175d, y: 0.19769313512269504d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5219498031661453d, y: 0.7449456456411435d), new NpgsqlTypes.NpgsqlPoint(x: 0.04854127092286953d, y: 0.14886864065978012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8822828133254659d, y: 0.9180790766376473d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05521026252308636d, y: 0.19389125322250633d), new NpgsqlTypes.NpgsqlPoint(x: 0.6512443979272334d, y: 0.6730531256390477d), new NpgsqlTypes.NpgsqlPoint(x: 0.01979040543754551d, y: 0.42440343262222757d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1849198227734633d, y: 0.5100028637487153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9104208056526043d, y: 0.003047576443418465d), new NpgsqlTypes.NpgsqlPoint(x: 0.42024759168147374d, y: 0.4287052265489978d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8548355071996188d, y: 0.22608768386496547d), new NpgsqlTypes.NpgsqlPoint(x: 0.43258173634598596d, y: 0.8524997110971417d), new NpgsqlTypes.NpgsqlPoint(x: 0.12166868380867168d, y: 0.13238594736174647d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33206042999217356d, y: 0.4673214961935125d), new NpgsqlTypes.NpgsqlPoint(x: 0.053941949984824156d, y: 0.9759192930295002d), new NpgsqlTypes.NpgsqlPoint(x: 0.7086783820351188d, y: 0.2155528974238532d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9044857913879791d, y: 0.5375828622613211d), new NpgsqlTypes.NpgsqlPoint(x: 0.5896030811531419d, y: 0.4057122773302799d), new NpgsqlTypes.NpgsqlPoint(x: 0.19571900680966015d, y: 0.3250009129922161d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3179094395786024d, y: 0.6786556303953566d), new NpgsqlTypes.NpgsqlPoint(x: 0.29106400150143774d, y: 0.9943555327458341d), new NpgsqlTypes.NpgsqlPoint(x: 0.8461150561308384d, y: 0.15489144206545657d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39442352527971203d, y: 0.24449455309346357d), new NpgsqlTypes.NpgsqlPoint(x: 0.47032477221989166d, y: 0.30669002981452254d), new NpgsqlTypes.NpgsqlPoint(x: 0.7767938268196146d, y: 0.9803986808896317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03656320583354056d, y: 0.2025763646961718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6429271983171123d, y: 0.061850070244157895d), new NpgsqlTypes.NpgsqlPoint(x: 0.3065052749988898d, y: 0.23867247343034415d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5620442796039699d, y: 0.6969273426761118d), new NpgsqlTypes.NpgsqlPoint(x: 0.07826502232836452d, y: 0.35337577508815277d), new NpgsqlTypes.NpgsqlPoint(x: 0.1629787046483231d, y: 0.584177788196157d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09749319868815587d, y: 0.8913510780590599d), new NpgsqlTypes.NpgsqlPoint(x: 0.6606831661327272d, y: 0.5187857442202386d), new NpgsqlTypes.NpgsqlPoint(x: 0.41312772951992827d, y: 0.6789147253403287d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12177335429434477d, y: 0.4708696385047155d), new NpgsqlTypes.NpgsqlPoint(x: 0.2928616936216012d, y: 0.6842007343974168d), new NpgsqlTypes.NpgsqlPoint(x: 0.7462088108401352d, y: 0.6744609925241735d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38873608012439986d, y: 0.571677261558122d), new NpgsqlTypes.NpgsqlPoint(x: 0.8926252625928623d, y: 0.8205569281413455d), new NpgsqlTypes.NpgsqlPoint(x: 0.0893741245719607d, y: 0.27333365389039743d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.354666792006462d, y: 0.4465308608078037d), new NpgsqlTypes.NpgsqlPoint(x: 0.498065277767355d, y: 0.05617821143408597d), new NpgsqlTypes.NpgsqlPoint(x: 0.4694120172336159d, y: 0.9735064747296351d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8069949120603931d, y: 0.5418262857638997d), new NpgsqlTypes.NpgsqlPoint(x: 0.9563549626218147d, y: 0.09093948152835518d), new NpgsqlTypes.NpgsqlPoint(x: 0.5687425715450416d, y: 0.2643389764868326d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7574200119410879d, y: 0.8013158275371889d), new NpgsqlTypes.NpgsqlPoint(x: 0.2573428700699032d, y: 0.13381658486628434d), new NpgsqlTypes.NpgsqlPoint(x: 0.45365842809942414d, y: 0.42611110869222846d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5880556827716689d, y: 0.999987527476756d), new NpgsqlTypes.NpgsqlPoint(x: 0.08230378610444888d, y: 0.37497226230297775d), new NpgsqlTypes.NpgsqlPoint(x: 0.19626619764060682d, y: 0.7219711410053464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014576490765582872d, y: 0.49977552406317205d), new NpgsqlTypes.NpgsqlPoint(x: 0.4777571750950955d, y: 0.5668442597371176d), new NpgsqlTypes.NpgsqlPoint(x: 0.3048448827720356d, y: 0.5556477946553011d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03911403496948218d, y: 0.39816156480325726d), new NpgsqlTypes.NpgsqlPoint(x: 0.96786824569146d, y: 0.01912454416411813d), new NpgsqlTypes.NpgsqlPoint(x: 0.874378912064118d, y: 0.7133261911649028d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7030484853091882d, y: 0.7472731288384028d), new NpgsqlTypes.NpgsqlPoint(x: 0.35564714181781987d, y: 0.27445559667421504d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776522527897125d, y: 0.5501014852042334d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31666745736966084d, y: 0.2516595058226978d), new NpgsqlTypes.NpgsqlPoint(x: 0.795377266299428d, y: 0.530911732770171d), new NpgsqlTypes.NpgsqlPoint(x: 0.1207111389261204d, y: 0.20901428675211653d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8551849053015779d, y: 0.5057909118257319d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455102484907501d, y: 0.3954751409460646d), new NpgsqlTypes.NpgsqlPoint(x: 0.32268693155281114d, y: 0.9376562921364273d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9620538854768402d, y: 0.8324679885265484d), new NpgsqlTypes.NpgsqlPoint(x: 0.8644949155356869d, y: 0.646220265658232d), new NpgsqlTypes.NpgsqlPoint(x: 0.27648506341233214d, y: 0.989409684198206d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7611925627898362d, y: 0.3816806078635012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8190582467126877d, y: 0.8496272405173768d), new NpgsqlTypes.NpgsqlPoint(x: 0.07496982755200898d, y: 0.6436424753752461d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9336255657652698d, y: 0.6299346570240921d), new NpgsqlTypes.NpgsqlPoint(x: 0.5063397566252631d, y: 0.6078928710806195d), new NpgsqlTypes.NpgsqlPoint(x: 0.7257105841918783d, y: 0.9196939544660673d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9861997420435973d, y: 0.15476532556144895d), new NpgsqlTypes.NpgsqlPoint(x: 0.3826328401004593d, y: 0.12891094560497263d), new NpgsqlTypes.NpgsqlPoint(x: 0.15282991997171802d, y: 0.6163299571507471d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3118886571045424d, y: 0.23381775388966153d), new NpgsqlTypes.NpgsqlPoint(x: 0.465531937435149d, y: 0.0794841011517442d), new NpgsqlTypes.NpgsqlPoint(x: 0.802354591439188d, y: 0.7795287361060281d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31922460416803233d, y: 0.024133774398240715d), new NpgsqlTypes.NpgsqlPoint(x: 0.020694220422182052d, y: 0.21965927700490873d), new NpgsqlTypes.NpgsqlPoint(x: 0.3553564245799934d, y: 0.021268114857866727d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.60173160174089d, y: 0.5045224457377881d), new NpgsqlTypes.NpgsqlPoint(x: 0.20942529644565988d, y: 0.49612944037405793d), new NpgsqlTypes.NpgsqlPoint(x: 0.8084974361693352d, y: 0.9600919312134727d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6012174403727797d, y: 0.5976642659732354d), new NpgsqlTypes.NpgsqlPoint(x: 0.4137348777672054d, y: 0.725242770439184d), new NpgsqlTypes.NpgsqlPoint(x: 0.793402221113283d, y: 0.5960272009057758d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3218793157231449d, y: 0.3890049787242874d), new NpgsqlTypes.NpgsqlPoint(x: 0.16014972802772653d, y: 0.5006264638448198d), new NpgsqlTypes.NpgsqlPoint(x: 0.10738507422069854d, y: 0.21791301950603625d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4034579947032054d, y: 0.9599568439026605d), new NpgsqlTypes.NpgsqlPoint(x: 0.010652441473458674d, y: 0.48552272477220404d), new NpgsqlTypes.NpgsqlPoint(x: 0.47535060191483935d, y: 0.0350369052210171d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08039890328626675d, y: 0.1414434175395355d), new NpgsqlTypes.NpgsqlPoint(x: 0.5820495339019865d, y: 0.5426849079548698d), new NpgsqlTypes.NpgsqlPoint(x: 0.9213149345432919d, y: 0.5676862496038623d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9131700093712334d, y: 0.9296853641479605d), new NpgsqlTypes.NpgsqlPoint(x: 0.6641932875796117d, y: 0.5051157685848002d), new NpgsqlTypes.NpgsqlPoint(x: 0.2832097440178645d, y: 0.31581668425364606d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4686522098358076d, y: 0.5215430569822169d), new NpgsqlTypes.NpgsqlPoint(x: 0.8733660306441531d, y: 0.39810222924977035d), new NpgsqlTypes.NpgsqlPoint(x: 0.6116021082723396d, y: 0.6767924202941601d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07263220271001625d, y: 0.584377013044641d), new NpgsqlTypes.NpgsqlPoint(x: 0.03473584585868994d, y: 0.3755436361216463d), new NpgsqlTypes.NpgsqlPoint(x: 0.9458251048589112d, y: 0.8630112806103706d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19875410901213864d, y: 0.5256953123314658d), new NpgsqlTypes.NpgsqlPoint(x: 0.43535760928054357d, y: 0.5097746822712426d), new NpgsqlTypes.NpgsqlPoint(x: 0.6105866280790224d, y: 0.5972641313440783d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8253428688300624d, y: 0.5450142407464406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5943476956308168d, y: 0.5408329630090544d), new NpgsqlTypes.NpgsqlPoint(x: 0.9623729131709841d, y: 0.6543027719580207d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4423868881708688d, y: 0.3693300548304519d), new NpgsqlTypes.NpgsqlPoint(x: 0.5390962589562368d, y: 0.28154626666750093d), new NpgsqlTypes.NpgsqlPoint(x: 0.22362994879846643d, y: 0.6804316614019553d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2391280199080107d, y: 0.317507636122242d), new NpgsqlTypes.NpgsqlPoint(x: 0.4239638350177022d, y: 0.043799861014417796d), new NpgsqlTypes.NpgsqlPoint(x: 0.9921134671865579d, y: 0.37500345128636514d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2604157316867537d, y: 0.45339912922315373d), new NpgsqlTypes.NpgsqlPoint(x: 0.14491647609752967d, y: 0.6874591150124324d), new NpgsqlTypes.NpgsqlPoint(x: 0.19235227709698177d, y: 0.9862996820628052d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5333762806018384d, y: 0.16044790045379598d), new NpgsqlTypes.NpgsqlPoint(x: 0.1783334180081959d, y: 0.05669937177144968d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510889304252882d, y: 0.4067713324553197d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26491158266741244d, y: 0.1482103903905474d), new NpgsqlTypes.NpgsqlPoint(x: 0.8421927759630361d, y: 0.01697540420557686d), new NpgsqlTypes.NpgsqlPoint(x: 0.021086103357299213d, y: 0.8592351518139563d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6348863345705397d, y: 0.9275917523479676d), new NpgsqlTypes.NpgsqlPoint(x: 0.5551033348590539d, y: 0.45964689468508746d), new NpgsqlTypes.NpgsqlPoint(x: 0.9468459165564889d, y: 0.28824138161962487d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9735261595669938d, y: 0.4148836222806137d), new NpgsqlTypes.NpgsqlPoint(x: 0.9155040958500587d, y: 0.23875682185472902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6326563056960575d, y: 0.26540262693005334d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34840788022383573d, y: 0.3716691339340007d), new NpgsqlTypes.NpgsqlPoint(x: 0.43910656096599154d, y: 0.058122241730937385d), new NpgsqlTypes.NpgsqlPoint(x: 0.06560661075053464d, y: 0.5251633900115215d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7375227347667385d, y: 0.13710529361535384d), new NpgsqlTypes.NpgsqlPoint(x: 0.6718859468896223d, y: 0.5644842403344749d), new NpgsqlTypes.NpgsqlPoint(x: 0.010114020474048968d, y: 0.6941498120105549d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2640551051772041d, y: 0.08558800205947936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8755550887771605d, y: 0.7930522846945591d), new NpgsqlTypes.NpgsqlPoint(x: 0.0917132129481315d, y: 0.6159167090119866d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0592877294436952d, y: 0.4678115861291189d), new NpgsqlTypes.NpgsqlPoint(x: 0.3313006573829389d, y: 0.6181801132567654d), new NpgsqlTypes.NpgsqlPoint(x: 0.767064807153708d, y: 0.10429731278423948d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9369546247164159d, y: 0.40457323758237596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6750251766263861d, y: 0.5295967574299955d), new NpgsqlTypes.NpgsqlPoint(x: 0.6580993908625783d, y: 0.8121074243857429d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8913212565616021d, y: 0.2875541138790233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5753611616162835d, y: 0.35330506905486236d), new NpgsqlTypes.NpgsqlPoint(x: 0.5066358111904078d, y: 0.6894681618535228d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7594216299648757d, y: 0.41642447587842957d), new NpgsqlTypes.NpgsqlPoint(x: 0.15927675883574044d, y: 0.825192765208676d), new NpgsqlTypes.NpgsqlPoint(x: 0.6871045800789252d, y: 0.18166504058630117d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10990036364163092d, y: 0.9915533884117396d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439137152292973d, y: 0.7259431876565594d), new NpgsqlTypes.NpgsqlPoint(x: 0.1501653377664609d, y: 0.6265393411047555d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011529578045789024d, y: 0.36504410572988744d), new NpgsqlTypes.NpgsqlPoint(x: 0.9262033468810369d, y: 0.6425867730581687d), new NpgsqlTypes.NpgsqlPoint(x: 0.5593896924744042d, y: 0.38815268320770735d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8800675140717904d, y: 0.08072756402881287d), new NpgsqlTypes.NpgsqlPoint(x: 0.5670735411900926d, y: 0.01745020904826311d), new NpgsqlTypes.NpgsqlPoint(x: 0.44928040765021116d, y: 0.6244226591518975d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3111492639182005d, y: 0.4016489250564469d), new NpgsqlTypes.NpgsqlPoint(x: 0.2212413005242495d, y: 0.7011570779165873d), new NpgsqlTypes.NpgsqlPoint(x: 0.8204156811451658d, y: 0.9936530942880745d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4922416270050485d, y: 0.724251983070978d), new NpgsqlTypes.NpgsqlPoint(x: 0.8808031829979981d, y: 0.3524910785162795d), new NpgsqlTypes.NpgsqlPoint(x: 0.1002045660699884d, y: 0.12873834251871863d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6373313027781692d, y: 0.18326588427551915d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161004872605841d, y: 0.511513379872618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8365553238154926d, y: 0.56066668324091d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11563831052349227d, y: 0.6849609570892451d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371789550662008d, y: 0.35209509138378803d), new NpgsqlTypes.NpgsqlPoint(x: 0.9401444629527321d, y: 0.4739655919082115d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9838953891674171d, y: 0.10029046450087087d), new NpgsqlTypes.NpgsqlPoint(x: 0.3959849711390683d, y: 0.36366511289638626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6991031479456032d, y: 0.14506729668902485d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6110324206529115d, y: 0.4069997982902155d), new NpgsqlTypes.NpgsqlPoint(x: 0.36364464937950325d, y: 0.0325700826743337d), new NpgsqlTypes.NpgsqlPoint(x: 0.868799407980666d, y: 0.29263904257538687d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27569588352339114d, y: 0.18344355167186643d), new NpgsqlTypes.NpgsqlPoint(x: 0.48655658387635814d, y: 0.4218338035447804d), new NpgsqlTypes.NpgsqlPoint(x: 0.3872837600512239d, y: 0.002186035539789133d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9099079345161581d, y: 0.7568872593169423d), new NpgsqlTypes.NpgsqlPoint(x: 0.22109242352742986d, y: 0.1331866446648189d), new NpgsqlTypes.NpgsqlPoint(x: 0.4998663463293572d, y: 0.2728096157174472d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32845430877849524d, y: 0.14882555454006485d), new NpgsqlTypes.NpgsqlPoint(x: 0.7212532167195554d, y: 0.41763782111996406d), new NpgsqlTypes.NpgsqlPoint(x: 0.028480707910816805d, y: 0.5451278504788398d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4895435243086945d, y: 0.10598320245025394d), new NpgsqlTypes.NpgsqlPoint(x: 0.3667766101352168d, y: 0.9403899394197466d), new NpgsqlTypes.NpgsqlPoint(x: 0.13770305428914076d, y: 0.9847268626620108d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3421269597271125d, y: 0.9856374156851379d), new NpgsqlTypes.NpgsqlPoint(x: 0.9972535225901781d, y: 0.48329192339078764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6814790912656852d, y: 0.07456518394059664d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.001380930625932475d, y: 0.4160544641046594d), new NpgsqlTypes.NpgsqlPoint(x: 0.875415405306324d, y: 0.9563882099723321d), new NpgsqlTypes.NpgsqlPoint(x: 0.6565676169024881d, y: 0.8820556244150796d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5757753458540613d, y: 0.0774200424071061d), new NpgsqlTypes.NpgsqlPoint(x: 0.7330645505483843d, y: 0.6067402860640576d), new NpgsqlTypes.NpgsqlPoint(x: 0.6479567794700879d, y: 0.01691937544102906d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9016467441872154d, y: 0.22760834324307122d), new NpgsqlTypes.NpgsqlPoint(x: 0.9361969403509712d, y: 0.21410458297069657d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752418147594486d, y: 0.775523467584957d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6765913989158057d, y: 0.1947791781269076d), new NpgsqlTypes.NpgsqlPoint(x: 0.8519804938175528d, y: 0.833690819373472d), new NpgsqlTypes.NpgsqlPoint(x: 0.49952332980308845d, y: 0.45374920818869824d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8652171183485042d, y: 0.667188228682364d), new NpgsqlTypes.NpgsqlPoint(x: 0.6020247933673082d, y: 0.5771758803273316d), new NpgsqlTypes.NpgsqlPoint(x: 0.4586451325148565d, y: 0.8464601737148459d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5717479956416607d, y: 0.7939688846115749d), new NpgsqlTypes.NpgsqlPoint(x: 0.44170861779559156d, y: 0.3049019618627071d), new NpgsqlTypes.NpgsqlPoint(x: 0.07697713248672744d, y: 0.8847804109307361d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07999576608292636d, y: 0.8389107785526623d), new NpgsqlTypes.NpgsqlPoint(x: 0.7169244065609203d, y: 0.9736090179871774d), new NpgsqlTypes.NpgsqlPoint(x: 0.6029294187476789d, y: 0.07070530636233496d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8131439367207363d, y: 0.8679798262309381d), new NpgsqlTypes.NpgsqlPoint(x: 0.37113394638540265d, y: 0.9057456528081114d), new NpgsqlTypes.NpgsqlPoint(x: 0.09430918301926527d, y: 0.06922718226065117d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3825184560524424d, y: 0.16197150098707314d), new NpgsqlTypes.NpgsqlPoint(x: 0.12164739110631273d, y: 0.8787143320369459d), new NpgsqlTypes.NpgsqlPoint(x: 0.9969737945246759d, y: 0.07132014443712098d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7503772942904903d, y: 0.5000030908282854d), new NpgsqlTypes.NpgsqlPoint(x: 0.35244416986608296d, y: 0.07088564706370648d), new NpgsqlTypes.NpgsqlPoint(x: 0.9224946746619391d, y: 0.20857781774280348d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9710568576845944d, y: 0.883705828871053d), new NpgsqlTypes.NpgsqlPoint(x: 0.9245869830392544d, y: 0.6619118276533562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5034541061662177d, y: 0.896499275732873d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07161461050156703d, y: 0.9715515900304303d), new NpgsqlTypes.NpgsqlPoint(x: 0.18156027599555735d, y: 0.3882593124260405d), new NpgsqlTypes.NpgsqlPoint(x: 0.2500736625496982d, y: 0.11577463640491392d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.053356820152703155d, y: 0.5028125543217765d), new NpgsqlTypes.NpgsqlPoint(x: 0.07647045611801717d, y: 0.13115780282857326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5212213313706561d, y: 0.24476656222865334d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6083936767979178d, y: 0.8552002913983678d), new NpgsqlTypes.NpgsqlPoint(x: 0.4271876580503582d, y: 0.8025555384269009d), new NpgsqlTypes.NpgsqlPoint(x: 0.13171279555345505d, y: 0.8697540719502619d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33164968808681405d, y: 0.09895888699736421d), new NpgsqlTypes.NpgsqlPoint(x: 0.34608871998750634d, y: 0.8457671410585554d), new NpgsqlTypes.NpgsqlPoint(x: 0.3081562420903262d, y: 0.017207070856221085d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3080368652574056d, y: 0.6395542676666627d), new NpgsqlTypes.NpgsqlPoint(x: 0.8368450228712122d, y: 0.5959012849714448d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848976668920189d, y: 0.24631029797769766d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9441702525364642d, y: 0.09364789587124933d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218397880560071d, y: 0.36722888508713736d), new NpgsqlTypes.NpgsqlPoint(x: 0.37032221937944787d, y: 0.3426769118548244d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8145250691944361d, y: 0.24120021388944635d), new NpgsqlTypes.NpgsqlPoint(x: 0.71785996627685d, y: 0.9428294000426186d), new NpgsqlTypes.NpgsqlPoint(x: 0.8607768675918321d, y: 0.6317215062252047d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16284273229923463d, y: 0.0816526321579848d), new NpgsqlTypes.NpgsqlPoint(x: 0.46852053250002057d, y: 0.334925772257175d), new NpgsqlTypes.NpgsqlPoint(x: 0.17100357311357606d, y: 0.6430104989660482d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1706556690620218d, y: 0.09566661021850897d), new NpgsqlTypes.NpgsqlPoint(x: 0.9964773910890211d, y: 0.8585414218774049d), new NpgsqlTypes.NpgsqlPoint(x: 0.617063426129455d, y: 0.03238792390765677d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4727836503237741d, y: 0.5052836530179488d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868593609726251d, y: 0.09024465837641493d), new NpgsqlTypes.NpgsqlPoint(x: 0.32869589872866134d, y: 0.26882443444871285d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8461002533531373d, y: 0.0005877498774364831d), new NpgsqlTypes.NpgsqlPoint(x: 0.028585752618536242d, y: 0.5057170776717758d), new NpgsqlTypes.NpgsqlPoint(x: 0.17973410977692117d, y: 0.0932002695725912d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47844151908500876d, y: 0.80621759012083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6440774681522579d, y: 0.6767350647483531d), new NpgsqlTypes.NpgsqlPoint(x: 0.14081446459938152d, y: 0.8099488997285346d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.684150415800563d, y: 0.8223613357658032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6773039898880217d, y: 0.3750703454373774d), new NpgsqlTypes.NpgsqlPoint(x: 0.2641577587522429d, y: 0.25734206286401495d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9981792389796558d, y: 0.9262028999090659d), new NpgsqlTypes.NpgsqlPoint(x: 0.4591195956480211d, y: 0.10050069679729445d), new NpgsqlTypes.NpgsqlPoint(x: 0.8600062771730193d, y: 0.8268288119630867d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.665842693284015d, y: 0.09435920181099433d), new NpgsqlTypes.NpgsqlPoint(x: 0.691034096405704d, y: 0.23329702645817485d), new NpgsqlTypes.NpgsqlPoint(x: 0.21524159946050736d, y: 0.29332313900793994d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4542684832857028d, y: 0.8421730472736253d), new NpgsqlTypes.NpgsqlPoint(x: 0.8398895551682343d, y: 0.816488379617471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5043868101627029d, y: 0.9680196423274925d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6224470802279028d, y: 0.22775176494317206d), new NpgsqlTypes.NpgsqlPoint(x: 0.923433896013138d, y: 0.6827889231795414d), new NpgsqlTypes.NpgsqlPoint(x: 0.24511096573980473d, y: 0.6519378707363941d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47312963142519837d, y: 0.11036069326789055d), new NpgsqlTypes.NpgsqlPoint(x: 0.2860815769345396d, y: 0.6882470701970832d), new NpgsqlTypes.NpgsqlPoint(x: 0.6480813905360892d, y: 0.5117689135982255d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4303968408492236d, y: 0.27450943184562204d), new NpgsqlTypes.NpgsqlPoint(x: 0.4759546010005635d, y: 0.9975296461366094d), new NpgsqlTypes.NpgsqlPoint(x: 0.7470630249923309d, y: 0.7259048681961533d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8810239056688723d, y: 0.6343204104957831d), new NpgsqlTypes.NpgsqlPoint(x: 0.43212097989496534d, y: 0.4538971913181661d), new NpgsqlTypes.NpgsqlPoint(x: 0.34302021271198035d, y: 0.8701466139032502d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12445394075854022d, y: 0.7222022720325212d), new NpgsqlTypes.NpgsqlPoint(x: 0.12199710952694165d, y: 0.15904077579752207d), new NpgsqlTypes.NpgsqlPoint(x: 0.5005502616021925d, y: 0.3967516802539661d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07886809624699731d, y: 0.20462734576601516d), new NpgsqlTypes.NpgsqlPoint(x: 0.38325309298032106d, y: 0.26208918978156814d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575595762248388d, y: 0.9806484854689065d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17793260666190414d, y: 0.9645948694079918d), new NpgsqlTypes.NpgsqlPoint(x: 0.8901684372469505d, y: 0.710941542277013d), new NpgsqlTypes.NpgsqlPoint(x: 0.17313325962653903d, y: 0.134981264231412d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21013652793435955d, y: 0.7108626357696235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9357245024152379d, y: 0.5909691995664255d), new NpgsqlTypes.NpgsqlPoint(x: 0.8042884647406441d, y: 0.903026696735598d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10262410457582205d, y: 0.8651821764647124d), new NpgsqlTypes.NpgsqlPoint(x: 0.892243673083674d, y: 0.7795991684588857d), new NpgsqlTypes.NpgsqlPoint(x: 0.5308103530508821d, y: 0.8342003322935491d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49132506585684743d, y: 0.004129038052760325d), new NpgsqlTypes.NpgsqlPoint(x: 0.02026612640482539d, y: 0.010762088335004139d), new NpgsqlTypes.NpgsqlPoint(x: 0.42315246835655274d, y: 0.898136185190616d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9988278393118869d, y: 0.8310414269534083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6310428076514238d, y: 0.013578168710988825d), new NpgsqlTypes.NpgsqlPoint(x: 0.26858850391090994d, y: 0.5487924410987928d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7950722625784519d, y: 0.17176626394484518d), new NpgsqlTypes.NpgsqlPoint(x: 0.38922556288602783d, y: 0.5649961788859234d), new NpgsqlTypes.NpgsqlPoint(x: 0.15153370181904713d, y: 0.08825972638862689d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1753141764847801d, y: 0.7591644817911645d), new NpgsqlTypes.NpgsqlPoint(x: 0.24440488302225083d, y: 0.8329167695912145d), new NpgsqlTypes.NpgsqlPoint(x: 0.4093678261308441d, y: 0.08725908960372286d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023357307673992578d, y: 0.9466299871432486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4528771058797867d, y: 0.38554984219486865d), new NpgsqlTypes.NpgsqlPoint(x: 0.2778453042369241d, y: 0.5649507688107726d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3889514499502159d, y: 0.17822478516786466d), new NpgsqlTypes.NpgsqlPoint(x: 0.45741869421611425d, y: 0.36735266148408185d), new NpgsqlTypes.NpgsqlPoint(x: 0.6279557198421998d, y: 0.7727014697522752d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14499125323685036d, y: 0.7972879278765065d), new NpgsqlTypes.NpgsqlPoint(x: 0.9146154133750984d, y: 0.4503186163613635d), new NpgsqlTypes.NpgsqlPoint(x: 0.15037835125485166d, y: 0.8176892722953935d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9713518474373153d, y: 0.9101895109999393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7106135731901272d, y: 0.6179109342488367d), new NpgsqlTypes.NpgsqlPoint(x: 0.06473862748197201d, y: 0.48310844776211637d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.049068255419035256d, y: 0.8931471688169632d), new NpgsqlTypes.NpgsqlPoint(x: 0.8590217378238174d, y: 0.3664007616503926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7448994945803261d, y: 0.7451685591626774d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6238433236463468d, y: 0.8894592040695212d), new NpgsqlTypes.NpgsqlPoint(x: 0.29064913898493305d, y: 0.503449644603853d), new NpgsqlTypes.NpgsqlPoint(x: 0.14999774771115437d, y: 0.33416733799461207d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9803675747325846d, y: 0.4565896468378292d), new NpgsqlTypes.NpgsqlPoint(x: 0.8177142186456619d, y: 0.6829293891532883d), new NpgsqlTypes.NpgsqlPoint(x: 0.5643176777102326d, y: 0.2532355428413722d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9250268855689666d, y: 0.8315676543185329d), new NpgsqlTypes.NpgsqlPoint(x: 0.042764778870558184d, y: 0.5909193442966406d), new NpgsqlTypes.NpgsqlPoint(x: 0.4248397879941832d, y: 0.6713438342702321d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6427402111984679d, y: 0.6526535801966995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6629086590314582d, y: 0.13467207377419d), new NpgsqlTypes.NpgsqlPoint(x: 0.6940439742810933d, y: 0.9570310245704023d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8094272002564843d, y: 0.08054170060545862d), new NpgsqlTypes.NpgsqlPoint(x: 0.23121252026766725d, y: 0.6732939379241751d), new NpgsqlTypes.NpgsqlPoint(x: 0.8453479718573179d, y: 0.7410832213887304d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6601043019562226d, y: 0.6985190639325379d), new NpgsqlTypes.NpgsqlPoint(x: 0.8257172637578704d, y: 0.06999139480580163d), new NpgsqlTypes.NpgsqlPoint(x: 0.44980938811774085d, y: 0.5202522501129391d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16709292111634677d, y: 0.8686078265809497d), new NpgsqlTypes.NpgsqlPoint(x: 0.5134284346818084d, y: 0.8806127654443924d), new NpgsqlTypes.NpgsqlPoint(x: 0.9560169618198169d, y: 0.06423279953880068d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5113525109805029d, y: 0.9691340553737139d), new NpgsqlTypes.NpgsqlPoint(x: 0.4760489677774292d, y: 0.3069064883277931d), new NpgsqlTypes.NpgsqlPoint(x: 0.7309462020385994d, y: 0.413538751876632d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8100251864105599d, y: 0.17830841340755454d), new NpgsqlTypes.NpgsqlPoint(x: 0.7239120149624911d, y: 0.7377702513141744d), new NpgsqlTypes.NpgsqlPoint(x: 0.1415720926505245d, y: 0.47418415135177194d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9326799490568618d, y: 0.02598663329108608d), new NpgsqlTypes.NpgsqlPoint(x: 0.03785120507392847d, y: 0.5605143604365878d), new NpgsqlTypes.NpgsqlPoint(x: 0.3403523967032557d, y: 0.8944576914666281d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5294292204875529d, y: 0.4590095511073421d), new NpgsqlTypes.NpgsqlPoint(x: 0.14798751251675912d, y: 0.3271121956666313d), new NpgsqlTypes.NpgsqlPoint(x: 0.04154682222748729d, y: 0.1321347085113198d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6056049925320183d, y: 0.7889937718642355d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818684404839345d, y: 0.7309481997848984d), new NpgsqlTypes.NpgsqlPoint(x: 0.7220137693963041d, y: 0.5709113451291286d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002334642003435139d, y: 0.4953690796803608d), new NpgsqlTypes.NpgsqlPoint(x: 0.2398618044154498d, y: 0.6936716635546226d), new NpgsqlTypes.NpgsqlPoint(x: 0.17826536994080022d, y: 0.46854962154760493d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.991135642455951d, y: 0.34068194408428d), new NpgsqlTypes.NpgsqlPoint(x: 0.7940718075898132d, y: 0.17047213486515767d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800015859400231d, y: 0.38278851431604266d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022473704303657027d, y: 0.5159248897248531d), new NpgsqlTypes.NpgsqlPoint(x: 0.783022187124539d, y: 0.2140621112230806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5158939987468254d, y: 0.7607229429985604d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8888366310607321d, y: 0.9728021680168534d), new NpgsqlTypes.NpgsqlPoint(x: 0.5960681935925558d, y: 0.7833972199123882d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373688127417575d, y: 0.45315606764440597d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08362584317648669d, y: 0.0011103701447328085d), new NpgsqlTypes.NpgsqlPoint(x: 0.44648415467294134d, y: 0.5838916569359913d), new NpgsqlTypes.NpgsqlPoint(x: 0.15895427586457378d, y: 0.29778804992879315d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6568633011739962d, y: 0.9461947929051475d), new NpgsqlTypes.NpgsqlPoint(x: 0.18565739462209452d, y: 0.4604901908123209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5036360927865934d, y: 0.20044271343563758d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5831990881870662d, y: 0.47990243606257854d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618316160032228d, y: 0.6336581023109049d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989343831632934d, y: 0.4452462699129186d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9608872429502167d, y: 0.15459619080038745d), new NpgsqlTypes.NpgsqlPoint(x: 0.6275850232442278d, y: 0.08275069509052146d), new NpgsqlTypes.NpgsqlPoint(x: 0.450941796699623d, y: 0.468492213179746d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7988796148903861d, y: 0.606818293480518d), new NpgsqlTypes.NpgsqlPoint(x: 0.4146369032908992d, y: 0.35625244200575956d), new NpgsqlTypes.NpgsqlPoint(x: 0.39153789350181534d, y: 0.8181543872375132d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9203537002378749d, y: 0.0076067242850116346d), new NpgsqlTypes.NpgsqlPoint(x: 0.8803314633400394d, y: 0.3418606735492852d), new NpgsqlTypes.NpgsqlPoint(x: 0.4187400663175499d, y: 0.3957944859672996d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48636579938861746d, y: 0.36676974688815744d), new NpgsqlTypes.NpgsqlPoint(x: 0.9476978735799975d, y: 0.2738018209301428d), new NpgsqlTypes.NpgsqlPoint(x: 0.5491538360061773d, y: 0.574827725563193d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4936413140493714d, y: 0.04471248591533361d), new NpgsqlTypes.NpgsqlPoint(x: 0.1385601595616014d, y: 0.41076603753512586d), new NpgsqlTypes.NpgsqlPoint(x: 0.8089229954214833d, y: 0.2623895182290106d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8292097328349778d, y: 0.7974372335761236d), new NpgsqlTypes.NpgsqlPoint(x: 0.32765942129711667d, y: 0.5080296005841272d), new NpgsqlTypes.NpgsqlPoint(x: 0.9821992851251605d, y: 0.9906323731997282d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9390349920764713d, y: 0.848282681516952d), new NpgsqlTypes.NpgsqlPoint(x: 0.3707399249910025d, y: 0.8366000137859033d), new NpgsqlTypes.NpgsqlPoint(x: 0.0838372983373491d, y: 0.5944958095307494d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9723752387053513d, y: 0.85053470252127d), new NpgsqlTypes.NpgsqlPoint(x: 0.703379237526558d, y: 0.32976445273342847d), new NpgsqlTypes.NpgsqlPoint(x: 0.3604843245006203d, y: 0.12208547136039194d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6229891344670364d, y: 0.1737932267070159d), new NpgsqlTypes.NpgsqlPoint(x: 0.060885611073592916d, y: 0.9766621809922847d), new NpgsqlTypes.NpgsqlPoint(x: 0.9286750429990521d, y: 0.0614044282075501d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02354592867155214d, y: 0.2356314498886627d), new NpgsqlTypes.NpgsqlPoint(x: 0.21504492543753617d, y: 0.940625158426578d), new NpgsqlTypes.NpgsqlPoint(x: 0.5711917297670764d, y: 0.2910927286772139d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6891137614573273d, y: 0.013325470574769627d), new NpgsqlTypes.NpgsqlPoint(x: 0.17900071870692902d, y: 0.10999929518114582d), new NpgsqlTypes.NpgsqlPoint(x: 0.26495497076395647d, y: 0.4696182809735816d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4751438325667233d, y: 0.6504571141970896d), new NpgsqlTypes.NpgsqlPoint(x: 0.717466538174521d, y: 0.49463558818797004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8467803055701608d, y: 0.3009016271682584d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18140556754831882d, y: 0.7089963384693493d), new NpgsqlTypes.NpgsqlPoint(x: 0.8642189071475825d, y: 0.19244280821381088d), new NpgsqlTypes.NpgsqlPoint(x: 0.908351877253286d, y: 0.6817393924861671d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09138745361350131d, y: 0.8357702321151674d), new NpgsqlTypes.NpgsqlPoint(x: 0.05274109520123915d, y: 0.6276737063925549d), new NpgsqlTypes.NpgsqlPoint(x: 0.43670935416439627d, y: 0.3401326329765677d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16431427259417786d, y: 0.7584881515171333d), new NpgsqlTypes.NpgsqlPoint(x: 0.6710361127659583d, y: 0.31463597589131564d), new NpgsqlTypes.NpgsqlPoint(x: 0.4016892027774279d, y: 0.41150963958483955d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43649983792091096d, y: 0.09178854154478189d), new NpgsqlTypes.NpgsqlPoint(x: 0.667743715086285d, y: 0.34327103667431313d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534997906122296d, y: 0.6402124186693352d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5258525968974765d, y: 0.8291971593965335d), new NpgsqlTypes.NpgsqlPoint(x: 0.019299954851480283d, y: 0.9851082391188667d), new NpgsqlTypes.NpgsqlPoint(x: 0.2783350789949307d, y: 0.6962161001894156d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2526959542273701d, y: 0.7079048344504679d), new NpgsqlTypes.NpgsqlPoint(x: 0.1727920435520267d, y: 0.9062691915255249d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441946921836218d, y: 0.2024359433631815d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35017640351755d, y: 0.4945019398134798d), new NpgsqlTypes.NpgsqlPoint(x: 0.5609874464475928d, y: 0.2740146216168208d), new NpgsqlTypes.NpgsqlPoint(x: 0.9845119645652273d, y: 0.5819007681131098d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10634541177740575d, y: 0.04716604865017937d), new NpgsqlTypes.NpgsqlPoint(x: 0.45707089218434016d, y: 0.999467901514541d), new NpgsqlTypes.NpgsqlPoint(x: 0.4955315568041577d, y: 0.9490919317252678d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7883512047878047d, y: 0.6265306835897435d), new NpgsqlTypes.NpgsqlPoint(x: 0.3098613549182694d, y: 0.35647091747845217d), new NpgsqlTypes.NpgsqlPoint(x: 0.3231464171620977d, y: 0.6126904374925909d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5720857498783782d, y: 0.16539188237245284d), new NpgsqlTypes.NpgsqlPoint(x: 0.5377649750371942d, y: 0.5787989888977845d), new NpgsqlTypes.NpgsqlPoint(x: 0.6822470875387487d, y: 0.8483269760754906d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9302272877929303d, y: 0.5374170633294375d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575324686119029d, y: 0.9457652638614514d), new NpgsqlTypes.NpgsqlPoint(x: 0.289580682842972d, y: 0.33028206224186774d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10252485467197714d, y: 0.5784399708050219d), new NpgsqlTypes.NpgsqlPoint(x: 0.689510543308341d, y: 0.6154417006355474d), new NpgsqlTypes.NpgsqlPoint(x: 0.7645595615399526d, y: 0.7317532280573448d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29438021390288405d, y: 0.2771677938890075d), new NpgsqlTypes.NpgsqlPoint(x: 0.29119994221999657d, y: 0.5086872206988072d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973573767846569d, y: 0.9017343568303997d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04225945259230124d, y: 0.7469952943163971d), new NpgsqlTypes.NpgsqlPoint(x: 0.17238369100819173d, y: 0.5951381959169697d), new NpgsqlTypes.NpgsqlPoint(x: 0.33455652894588195d, y: 0.1348481797803538d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2930766352404177d, y: 0.8766054121881349d), new NpgsqlTypes.NpgsqlPoint(x: 0.2031373183736509d, y: 0.1612672811378979d), new NpgsqlTypes.NpgsqlPoint(x: 0.5433633020071611d, y: 0.7521192505533214d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3993059567682987d, y: 0.48940421837538794d), new NpgsqlTypes.NpgsqlPoint(x: 0.9159763666265665d, y: 0.04471295995135238d), new NpgsqlTypes.NpgsqlPoint(x: 0.3471810491448041d, y: 0.5529252448728148d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2161313563105418d, y: 0.40167811393344843d), new NpgsqlTypes.NpgsqlPoint(x: 0.9254203791232368d, y: 0.4672550956356446d), new NpgsqlTypes.NpgsqlPoint(x: 0.08969447022832522d, y: 0.21729132245420524d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48933590808083427d, y: 0.2147216644055291d), new NpgsqlTypes.NpgsqlPoint(x: 0.7231473352251163d, y: 0.5686172406270896d), new NpgsqlTypes.NpgsqlPoint(x: 0.642682402857819d, y: 0.9911955291538382d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08614262371199233d, y: 0.5119985470572106d), new NpgsqlTypes.NpgsqlPoint(x: 0.4048542877172304d, y: 0.09156371423265408d), new NpgsqlTypes.NpgsqlPoint(x: 0.7438704651440075d, y: 0.6258489326507239d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 116;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 143, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 76, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 159, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 85, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 42, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 116, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 85, query1, 159, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 42, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 129, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);NpgsqlPathpathArray2M.AssertModel(models[29],_testData[30], false);NpgsqlPathpathArray2M.AssertModel(models[30],_testData[31], false);NpgsqlPathpathArray2M.AssertModel(models[31],_testData[32], false);NpgsqlPathpathArray2M.AssertModel(models[32],_testData[33], false);NpgsqlPathpathArray2M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[30], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[31], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[32], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[33], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPathListpathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

