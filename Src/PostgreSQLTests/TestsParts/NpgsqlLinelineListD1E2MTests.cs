

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
    internal partial interface INpgsqlLineListlineListD1
    {
    }
    
    internal partial class NpgsqlLineListlineListD1 : INpgsqlLineListlineListD1
    {


#region TestData

        private readonly NpgsqlLinelineListD1E2M[] _testData = new NpgsqlLinelineListD1E2M[]
        {
            new NpgsqlLinelineListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.37792173199023404d, b: 0.6830937681668797d, c: 0.1253121371030409d),

new NpgsqlTypes.NpgsqlLine(a: 0.6072841959516502d, b: 0.21556577939749588d, c: 0.9593767998672572d),

new NpgsqlTypes.NpgsqlLine(a: 0.9240893408525955d, b: 0.11896055092825075d, c: 0.003449052729241897d),

new NpgsqlTypes.NpgsqlLine(a: 0.4528740853760318d, b: 0.3091383538841599d, c: 0.6007395954072273d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7131041385516911d, b: 0.7330186414789134d, c: 0.45722173441145575d),

new NpgsqlTypes.NpgsqlLine(a: 0.08577544043113294d, b: 0.05200018943464735d, c: 0.9387784410305533d),

new NpgsqlTypes.NpgsqlLine(a: 0.37828426185395414d, b: 0.7265386008474726d, c: 0.11057694173816479d),

new NpgsqlTypes.NpgsqlLine(a: 0.5263313987920132d, b: 0.689260929418181d, c: 0.1942820078120715d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22530918765392483d, b: 0.24985229875691017d, c: 0.6931281090884335d),

new NpgsqlTypes.NpgsqlLine(a: 0.23150695061636617d, b: 0.1840131126202904d, c: 0.8866836366244387d),

new NpgsqlTypes.NpgsqlLine(a: 0.7442769040819361d, b: 0.0027205094061334423d, c: 0.33893501838490925d),

new NpgsqlTypes.NpgsqlLine(a: 0.4589863941637119d, b: 0.9378157331224009d, c: 0.8445880022122367d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9232816480666928d, b: 0.9643912995499911d, c: 0.03878808759271257d),

new NpgsqlTypes.NpgsqlLine(a: 0.5514866224768408d, b: 0.41983966991725674d, c: 0.710107912695587d),

new NpgsqlTypes.NpgsqlLine(a: 0.0206967849476547d, b: 0.5898030765704123d, c: 0.806689427934064d),

new NpgsqlTypes.NpgsqlLine(a: 0.9351771694517458d, b: 0.43723795263784226d, c: 0.9949683203563039d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5872278699304975d, b: 0.0555347428579237d, c: 0.8333569329866507d),

new NpgsqlTypes.NpgsqlLine(a: 0.9271108400828542d, b: 0.23671853203233362d, c: 0.5500497332897564d),

new NpgsqlTypes.NpgsqlLine(a: 0.9707578690700904d, b: 0.973499502675278d, c: 0.727195165471426d),

new NpgsqlTypes.NpgsqlLine(a: 0.06981804573182804d, b: 0.7729472275530627d, c: 0.2585745919492237d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3157298754898159d, b: 0.28877241182667823d, c: 0.7357721103720074d),

new NpgsqlTypes.NpgsqlLine(a: 0.31075549330286656d, b: 0.39686223460260117d, c: 0.4792141770062863d),

new NpgsqlTypes.NpgsqlLine(a: 0.4136985215950256d, b: 0.2979834463224006d, c: 0.6050851348852277d),

new NpgsqlTypes.NpgsqlLine(a: 0.7195132240797935d, b: 0.022713512290715276d, c: 0.5461212847533883d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7099576619374911d, b: 0.23218918122139898d, c: 0.4568635356391916d),

new NpgsqlTypes.NpgsqlLine(a: 0.24327125977281183d, b: 0.006173258426358963d, c: 0.41892623181249455d),

new NpgsqlTypes.NpgsqlLine(a: 0.3792379184107889d, b: 0.9446912331134437d, c: 0.16675020146244002d),

new NpgsqlTypes.NpgsqlLine(a: 0.35969068727291464d, b: 0.19591908636098743d, c: 0.9970466444130013d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4351495719984728d, b: 0.6527081323831082d, c: 0.26419114079506756d),

new NpgsqlTypes.NpgsqlLine(a: 0.24687811576383423d, b: 0.36871285876088467d, c: 0.4274462399527499d),

new NpgsqlTypes.NpgsqlLine(a: 0.4685491781232245d, b: 0.9279839432742126d, c: 0.6443897672631527d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6410941787971816d, b: 0.6697373334221225d, c: 0.6129106230790431d),

new NpgsqlTypes.NpgsqlLine(a: 0.7626213931879348d, b: 0.42304676963638976d, c: 0.08047599675062123d),

new NpgsqlTypes.NpgsqlLine(a: 0.33240483887530925d, b: 0.18570054028974825d, c: 0.13201066337610845d),

new NpgsqlTypes.NpgsqlLine(a: 0.31489633405571604d, b: 0.6907393108930038d, c: 0.7621154246059623d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9135463632620615d, b: 0.7853267097535672d, c: 0.6713694742908565d),

new NpgsqlTypes.NpgsqlLine(a: 0.6751216913113922d, b: 0.41269902509220824d, c: 0.06863862676993326d),

new NpgsqlTypes.NpgsqlLine(a: 0.8688320443151355d, b: 0.02962191859892893d, c: 0.272509096816964d),

new NpgsqlTypes.NpgsqlLine(a: 0.1731398667867553d, b: 0.6661613918767944d, c: 0.16796100914630352d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2885313793260922d, b: 0.24520746619472433d, c: 0.5435736420523408d),

new NpgsqlTypes.NpgsqlLine(a: 0.5142767313562344d, b: 0.5124750910612944d, c: 0.5432696193508916d),

new NpgsqlTypes.NpgsqlLine(a: 0.21058530855389102d, b: 0.06973071962394572d, c: 0.19115535893142488d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5694544574702697d, b: 0.5417010305712824d, c: 0.6765109354496497d),

new NpgsqlTypes.NpgsqlLine(a: 0.10520912521707426d, b: 0.8595128874493005d, c: 0.8594415945607288d),

new NpgsqlTypes.NpgsqlLine(a: 0.7760826325714689d, b: 0.45700427632413043d, c: 0.7026098425179745d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03971663126397107d, b: 0.43283529208236604d, c: 0.7006746851077437d),

new NpgsqlTypes.NpgsqlLine(a: 0.4293484881648648d, b: 0.9702323037015197d, c: 0.39405156730292656d),

new NpgsqlTypes.NpgsqlLine(a: 0.05828232763799723d, b: 0.3808231400842287d, c: 0.3216568782860848d),

new NpgsqlTypes.NpgsqlLine(a: 0.5709302883088985d, b: 0.12188061066076017d, c: 0.6684008337562257d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6312200230277206d, b: 0.19437863328561666d, c: 0.7244077261464166d),

new NpgsqlTypes.NpgsqlLine(a: 0.5486321847856499d, b: 0.2390943689128564d, c: 0.9066171633125826d),

new NpgsqlTypes.NpgsqlLine(a: 0.7716896689649273d, b: 0.5271349032279681d, c: 0.9526165133133961d),

new NpgsqlTypes.NpgsqlLine(a: 0.6200418018466511d, b: 0.31029732441685776d, c: 0.2548764736503659d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5653777935849168d, b: 0.3429022216790808d, c: 0.3247339063434612d),

new NpgsqlTypes.NpgsqlLine(a: 0.341111550625779d, b: 0.8115504396187404d, c: 0.5834161821061565d),

new NpgsqlTypes.NpgsqlLine(a: 0.1937256932127296d, b: 0.5556195449183188d, c: 0.21956373432578424d),

new NpgsqlTypes.NpgsqlLine(a: 0.4841560027120785d, b: 0.9555468177950365d, c: 0.3568077726877116d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21529539743317683d, b: 0.6995934528588d, c: 0.17229927535754408d),

new NpgsqlTypes.NpgsqlLine(a: 0.9412528750651303d, b: 0.7684079281865122d, c: 0.9419141160337862d),

new NpgsqlTypes.NpgsqlLine(a: 0.1777571321277892d, b: 0.5075351352233082d, c: 0.9193319817199078d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06373135550691555d, b: 0.2170423387211775d, c: 0.23598897391285156d),

new NpgsqlTypes.NpgsqlLine(a: 0.8589630851329262d, b: 0.807692522532502d, c: 0.21274773194223107d),

new NpgsqlTypes.NpgsqlLine(a: 0.8323062305095519d, b: 0.370622423744992d, c: 0.5579618206491896d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8866592614248118d, b: 0.9760792530041911d, c: 0.900767103008202d),

new NpgsqlTypes.NpgsqlLine(a: 0.5709257636864191d, b: 0.29121259644894204d, c: 0.9722057805055785d),

new NpgsqlTypes.NpgsqlLine(a: 0.28674556424753894d, b: 0.7034438779456921d, c: 0.1545275280306827d),

new NpgsqlTypes.NpgsqlLine(a: 0.48091102504441874d, b: 0.4777627553042205d, c: 0.527377655532787d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1007699544322136d, b: 0.834149209435903d, c: 0.7489479014492189d),

new NpgsqlTypes.NpgsqlLine(a: 0.6376775802934015d, b: 0.1282088214613024d, c: 0.7487464886418222d),

new NpgsqlTypes.NpgsqlLine(a: 0.39348451625475944d, b: 0.6392208651142816d, c: 0.5603349825090166d),

new NpgsqlTypes.NpgsqlLine(a: 0.7131129835462899d, b: 0.8680193814872145d, c: 0.16755608070694683d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7535420535412594d, b: 0.29157356983556404d, c: 0.10216646867997925d),

new NpgsqlTypes.NpgsqlLine(a: 0.27804417616852284d, b: 0.07191051568639895d, c: 0.37110750472819487d),

new NpgsqlTypes.NpgsqlLine(a: 0.06124518279801583d, b: 0.8054753476285853d, c: 0.9148109197926656d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7457719174439857d, b: 0.7489727758534085d, c: 0.5883503402767855d),

new NpgsqlTypes.NpgsqlLine(a: 0.7204841241693106d, b: 0.6909444788555894d, c: 0.33535251683333633d),

new NpgsqlTypes.NpgsqlLine(a: 0.7950791118791652d, b: 0.6599759822589372d, c: 0.5768030638528349d),

new NpgsqlTypes.NpgsqlLine(a: 0.3579122410978657d, b: 0.9603273651636846d, c: 0.6430538439297225d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9139144893715512d, b: 0.5638106906408598d, c: 0.5992858787113549d),

new NpgsqlTypes.NpgsqlLine(a: 0.5030964763392534d, b: 0.5443842585784904d, c: 0.5302149210640528d),

new NpgsqlTypes.NpgsqlLine(a: 0.12831708310575174d, b: 0.48124945887818393d, c: 0.51904444050613d),

new NpgsqlTypes.NpgsqlLine(a: 0.3856385274123526d, b: 0.9120100004596866d, c: 0.9902551800240526d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28234669394340706d, b: 0.07090125168168515d, c: 0.9958091415157239d),

new NpgsqlTypes.NpgsqlLine(a: 0.8783543683254951d, b: 0.9617513464279227d, c: 0.4268943644794987d),

new NpgsqlTypes.NpgsqlLine(a: 0.8285762592004752d, b: 0.25561161484691175d, c: 0.926067959131267d),

new NpgsqlTypes.NpgsqlLine(a: 0.9481170905941546d, b: 0.8832839645535465d, c: 0.7953999790465929d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7714701863399254d, b: 0.167283649303833d, c: 0.7044541615041732d),

new NpgsqlTypes.NpgsqlLine(a: 0.124136596585945d, b: 0.20992037388156026d, c: 0.9356596698830828d),

new NpgsqlTypes.NpgsqlLine(a: 0.804394334681544d, b: 0.9095383236246017d, c: 0.25882682054790995d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23999048840589354d, b: 0.9741001771156436d, c: 0.6170646630191046d),

new NpgsqlTypes.NpgsqlLine(a: 0.5694736887059234d, b: 0.5541408593450863d, c: 0.3106799289395745d),

new NpgsqlTypes.NpgsqlLine(a: 0.7684540341593687d, b: 0.4595998492746268d, c: 0.5704813741326819d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9205712442419244d, b: 0.806838436466067d, c: 0.3595812599610059d),

new NpgsqlTypes.NpgsqlLine(a: 0.9564843656257721d, b: 0.5356123944206447d, c: 0.5422665920364317d),

new NpgsqlTypes.NpgsqlLine(a: 0.07819010800222193d, b: 0.8245698244263614d, c: 0.6021963953460123d),

new NpgsqlTypes.NpgsqlLine(a: 0.8124072758767799d, b: 0.4244902361808327d, c: 0.7451519553411662d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7575038934330295d, b: 0.3744033709869199d, c: 0.1322408868936792d),

new NpgsqlTypes.NpgsqlLine(a: 0.7636047469597936d, b: 0.8355066204129425d, c: 0.018511177320187477d),

new NpgsqlTypes.NpgsqlLine(a: 0.7970951100584867d, b: 0.9580126806371961d, c: 0.7242719256907406d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.009657745311285493d, b: 0.046277393125453536d, c: 0.35483764959055064d),

new NpgsqlTypes.NpgsqlLine(a: 0.8792810518936031d, b: 0.44847959518463376d, c: 0.7938868806035582d),

new NpgsqlTypes.NpgsqlLine(a: 0.658097517416113d, b: 0.42276914739327287d, c: 0.972433411187811d),

new NpgsqlTypes.NpgsqlLine(a: 0.0046711107272956465d, b: 0.6834614317344435d, c: 0.9998360693469355d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7850730790290799d, b: 0.773714677134499d, c: 0.946766400788659d),

new NpgsqlTypes.NpgsqlLine(a: 0.004389173764558163d, b: 0.8796311613115545d, c: 0.12649431152262958d),

new NpgsqlTypes.NpgsqlLine(a: 0.8317077975256638d, b: 0.2503796039520746d, c: 0.3975392849803767d),

new NpgsqlTypes.NpgsqlLine(a: 0.8915844053144438d, b: 0.1443430297094247d, c: 0.5432707904959228d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5236338496781968d, b: 0.7458516286823134d, c: 0.33188100714294244d),

new NpgsqlTypes.NpgsqlLine(a: 0.6372465340331022d, b: 0.1557703582423654d, c: 0.5365869658843303d),

new NpgsqlTypes.NpgsqlLine(a: 0.7243099611238382d, b: 0.6024409665970886d, c: 0.43600852385472155d),

new NpgsqlTypes.NpgsqlLine(a: 0.8990917079556718d, b: 0.09558041655699634d, c: 0.3968006693342113d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6623548458498878d, b: 0.10240383009066312d, c: 0.22372141721086003d),

new NpgsqlTypes.NpgsqlLine(a: 0.5204110556287481d, b: 0.6386288423843974d, c: 0.7135616312535386d),

new NpgsqlTypes.NpgsqlLine(a: 0.5963406723848802d, b: 0.4429657355874167d, c: 0.06037871586914689d),

new NpgsqlTypes.NpgsqlLine(a: 0.24584715288602021d, b: 0.17252993419283624d, c: 0.5566558203056002d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5967263810912081d, b: 0.9953781650768903d, c: 0.1479970611708945d),

new NpgsqlTypes.NpgsqlLine(a: 0.03499306380505396d, b: 0.23382064291135662d, c: 0.3513861127324457d),

new NpgsqlTypes.NpgsqlLine(a: 0.42138420260352627d, b: 0.37037079092393055d, c: 0.15448860101432682d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8546300458635651d, b: 0.8126013906259869d, c: 0.6649029414011557d),

new NpgsqlTypes.NpgsqlLine(a: 0.26386770766590784d, b: 0.785925439357606d, c: 0.6494644727806133d),

new NpgsqlTypes.NpgsqlLine(a: 0.8383027130006797d, b: 0.8647668166485569d, c: 0.8142258369454574d),

new NpgsqlTypes.NpgsqlLine(a: 0.6717008683584674d, b: 0.40415826274775835d, c: 0.8318959867403457d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.02127273090145798d, b: 0.8961442078083419d, c: 0.36091197346088555d),

new NpgsqlTypes.NpgsqlLine(a: 0.09364227907520872d, b: 0.41108045100921653d, c: 0.55965342771591d),

new NpgsqlTypes.NpgsqlLine(a: 0.23449960562918026d, b: 0.5373529017645619d, c: 0.9515448155087065d),

new NpgsqlTypes.NpgsqlLine(a: 0.000951202511814353d, b: 0.6826282270033629d, c: 0.7619524240686336d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6779451356539661d, b: 0.7912598362423444d, c: 0.36754012055551855d),

new NpgsqlTypes.NpgsqlLine(a: 0.4910272167091174d, b: 0.22760464027408467d, c: 0.7806835984985714d),

new NpgsqlTypes.NpgsqlLine(a: 0.8304581148696443d, b: 0.779088195999845d, c: 0.8679868568799929d),

new NpgsqlTypes.NpgsqlLine(a: 0.19539154561737804d, b: 0.9023638636940077d, c: 0.41321835895389514d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4778620381008414d, b: 0.8808871533787803d, c: 0.8405100459887818d),

new NpgsqlTypes.NpgsqlLine(a: 0.07915604651994401d, b: 0.3224921867968732d, c: 0.899539564634034d),

new NpgsqlTypes.NpgsqlLine(a: 0.812594459270636d, b: 0.3114950219692669d, c: 0.40300399697621847d),

new NpgsqlTypes.NpgsqlLine(a: 0.0990743732915107d, b: 0.7918904579101094d, c: 0.5025657407453578d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7791817689531545d, b: 0.9209778629031785d, c: 0.2926076187666148d),

new NpgsqlTypes.NpgsqlLine(a: 0.9820217820980706d, b: 0.4728397327268872d, c: 0.8221639133256474d),

new NpgsqlTypes.NpgsqlLine(a: 0.9012488801815696d, b: 0.12761064197020522d, c: 0.20231309761307636d),

new NpgsqlTypes.NpgsqlLine(a: 0.8150156803486843d, b: 0.030937873903245316d, c: 0.7056134771958404d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.010357727089574498d, b: 0.13281587296686825d, c: 0.7320020931568788d),

new NpgsqlTypes.NpgsqlLine(a: 0.31080171631633036d, b: 0.013390591519393924d, c: 0.6809171983884355d),

new NpgsqlTypes.NpgsqlLine(a: 0.3479052404486799d, b: 0.786950651178249d, c: 0.0849394146757082d),

new NpgsqlTypes.NpgsqlLine(a: 0.9606659100639858d, b: 0.8238570926084693d, c: 0.1971137770051492d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.010268040565111214d, b: 0.19969675871852488d, c: 0.34161953571514436d),

new NpgsqlTypes.NpgsqlLine(a: 0.4585067062736282d, b: 0.7525422433431482d, c: 0.4336853077633618d),

new NpgsqlTypes.NpgsqlLine(a: 0.21092957298599602d, b: 0.8245915689352442d, c: 0.40378044209519093d),

new NpgsqlTypes.NpgsqlLine(a: 0.8318313682176958d, b: 0.8215446175835317d, c: 0.1132871788908073d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6431893540476221d, b: 0.8379050088213107d, c: 0.3404510096367961d),

new NpgsqlTypes.NpgsqlLine(a: 0.7435511917866212d, b: 0.14619286972196655d, c: 0.6291397503783958d),

new NpgsqlTypes.NpgsqlLine(a: 0.9417353027287511d, b: 0.7631123218846819d, c: 0.33210040828274257d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.046060541470295924d, b: 0.7657465722810218d, c: 0.31896972582887995d),

new NpgsqlTypes.NpgsqlLine(a: 0.6783845987821202d, b: 0.9085634983410816d, c: 0.6035445698398528d),

new NpgsqlTypes.NpgsqlLine(a: 0.8963275098167468d, b: 0.8187925894562501d, c: 0.12292780260004821d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6385832074775002d, b: 0.7384872347004686d, c: 0.614753707985931d),

new NpgsqlTypes.NpgsqlLine(a: 0.8936719370592032d, b: 0.09178808162722174d, c: 0.27388484519882006d),

new NpgsqlTypes.NpgsqlLine(a: 0.35010881293175133d, b: 0.5173960510135456d, c: 0.4705249040410354d),

new NpgsqlTypes.NpgsqlLine(a: 0.4262319629809479d, b: 0.9212824672449135d, c: 0.16236027294158994d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.506846513268433d, b: 0.20605462378665196d, c: 0.0566983406948145d),

new NpgsqlTypes.NpgsqlLine(a: 0.6849836046145015d, b: 0.11509360156475534d, c: 0.5904429958246847d),

new NpgsqlTypes.NpgsqlLine(a: 0.9559933597385784d, b: 0.022955711477300134d, c: 0.4575669516712516d),

new NpgsqlTypes.NpgsqlLine(a: 0.22319609352595282d, b: 0.382397831949267d, c: 0.38942132236910343d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.00610674118298471d, b: 0.7607238642571723d, c: 0.17032919495621102d),

new NpgsqlTypes.NpgsqlLine(a: 0.20933139409307244d, b: 0.5531980512350532d, c: 0.5097493592867646d),

new NpgsqlTypes.NpgsqlLine(a: 0.2780445530449922d, b: 0.5533870459939167d, c: 0.6711562398023393d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.421649680649437d, b: 0.17527557384447734d, c: 0.02648003267803878d),

new NpgsqlTypes.NpgsqlLine(a: 0.28687337809250346d, b: 0.9334150429852387d, c: 0.7934838068769482d),

new NpgsqlTypes.NpgsqlLine(a: 0.20058220561007745d, b: 0.7618527610917618d, c: 0.7123433647455171d),

new NpgsqlTypes.NpgsqlLine(a: 0.32456640923414937d, b: 0.8164126652157602d, c: 0.35556688282770044d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.40165732759492045d, b: 0.1845379354664235d, c: 0.8063694626804495d),

new NpgsqlTypes.NpgsqlLine(a: 0.003910160790097095d, b: 0.16104663430776744d, c: 0.7299290404344202d),

new NpgsqlTypes.NpgsqlLine(a: 0.8324808713873691d, b: 0.5685019203274685d, c: 0.7096486352632023d),

new NpgsqlTypes.NpgsqlLine(a: 0.33305867943060374d, b: 0.1945424221676776d, c: 0.1654099732603156d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8760926569352897d, b: 0.2924294158844254d, c: 0.8015616760787829d),

new NpgsqlTypes.NpgsqlLine(a: 0.7793884779167145d, b: 0.4842681175360448d, c: 0.8390499084175821d),

new NpgsqlTypes.NpgsqlLine(a: 0.3364341915658293d, b: 0.21208213122311348d, c: 0.3093699269921151d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8184292822806122d, b: 0.27736607554016135d, c: 0.9862012087337201d),

new NpgsqlTypes.NpgsqlLine(a: 0.12560174125920565d, b: 0.6769116583025112d, c: 0.9060670652099471d),

new NpgsqlTypes.NpgsqlLine(a: 0.019961765274840837d, b: 0.5088075529352363d, c: 0.2872948711364882d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07521500914660773d, b: 0.4407923493336031d, c: 0.964457681986083d),

new NpgsqlTypes.NpgsqlLine(a: 0.15014167477089713d, b: 0.4400057232603197d, c: 0.5977777746810022d),

new NpgsqlTypes.NpgsqlLine(a: 0.0868662222515787d, b: 0.003669783991975595d, c: 0.1331152502563473d),

new NpgsqlTypes.NpgsqlLine(a: 0.21110150062884236d, b: 0.7897093841515883d, c: 0.3387896920798936d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45020852066214057d, b: 0.16136741054192716d, c: 0.033484106902399335d),

new NpgsqlTypes.NpgsqlLine(a: 0.48783443413602934d, b: 0.9305692141667126d, c: 0.31847669062566886d),

new NpgsqlTypes.NpgsqlLine(a: 0.33409983879289995d, b: 0.9687373209560656d, c: 0.9400192263162745d),

new NpgsqlTypes.NpgsqlLine(a: 0.04078114617031681d, b: 0.8212520219705308d, c: 0.892390425423859d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07955784645675157d, b: 0.2814071437628244d, c: 0.2386094064637887d),

new NpgsqlTypes.NpgsqlLine(a: 0.9175049080640962d, b: 0.43913144766676515d, c: 0.48063551521830994d),

new NpgsqlTypes.NpgsqlLine(a: 0.3042450557465116d, b: 0.13059860066079543d, c: 0.5793220608190127d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6377442314252537d, b: 0.794837019787826d, c: 0.31162457293959045d),

new NpgsqlTypes.NpgsqlLine(a: 0.6619289705116594d, b: 0.41074754337168384d, c: 0.31175503180297626d),

new NpgsqlTypes.NpgsqlLine(a: 0.46756139451456413d, b: 0.8741484234059013d, c: 0.8217240243755596d),

new NpgsqlTypes.NpgsqlLine(a: 0.7738124590650541d, b: 0.18059594154421765d, c: 0.4854076219180221d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.493453537445951d, b: 0.349226592649463d, c: 0.49000068456911194d),

new NpgsqlTypes.NpgsqlLine(a: 0.5754224360433918d, b: 0.6372542324452146d, c: 0.10409979838777017d),

new NpgsqlTypes.NpgsqlLine(a: 0.2923458844041128d, b: 0.013251549002627372d, c: 0.26221346319800576d),

new NpgsqlTypes.NpgsqlLine(a: 0.7296519970095824d, b: 0.7854001517209755d, c: 0.5874844263333177d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.548996325230455d, b: 0.7198156559356308d, c: 0.8011740285576805d),

new NpgsqlTypes.NpgsqlLine(a: 0.06364312376289061d, b: 0.4171892300975446d, c: 0.5183291805847748d),

new NpgsqlTypes.NpgsqlLine(a: 0.5223639432266706d, b: 0.2666822697499778d, c: 0.4897748286770871d),

new NpgsqlTypes.NpgsqlLine(a: 0.5383996113915789d, b: 0.12745587550157667d, c: 0.7909721533378453d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36656064305923197d, b: 0.46537707768981484d, c: 0.6848303413113763d),

new NpgsqlTypes.NpgsqlLine(a: 0.02084436973874282d, b: 0.17212825900207984d, c: 0.06599433866913973d),

new NpgsqlTypes.NpgsqlLine(a: 0.30554822449366525d, b: 0.33637609752605735d, c: 0.09849905391521174d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7631920607877668d, b: 0.8973001437279483d, c: 0.894544418217884d),

new NpgsqlTypes.NpgsqlLine(a: 0.4615153267493456d, b: 0.02033737736746144d, c: 0.3223100226902901d),

new NpgsqlTypes.NpgsqlLine(a: 0.23350398030422526d, b: 0.6793306175138488d, c: 0.3207390959611207d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.665049670404182d, b: 0.40967658053258393d, c: 0.6539591005508614d),

new NpgsqlTypes.NpgsqlLine(a: 0.7234817402840688d, b: 0.3538071830201156d, c: 0.5164973311654625d),

new NpgsqlTypes.NpgsqlLine(a: 0.6942818255357789d, b: 0.23802515652825396d, c: 0.47731984511259606d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21529862230566787d, b: 0.3992299733084079d, c: 0.25343170417601013d),

new NpgsqlTypes.NpgsqlLine(a: 0.9426023614286224d, b: 0.602472802781429d, c: 0.1659789024530577d),

new NpgsqlTypes.NpgsqlLine(a: 0.08450779258498775d, b: 0.5405448147009846d, c: 0.21429866391164776d),

new NpgsqlTypes.NpgsqlLine(a: 0.7702251211255303d, b: 0.9439741714148315d, c: 0.5420327634356006d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4316089679212324d, b: 0.27079810910173574d, c: 0.3589077312755513d),

new NpgsqlTypes.NpgsqlLine(a: 0.6866498296051291d, b: 0.6432470454805772d, c: 0.1149845111632033d),

new NpgsqlTypes.NpgsqlLine(a: 0.8280351515612616d, b: 0.6299850476778176d, c: 0.8915253634701252d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.456772092664366d, b: 0.832763846709084d, c: 0.23819909811602946d),

new NpgsqlTypes.NpgsqlLine(a: 0.36617319056339304d, b: 0.6864367861849363d, c: 0.7498263317512911d),

new NpgsqlTypes.NpgsqlLine(a: 0.16789458177823047d, b: 0.4241716956355832d, c: 0.9932427316400151d),

new NpgsqlTypes.NpgsqlLine(a: 0.7295928169399096d, b: 0.8767331008305522d, c: 0.696437244799448d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7696911407368641d, b: 0.6628009686959498d, c: 0.04594670415706226d),

new NpgsqlTypes.NpgsqlLine(a: 0.7057950136097464d, b: 0.7131670159716516d, c: 0.19251574419457507d),

new NpgsqlTypes.NpgsqlLine(a: 0.8357698770046186d, b: 0.7334827407344907d, c: 0.3618140309736829d),

new NpgsqlTypes.NpgsqlLine(a: 0.4565300921544526d, b: 0.908112975818531d, c: 0.6114549385421312d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6917639023913016d, b: 0.11406595224205451d, c: 0.18344021401014554d),

new NpgsqlTypes.NpgsqlLine(a: 0.5912506452397489d, b: 0.44720831067085876d, c: 0.4422466542723573d),

new NpgsqlTypes.NpgsqlLine(a: 0.42848812699045136d, b: 0.45877525110165573d, c: 0.2497006074777961d),

new NpgsqlTypes.NpgsqlLine(a: 0.49262494312083605d, b: 0.8659666007853295d, c: 0.4057529089515187d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9877248412721582d, b: 0.41491338834334524d, c: 0.241428667087484d),

new NpgsqlTypes.NpgsqlLine(a: 0.3931090627356236d, b: 0.7486735986904696d, c: 0.922279600257687d),

new NpgsqlTypes.NpgsqlLine(a: 0.5837485102723942d, b: 0.8963796925480639d, c: 0.8950603275530767d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7952554702905784d, b: 0.7296060141661662d, c: 0.4520152545095055d),

new NpgsqlTypes.NpgsqlLine(a: 0.3524058783442455d, b: 0.231882970240175d, c: 0.4315495705505302d),

new NpgsqlTypes.NpgsqlLine(a: 0.28824039502250454d, b: 0.23916709580953255d, c: 0.06566303577632426d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6125428583010789d, b: 0.562794301679257d, c: 0.21946455604568338d),

new NpgsqlTypes.NpgsqlLine(a: 0.34407355061818024d, b: 0.10047972841631891d, c: 0.4443008945338801d),

new NpgsqlTypes.NpgsqlLine(a: 0.22289366034763536d, b: 0.46395834227872745d, c: 0.40399861477647725d),

new NpgsqlTypes.NpgsqlLine(a: 0.620889803465488d, b: 0.4436249124411641d, c: 0.19135603657293931d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22612265594451164d, b: 0.2386129486476969d, c: 0.46919503884788205d),

new NpgsqlTypes.NpgsqlLine(a: 0.834148620741612d, b: 0.2840460599148471d, c: 0.9954800587282968d),

new NpgsqlTypes.NpgsqlLine(a: 0.6655844665920542d, b: 0.3752780881105976d, c: 0.38216394263566733d),

new NpgsqlTypes.NpgsqlLine(a: 0.21374304358701457d, b: 0.3143022974286753d, c: 0.8857362556942342d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3486318991118663d, b: 0.06470152822099373d, c: 0.2949399417476031d),

new NpgsqlTypes.NpgsqlLine(a: 0.035515126828673194d, b: 0.6155009515575663d, c: 0.9278217392478249d),

new NpgsqlTypes.NpgsqlLine(a: 0.15555734633342022d, b: 0.45402718236709594d, c: 0.23069795337014842d),

new NpgsqlTypes.NpgsqlLine(a: 0.8693951196844898d, b: 0.16851428903134824d, c: 0.5416037131838215d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24053328893885328d, b: 0.7452603309396968d, c: 0.025000963614366878d),

new NpgsqlTypes.NpgsqlLine(a: 0.9310264213398654d, b: 0.7991105536692205d, c: 0.7966567594425034d),

new NpgsqlTypes.NpgsqlLine(a: 0.7396211512673464d, b: 0.9890928609509324d, c: 0.08130074467110826d),

new NpgsqlTypes.NpgsqlLine(a: 0.4308095334693067d, b: 0.9785969310075253d, c: 0.7955298527482185d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25081502105503417d, b: 0.9160215692131235d, c: 0.6711157101582503d),

new NpgsqlTypes.NpgsqlLine(a: 0.25539542818019123d, b: 0.13862337227072297d, c: 0.038956488426379776d),

new NpgsqlTypes.NpgsqlLine(a: 0.38030878756460773d, b: 0.5994042273003136d, c: 0.9079304017124941d),

new NpgsqlTypes.NpgsqlLine(a: 0.5887248098809761d, b: 0.1360943780074173d, c: 0.6515444543216137d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.830634652024883d, b: 0.04838156908949609d, c: 0.9991103784371749d),

new NpgsqlTypes.NpgsqlLine(a: 0.6772352739578875d, b: 0.4391702086058942d, c: 0.04046332236518513d),

new NpgsqlTypes.NpgsqlLine(a: 0.9682958714173768d, b: 0.17754428646050768d, c: 0.7386073085872337d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10206846563327743d, b: 0.44061931023159606d, c: 0.8116959627664678d),

new NpgsqlTypes.NpgsqlLine(a: 0.814620014491243d, b: 0.9551331247106878d, c: 0.12214245382884381d),

new NpgsqlTypes.NpgsqlLine(a: 0.3096055259260504d, b: 0.9676763279542842d, c: 0.6672267039992159d),

new NpgsqlTypes.NpgsqlLine(a: 0.8713813108453831d, b: 0.25211988344075d, c: 0.37081600131726056d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4791959638126275d, b: 0.3079018298544688d, c: 0.9286689357078186d),

new NpgsqlTypes.NpgsqlLine(a: 0.7137110940536087d, b: 0.35683734985035154d, c: 0.4196060674265162d),

new NpgsqlTypes.NpgsqlLine(a: 0.6309558846595895d, b: 0.038408327941462206d, c: 0.16588081912650798d),

new NpgsqlTypes.NpgsqlLine(a: 0.8279297089938124d, b: 0.680339516670713d, c: 0.2417397258826982d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7873957802186257d, b: 0.8400299305965815d, c: 0.4418195446389459d),

new NpgsqlTypes.NpgsqlLine(a: 0.04194681649596543d, b: 0.7068374257980419d, c: 0.04416304234826829d),

new NpgsqlTypes.NpgsqlLine(a: 0.24549351070157466d, b: 0.9603041510806263d, c: 0.14898638831419053d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3392700891292205d, b: 0.2664497668885758d, c: 0.6689311861142363d),

new NpgsqlTypes.NpgsqlLine(a: 0.7487496559629055d, b: 0.13506975717485614d, c: 0.3293333352832071d),

new NpgsqlTypes.NpgsqlLine(a: 0.32865925901540716d, b: 0.466533222751647d, c: 0.8989453697473018d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3974799267216219d, b: 0.09915088524942883d, c: 0.704041935998234d),

new NpgsqlTypes.NpgsqlLine(a: 0.14297429857418686d, b: 0.9192800828337635d, c: 0.4019018557242072d),

new NpgsqlTypes.NpgsqlLine(a: 0.798267243378826d, b: 0.15385534015106728d, c: 0.6746992505181593d),

new NpgsqlTypes.NpgsqlLine(a: 0.07130157197340625d, b: 0.0672035869383083d, c: 0.6987313490085714d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5486504421539199d, b: 0.6080955157933199d, c: 0.6028079132339647d),

new NpgsqlTypes.NpgsqlLine(a: 0.8681055266709294d, b: 0.7644027115820416d, c: 0.21511735728460835d),

new NpgsqlTypes.NpgsqlLine(a: 0.6165597064564087d, b: 0.8262610387397239d, c: 0.40369454848838715d),

new NpgsqlTypes.NpgsqlLine(a: 0.5533249309272567d, b: 0.2147638379408794d, c: 0.5226528727888361d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04421405358569874d, b: 0.8798339486281272d, c: 0.1667103950316412d),

new NpgsqlTypes.NpgsqlLine(a: 0.8558452150955328d, b: 0.8555110931739506d, c: 0.6112377344458053d),

new NpgsqlTypes.NpgsqlLine(a: 0.9822891285998746d, b: 0.9547041777700447d, c: 0.485220038798596d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.343822988780512d, b: 0.5870427084630517d, c: 0.13967566874502824d),

new NpgsqlTypes.NpgsqlLine(a: 0.5783629583079876d, b: 0.8586461763259703d, c: 0.8126768822781384d),

new NpgsqlTypes.NpgsqlLine(a: 0.8080276751061329d, b: 0.4727848165923667d, c: 0.21430645496616685d),

new NpgsqlTypes.NpgsqlLine(a: 0.7744817374438441d, b: 0.2522952137508676d, c: 0.4036087205226788d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13813811262649478d, b: 0.27480970736545185d, c: 0.8357223908723858d),

new NpgsqlTypes.NpgsqlLine(a: 0.6718693031983575d, b: 0.2456720430254653d, c: 0.3606086722552253d),

new NpgsqlTypes.NpgsqlLine(a: 0.7219770769938865d, b: 0.6674181148304176d, c: 0.8028499438492113d),

new NpgsqlTypes.NpgsqlLine(a: 0.11224196677747444d, b: 0.5290019110423991d, c: 0.09026466031245783d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7481011611051633d, b: 0.8428582691626423d, c: 0.2702260105858246d),

new NpgsqlTypes.NpgsqlLine(a: 0.8865840996474527d, b: 0.3169880064005197d, c: 0.41785209452064975d),

new NpgsqlTypes.NpgsqlLine(a: 0.072855008126809d, b: 0.9695877370891459d, c: 0.17522224160495425d),

new NpgsqlTypes.NpgsqlLine(a: 0.020684267472723117d, b: 0.04936579975424571d, c: 0.05202994160151875d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
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

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                List<NpgsqlLinelineListD1E2M> models = null;

                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineListD1E2M> models = null;

                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 115;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 64, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 64, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 17, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 115, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 41, query1, 154, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 77, query1, 135, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 148, query1, 135, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 114, query1, 160, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 31, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatch(connection, 8, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models = await ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[18], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[19], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[20], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[21], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[22], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[23], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[24], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[25], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[26], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[27], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[28], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[29], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models =  ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[16], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[17], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[18], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[19], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[20], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[21], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[22], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[23], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[24], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[25], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[26], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[27], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[28], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[29], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[34], false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MI),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineListD1E2M),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
FROM public.binary_npgsqllinelinelistd1e2m m
LEFT JOIN public.binary_npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models =  ((INpgsqlLineListlineListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI), typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                await ((INpgsqlLineListlineListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                ((INpgsqlLineListlineListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

