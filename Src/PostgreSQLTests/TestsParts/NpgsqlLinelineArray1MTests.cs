

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
    internal partial interface INpgsqlLineArraylineArray
    {
    }
    
    internal partial class NpgsqlLineArraylineArray : INpgsqlLineArraylineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray1M[] _testData = new NpgsqlLinelineArray1M[]
        {
            new NpgsqlLinelineArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.33568497972503597d, b: 0.7578378972389582d, c: 0.4454845291839664d),
new NpgsqlTypes.NpgsqlLine(a: 0.3466237351759984d, b: 0.3511037640823813d, c: 0.9078352278569064d),
new NpgsqlTypes.NpgsqlLine(a: 0.8253946308461881d, b: 0.3712361888468343d, c: 0.9198020501108165d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49453415630327313d, b: 0.7785088331143679d, c: 0.31576251908021424d),
new NpgsqlTypes.NpgsqlLine(a: 0.1917088514476608d, b: 0.6927231465238916d, c: 0.492992028833541d),
new NpgsqlTypes.NpgsqlLine(a: 0.6533684921848298d, b: 0.23093059963361395d, c: 0.2241157249699679d),
new NpgsqlTypes.NpgsqlLine(a: 0.17488970640615797d, b: 0.662953488798972d, c: 0.8833113126076364d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6693205421715548d, b: 0.7777079234765877d, c: 0.7787558886766585d),
new NpgsqlTypes.NpgsqlLine(a: 0.7192635388093921d, b: 0.43707691206533317d, c: 0.9202693673499702d),
new NpgsqlTypes.NpgsqlLine(a: 0.48773200626258106d, b: 0.8746650025169024d, c: 0.7864941395115047d),
new NpgsqlTypes.NpgsqlLine(a: 0.6337509635972777d, b: 0.5019858308428027d, c: 0.6168541117486208d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4779560221515716d, b: 0.8165130220442252d, c: 0.481789983653512d),
new NpgsqlTypes.NpgsqlLine(a: 0.9629456674347949d, b: 0.7422188187537371d, c: 0.635694702058818d),
new NpgsqlTypes.NpgsqlLine(a: 0.9235239947205152d, b: 0.5506790642016219d, c: 0.6283439504332187d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.41783481909332165d, b: 0.0015588786095473983d, c: 0.6035643026579129d),
new NpgsqlTypes.NpgsqlLine(a: 0.06829775658825599d, b: 0.8514431080774723d, c: 0.5693061887072156d),
new NpgsqlTypes.NpgsqlLine(a: 0.8340811330961593d, b: 0.687396022946176d, c: 0.5023636325171922d),
new NpgsqlTypes.NpgsqlLine(a: 0.27263766508295506d, b: 0.9288942758985176d, c: 0.05312423934946553d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.06757085113639183d, b: 0.6409038914264825d, c: 0.2562012180570139d),
new NpgsqlTypes.NpgsqlLine(a: 0.9052114761894056d, b: 0.8307270310583421d, c: 0.28312165072508644d),
new NpgsqlTypes.NpgsqlLine(a: 0.23671563975098286d, b: 0.4314195259812734d, c: 0.23893985017787978d),
new NpgsqlTypes.NpgsqlLine(a: 0.5236990081113936d, b: 0.6759526447927502d, c: 0.00455842956896757d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9857824220907138d, b: 0.6820363207736174d, c: 0.1115059550186488d),
new NpgsqlTypes.NpgsqlLine(a: 0.9140762364145744d, b: 0.9705615481712349d, c: 0.6393736699054541d),
new NpgsqlTypes.NpgsqlLine(a: 0.5690594155871501d, b: 0.4162403337907784d, c: 0.5453055072259787d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1741906359483263d, b: 0.23269629049812268d, c: 0.6288421484032716d),
new NpgsqlTypes.NpgsqlLine(a: 0.19807944632719232d, b: 0.09922716902376794d, c: 0.07085948718063906d),
new NpgsqlTypes.NpgsqlLine(a: 0.7035061724924285d, b: 0.8563741473349401d, c: 0.1568434039687976d),
new NpgsqlTypes.NpgsqlLine(a: 0.2746088496311049d, b: 0.7304784226447534d, c: 0.7929724761440288d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08181734070769975d, b: 0.8624203679731022d, c: 0.7845281146717603d),
new NpgsqlTypes.NpgsqlLine(a: 0.9104177098555458d, b: 0.06393235776797845d, c: 0.5815775010580989d),
new NpgsqlTypes.NpgsqlLine(a: 0.5844744841763556d, b: 0.7529617061771234d, c: 0.036002743248700786d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30766764468583185d, b: 0.027108899485387417d, c: 0.5228767246577568d),
new NpgsqlTypes.NpgsqlLine(a: 0.02175970791739157d, b: 0.3832846563314455d, c: 0.7759226289401367d),
new NpgsqlTypes.NpgsqlLine(a: 0.04025932936207144d, b: 0.4389885371698464d, c: 0.4303116024720992d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0736995376642573d, b: 0.7644967950888113d, c: 0.8792422280818406d),
new NpgsqlTypes.NpgsqlLine(a: 0.12337032298881312d, b: 0.47896451292959774d, c: 0.19557052273854147d),
new NpgsqlTypes.NpgsqlLine(a: 0.7381077287884105d, b: 0.7214755964600792d, c: 0.7150998307346308d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.534299687422871d, b: 0.8449692554887543d, c: 0.16172598445131914d),
new NpgsqlTypes.NpgsqlLine(a: 0.6355037514741688d, b: 0.47108193378519037d, c: 0.3585137465206357d),
new NpgsqlTypes.NpgsqlLine(a: 0.8449599650343373d, b: 0.11047543722995257d, c: 0.6384121901151484d),
new NpgsqlTypes.NpgsqlLine(a: 0.34856322419581076d, b: 0.9857378920827696d, c: 0.39300919186551575d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8662628677639603d, b: 0.5021476818288451d, c: 0.5492334674998459d),
new NpgsqlTypes.NpgsqlLine(a: 0.29310965760406027d, b: 0.49338886880151955d, c: 0.8939988926799813d),
new NpgsqlTypes.NpgsqlLine(a: 0.26634955894546397d, b: 0.2698630481484722d, c: 0.5331978413446303d),
new NpgsqlTypes.NpgsqlLine(a: 0.016919473816286335d, b: 0.6973997257964304d, c: 0.9850889346692225d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4634245750750682d, b: 0.05001165856297518d, c: 0.5047770951486394d),
new NpgsqlTypes.NpgsqlLine(a: 0.23838496284302424d, b: 0.7613620951763074d, c: 0.316941847628065d),
new NpgsqlTypes.NpgsqlLine(a: 0.560503842796163d, b: 0.3292176090175247d, c: 0.8309937167590444d),
new NpgsqlTypes.NpgsqlLine(a: 0.734739476420209d, b: 0.6102685396508594d, c: 0.7415111017131853d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6391906647755596d, b: 0.01695002717556382d, c: 0.42394248250577615d),
new NpgsqlTypes.NpgsqlLine(a: 0.3371520771312344d, b: 0.18864161448918138d, c: 0.3658106134618254d),
new NpgsqlTypes.NpgsqlLine(a: 0.2297495864398229d, b: 0.9747751204172681d, c: 0.5194136993525752d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17694019825780882d, b: 0.21471048507013357d, c: 0.47688882686707934d),
new NpgsqlTypes.NpgsqlLine(a: 0.14803250459010986d, b: 0.49823170694335417d, c: 0.6763982786379025d),
new NpgsqlTypes.NpgsqlLine(a: 0.8967785233540304d, b: 0.09451616593083578d, c: 0.34219997668592084d),
new NpgsqlTypes.NpgsqlLine(a: 0.5141577822514158d, b: 0.2459457587623054d, c: 0.4453968365599458d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6793606294850143d, b: 0.10780966972805472d, c: 0.8591707876381356d),
new NpgsqlTypes.NpgsqlLine(a: 0.08630878488716875d, b: 0.4806284071780973d, c: 0.30719693749573973d),
new NpgsqlTypes.NpgsqlLine(a: 0.7356027783078009d, b: 0.9986777534293035d, c: 0.9194910196588245d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05991970356837484d, b: 0.2186517840724843d, c: 0.8662457165020323d),
new NpgsqlTypes.NpgsqlLine(a: 0.6299011199052146d, b: 0.1745295709288921d, c: 0.8545864998033255d),
new NpgsqlTypes.NpgsqlLine(a: 0.5732767949233403d, b: 0.16766877567967808d, c: 0.022914605630586116d),
new NpgsqlTypes.NpgsqlLine(a: 0.17484622940164618d, b: 0.19745168863521512d, c: 0.2013327753920381d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3749780238815129d, b: 0.8228941802997117d, c: 0.8081263040936019d),
new NpgsqlTypes.NpgsqlLine(a: 0.6439040336558076d, b: 0.4017575748514949d, c: 0.11554015183667354d),
new NpgsqlTypes.NpgsqlLine(a: 0.22391371936192972d, b: 0.5369662954411757d, c: 0.05512332992603952d),
new NpgsqlTypes.NpgsqlLine(a: 0.7326845917143717d, b: 0.9508504149614105d, c: 0.7837241987769643d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09858471219158627d, b: 0.054034439918125066d, c: 0.6188076540660351d),
new NpgsqlTypes.NpgsqlLine(a: 0.9995588965474119d, b: 0.8940167153450673d, c: 0.203362409985532d),
new NpgsqlTypes.NpgsqlLine(a: 0.6106339150706992d, b: 0.7654174001053228d, c: 0.9625277870302262d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8129856812234731d, b: 0.17380191636619868d, c: 0.030396764331696136d),
new NpgsqlTypes.NpgsqlLine(a: 0.564382712864457d, b: 0.44014605869734547d, c: 0.16205201811100345d),
new NpgsqlTypes.NpgsqlLine(a: 0.8126176204276523d, b: 0.03167986405461576d, c: 0.7684996624988998d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7924066650659547d, b: 0.021371654541231022d, c: 0.9869374733614139d),
new NpgsqlTypes.NpgsqlLine(a: 0.7873680365994759d, b: 0.31294798033592197d, c: 0.26097843644723095d),
new NpgsqlTypes.NpgsqlLine(a: 0.8611199974315291d, b: 0.10353836265930139d, c: 0.5827787560757755d),
new NpgsqlTypes.NpgsqlLine(a: 0.9627236997554444d, b: 0.4284875783202472d, c: 0.3133509686473618d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7511970036694793d, b: 0.3417091274426808d, c: 0.0353025501801254d),
new NpgsqlTypes.NpgsqlLine(a: 0.45820732382948404d, b: 0.49758336749761367d, c: 0.9419273516477104d),
new NpgsqlTypes.NpgsqlLine(a: 0.9118040856723592d, b: 0.26206806358713985d, c: 0.11805764796013707d),
new NpgsqlTypes.NpgsqlLine(a: 0.744283451297434d, b: 0.8193396342983813d, c: 0.4442634582322631d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.46592519649082353d, b: 0.8613875512875702d, c: 0.2701740101888692d),
new NpgsqlTypes.NpgsqlLine(a: 0.9416048618348178d, b: 0.4740364685751506d, c: 0.3077031717134435d),
new NpgsqlTypes.NpgsqlLine(a: 0.16488516482039606d, b: 0.40391348666530436d, c: 0.3451669003166331d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7990706562543104d, b: 0.06468219695690136d, c: 0.9844475251470326d),
new NpgsqlTypes.NpgsqlLine(a: 0.8248284085235942d, b: 0.9281437066560752d, c: 0.11619068403997812d),
new NpgsqlTypes.NpgsqlLine(a: 0.5445649980231535d, b: 0.004387599391122321d, c: 0.9062911039011998d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9938668662512163d, b: 0.37210313221375d, c: 0.9345866641552998d),
new NpgsqlTypes.NpgsqlLine(a: 0.5057653388508656d, b: 0.057440655691437636d, c: 0.667634788020667d),
new NpgsqlTypes.NpgsqlLine(a: 0.02513027884772767d, b: 0.05734450354034204d, c: 0.9866165670197549d),
new NpgsqlTypes.NpgsqlLine(a: 0.2213802231429458d, b: 0.5701495935291712d, c: 0.6558535578687463d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25328942735440263d, b: 0.6396406006706996d, c: 0.01754143041692091d),
new NpgsqlTypes.NpgsqlLine(a: 0.32086202901838534d, b: 0.060954721856211536d, c: 0.8181067295598904d),
new NpgsqlTypes.NpgsqlLine(a: 0.6953473375922916d, b: 0.4256329096875421d, c: 0.19624487162653725d),
new NpgsqlTypes.NpgsqlLine(a: 0.21427332110167996d, b: 0.4638673655880807d, c: 0.822412501778143d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43362077481952543d, b: 0.22707290363197286d, c: 0.6077427219898934d),
new NpgsqlTypes.NpgsqlLine(a: 0.4092764074114482d, b: 0.41154531584159626d, c: 0.281370284166786d),
new NpgsqlTypes.NpgsqlLine(a: 0.10860812719044122d, b: 0.19225239061609356d, c: 0.8964391664002263d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6852593885229809d, b: 0.5085394716026977d, c: 0.1482211566907995d),
new NpgsqlTypes.NpgsqlLine(a: 0.9359261721680041d, b: 0.37244337471745537d, c: 0.3352946258893573d),
new NpgsqlTypes.NpgsqlLine(a: 0.440081511484802d, b: 0.8497898092567255d, c: 0.10927523110645154d),
new NpgsqlTypes.NpgsqlLine(a: 0.7908355319880584d, b: 0.11127269810690721d, c: 0.1487842928960026d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.41591631157204867d, b: 0.33040120550201d, c: 0.6445067779056349d),
new NpgsqlTypes.NpgsqlLine(a: 0.6193711983929855d, b: 0.4412488330938866d, c: 0.558250174726812d),
new NpgsqlTypes.NpgsqlLine(a: 0.09318507338558335d, b: 0.7415119906901317d, c: 0.8455889673619841d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.20312772264926116d, b: 0.9855417537598393d, c: 0.2856560026295022d),
new NpgsqlTypes.NpgsqlLine(a: 0.8935481935002122d, b: 0.034812273263493565d, c: 0.6865470837150042d),
new NpgsqlTypes.NpgsqlLine(a: 0.9151895931031934d, b: 0.02996002180438151d, c: 0.07885214774065707d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8198195039868614d, b: 0.00951829914872171d, c: 0.2310098723386257d),
new NpgsqlTypes.NpgsqlLine(a: 0.5017316612984646d, b: 0.04413314007719038d, c: 0.5407703634241272d),
new NpgsqlTypes.NpgsqlLine(a: 0.05209931339221652d, b: 0.914462555921415d, c: 0.3998960083098778d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43642677187181267d, b: 0.19846512499138447d, c: 0.8654822025283893d),
new NpgsqlTypes.NpgsqlLine(a: 0.3472110868535704d, b: 0.9999300895663946d, c: 0.9948572719472653d),
new NpgsqlTypes.NpgsqlLine(a: 0.4953510377852244d, b: 0.027148895716742172d, c: 0.5566657004040183d),
new NpgsqlTypes.NpgsqlLine(a: 0.21549149190626482d, b: 0.4301305396072175d, c: 0.12758068310521897d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14441527258232445d, b: 0.11735764081086708d, c: 0.6744580114372659d),
new NpgsqlTypes.NpgsqlLine(a: 0.3655753286576172d, b: 0.9373448196858847d, c: 0.7934246643593471d),
new NpgsqlTypes.NpgsqlLine(a: 0.1610240160046843d, b: 0.9572794928809315d, c: 0.5484176669444418d),
new NpgsqlTypes.NpgsqlLine(a: 0.686374442750453d, b: 0.25000410043961163d, c: 0.5806789810096705d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08105107307717463d, b: 0.21147550950879823d, c: 0.7744982754564046d),
new NpgsqlTypes.NpgsqlLine(a: 0.5050990188422253d, b: 0.9884273707361181d, c: 0.2989296393329408d),
new NpgsqlTypes.NpgsqlLine(a: 0.11491492983602858d, b: 0.663638400826571d, c: 0.6174711317409549d),
new NpgsqlTypes.NpgsqlLine(a: 0.8319815259917899d, b: 0.38338352571393464d, c: 0.3027784958751788d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.050306363383219144d, b: 0.7919627109881545d, c: 0.3970775512996858d),
new NpgsqlTypes.NpgsqlLine(a: 0.021359847071003135d, b: 0.3594059454740326d, c: 0.2503263197886767d),
new NpgsqlTypes.NpgsqlLine(a: 0.2931336466209954d, b: 0.24318478674479105d, c: 0.8749729317976065d),
new NpgsqlTypes.NpgsqlLine(a: 0.23061735532216865d, b: 0.5257511180519954d, c: 0.605477142909109d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5915824128676856d, b: 0.742217952838701d, c: 0.3770588869064869d),
new NpgsqlTypes.NpgsqlLine(a: 0.3040954141885396d, b: 0.887804001238698d, c: 0.8292054793790723d),
new NpgsqlTypes.NpgsqlLine(a: 0.20146996261844663d, b: 0.7564957221057728d, c: 0.6222720331403958d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7815653100292813d, b: 0.6395388472720281d, c: 0.5431518592690512d),
new NpgsqlTypes.NpgsqlLine(a: 0.47976507513744293d, b: 0.2912963510725396d, c: 0.6472359894423071d),
new NpgsqlTypes.NpgsqlLine(a: 0.2385809854285349d, b: 0.5376305744403482d, c: 0.7809919810118947d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4552881075193972d, b: 0.8170660163241964d, c: 0.6280484145349361d),
new NpgsqlTypes.NpgsqlLine(a: 0.8152383823882035d, b: 0.8846875045221746d, c: 0.9095925630735937d),
new NpgsqlTypes.NpgsqlLine(a: 0.4348004108460676d, b: 0.15205022250147893d, c: 0.3105097735699268d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5446710033860189d, b: 0.46767713200258954d, c: 0.39438686075374996d),
new NpgsqlTypes.NpgsqlLine(a: 0.22526399919330675d, b: 0.8790816246727358d, c: 0.25882320540203596d),
new NpgsqlTypes.NpgsqlLine(a: 0.9937617098416299d, b: 0.510079736184717d, c: 0.4758486592679604d),
new NpgsqlTypes.NpgsqlLine(a: 0.343255491169831d, b: 0.9890524090311935d, c: 0.9042046424606158d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8947021755130131d, b: 0.9923275173050032d, c: 0.3565731512887187d),
new NpgsqlTypes.NpgsqlLine(a: 0.6070063636654277d, b: 0.5432749165423301d, c: 0.9646669068647052d),
new NpgsqlTypes.NpgsqlLine(a: 0.5402985257284701d, b: 0.3094160533444311d, c: 0.15804977623665561d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7176202288368063d, b: 0.1966274753747571d, c: 0.710874438658089d),
new NpgsqlTypes.NpgsqlLine(a: 0.8663860351331911d, b: 0.11371029286387235d, c: 0.8189702392299021d),
new NpgsqlTypes.NpgsqlLine(a: 0.2069776472978868d, b: 0.992555538125557d, c: 0.7936117960135592d),
new NpgsqlTypes.NpgsqlLine(a: 0.8548609937597061d, b: 0.9242253062427828d, c: 0.8146035950573164d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5740247272397094d, b: 0.5126838967404671d, c: 0.7513507703353959d),
new NpgsqlTypes.NpgsqlLine(a: 0.8177752429193412d, b: 0.1728137344260311d, c: 0.26971557149179215d),
new NpgsqlTypes.NpgsqlLine(a: 0.6555845972408897d, b: 0.1132843573880371d, c: 0.04606283993610594d),
new NpgsqlTypes.NpgsqlLine(a: 0.7825912400979949d, b: 0.7222692905134316d, c: 0.9154360388291325d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5799953026803654d, b: 0.1922767055641823d, c: 0.2516058383877676d),
new NpgsqlTypes.NpgsqlLine(a: 0.9253143697064956d, b: 0.5958488224211985d, c: 0.8714589324894675d),
new NpgsqlTypes.NpgsqlLine(a: 0.36898599760919426d, b: 0.17470273057430263d, c: 0.750074530358264d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6130927376908041d, b: 0.5982047325501345d, c: 0.49199121917818855d),
new NpgsqlTypes.NpgsqlLine(a: 0.306357568319481d, b: 0.7399178418969129d, c: 0.9766797426111465d),
new NpgsqlTypes.NpgsqlLine(a: 0.20460928685647217d, b: 0.9694214664750062d, c: 0.5465624456242204d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.29880588901335126d, b: 0.90117325314305d, c: 0.21725608883390768d),
new NpgsqlTypes.NpgsqlLine(a: 0.23866602629435418d, b: 0.6145382195202927d, c: 0.464872520321558d),
new NpgsqlTypes.NpgsqlLine(a: 0.5933735019050608d, b: 0.6500893386718001d, c: 0.7064373329293145d),
new NpgsqlTypes.NpgsqlLine(a: 0.6396499609671112d, b: 0.585423766410143d, c: 0.42856752916573837d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5385492493928016d, b: 0.19607940522482836d, c: 0.5749764577458648d),
new NpgsqlTypes.NpgsqlLine(a: 0.45667741056000843d, b: 0.5891665375986724d, c: 0.0645069472298414d),
new NpgsqlTypes.NpgsqlLine(a: 0.9644060342204399d, b: 0.22005941765674597d, c: 0.15667558608706567d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18747536516609553d, b: 0.3899894389788974d, c: 0.12267887558066026d),
new NpgsqlTypes.NpgsqlLine(a: 0.052595889489207015d, b: 0.6277934806475359d, c: 0.029594101849778398d),
new NpgsqlTypes.NpgsqlLine(a: 0.1533176667652184d, b: 0.838271504233108d, c: 0.9503669187120926d),
new NpgsqlTypes.NpgsqlLine(a: 0.8979133994662959d, b: 0.2224559676462089d, c: 0.22166420089114747d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8731936079828879d, b: 0.4807601109682561d, c: 0.8181213319363042d),
new NpgsqlTypes.NpgsqlLine(a: 0.34659031699232656d, b: 0.07555605044551073d, c: 0.437891201215601d),
new NpgsqlTypes.NpgsqlLine(a: 0.23839104245531373d, b: 0.3874767669963649d, c: 0.08912574914751592d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7984765422510419d, b: 0.15539490881108242d, c: 0.3509361314440653d),
new NpgsqlTypes.NpgsqlLine(a: 0.8683268536049491d, b: 0.8160856116091283d, c: 0.4238503889382059d),
new NpgsqlTypes.NpgsqlLine(a: 0.7238717744602645d, b: 0.2949479054299363d, c: 0.8147901575416543d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19917813857791977d, b: 0.5165545549938526d, c: 0.5367226026391494d),
new NpgsqlTypes.NpgsqlLine(a: 0.29720572078182017d, b: 0.524115124549715d, c: 0.9054979034958524d),
new NpgsqlTypes.NpgsqlLine(a: 0.8643544957692868d, b: 0.7373353450111908d, c: 0.3763669246789264d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7735209395594441d, b: 0.4752075451154437d, c: 0.24925926352848282d),
new NpgsqlTypes.NpgsqlLine(a: 0.7025323928745569d, b: 0.8105203557844926d, c: 0.14271085862662636d),
new NpgsqlTypes.NpgsqlLine(a: 0.3109815636687453d, b: 0.39223706444036466d, c: 0.5867727635021593d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5468319456551666d, b: 0.26182320049310137d, c: 0.4448584302005424d),
new NpgsqlTypes.NpgsqlLine(a: 0.26915742016180133d, b: 0.7195763469845851d, c: 0.575827627154588d),
new NpgsqlTypes.NpgsqlLine(a: 0.9204056832899735d, b: 0.4342563976731403d, c: 0.4591610190174499d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8162033926584573d, b: 0.03843748668461466d, c: 0.9571432179596101d),
new NpgsqlTypes.NpgsqlLine(a: 0.20795733017587226d, b: 0.8915159773011367d, c: 0.051404357200607875d),
new NpgsqlTypes.NpgsqlLine(a: 0.8575915281307797d, b: 0.9775253677959789d, c: 0.23357854256251798d),
new NpgsqlTypes.NpgsqlLine(a: 0.8024590592571647d, b: 0.5859838658634056d, c: 0.2659024788159917d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.651426934734539d, b: 0.3800022652541386d, c: 0.06979097746846563d),
new NpgsqlTypes.NpgsqlLine(a: 0.3977776735167652d, b: 0.30003898006827967d, c: 0.1457521117281665d),
new NpgsqlTypes.NpgsqlLine(a: 0.2960464338510195d, b: 0.30286940981109167d, c: 0.3370359921156353d),
new NpgsqlTypes.NpgsqlLine(a: 0.01677761371939257d, b: 0.6344518028708513d, c: 0.5584234225028599d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.32575031625938156d, b: 0.26003169184737196d, c: 0.8420125653719395d),
new NpgsqlTypes.NpgsqlLine(a: 0.18137138621027438d, b: 0.12771634442879065d, c: 0.864265533768253d),
new NpgsqlTypes.NpgsqlLine(a: 0.01724870408984236d, b: 0.1004521320406605d, c: 0.5280699489872246d),
new NpgsqlTypes.NpgsqlLine(a: 0.8529724818487308d, b: 0.8146726814379059d, c: 0.7678866192607607d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9208048355068801d, b: 0.19202878622542086d, c: 0.5920546115041858d),
new NpgsqlTypes.NpgsqlLine(a: 0.9038105709100334d, b: 0.7952451041794941d, c: 0.7266874600197457d),
new NpgsqlTypes.NpgsqlLine(a: 0.7276857318746287d, b: 0.30383418333971524d, c: 0.14332039136953234d),
new NpgsqlTypes.NpgsqlLine(a: 0.8037188331016862d, b: 0.937726066953367d, c: 0.4129923088295552d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.822771088206512d, b: 0.6035535295198984d, c: 0.6286467282448989d),
new NpgsqlTypes.NpgsqlLine(a: 0.5595758729666986d, b: 0.5842639414420158d, c: 0.7606719900369955d),
new NpgsqlTypes.NpgsqlLine(a: 0.5881399275820995d, b: 0.7529693731229816d, c: 0.977994751286431d),
new NpgsqlTypes.NpgsqlLine(a: 0.5055013530500234d, b: 0.44332456667201237d, c: 0.7135308674093546d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14213610851338931d, b: 0.5247984247529974d, c: 0.7057906835538598d),
new NpgsqlTypes.NpgsqlLine(a: 0.933402820597775d, b: 0.9919593672938043d, c: 0.2859742413263049d),
new NpgsqlTypes.NpgsqlLine(a: 0.7930625681270205d, b: 0.9969413864195227d, c: 0.2343650414964823d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8207562993267611d, b: 0.41424431693931874d, c: 0.6069079467087115d),
new NpgsqlTypes.NpgsqlLine(a: 0.028042045516612157d, b: 0.7382302767011762d, c: 0.713888747137405d),
new NpgsqlTypes.NpgsqlLine(a: 0.24970830725816384d, b: 0.07063612590059898d, c: 0.8434457178400739d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15863688607699922d, b: 0.18469609439979162d, c: 0.0794338302909059d),
new NpgsqlTypes.NpgsqlLine(a: 0.15374754852816286d, b: 0.375229116961434d, c: 0.47873940542383553d),
new NpgsqlTypes.NpgsqlLine(a: 0.49690085549648155d, b: 0.09724819354577174d, c: 0.20024792686307158d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8763864585643864d, b: 0.8350639519652846d, c: 0.005565413932316576d),
new NpgsqlTypes.NpgsqlLine(a: 0.37719739128939767d, b: 0.034888301708503544d, c: 0.8224182786702106d),
new NpgsqlTypes.NpgsqlLine(a: 0.9005423892162928d, b: 0.3574451615638815d, c: 0.8142271391296962d),
new NpgsqlTypes.NpgsqlLine(a: 0.16218127340339183d, b: 0.7533232538829867d, c: 0.06542309324240181d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2212484218411862d, b: 0.2747104597597111d, c: 0.09768573002776026d),
new NpgsqlTypes.NpgsqlLine(a: 0.4343924923743353d, b: 0.18190129744612626d, c: 0.4480300879652911d),
new NpgsqlTypes.NpgsqlLine(a: 0.08397464176910896d, b: 0.40269299138483317d, c: 0.5901619595973908d),
new NpgsqlTypes.NpgsqlLine(a: 0.684850640126359d, b: 0.4233679638724315d, c: 0.8252007984421857d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8780584151225507d, b: 0.252670916551343d, c: 0.09744235457110118d),
new NpgsqlTypes.NpgsqlLine(a: 0.32610387219604076d, b: 0.5240471564524993d, c: 0.9663437807696529d),
new NpgsqlTypes.NpgsqlLine(a: 0.12312902713866591d, b: 0.08927017071850718d, c: 0.5371498593814781d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11609528857849094d, b: 0.22488288291936165d, c: 0.6109925768220728d),
new NpgsqlTypes.NpgsqlLine(a: 0.5991734316078615d, b: 0.6486746978259254d, c: 0.9461771960990559d),
new NpgsqlTypes.NpgsqlLine(a: 0.26116454423295254d, b: 0.9205984957282086d, c: 0.5740179894861404d),
new NpgsqlTypes.NpgsqlLine(a: 0.03577493103572249d, b: 0.48712613901431945d, c: 0.8073004212443635d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5803279149686404d, b: 0.9348011635076242d, c: 0.28097503571096305d),
new NpgsqlTypes.NpgsqlLine(a: 0.9803496477708329d, b: 0.32483058573955803d, c: 0.2646281116163287d),
new NpgsqlTypes.NpgsqlLine(a: 0.7449644957917562d, b: 0.5912283895729917d, c: 0.9254466654890678d),
},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
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

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0736995376642573d, b: 0.7644967950888113d, c: 0.8792422280818406d),
new NpgsqlTypes.NpgsqlLine(a: 0.12337032298881312d, b: 0.47896451292959774d, c: 0.19557052273854147d),
new NpgsqlTypes.NpgsqlLine(a: 0.7381077287884105d, b: 0.7214755964600792d, c: 0.7150998307346308d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4634245750750682d, b: 0.05001165856297518d, c: 0.5047770951486394d),
new NpgsqlTypes.NpgsqlLine(a: 0.23838496284302424d, b: 0.7613620951763074d, c: 0.316941847628065d),
new NpgsqlTypes.NpgsqlLine(a: 0.560503842796163d, b: 0.3292176090175247d, c: 0.8309937167590444d),
new NpgsqlTypes.NpgsqlLine(a: 0.734739476420209d, b: 0.6102685396508594d, c: 0.7415111017131853d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17694019825780882d, b: 0.21471048507013357d, c: 0.47688882686707934d),
new NpgsqlTypes.NpgsqlLine(a: 0.14803250459010986d, b: 0.49823170694335417d, c: 0.6763982786379025d),
new NpgsqlTypes.NpgsqlLine(a: 0.8967785233540304d, b: 0.09451616593083578d, c: 0.34219997668592084d),
new NpgsqlTypes.NpgsqlLine(a: 0.5141577822514158d, b: 0.2459457587623054d, c: 0.4453968365599458d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3749780238815129d, b: 0.8228941802997117d, c: 0.8081263040936019d),
new NpgsqlTypes.NpgsqlLine(a: 0.6439040336558076d, b: 0.4017575748514949d, c: 0.11554015183667354d),
new NpgsqlTypes.NpgsqlLine(a: 0.22391371936192972d, b: 0.5369662954411757d, c: 0.05512332992603952d),
new NpgsqlTypes.NpgsqlLine(a: 0.7326845917143717d, b: 0.9508504149614105d, c: 0.7837241987769643d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8129856812234731d, b: 0.17380191636619868d, c: 0.030396764331696136d),
new NpgsqlTypes.NpgsqlLine(a: 0.564382712864457d, b: 0.44014605869734547d, c: 0.16205201811100345d),
new NpgsqlTypes.NpgsqlLine(a: 0.8126176204276523d, b: 0.03167986405461576d, c: 0.7684996624988998d),
}));
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7990706562543104d, b: 0.06468219695690136d, c: 0.9844475251470326d),
new NpgsqlTypes.NpgsqlLine(a: 0.8248284085235942d, b: 0.9281437066560752d, c: 0.11619068403997812d),
new NpgsqlTypes.NpgsqlLine(a: 0.5445649980231535d, b: 0.004387599391122321d, c: 0.9062911039011998d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25328942735440263d, b: 0.6396406006706996d, c: 0.01754143041692091d),
new NpgsqlTypes.NpgsqlLine(a: 0.32086202901838534d, b: 0.060954721856211536d, c: 0.8181067295598904d),
new NpgsqlTypes.NpgsqlLine(a: 0.6953473375922916d, b: 0.4256329096875421d, c: 0.19624487162653725d),
new NpgsqlTypes.NpgsqlLine(a: 0.21427332110167996d, b: 0.4638673655880807d, c: 0.822412501778143d),
}));
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.41591631157204867d, b: 0.33040120550201d, c: 0.6445067779056349d),
new NpgsqlTypes.NpgsqlLine(a: 0.6193711983929855d, b: 0.4412488330938866d, c: 0.558250174726812d),
new NpgsqlTypes.NpgsqlLine(a: 0.09318507338558335d, b: 0.7415119906901317d, c: 0.8455889673619841d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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

                var models = await ((INpgsqlLineArraylineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[4], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[5], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[6], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[7], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[8], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
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

                var models =  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 60, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[7], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[8], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 42, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatchAsync(connection, 31, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[29], false);
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
                var models =  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatch(connection, 72, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
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
                await using var cmd = await ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 114);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[3], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[4], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[5], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[6], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[24],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[25],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[26],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
FROM public.binary_npgsqllinelinearray1m m
LEFT JOIN public.binary_npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlLinelineArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlLinelineArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlLinelineArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlLinelineArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlLinelineArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlLinelineArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlLinelineArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlLinelineArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlLinelineArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlLinelineArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlLinelineArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlLinelineArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlLinelineArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlLinelineArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlLinelineArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

