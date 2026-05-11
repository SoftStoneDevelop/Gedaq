

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
    internal partial interface INpgsqlLineMArraylineMArrayD1
    {
    }
    
    internal partial class NpgsqlLineMArraylineMArrayD1 : INpgsqlLineMArraylineMArrayD1
    {


#region TestData

        private readonly NpgsqlLinelineMArrayD1E1M[] _testData = new NpgsqlLinelineMArrayD1E1M[]
        {
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.03244763331188594d, b: 0.3663910168709811d, c: 0.501475254922856d),
new NpgsqlTypes.NpgsqlLine(a: 0.18900207196759322d, b: 0.6613436546457597d, c: 0.1566522286039127d),
new NpgsqlTypes.NpgsqlLine(a: 0.03663449945128838d, b: 0.4987347036866808d, c: 0.875461185837265d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8012362264499554d, b: 0.7138576642012316d, c: 0.20279503446183256d),
new NpgsqlTypes.NpgsqlLine(a: 0.8941380660956529d, b: 0.8507643817720194d, c: 0.5506600820828947d),
new NpgsqlTypes.NpgsqlLine(a: 0.7969836034096248d, b: 0.07630113229559554d, c: 0.4358463366390539d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9270018660970999d, b: 0.4631859343727419d, c: 0.5552944724685918d),
new NpgsqlTypes.NpgsqlLine(a: 0.4177786329582104d, b: 0.8326642508301301d, c: 0.6831977844269534d),
new NpgsqlTypes.NpgsqlLine(a: 0.6000703872991653d, b: 0.4544436482708326d, c: 0.8723297200256469d),
new NpgsqlTypes.NpgsqlLine(a: 0.917719315163492d, b: 0.21571654607815227d, c: 0.5954419281602741d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08959747561967568d, b: 0.80443601880007d, c: 0.309635579495563d),
new NpgsqlTypes.NpgsqlLine(a: 0.8096399319943595d, b: 0.5672463856808978d, c: 0.03367742452376132d),
new NpgsqlTypes.NpgsqlLine(a: 0.5110262076385036d, b: 0.08294532189885717d, c: 0.9046434128777521d),
new NpgsqlTypes.NpgsqlLine(a: 0.7121636836220253d, b: 0.3502220844678129d, c: 0.18631186572207503d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7059296491102727d, b: 0.18370808446609288d, c: 0.14015362168645584d),
new NpgsqlTypes.NpgsqlLine(a: 0.41956728509932095d, b: 0.6666028554326722d, c: 0.8875592856837803d),
new NpgsqlTypes.NpgsqlLine(a: 0.43513706260651697d, b: 0.3489022860147327d, c: 0.8054541482871798d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7236814429449281d, b: 0.13042440355622453d, c: 0.8765931549139842d),
new NpgsqlTypes.NpgsqlLine(a: 0.18330563303737768d, b: 0.01718353898491487d, c: 0.9846535292371741d),
new NpgsqlTypes.NpgsqlLine(a: 0.59378033689955d, b: 0.3488192616793564d, c: 0.8652326592620522d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7939583061796024d, b: 0.6438818066853126d, c: 0.16785710851850943d),
new NpgsqlTypes.NpgsqlLine(a: 0.07240006674877286d, b: 0.5429841201336594d, c: 0.056159892174372894d),
new NpgsqlTypes.NpgsqlLine(a: 0.952714395766043d, b: 0.8417206474493775d, c: 0.8613133334823663d),
new NpgsqlTypes.NpgsqlLine(a: 0.5055881961708595d, b: 0.09475571469624633d, c: 0.27092257229945493d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3293784973380599d, b: 0.29636698863387057d, c: 0.4543193505182386d),
new NpgsqlTypes.NpgsqlLine(a: 0.5139555466995727d, b: 0.44857294870672515d, c: 0.9066449581712318d),
new NpgsqlTypes.NpgsqlLine(a: 0.984255676303957d, b: 0.538880068117178d, c: 0.6946356300659593d),
new NpgsqlTypes.NpgsqlLine(a: 0.6641884108526693d, b: 0.9526759436329255d, c: 0.6064960371697343d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5536704997248947d, b: 0.1997530154084567d, c: 0.8845054218984054d),
new NpgsqlTypes.NpgsqlLine(a: 0.22868690159508376d, b: 0.5656276746031818d, c: 0.7977523248319559d),
new NpgsqlTypes.NpgsqlLine(a: 0.26406226138489386d, b: 0.5183421137392087d, c: 0.7296814355785843d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.45488707028277797d, b: 0.5495126785326345d, c: 0.26413716164744183d),
new NpgsqlTypes.NpgsqlLine(a: 0.5776804169487253d, b: 0.8355598331596952d, c: 0.7606860898116334d),
new NpgsqlTypes.NpgsqlLine(a: 0.4410320069246204d, b: 0.38786968599830673d, c: 0.7502147480265517d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04904385847142867d, b: 0.6132839000486674d, c: 0.9119731440198265d),
new NpgsqlTypes.NpgsqlLine(a: 0.4848734152265365d, b: 0.5992944965810013d, c: 0.5285669166439111d),
new NpgsqlTypes.NpgsqlLine(a: 0.7001570592894153d, b: 0.21338225254776122d, c: 0.9776453742175817d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.03303553830240347d, b: 0.4025327706246642d, c: 0.847933815158339d),
new NpgsqlTypes.NpgsqlLine(a: 0.8861874611937108d, b: 0.667584937435971d, c: 0.8833369313210755d),
new NpgsqlTypes.NpgsqlLine(a: 0.6452633311201701d, b: 0.2943403120651522d, c: 0.5119227627745603d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5506140825747309d, b: 0.6273823104110597d, c: 0.3732927379351636d),
new NpgsqlTypes.NpgsqlLine(a: 0.412638830480754d, b: 0.10744298792715146d, c: 0.01643754794628771d),
new NpgsqlTypes.NpgsqlLine(a: 0.5036052826122834d, b: 0.06809955392372957d, c: 0.6817980876657058d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18475338034440802d, b: 0.47578566833976843d, c: 0.8053376203153549d),
new NpgsqlTypes.NpgsqlLine(a: 0.7898899120318217d, b: 0.31242778058377507d, c: 0.9312046971022777d),
new NpgsqlTypes.NpgsqlLine(a: 0.7114432734429655d, b: 0.4271812051429078d, c: 0.9072191293062741d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6422170520781493d, b: 0.2138701587787386d, c: 0.8180876628348432d),
new NpgsqlTypes.NpgsqlLine(a: 0.6259944811146512d, b: 0.669975085236434d, c: 0.45287792987176423d),
new NpgsqlTypes.NpgsqlLine(a: 0.9921043430999253d, b: 0.35266784971137133d, c: 0.9967608000257905d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10102597740433439d, b: 0.5697068417206783d, c: 0.5376022996015349d),
new NpgsqlTypes.NpgsqlLine(a: 0.9529931330622219d, b: 0.990085845542584d, c: 0.43804916728018317d),
new NpgsqlTypes.NpgsqlLine(a: 0.932543566806562d, b: 0.7442456225932069d, c: 0.8152383907255927d),
new NpgsqlTypes.NpgsqlLine(a: 0.7610066879212177d, b: 0.6561188120832881d, c: 0.15164707432946678d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9760246573784297d, b: 0.2871757163620413d, c: 0.13568798184291175d),
new NpgsqlTypes.NpgsqlLine(a: 0.958741458293978d, b: 0.7352213500967757d, c: 0.8800081090177425d),
new NpgsqlTypes.NpgsqlLine(a: 0.48921706238508267d, b: 0.19741446495498427d, c: 0.8489626966797328d),
new NpgsqlTypes.NpgsqlLine(a: 0.7082091003415759d, b: 0.636224219459765d, c: 0.4380480329758173d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.26121986650775675d, b: 0.15279735147553097d, c: 0.007747080972515197d),
new NpgsqlTypes.NpgsqlLine(a: 0.9102049145891308d, b: 0.8865260351549921d, c: 0.28227945236034313d),
new NpgsqlTypes.NpgsqlLine(a: 0.7117958315419498d, b: 0.09422168099544881d, c: 0.36351380818295576d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7486223692244187d, b: 0.19551041735683838d, c: 0.057478557991904156d),
new NpgsqlTypes.NpgsqlLine(a: 0.9870065800389963d, b: 0.9622449719131169d, c: 0.22733493059167886d),
new NpgsqlTypes.NpgsqlLine(a: 0.4211580262163992d, b: 0.5305148500008505d, c: 0.44702248237614184d),
new NpgsqlTypes.NpgsqlLine(a: 0.7479659035586876d, b: 0.5598837919923357d, c: 0.739332690565688d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0464627258038105d, b: 0.6904566436880989d, c: 0.20615617579560097d),
new NpgsqlTypes.NpgsqlLine(a: 0.5212285932489535d, b: 0.8793134037146787d, c: 0.3421438980947308d),
new NpgsqlTypes.NpgsqlLine(a: 0.5736983413646236d, b: 0.04082465339353347d, c: 0.7329701168165736d),
new NpgsqlTypes.NpgsqlLine(a: 0.8810212886679973d, b: 0.984484994860359d, c: 0.6775306120211999d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9222146294765742d, b: 0.7327987323617366d, c: 0.06418099251262976d),
new NpgsqlTypes.NpgsqlLine(a: 0.5956822010139996d, b: 0.890849285198888d, c: 0.3953744142572527d),
new NpgsqlTypes.NpgsqlLine(a: 0.5138819622263721d, b: 0.14420143021801146d, c: 0.25965470721196116d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6691314927135001d, b: 0.7894473000770662d, c: 0.24735126949115505d),
new NpgsqlTypes.NpgsqlLine(a: 0.9107670185658814d, b: 0.9707879867842913d, c: 0.6226774444933888d),
new NpgsqlTypes.NpgsqlLine(a: 0.11534711328810998d, b: 0.7581013741636287d, c: 0.9635423569886175d),
new NpgsqlTypes.NpgsqlLine(a: 0.8907281887679562d, b: 0.7242840274626052d, c: 0.22452557853673416d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7084341169204943d, b: 0.08537765558457977d, c: 0.9453103372992885d),
new NpgsqlTypes.NpgsqlLine(a: 0.9836250645053632d, b: 0.6308581329194348d, c: 0.036255124480882306d),
new NpgsqlTypes.NpgsqlLine(a: 0.40976824986702043d, b: 0.14419512030216197d, c: 0.1404244713991466d),
new NpgsqlTypes.NpgsqlLine(a: 0.34176551591790094d, b: 0.2193736282365022d, c: 0.04356862061544098d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5980312688102384d, b: 0.4052778351984554d, c: 0.07165946202728268d),
new NpgsqlTypes.NpgsqlLine(a: 0.40042985755223803d, b: 0.01326185676150382d, c: 0.721326367030087d),
new NpgsqlTypes.NpgsqlLine(a: 0.1682156093158481d, b: 0.36372882295073217d, c: 0.09463423850311703d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12231705971519491d, b: 0.8278032297377406d, c: 0.8237723135611054d),
new NpgsqlTypes.NpgsqlLine(a: 0.13000934967852384d, b: 0.3942336315775563d, c: 0.7902517359465694d),
new NpgsqlTypes.NpgsqlLine(a: 0.6822505213876904d, b: 0.6727968722042059d, c: 0.7881074609646941d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6053767644174342d, b: 0.3313049604023244d, c: 0.8034263898525542d),
new NpgsqlTypes.NpgsqlLine(a: 0.17373562217762406d, b: 0.13876999222359365d, c: 0.5928675735128321d),
new NpgsqlTypes.NpgsqlLine(a: 0.4469318695718838d, b: 0.8547674099901582d, c: 0.9866896513013109d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.36505300061584056d, b: 0.3473859349058036d, c: 0.5970168273877505d),
new NpgsqlTypes.NpgsqlLine(a: 0.5549566297319563d, b: 0.8449173191746955d, c: 0.0960740412863097d),
new NpgsqlTypes.NpgsqlLine(a: 0.31988019890402863d, b: 0.40546476767161965d, c: 0.1614986978830032d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5891328273587113d, b: 0.7628082613573721d, c: 0.6307247238413141d),
new NpgsqlTypes.NpgsqlLine(a: 0.08973901497690373d, b: 0.6641963543938106d, c: 0.5137502637429616d),
new NpgsqlTypes.NpgsqlLine(a: 0.2260488714773673d, b: 0.7362093258659338d, c: 0.8494289192023304d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23686753901270308d, b: 0.00011734416829622951d, c: 0.02083129031198261d),
new NpgsqlTypes.NpgsqlLine(a: 0.5217350460830702d, b: 0.28986694223136333d, c: 0.58632151021735d),
new NpgsqlTypes.NpgsqlLine(a: 0.841913165593218d, b: 0.5581504731008207d, c: 0.6610674418743283d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8143561889357326d, b: 0.4277747727279667d, c: 0.12003663429865874d),
new NpgsqlTypes.NpgsqlLine(a: 0.5922110862559843d, b: 0.7130445254198609d, c: 0.5619206636502603d),
new NpgsqlTypes.NpgsqlLine(a: 0.3702099575927732d, b: 0.9954310554476898d, c: 0.8196624802803495d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4081162530022886d, b: 0.015607455864795838d, c: 0.906574347914777d),
new NpgsqlTypes.NpgsqlLine(a: 0.8736499476491553d, b: 0.6051476092455644d, c: 0.8354765718306596d),
new NpgsqlTypes.NpgsqlLine(a: 0.6784757468564965d, b: 0.4438562036207705d, c: 0.08422712329152537d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6862107969455312d, b: 0.35940761282643807d, c: 0.7345518507883543d),
new NpgsqlTypes.NpgsqlLine(a: 0.11728362829913097d, b: 0.2696917090889255d, c: 0.6552271731963462d),
new NpgsqlTypes.NpgsqlLine(a: 0.8004218001889327d, b: 0.06753092860665344d, c: 0.46441689423557597d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5305604949410858d, b: 0.9429519864843033d, c: 0.44299139306498236d),
new NpgsqlTypes.NpgsqlLine(a: 0.25265113158410957d, b: 0.03246932759814969d, c: 0.20815461574455507d),
new NpgsqlTypes.NpgsqlLine(a: 0.6123457541084095d, b: 0.13206345716774281d, c: 0.6542667573393479d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17323965907785122d, b: 0.35074421047884496d, c: 0.1044415530121614d),
new NpgsqlTypes.NpgsqlLine(a: 0.3511047854595525d, b: 0.2269049636069893d, c: 0.4070388254124222d),
new NpgsqlTypes.NpgsqlLine(a: 0.6254889708401051d, b: 0.058552509732471725d, c: 0.9438361161324316d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6331676337495948d, b: 0.36555506090608025d, c: 0.8385911071195628d),
new NpgsqlTypes.NpgsqlLine(a: 0.5667281339831215d, b: 0.4703403303332663d, c: 0.6322091569212336d),
new NpgsqlTypes.NpgsqlLine(a: 0.644178620661904d, b: 0.18700398198391732d, c: 0.12282036989718914d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6235134570599677d, b: 0.04398184872454891d, c: 0.0001892169073092198d),
new NpgsqlTypes.NpgsqlLine(a: 0.5849457074084228d, b: 0.16697844993414301d, c: 0.592783985057095d),
new NpgsqlTypes.NpgsqlLine(a: 0.526836828630114d, b: 0.4725072104491096d, c: 0.8596588148613582d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10334123233963277d, b: 0.8340752170105018d, c: 0.9106846335402327d),
new NpgsqlTypes.NpgsqlLine(a: 0.12512341145615857d, b: 0.5701355657151789d, c: 0.12582939506970559d),
new NpgsqlTypes.NpgsqlLine(a: 0.5613524472927124d, b: 0.4849151616766717d, c: 0.9152246354056717d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3254968420044867d, b: 0.8209542014932005d, c: 0.45348340282477806d),
new NpgsqlTypes.NpgsqlLine(a: 0.5388560954980286d, b: 0.3682361324314163d, c: 0.03045862602467675d),
new NpgsqlTypes.NpgsqlLine(a: 0.0026779095280354825d, b: 0.3781654840728501d, c: 0.7853573437881552d),
new NpgsqlTypes.NpgsqlLine(a: 0.008257001605421865d, b: 0.7122012823028675d, c: 0.8899323928431817d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.217090890083821d, b: 0.3179317705469803d, c: 0.2728752121929586d),
new NpgsqlTypes.NpgsqlLine(a: 0.8644640573000287d, b: 0.9258717434705855d, c: 0.6725522600732601d),
new NpgsqlTypes.NpgsqlLine(a: 0.9337226173066447d, b: 0.5566678920399523d, c: 0.22555311061182326d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3111932814636831d, b: 0.575826692096787d, c: 0.6017703433081877d),
new NpgsqlTypes.NpgsqlLine(a: 0.34795958879601374d, b: 0.9162517794629848d, c: 0.84367844429616d),
new NpgsqlTypes.NpgsqlLine(a: 0.6413520052197854d, b: 0.6944336387502603d, c: 0.5181236805512458d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.31439223070888456d, b: 0.23169322942968973d, c: 0.3262525106244588d),
new NpgsqlTypes.NpgsqlLine(a: 0.02284885528170011d, b: 0.5155938311616592d, c: 0.8912947901769505d),
new NpgsqlTypes.NpgsqlLine(a: 0.4813055904205521d, b: 0.8118955734968325d, c: 0.9462581883838268d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9707136228625858d, b: 0.5062603494776745d, c: 0.30406811779849674d),
new NpgsqlTypes.NpgsqlLine(a: 0.04176627746114536d, b: 0.7677616578771242d, c: 0.9382552968245798d),
new NpgsqlTypes.NpgsqlLine(a: 0.7221115762213377d, b: 0.11751950308531012d, c: 0.81761179992872d),
new NpgsqlTypes.NpgsqlLine(a: 0.4929463863258944d, b: 0.3355032695877168d, c: 0.1356744805599176d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9883233958805778d, b: 0.9644185601069729d, c: 0.13381028083613988d),
new NpgsqlTypes.NpgsqlLine(a: 0.20156653760488974d, b: 0.286777096432296d, c: 0.22825456646677866d),
new NpgsqlTypes.NpgsqlLine(a: 0.616612317660667d, b: 0.9185771077825243d, c: 0.2517976068133069d),
new NpgsqlTypes.NpgsqlLine(a: 0.14951951930544805d, b: 0.04710546931612747d, c: 0.8973117889426699d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.31085796713562863d, b: 0.5367574079155897d, c: 0.6295908306046696d),
new NpgsqlTypes.NpgsqlLine(a: 0.03780624302369018d, b: 0.05696502508056367d, c: 0.5758331968504372d),
new NpgsqlTypes.NpgsqlLine(a: 0.6856537821370863d, b: 0.0932307716709414d, c: 0.6240558955568992d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12327996240012351d, b: 0.8041778869280338d, c: 0.9738204401872665d),
new NpgsqlTypes.NpgsqlLine(a: 0.15234418799085958d, b: 0.034349421563035665d, c: 0.3217187310121825d),
new NpgsqlTypes.NpgsqlLine(a: 0.18473143794507463d, b: 0.029145958101878144d, c: 0.6881718282637684d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24232562047767858d, b: 0.5224617032803546d, c: 0.4345811267317615d),
new NpgsqlTypes.NpgsqlLine(a: 0.3711535908654734d, b: 0.23549164712626314d, c: 0.009882601043546435d),
new NpgsqlTypes.NpgsqlLine(a: 0.5435187328985446d, b: 0.44316185800170116d, c: 0.9651593800341669d),
new NpgsqlTypes.NpgsqlLine(a: 0.33700970106241535d, b: 0.3018361715681447d, c: 0.7805560019416841d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18017038002848396d, b: 0.761437480192613d, c: 0.8836154997901731d),
new NpgsqlTypes.NpgsqlLine(a: 0.47046184765271293d, b: 0.5575089879561419d, c: 0.8086052668248377d),
new NpgsqlTypes.NpgsqlLine(a: 0.9180308321688362d, b: 0.37547493409867194d, c: 0.9903557365858228d),
new NpgsqlTypes.NpgsqlLine(a: 0.45196454522315344d, b: 0.6759463643813205d, c: 0.3101708756235205d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4502685477800423d, b: 0.24753780400382008d, c: 0.8135389197859675d),
new NpgsqlTypes.NpgsqlLine(a: 0.8070461647538061d, b: 0.0968195363469897d, c: 0.5772758761897457d),
new NpgsqlTypes.NpgsqlLine(a: 0.42741242969077864d, b: 0.766126524013489d, c: 0.4473318831866645d),
new NpgsqlTypes.NpgsqlLine(a: 0.744920331386344d, b: 0.07162166643147139d, c: 0.10141220952596763d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8306764750239396d, b: 0.7401919605533334d, c: 0.659072002637347d),
new NpgsqlTypes.NpgsqlLine(a: 0.07451805977086468d, b: 0.6492888713067045d, c: 0.41922842934133864d),
new NpgsqlTypes.NpgsqlLine(a: 0.06085665733607859d, b: 0.23161313368791814d, c: 0.5190080331223795d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4987970522505203d, b: 0.6927430152404876d, c: 0.14469021107411906d),
new NpgsqlTypes.NpgsqlLine(a: 0.7421990778642613d, b: 0.7923245220487516d, c: 0.8557016412078454d),
new NpgsqlTypes.NpgsqlLine(a: 0.8146161064809764d, b: 0.4457136225436039d, c: 0.09964230178061273d),
new NpgsqlTypes.NpgsqlLine(a: 0.5095285861485274d, b: 0.0565526077450782d, c: 0.18104684639775226d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.20683294916333916d, b: 0.8313278259861392d, c: 0.30265980595287434d),
new NpgsqlTypes.NpgsqlLine(a: 0.45493475721148d, b: 0.9857803869646083d, c: 0.6077488350738406d),
new NpgsqlTypes.NpgsqlLine(a: 0.4048467805910384d, b: 0.06804867615545729d, c: 0.026544539824319036d),
new NpgsqlTypes.NpgsqlLine(a: 0.3146948589292222d, b: 0.24533278678232828d, c: 0.3791860323535191d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.41607041958350455d, b: 0.5136705261294845d, c: 0.21785538594724685d),
new NpgsqlTypes.NpgsqlLine(a: 0.7850185479774402d, b: 0.06718327034979232d, c: 0.9818718546890967d),
new NpgsqlTypes.NpgsqlLine(a: 0.5416598903864455d, b: 0.022338075995081086d, c: 0.5535538388614683d),
new NpgsqlTypes.NpgsqlLine(a: 0.6306949935593247d, b: 0.9575982118336358d, c: 0.9213399549438951d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7548515159069195d, b: 0.07910400752465963d, c: 0.8737581293120459d),
new NpgsqlTypes.NpgsqlLine(a: 0.211844217843021d, b: 0.23938524299803732d, c: 0.2518134703385745d),
new NpgsqlTypes.NpgsqlLine(a: 0.7915416353971542d, b: 0.889423128062147d, c: 0.9702124992750877d),
new NpgsqlTypes.NpgsqlLine(a: 0.5898482443735898d, b: 0.21155172323279903d, c: 0.009687426255710618d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4867446817286999d, b: 0.4551368833960555d, c: 0.6310717841675139d),
new NpgsqlTypes.NpgsqlLine(a: 0.8433056882662031d, b: 0.012706536073315067d, c: 0.3961308437358112d),
new NpgsqlTypes.NpgsqlLine(a: 0.4674399187126238d, b: 0.11864485238417088d, c: 0.058239738684432885d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.13671340222146244d, b: 0.092290911820052d, c: 0.7503027446494114d),
new NpgsqlTypes.NpgsqlLine(a: 0.8890098089806049d, b: 0.6699083745801641d, c: 0.47368923719736045d),
new NpgsqlTypes.NpgsqlLine(a: 0.6917468239559039d, b: 0.5481085504868559d, c: 0.9258464208904269d),
new NpgsqlTypes.NpgsqlLine(a: 0.9199422252251087d, b: 0.19554282803481826d, c: 0.8510492096018243d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8962986837983918d, b: 0.760927295798839d, c: 0.602502542059493d),
new NpgsqlTypes.NpgsqlLine(a: 0.8534691226588171d, b: 0.8692546916015617d, c: 0.5353938260259168d),
new NpgsqlTypes.NpgsqlLine(a: 0.4544296205509114d, b: 0.5486078172848773d, c: 0.998311686795661d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10494971255725227d, b: 0.7747340480919646d, c: 0.78204674662682d),
new NpgsqlTypes.NpgsqlLine(a: 0.936904612563891d, b: 0.3408452776524459d, c: 0.7014023043562216d),
new NpgsqlTypes.NpgsqlLine(a: 0.7290123058354593d, b: 0.006547010443562429d, c: 0.577046456916388d),
new NpgsqlTypes.NpgsqlLine(a: 0.4375685791846988d, b: 0.13312894356731153d, c: 0.616671624618484d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6846277645033213d, b: 0.24675834082924175d, c: 0.3608916487511441d),
new NpgsqlTypes.NpgsqlLine(a: 0.8675081761273982d, b: 0.2498390050621656d, c: 0.45895750399161084d),
new NpgsqlTypes.NpgsqlLine(a: 0.2709451629991708d, b: 0.06118253537218843d, c: 0.5371867522546879d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.31850958023159404d, b: 0.5075993071169579d, c: 0.07349129959825873d),
new NpgsqlTypes.NpgsqlLine(a: 0.3783648564063453d, b: 0.9884266655216551d, c: 0.7099411266087332d),
new NpgsqlTypes.NpgsqlLine(a: 0.8790689400410245d, b: 0.49375875446958817d, c: 0.059619687136029165d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3659662584440153d, b: 0.740610303289345d, c: 0.538443769893777d),
new NpgsqlTypes.NpgsqlLine(a: 0.6599031242215978d, b: 0.08635949589024672d, c: 0.24392130711121907d),
new NpgsqlTypes.NpgsqlLine(a: 0.10186842105416982d, b: 0.04754097662592616d, c: 0.10927116581386653d),
new NpgsqlTypes.NpgsqlLine(a: 0.40109475310594334d, b: 0.32934265463661816d, c: 0.9162809548288893d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.618080449600471d, b: 0.009429145921472148d, c: 0.8558773781463246d),
new NpgsqlTypes.NpgsqlLine(a: 0.24168480086578015d, b: 0.3088207723694285d, c: 0.384128452869709d),
new NpgsqlTypes.NpgsqlLine(a: 0.8740373403224305d, b: 0.812122560773261d, c: 0.3149560313623214d),
new NpgsqlTypes.NpgsqlLine(a: 0.2357666560972912d, b: 0.04702322363422884d, c: 0.4351983648224488d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5899478400139305d, b: 0.5899014812491592d, c: 0.6400882291415086d),
new NpgsqlTypes.NpgsqlLine(a: 0.5462457281671972d, b: 0.6466362469813766d, c: 0.1942745128213188d),
new NpgsqlTypes.NpgsqlLine(a: 0.9645537528981022d, b: 0.8517697837178184d, c: 0.3387007436472945d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9822412659697956d, b: 0.6277617917775778d, c: 0.9586211419642382d),
new NpgsqlTypes.NpgsqlLine(a: 0.009693192846405574d, b: 0.8672505354986295d, c: 0.9489231058826418d),
new NpgsqlTypes.NpgsqlLine(a: 0.8738272746663799d, b: 0.9084769017594443d, c: 0.01671270934259972d),
new NpgsqlTypes.NpgsqlLine(a: 0.28330178506620796d, b: 0.4700896391568514d, c: 0.8092938355459436d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8916247907579535d, b: 0.48239546474141115d, c: 0.18974348775779115d),
new NpgsqlTypes.NpgsqlLine(a: 0.19472855592453342d, b: 0.5267577564369975d, c: 0.578143968900291d),
new NpgsqlTypes.NpgsqlLine(a: 0.8819968390512113d, b: 0.24169333611904464d, c: 0.13331110291124615d),
new NpgsqlTypes.NpgsqlLine(a: 0.6355464992412466d, b: 0.7296796003231587d, c: 0.22003388913595046d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5188419122977928d, b: 0.2692682482269442d, c: 0.4329027496631028d),
new NpgsqlTypes.NpgsqlLine(a: 0.7326050541744685d, b: 0.42844189764482743d, c: 0.023491872055632634d),
new NpgsqlTypes.NpgsqlLine(a: 0.16515063431501176d, b: 0.9642016627194888d, c: 0.7277142436098496d),
new NpgsqlTypes.NpgsqlLine(a: 0.5221754121736547d, b: 0.3483258333161485d, c: 0.828855762105245d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43752327390247236d, b: 0.5110521993314739d, c: 0.7985058536151376d),
new NpgsqlTypes.NpgsqlLine(a: 0.7583708890918543d, b: 0.06456152027852236d, c: 0.27201452921042935d),
new NpgsqlTypes.NpgsqlLine(a: 0.9380493868906262d, b: 0.3871027478743878d, c: 0.40477472335531517d),
new NpgsqlTypes.NpgsqlLine(a: 0.4271317033875237d, b: 0.6675633810689057d, c: 0.6746936196121234d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.300717351722694d, b: 0.06988336448373067d, c: 0.1333822322198046d),
new NpgsqlTypes.NpgsqlLine(a: 0.506801511071992d, b: 0.8394528255266928d, c: 0.03921607628729895d),
new NpgsqlTypes.NpgsqlLine(a: 0.9626617960924144d, b: 0.18175295632093746d, c: 0.43840489372742575d),
new NpgsqlTypes.NpgsqlLine(a: 0.02287079774789147d, b: 0.7221220963074716d, c: 0.7626381224536095d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.592496555338033d, b: 0.37932765904634824d, c: 0.9031223704803962d),
new NpgsqlTypes.NpgsqlLine(a: 0.26200209295722776d, b: 0.7051996985016481d, c: 0.2112644527936225d),
new NpgsqlTypes.NpgsqlLine(a: 0.8761801539745945d, b: 0.610862616187304d, c: 0.2674540518354125d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5959562338431457d, b: 0.9665285497685817d, c: 0.6980893515138635d),
new NpgsqlTypes.NpgsqlLine(a: 0.6376368022779357d, b: 0.4848239895488502d, c: 0.5117562296616454d),
new NpgsqlTypes.NpgsqlLine(a: 0.05836542979001891d, b: 0.814090398013282d, c: 0.9867687676207544d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08212675092607313d, b: 0.22096374824299791d, c: 0.6490991126470762d),
new NpgsqlTypes.NpgsqlLine(a: 0.2829102385022916d, b: 0.14383078990602638d, c: 0.06989129785507109d),
new NpgsqlTypes.NpgsqlLine(a: 0.6831243151809999d, b: 0.2627398034697648d, c: 0.07795230255366503d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2395073009383888d, b: 0.5826932926012128d, c: 0.4794718704214941d),
new NpgsqlTypes.NpgsqlLine(a: 0.7575813524092236d, b: 0.2227223363133256d, c: 0.34702892519529327d),
new NpgsqlTypes.NpgsqlLine(a: 0.10276545272676418d, b: 0.15271435451490878d, c: 0.41786151489611556d),
new NpgsqlTypes.NpgsqlLine(a: 0.8637978682307115d, b: 0.21019576561465314d, c: 0.6211668828685659d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6358007206336308d, b: 0.9777447706840944d, c: 0.10532183600745748d),
new NpgsqlTypes.NpgsqlLine(a: 0.16552996538798648d, b: 0.5809169862837804d, c: 0.6831018071124595d),
new NpgsqlTypes.NpgsqlLine(a: 0.9150244953833465d, b: 0.16729169520825582d, c: 0.9813816759049228d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4103248456551717d, b: 0.7251144809998156d, c: 0.49816972169933327d),
new NpgsqlTypes.NpgsqlLine(a: 0.4234854131972434d, b: 0.911801637217709d, c: 0.11541978915741269d),
new NpgsqlTypes.NpgsqlLine(a: 0.14781174611142667d, b: 0.6482192537773822d, c: 0.26086670110217636d),
new NpgsqlTypes.NpgsqlLine(a: 0.6300353465834552d, b: 0.14682936140232117d, c: 0.6864996261933575d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 173,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4790110164400866d, b: 0.02876336494151066d, c: 0.7021453609126385d),
new NpgsqlTypes.NpgsqlLine(a: 0.1630381872272576d, b: 0.8808662273716154d, c: 0.24151151361550438d),
new NpgsqlTypes.NpgsqlLine(a: 0.8271174603693546d, b: 0.1969193812772171d, c: 0.4414362748610384d),
},
    ModelInner = new NpgsqlLinelineMArrayD11MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24698101314160892d, b: 0.6463523565772932d, c: 0.006412917964954912d),
new NpgsqlTypes.NpgsqlLine(a: 0.420903713340227d, b: 0.632423219427584d, c: 0.6595660824992121d),
new NpgsqlTypes.NpgsqlLine(a: 0.7662426221889275d, b: 0.7387857588592307d, c: 0.8974670988128461d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6368604321502614d, b: 0.1536466404285588d, c: 0.5025367107706132d),
new NpgsqlTypes.NpgsqlLine(a: 0.9523455438162012d, b: 0.6001310682116215d, c: 0.45422633489982245d),
new NpgsqlTypes.NpgsqlLine(a: 0.9211870882252584d, b: 0.8669425518359875d, c: 0.5374409284102678d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.36341973888709056d, b: 0.1820230315116722d, c: 0.38723243419515685d),
new NpgsqlTypes.NpgsqlLine(a: 0.5104595901368272d, b: 0.8720901376196201d, c: 0.9562488163314374d),
new NpgsqlTypes.NpgsqlLine(a: 0.21075966729599616d, b: 0.9627832446545158d, c: 0.44716556838755805d),
},
},
            new NpgsqlLinelineMArrayD1E1M
{
    Id = 181,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5888455697574579d, b: 0.7119315071739978d, c: 0.8765981337807589d),
new NpgsqlTypes.NpgsqlLine(a: 0.3300537882670399d, b: 0.17243070466458932d, c: 0.7388803740417184d),
new NpgsqlTypes.NpgsqlLine(a: 0.887401666954529d, b: 0.84513472388645d, c: 0.20968676614625836d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8614832219765215d, b: 0.49601774703256374d, c: 0.8467907780022227d),
new NpgsqlTypes.NpgsqlLine(a: 0.512451198814745d, b: 0.4263666638676885d, c: 0.19518203951371815d),
new NpgsqlTypes.NpgsqlLine(a: 0.5594670065809078d, b: 0.005900187258832568d, c: 0.29818286552982864d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemarrayd11mi(
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
INSERT INTO public.npgsqllinelinemarrayd11mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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

                changedRows =  ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemarrayd11mi_id
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)), 
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
                methodParametrName: "npgsqllinelinemarrayd11mi_id", 
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
                changedRows =  ((INpgsqlLineMArraylineMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineMArraylineMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemarrayd11mi_id
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
    npgsqllinelinemarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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

                    nullable =  ((INpgsqlLineMArraylineMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04904385847142867d, b: 0.6132839000486674d, c: 0.9119731440198265d),
new NpgsqlTypes.NpgsqlLine(a: 0.4848734152265365d, b: 0.5992944965810013d, c: 0.5285669166439111d),
new NpgsqlTypes.NpgsqlLine(a: 0.7001570592894153d, b: 0.21338225254776122d, c: 0.9776453742175817d),
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

                    nullable =  ((INpgsqlLineMArraylineMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6422170520781493d, b: 0.2138701587787386d, c: 0.8180876628348432d),
new NpgsqlTypes.NpgsqlLine(a: 0.6259944811146512d, b: 0.669975085236434d, c: 0.45287792987176423d),
new NpgsqlTypes.NpgsqlLine(a: 0.9921043430999253d, b: 0.35266784971137133d, c: 0.9967608000257905d),
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

                    nullable = await ((INpgsqlLineMArraylineMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9760246573784297d, b: 0.2871757163620413d, c: 0.13568798184291175d),
new NpgsqlTypes.NpgsqlLine(a: 0.958741458293978d, b: 0.7352213500967757d, c: 0.8800081090177425d),
new NpgsqlTypes.NpgsqlLine(a: 0.48921706238508267d, b: 0.19741446495498427d, c: 0.8489626966797328d),
new NpgsqlTypes.NpgsqlLine(a: 0.7082091003415759d, b: 0.636224219459765d, c: 0.4380480329758173d),
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

                    nullable = await ((INpgsqlLineMArraylineMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9222146294765742d, b: 0.7327987323617366d, c: 0.06418099251262976d),
new NpgsqlTypes.NpgsqlLine(a: 0.5956822010139996d, b: 0.890849285198888d, c: 0.3953744142572527d),
new NpgsqlTypes.NpgsqlLine(a: 0.5138819622263721d, b: 0.14420143021801146d, c: 0.25965470721196116d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemarrayd11mi_id
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
    npgsqllinelinemarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
                methodParametrName: "npgsqllinelinemarrayd11mi_id", 
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
                nullable =  ((INpgsqlLineMArraylineMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlLineMArraylineMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineMArraylineMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineMArraylineMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMArrayD1E1M> models = null;

                models =  ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMArrayD1E1M> models = null;

                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineMArraylineMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD1E1M), typeof(FlatNpgsqlLinelineMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                ((INpgsqlLineMArraylineMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineMArraylineMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
LEFT JOIN public.npgsqllinelinemarrayd11mi mi ON mi.id = m.npgsqllinelinemarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineMArraylineMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD1E1M), typeof(FlatNpgsqlLinelineMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                ((INpgsqlLineMArraylineMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
LEFT JOIN public.npgsqllinelinemarrayd11mi mi ON mi.id = m.npgsqllinelinemarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineMArraylineMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD1E1M), typeof(FlatNpgsqlLinelineMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                await((INpgsqlLineMArraylineMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineMArraylineMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 169;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
LEFT JOIN public.npgsqllinelinemarrayd11mi mi ON mi.id = m.npgsqllinelinemarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
                var models = await((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD1E1M), typeof(FlatNpgsqlLinelineMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                await((INpgsqlLineMArraylineMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 159, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 96, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 47, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 47, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineMArraylineMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 14, query1, 160, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 132, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 64, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
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
FROM public.npgsqllinelinemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 151, query1, 84, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqllinelinemarrayd1e1m m
LEFT JOIN public.npgsqllinelinemarrayd11mi mi ON mi.id = m.npgsqllinelinemarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
                var models = await((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 5, 118))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineMArraylineMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 96, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlLinelineMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineMArraylineMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineMArraylineMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineMArraylineMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineMArraylineMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 18);
                var models =  ((INpgsqlLineMArraylineMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                NpgsqlLinelineMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
FROM public.binary_npgsqllinelinemarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMArrayD11MIWA),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMArrayD11MI),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinemarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
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
FROM public.binary_npgsqllinelinemarrayd1e1m m
LEFT JOIN public.binary_npgsqllinelinemarrayd11mi mi ON mi.id = m.npgsqllinelinemarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinemarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
                var models =  ((INpgsqlLineMArraylineMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD11MIWA), typeof(NpgsqlLinelineMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
                var models1 = new List<NpgsqlLinelineMArrayD11MIWA>();
                var models2 = new List<NpgsqlLinelineMArrayD11MIWA>();
                await ((INpgsqlLineMArraylineMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMArrayD11MIWA>();
                var models2 = new List<NpgsqlLinelineMArrayD11MIWA>();
                ((INpgsqlLineMArraylineMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemarrayd11mi
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
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemarrayd11mi
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
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD11MIWA), typeof(NpgsqlLinelineMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
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
                var models1 = new List<NpgsqlLinelineMArrayD11MIWA>();
                var models2 = new List<NpgsqlLinelineMArrayD11MIWA>();
                await ((INpgsqlLineMArraylineMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMArrayD11MIWA>();
                var models2 = new List<NpgsqlLinelineMArrayD11MIWA>();
                ((INpgsqlLineMArraylineMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
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
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemarrayd11mi
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
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemarrayd11mi
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
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD11MI), typeof(NpgsqlLinelineMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
                var models1 = new List<NpgsqlLinelineMArrayD11MI>();
                var models2 = new List<NpgsqlLinelineMArrayD11MI>();
                await ((INpgsqlLineMArraylineMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMArrayD11MI>();
                var models2 = new List<NpgsqlLinelineMArrayD11MI>();
                ((INpgsqlLineMArraylineMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1)),
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
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD11MIWA), typeof(NpgsqlLinelineMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
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
                var models1 = new List<NpgsqlLinelineMArrayD11MIWA>();
                var models2 = new List<NpgsqlLinelineMArrayD11MIWA>();
                await ((INpgsqlLineMArraylineMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMArrayD11MIWA>();
                var models2 = new List<NpgsqlLinelineMArrayD11MIWA>();
                ((INpgsqlLineMArraylineMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMArrayD1))]
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
                var models = await ((INpgsqlLineMArraylineMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

