

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
new NpgsqlTypes.NpgsqlPoint(x: 0.4082700424296659d, y: 0.48326438583400666d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7229206697006612d, y: 0.21786047734769698d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6942074470413325d, y: 0.02104825555657608d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46989288739534874d, y: 0.47255592332139273d),
new NpgsqlTypes.NpgsqlPoint(x: 0.758189160745986d, y: 0.7443343796211382d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6451879143610714d, y: 0.12356731745920357d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8366738347854734d, y: 0.6725483581755181d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1669457538150947d, y: 0.5807603418292459d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6246479029334475d, y: 0.9839068334671107d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8209085744612796d, y: 0.025730551739499563d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3306202788097389d, y: 0.9270218426566219d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28884539762198624d, y: 0.294807170470307d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6674356496519763d, y: 0.9837858232288769d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14703756070363194d, y: 0.39831714670137053d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.530267156466035d, y: 0.6405106396542971d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8624071204068837d, y: 0.4337601160279537d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6724407806326799d, y: 0.21307652406310473d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12261969425732955d, y: 0.8428615174504451d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6710783348378014d, y: 0.6669549015081306d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8960733104820854d, y: 0.6976064114664056d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26547869166669447d, y: 0.8903184857770974d),
new NpgsqlTypes.NpgsqlPoint(x: 0.030288809366539104d, y: 0.1728786386474096d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4608428391534496d, y: 0.36363722642806384d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1266571392786422d, y: 0.314989384089315d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6730656057646428d, y: 0.7316786287129409d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6046736384514022d, y: 0.30396228912020784d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9601549786563187d, y: 0.8604858541514484d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6079847588790073d, y: 0.20942798834677512d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3032640569009405d, y: 0.8522137557167311d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7079441058526328d, y: 0.22666929222645682d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9380419316494438d, y: 0.7431200289127449d),
new NpgsqlTypes.NpgsqlPoint(x: 0.606520624853853d, y: 0.7500663032221415d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21629061613944633d, y: 0.041842673918364603d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46717015544859697d, y: 0.4253118964137087d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06121287469323233d, y: 0.6292047632989216d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6032094152616637d, y: 0.8927560986095648d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10638819718284187d, y: 0.019747563158980963d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02430058657238554d, y: 0.21272038223297418d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7820764258124362d, y: 0.18923336256384982d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6588304826622947d, y: 0.9944187630371881d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9788962519981783d, y: 0.7713970196794381d),
new NpgsqlTypes.NpgsqlPoint(x: 0.952336848809656d, y: 0.44082814669456594d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7463286785888406d, y: 0.45580235229566335d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30762971931232785d, y: 0.8565735225929223d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9501918886327826d, y: 0.1676179243177115d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6565319952145238d, y: 0.28472684150335614d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6809421515640183d, y: 0.4586170066074142d),
new NpgsqlTypes.NpgsqlPoint(x: 0.591721670013615d, y: 0.4480859343602699d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8702152414211484d, y: 0.9261027014047928d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.577982287791805d, y: 0.2992690021923756d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8519556067066001d, y: 0.7188736658458283d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7998820881032288d, y: 0.5119975415325922d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26320864547859946d, y: 0.9606974712521632d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11927079479555525d, y: 0.21216191800878248d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1011386711901322d, y: 0.7161769696869362d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10945744977558136d, y: 0.1716916900745875d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8587712591242137d, y: 0.137565502619591d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7518118582126855d, y: 0.6107381644849698d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2757404141306107d, y: 0.42358697698467307d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8267022367171595d, y: 0.42220565308529745d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6036396019422378d, y: 0.135486445811827d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5639151116069939d, y: 0.9411756216210465d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31266087887069316d, y: 0.770620650490929d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7216977229148226d, y: 0.14835537977188928d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8570437888752156d, y: 0.006888033638888569d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7204882678130899d, y: 0.25209042727483766d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3704253123161598d, y: 0.40764949103758796d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08360095778755727d, y: 0.6644400225886513d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6261099395381476d, y: 0.970596247514454d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9471627846503403d, y: 0.9339467791057814d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7330120390161312d, y: 0.18260949637053192d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5939925638057415d, y: 0.36465134290913426d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08273493851207636d, y: 0.4326871482545782d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2744348997892898d, y: 0.9295090733955004d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6170594112765111d, y: 0.6666042649372441d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16470240087037025d, y: 0.3820110371842095d),
new NpgsqlTypes.NpgsqlPoint(x: 0.006903451961394413d, y: 0.3915928528450311d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6656577809523525d, y: 0.22715409200628822d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8236124765264703d, y: 0.9292127972234525d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30258339274837576d, y: 0.25288693241762883d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7526804285668771d, y: 0.3214730522551976d),
new NpgsqlTypes.NpgsqlPoint(x: 0.052942865268905126d, y: 0.5549723843294483d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3175514225816318d, y: 0.16235908395258303d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2200228005771433d, y: 0.8314342338789036d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9974826259405438d, y: 0.09733997206393408d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46809818499903044d, y: 0.14867957270710164d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.75464035860186d, y: 0.6159876188776986d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9821105135777507d, y: 0.177614928583136d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7377582541639945d, y: 0.9637504875181437d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04350056623670617d, y: 0.16795653121227372d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4988508562107955d, y: 0.0011559309931165052d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11764783666026968d, y: 0.5528457366668316d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3229578697051251d, y: 0.7420147411777319d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2601564019261695d, y: 0.8739027956964992d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9740138295873668d, y: 0.9640913406208431d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7876690798970012d, y: 0.17052083029519327d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6841830873764291d, y: 0.684278771391286d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5813415133532218d, y: 0.423530019654185d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3604890128483884d, y: 0.5011310234461389d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0035880964299237483d, y: 0.09862050967327596d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8566746232421876d, y: 0.40675701344320536d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4350857202188668d, y: 0.6510603687520994d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29741299858279846d, y: 0.4673763641137101d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7256929789069791d, y: 0.6251888807555722d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11532227421804464d, y: 0.5985992510029969d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1858002954092417d, y: 0.026530264599773146d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5108930922003264d, y: 0.05739388915068255d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2630454576427672d, y: 0.9863342251640425d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11059896731797214d, y: 0.21476081812270265d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9702330053344863d, y: 0.8005921151037764d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1710132466819051d, y: 0.3794794374520398d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17168441494921827d, y: 0.8850342424073199d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0045399599960772585d, y: 0.1983442823864644d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4308567531980435d, y: 0.2969798427566612d),
new NpgsqlTypes.NpgsqlPoint(x: 0.865503505075379d, y: 0.2736682367476394d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38211136960597913d, y: 0.47801800266827954d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28570033860551436d, y: 0.8482893443065365d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7844161035742582d, y: 0.1274493962763784d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06248944879318674d, y: 0.35037180434032844d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2860844704093559d, y: 0.17790768708245885d),
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
new NpgsqlTypes.NpgsqlPoint(x: 0.05716846929106312d, y: 0.8306999098818774d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31971981371821134d, y: 0.5300362339106239d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29950879498493144d, y: 0.02051678286419112d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6328827969880257d, y: 0.6800652622957264d),
new NpgsqlTypes.NpgsqlPoint(x: 0.019271301355783255d, y: 0.3159625540102631d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10323498322283664d, y: 0.7514726207138464d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8530896543121071d, y: 0.6488696009818236d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02976695987568312d, y: 0.30896512911910246d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5673515093470444d, y: 0.8248835507382118d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9527975331265174d, y: 0.042083436584670175d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04097298145399242d, y: 0.49614057488329333d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7809001795716809d, y: 0.9997075866329386d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49486772638081444d, y: 0.44725855607940257d),
new NpgsqlTypes.NpgsqlPoint(x: 0.011432333165381725d, y: 0.11028184376945693d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38590525441298895d, y: 0.12369516940507164d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7017827466915161d, y: 0.9292813239526431d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8989820541542466d, y: 0.8331278250246421d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9881258411485632d, y: 0.01803500946187253d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6450999900492164d, y: 0.3266253934562836d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26962512683440576d, y: 0.12402443117479434d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9078880055408901d, y: 0.4773917461194169d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6325568447191965d, y: 0.6057213369287153d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12582508005963855d, y: 0.33245260758633577d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30476690324113664d, y: 0.01286804301101252d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8182357036572607d, y: 0.48797798395191183d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.974958793641373d, y: 0.5705587826389762d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3571941242489559d, y: 0.17268699720248015d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14821249261161196d, y: 0.1113990915594234d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9835421030127909d, y: 0.7484205708513347d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24613133796504227d, y: 0.6734544944012428d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6550192963608433d, y: 0.8414456526496685d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09979666426367018d, y: 0.30044729743940357d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8990761768081887d, y: 0.8629499233620915d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09422160531361601d, y: 0.8908198134009466d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32404575221545073d, y: 0.8725634073571257d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4174413421613016d, y: 0.4816605618401798d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37635326379614187d, y: 0.7217657631361728d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5276412542108623d, y: 0.3473972139380671d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6281396361534983d, y: 0.310598832165228d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24891180250064915d, y: 0.8234238273865592d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9998609698632525d, y: 0.2802498226426905d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6247414441828167d, y: 0.11729155371556899d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9260425398601287d, y: 0.13538084985994558d),
new NpgsqlTypes.NpgsqlPoint(x: 0.024564636600771572d, y: 0.969902293246163d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6940513137123421d, y: 0.742350353079478d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7000700741328766d, y: 0.8687956219714074d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7602132786366351d, y: 0.9819428417989168d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9560683184245394d, y: 0.24347068481154244d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38616783198929505d, y: 0.8578924910336042d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18793051762879587d, y: 0.3197808856151162d),
new NpgsqlTypes.NpgsqlPoint(x: 0.665981909357952d, y: 0.3346801436697473d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5675496903780285d, y: 0.24711727900604752d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16180836785268493d, y: 0.6351943754403503d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5336073147068255d, y: 0.007041618591718812d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4201043212961043d, y: 0.5279054227332434d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5399655719284744d, y: 0.7006614304276291d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14152765029362258d, y: 0.8164905941160038d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9413328880712682d, y: 0.6943975967007869d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5948259991671687d, y: 0.774927173866503d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19186026418850122d, y: 0.6423806671571641d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24755265585842157d, y: 0.48995782250572883d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7609139833799426d, y: 0.4543087241141902d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9640028141208536d, y: 0.16353388858018603d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24439234826743905d, y: 0.3541709867419076d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6642838140496775d, y: 0.18587871681032286d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43832173268050045d, y: 0.5059178379077804d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9421047222105435d, y: 0.7410473832551813d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19082546173504766d, y: 0.6604087954954869d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27796140219021237d, y: 0.1004890053749602d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7371456271947473d, y: 0.706808755349097d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3270019690983582d, y: 0.9744779882385524d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6668147022158919d, y: 0.3192914678054274d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43071539020972915d, y: 0.30073635584661584d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6785160615730993d, y: 0.3146651428872492d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07518055536531021d, y: 0.26935981378027896d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48405674001147725d, y: 0.7635836863222414d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6422198838770133d, y: 0.6109885513250511d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7527690490407349d, y: 0.43091981212115293d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9463262534048302d, y: 0.028665538509492938d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13194602054140336d, y: 0.9615263278399193d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6439105668956749d, y: 0.3146942277868142d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7069582792428712d, y: 0.37244227843911004d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9294920743327268d, y: 0.7152524325055465d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3381603920870061d, y: 0.5917540704195345d),
new NpgsqlTypes.NpgsqlPoint(x: 0.008968082428636004d, y: 0.21479722302293391d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41745944718311d, y: 0.18910806410591285d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23593057570651588d, y: 0.4087451638635191d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5827095000708238d, y: 0.7298307944997875d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36035620772364885d, y: 0.3934960014782345d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3080841751786074d, y: 0.4397270160796989d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43337150134926883d, y: 0.7864534413277142d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9569605597631688d, y: 0.6262194362412019d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6245751246424786d, y: 0.5258627776004547d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6222833227022455d, y: 0.9975866035510332d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9843632653488891d, y: 0.3112284463550937d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6865051265462337d, y: 0.7505968963821747d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6753044435758955d, y: 0.8004437642452588d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26421673583021643d, y: 0.12652571252532363d),
new NpgsqlTypes.NpgsqlPoint(x: 0.967477991184813d, y: 0.43504747349739614d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42929396144614484d, y: 0.03498113497115396d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8206668680759592d, y: 0.5178512346086178d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30681483424191813d, y: 0.6390638573769499d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2529324881540539d, y: 0.6956104720528499d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15297179252158222d, y: 0.4398217479697726d),
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
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30762971931232785d, y: 0.8565735225929223d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9501918886327826d, y: 0.1676179243177115d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6565319952145238d, y: 0.28472684150335614d),
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
new NpgsqlTypes.NpgsqlPoint(x: 0.7518118582126855d, y: 0.6107381644849698d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2757404141306107d, y: 0.42358697698467307d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8267022367171595d, y: 0.42220565308529745d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6036396019422378d, y: 0.135486445811827d),
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlPoint(x: 0.3175514225816318d, y: 0.16235908395258303d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2200228005771433d, y: 0.8314342338789036d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9974826259405438d, y: 0.09733997206393408d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46809818499903044d, y: 0.14867957270710164d),
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
new NpgsqlTypes.NpgsqlPoint(x: 0.04350056623670617d, y: 0.16795653121227372d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4988508562107955d, y: 0.0011559309931165052d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11764783666026968d, y: 0.5528457366668316d),
}));
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7256929789069791d, y: 0.6251888807555722d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11532227421804464d, y: 0.5985992510029969d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1858002954092417d, y: 0.026530264599773146d),
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 73, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 73, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 8, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[29], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 14, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 112, query1, 115, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 115, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 27, query1, 27, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[29], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 112, query1, 131, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 127, 66))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 46, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
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
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[29], false);
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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointArraypointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPointArraypointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
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
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1M>(15);

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
                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

