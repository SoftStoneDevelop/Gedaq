

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
    internal partial interface INpgsqlBoxArrayboxArray
    {
    }
    
    internal partial class NpgsqlBoxArrayboxArray : INpgsqlBoxArrayboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray1M[] _testData = new NpgsqlBoxboxArray1M[]
        {
            new NpgsqlBoxboxArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6129044562717739d,right: 0.29597460722768654d,bottom: 0.48334360575042823d,left: 0.07589667017322665d),
new NpgsqlTypes.NpgsqlBox(top: 0.9565519811843983d,right: 0.5406282981697578d,bottom: 0.46118840009928364d,left: 0.13588395682077437d),
new NpgsqlTypes.NpgsqlBox(top: 0.9895430889261034d,right: 0.5401610636013111d,bottom: 0.5877749313656115d,left: 0.05608932715822512d),
new NpgsqlTypes.NpgsqlBox(top: 0.6117451185067101d,right: 0.3318635046170709d,bottom: 0.3090628704137791d,left: 0.2304268393053711d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8074355364839285d,right: 0.5500916605194167d,bottom: 0.7034740016429981d,left: 0.45387835800000054d),
new NpgsqlTypes.NpgsqlBox(top: 0.636830869813429d,right: 0.8004373984805615d,bottom: 0.4774546942524046d,left: 0.009565748825649867d),
new NpgsqlTypes.NpgsqlBox(top: 0.916593196737793d,right: 0.4173349161214882d,bottom: 0.5647238282574307d,left: 0.2341643769437518d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7572363037507983d,right: 0.8051300200499153d,bottom: 0.0356173780438086d,left: 0.014999336615538317d),
new NpgsqlTypes.NpgsqlBox(top: 0.8047805611770091d,right: 0.7959844982884909d,bottom: 0.17071582197965818d,left: 0.20470679129209424d),
new NpgsqlTypes.NpgsqlBox(top: 0.6976886117593522d,right: 0.4157126046902314d,bottom: 0.03327862458508346d,left: 0.06081823116325347d),
new NpgsqlTypes.NpgsqlBox(top: 0.08681390069839767d,right: 0.45476947575331605d,bottom: 0.03473056576506184d,left: 0.21675281182222317d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4055298183025272d,right: 0.4261742577272598d,bottom: 0.3781047056037887d,left: 0.3782870002517307d),
new NpgsqlTypes.NpgsqlBox(top: 0.8033226878758132d,right: 0.20063255810561642d,bottom: 0.063096033564767d,left: 0.12403059709804676d),
new NpgsqlTypes.NpgsqlBox(top: 0.5532671209363418d,right: 0.5375195076335273d,bottom: 0.47666427270886524d,left: 0.05148926435426027d),
new NpgsqlTypes.NpgsqlBox(top: 0.7328300384159656d,right: 0.5282015299942748d,bottom: 0.23994574961419546d,left: 0.12699204479885184d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7341064537761861d,right: 0.21088713946263338d,bottom: 0.22551197533421463d,left: 0.01794857846377529d),
new NpgsqlTypes.NpgsqlBox(top: 0.9453338443609277d,right: 0.8610821271519773d,bottom: 0.6171114297485424d,left: 0.0015209213280165113d),
new NpgsqlTypes.NpgsqlBox(top: 0.763244758525698d,right: 0.8277181644836893d,bottom: 0.6829847754142231d,left: 0.6226508270173946d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.37394355664733625d,right: 0.5020852493697613d,bottom: 0.0337284794164503d,left: 0.4700646339346284d),
new NpgsqlTypes.NpgsqlBox(top: 0.9434086397537301d,right: 0.9026177024185182d,bottom: 0.4557583819664165d,left: 0.6995982388411204d),
new NpgsqlTypes.NpgsqlBox(top: 0.6743140744915626d,right: 0.3587003521173472d,bottom: 0.28989318600633907d,left: 0.25327966226287546d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5980094529400537d,right: 0.532859007648835d,bottom: 0.32164677081085813d,left: 0.1556396830508675d),
new NpgsqlTypes.NpgsqlBox(top: 0.7512811771189521d,right: 0.6870863885796351d,bottom: 0.1401928735786837d,left: 0.44872149656861815d),
new NpgsqlTypes.NpgsqlBox(top: 0.6979446385706861d,right: 0.4668725503707444d,bottom: 0.33463904436037706d,left: 0.17359495058618735d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.638165506986998d,right: 0.1463976279597472d,bottom: 0.6118589605619325d,left: 0.015441223436094886d),
new NpgsqlTypes.NpgsqlBox(top: 0.9468812302900307d,right: 0.6165463218389267d,bottom: 0.7083504347675532d,left: 0.6050434739363372d),
new NpgsqlTypes.NpgsqlBox(top: 0.8882885425632603d,right: 0.9841074347740325d,bottom: 0.3293753576581553d,left: 0.30995640403601443d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6197959953727933d,right: 0.7149432589542197d,bottom: 0.1405608953881785d,left: 0.6846542308859013d),
new NpgsqlTypes.NpgsqlBox(top: 0.8267449213238528d,right: 0.4233861363583822d,bottom: 0.7924675620279502d,left: 0.09896602343352034d),
new NpgsqlTypes.NpgsqlBox(top: 0.8998371890820379d,right: 0.6004197618999644d,bottom: 0.22870602063083667d,left: 0.08828664784896545d),
new NpgsqlTypes.NpgsqlBox(top: 0.22071206000403665d,right: 0.8756551549590748d,bottom: 0.17290632159617136d,left: 0.4913103745337919d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.680032529830408d,right: 0.28662961906929485d,bottom: 0.1379445935447836d,left: 0.19208449401640604d),
new NpgsqlTypes.NpgsqlBox(top: 0.9652391963049135d,right: 0.9635352392942309d,bottom: 0.25845244982417803d,left: 0.5076264930218258d),
new NpgsqlTypes.NpgsqlBox(top: 0.7806648362280859d,right: 0.9004224726257254d,bottom: 0.770094329759309d,left: 0.7215046060021145d),
new NpgsqlTypes.NpgsqlBox(top: 0.7568786185431813d,right: 0.7845359003102571d,bottom: 0.5953254592574292d,left: 0.06489099037223756d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3523051414379341d,right: 0.2129608696331644d,bottom: 0.29055957654929687d,left: 0.05139743432339772d),
new NpgsqlTypes.NpgsqlBox(top: 0.3367664041769093d,right: 0.3085947358619455d,bottom: 0.1688106195544088d,left: 0.18952498263990014d),
new NpgsqlTypes.NpgsqlBox(top: 0.4665310628809948d,right: 0.7210601888686091d,bottom: 0.15050879477818302d,left: 0.033194622648525796d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.937979225176837d,right: 0.4637350092929119d,bottom: 0.20518334807201788d,left: 0.20447834554877709d),
new NpgsqlTypes.NpgsqlBox(top: 0.7226770815853196d,right: 0.6531048598340435d,bottom: 0.682653048508078d,left: 0.057872181428402225d),
new NpgsqlTypes.NpgsqlBox(top: 0.45662691213643136d,right: 0.9638816095003303d,bottom: 0.08443715472982294d,left: 0.5590935866909468d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7405838661287384d,right: 0.8004887748030087d,bottom: 0.03563033404571614d,left: 0.28191751959803146d),
new NpgsqlTypes.NpgsqlBox(top: 0.6807080699489335d,right: 0.4572402009027524d,bottom: 0.07386282735982552d,left: 0.3149195210471546d),
new NpgsqlTypes.NpgsqlBox(top: 0.6970015962246833d,right: 0.3264724178055275d,bottom: 0.384196466014213d,left: 0.224858774956196d),
new NpgsqlTypes.NpgsqlBox(top: 0.3719442477903203d,right: 0.5175562653608587d,bottom: 0.29142732063103427d,left: 0.3091651881976073d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9994278469377182d,right: 0.8108047924633149d,bottom: 0.7266496080385476d,left: 0.5950809570988134d),
new NpgsqlTypes.NpgsqlBox(top: 0.8559386399032636d,right: 0.7131441320050161d,bottom: 0.8442122746089593d,left: 0.6099807509383361d),
new NpgsqlTypes.NpgsqlBox(top: 0.5599294560047076d,right: 0.7856694064609678d,bottom: 0.21353875759622176d,left: 0.26535965106025605d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5472395926764267d,right: 0.6657201579404707d,bottom: 0.0852937174617101d,left: 0.4093971217495881d),
new NpgsqlTypes.NpgsqlBox(top: 0.6520656012521625d,right: 0.6272675444443497d,bottom: 0.5910486334629397d,left: 0.022043850898309958d),
new NpgsqlTypes.NpgsqlBox(top: 0.04750677403300452d,right: 0.6547475561507561d,bottom: 0.044801550258360745d,left: 0.44676404152498006d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.47027454658548307d,right: 0.8360418540074268d,bottom: 0.10107053592976456d,left: 0.3939174510746857d),
new NpgsqlTypes.NpgsqlBox(top: 0.2512162573453208d,right: 0.8170860569314792d,bottom: 0.16914421236008903d,left: 0.46919566092037956d),
new NpgsqlTypes.NpgsqlBox(top: 0.9918119077778494d,right: 0.40213025929228097d,bottom: 0.8823832159202025d,left: 0.2392021888020861d),
new NpgsqlTypes.NpgsqlBox(top: 0.2620246646080352d,right: 0.331865238649965d,bottom: 0.22742796885323746d,left: 0.12491631844769424d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6695088947685675d,right: 0.8846305838107116d,bottom: 0.10774797751660514d,left: 0.35766623410651044d),
new NpgsqlTypes.NpgsqlBox(top: 0.5775683111707781d,right: 0.6211103679506527d,bottom: 0.19158961493814608d,left: 0.5576156828369941d),
new NpgsqlTypes.NpgsqlBox(top: 0.6588406938390121d,right: 0.36758610739752917d,bottom: 0.2893212271265271d,left: 0.20215041475222872d),
new NpgsqlTypes.NpgsqlBox(top: 0.939239832929269d,right: 0.89170883837474d,bottom: 0.22632952348445934d,left: 0.8007451320760951d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8512924011104689d,right: 0.43232110769536936d,bottom: 0.09688409574106827d,left: 0.15342180795484384d),
new NpgsqlTypes.NpgsqlBox(top: 0.763633264881727d,right: 0.1916136154762802d,bottom: 0.2503714952106615d,left: 0.111749407176856d),
new NpgsqlTypes.NpgsqlBox(top: 0.5823778676798317d,right: 0.7579286367530119d,bottom: 0.09206020036339102d,left: 0.19310307882298128d),
new NpgsqlTypes.NpgsqlBox(top: 0.8852792852021933d,right: 0.8940738841694463d,bottom: 0.41281539662777d,left: 0.7131825677035554d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.97587823157268d,right: 0.7180401580506839d,bottom: 0.5834601753222577d,left: 0.4606244762456222d),
new NpgsqlTypes.NpgsqlBox(top: 0.8732809051262449d,right: 0.8265077514945679d,bottom: 0.07005489198021142d,left: 0.2000632241011071d),
new NpgsqlTypes.NpgsqlBox(top: 0.8229050564679128d,right: 0.20960585714266067d,bottom: 0.12959438030868253d,left: 0.0470747142309319d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.807151570854714d,right: 0.9769560612105737d,bottom: 0.6847732548241369d,left: 0.28951137138623484d),
new NpgsqlTypes.NpgsqlBox(top: 0.9838156178802228d,right: 0.9039436069366554d,bottom: 0.5943173529640794d,left: 0.4245152709890384d),
new NpgsqlTypes.NpgsqlBox(top: 0.25788570862216476d,right: 0.8922593666721301d,bottom: 0.0917096163093637d,left: 0.4560573830729404d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7486586072445299d,right: 0.6779860220718295d,bottom: 0.3381598961972637d,left: 0.08532066112433512d),
new NpgsqlTypes.NpgsqlBox(top: 0.9587732959234883d,right: 0.5035930156037229d,bottom: 0.19509000706675428d,left: 0.30095672857272737d),
new NpgsqlTypes.NpgsqlBox(top: 0.9853582529400114d,right: 0.544253794976087d,bottom: 0.4337823099126772d,left: 0.07826159311463843d),
new NpgsqlTypes.NpgsqlBox(top: 0.5554828255761322d,right: 0.962065135137291d,bottom: 0.40444624690046627d,left: 0.14127719381828296d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.365673621763245d,right: 0.8121613186024967d,bottom: 0.18104327594489933d,left: 0.038902305695876827d),
new NpgsqlTypes.NpgsqlBox(top: 0.796982256588004d,right: 0.9489241525769728d,bottom: 0.10289525209856976d,left: 0.24144715251004034d),
new NpgsqlTypes.NpgsqlBox(top: 0.7234294574880445d,right: 0.23436001899711223d,bottom: 0.5427860241043463d,left: 0.056220855139611614d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7966237152912227d,right: 0.5526554827593725d,bottom: 0.36901158313482474d,left: 0.03196216932929119d),
new NpgsqlTypes.NpgsqlBox(top: 0.43506301986218165d,right: 0.8835845937500729d,bottom: 0.07724396262176336d,left: 0.33597472479791457d),
new NpgsqlTypes.NpgsqlBox(top: 0.40231359287174784d,right: 0.8583289610327405d,bottom: 0.20202554365504255d,left: 0.19947393210043762d),
new NpgsqlTypes.NpgsqlBox(top: 0.5807816600730454d,right: 0.6641012447183194d,bottom: 0.5635629175976753d,left: 0.11001256727592934d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4621872781002804d,right: 0.8157123952923165d,bottom: 0.03703653783616767d,left: 0.5524366745626208d),
new NpgsqlTypes.NpgsqlBox(top: 0.31264834497803407d,right: 0.9609029684251936d,bottom: 0.19365077939713338d,left: 0.1741796662672881d),
new NpgsqlTypes.NpgsqlBox(top: 0.5201882621318744d,right: 0.3497648052039375d,bottom: 0.19930017004023348d,left: 0.3381409674487905d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9514043602826513d,right: 0.7699597192923491d,bottom: 0.3228469557011544d,left: 0.36150508917123614d),
new NpgsqlTypes.NpgsqlBox(top: 0.6672042726540116d,right: 0.9571957088976613d,bottom: 0.43589942227722533d,left: 0.2664622471152932d),
new NpgsqlTypes.NpgsqlBox(top: 0.6776913107347533d,right: 0.9982208637020532d,bottom: 0.4780767119228694d,left: 0.3600158696454858d),
new NpgsqlTypes.NpgsqlBox(top: 0.5661699756433689d,right: 0.549795508466151d,bottom: 0.1100362662700537d,left: 0.539136737654355d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6581095968006048d,right: 0.8759285464111569d,bottom: 0.5960798304527585d,left: 0.4598380408405899d),
new NpgsqlTypes.NpgsqlBox(top: 0.38060301949369635d,right: 0.2815426362504675d,bottom: 0.08321531257650983d,left: 0.12355467138907206d),
new NpgsqlTypes.NpgsqlBox(top: 0.9194343375193066d,right: 0.9810908710188356d,bottom: 0.2574157235007375d,left: 0.8029248717475373d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9769757258530191d,right: 0.8745884308851469d,bottom: 0.24604824917776524d,left: 0.4832225899757361d),
new NpgsqlTypes.NpgsqlBox(top: 0.6108625101238347d,right: 0.5078020429253431d,bottom: 0.4454919924139287d,left: 0.45662781693208154d),
new NpgsqlTypes.NpgsqlBox(top: 0.519152199787985d,right: 0.4079429679869715d,bottom: 0.3605602282563124d,left: 0.20683029132812336d),
new NpgsqlTypes.NpgsqlBox(top: 0.8467431437946247d,right: 0.5423505012328964d,bottom: 0.5971202903335745d,left: 0.07226260478899682d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.44751446315864085d,right: 0.9489226844717795d,bottom: 0.10714403149959639d,left: 0.40628781299055006d),
new NpgsqlTypes.NpgsqlBox(top: 0.7464575458802163d,right: 0.343585847491509d,bottom: 0.1333757882601515d,left: 0.2002257833819998d),
new NpgsqlTypes.NpgsqlBox(top: 0.731709005681736d,right: 0.43358411798633656d,bottom: 0.07904746378273064d,left: 0.28559566925765445d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9834178613286183d,right: 0.6210082128227292d,bottom: 0.08461462588450053d,left: 0.5892350704773103d),
new NpgsqlTypes.NpgsqlBox(top: 0.8335801362811481d,right: 0.5831630130186775d,bottom: 0.005230213609672019d,left: 0.07681014272522557d),
new NpgsqlTypes.NpgsqlBox(top: 0.7291489187205268d,right: 0.12632711657858064d,bottom: 0.30241450550112503d,left: 0.06087635134473335d),
new NpgsqlTypes.NpgsqlBox(top: 0.2711329400482052d,right: 0.32564405004945973d,bottom: 0.02382198535757385d,left: 0.11606013936195436d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.730757268571484d,right: 0.8002201126174467d,bottom: 0.48029014331156294d,left: 0.40190223197251296d),
new NpgsqlTypes.NpgsqlBox(top: 0.9381855766201055d,right: 0.3526934614081634d,bottom: 0.578548883246436d,left: 0.2159702174007574d),
new NpgsqlTypes.NpgsqlBox(top: 0.6069462944726186d,right: 0.5228394446267773d,bottom: 0.4663952276792367d,left: 0.020058766442252685d),
new NpgsqlTypes.NpgsqlBox(top: 0.4754046333534554d,right: 0.440698252629913d,bottom: 0.027530817611361114d,left: 0.1042717294665354d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7765120895865277d,right: 0.8219429233628802d,bottom: 0.588704209091471d,left: 0.07112187201839693d),
new NpgsqlTypes.NpgsqlBox(top: 0.9912499638939204d,right: 0.8330269113913906d,bottom: 0.3511822582439773d,left: 0.04710672345811073d),
new NpgsqlTypes.NpgsqlBox(top: 0.9589845870462377d,right: 0.8788330272499402d,bottom: 0.16432356357162659d,left: 0.026134796313389774d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6842520127044578d,right: 0.8002195809381158d,bottom: 0.41082336247271567d,left: 0.4638782773326491d),
new NpgsqlTypes.NpgsqlBox(top: 0.848739325017659d,right: 0.4437101380280909d,bottom: 0.4169289275759429d,left: 0.004000282917351439d),
new NpgsqlTypes.NpgsqlBox(top: 0.7095346252216075d,right: 0.2992321214581133d,bottom: 0.25958780163494977d,left: 0.251859272303002d),
new NpgsqlTypes.NpgsqlBox(top: 0.18737924302368125d,right: 0.6010061326978889d,bottom: 0.16438889647642496d,left: 0.004053776329863146d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9780502691851557d,right: 0.4907162420604021d,bottom: 0.20140511454156007d,left: 0.28266949830810273d),
new NpgsqlTypes.NpgsqlBox(top: 0.44070885357669676d,right: 0.6174149533260999d,bottom: 0.29797482879198733d,left: 0.3642499827121012d),
new NpgsqlTypes.NpgsqlBox(top: 0.961170282896672d,right: 0.9780532566947806d,bottom: 0.727403597816195d,left: 0.46615582630124897d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5223735518697596d,right: 0.44796307216604725d,bottom: 0.046484012201180924d,left: 0.4201221352181521d),
new NpgsqlTypes.NpgsqlBox(top: 0.9750801554619641d,right: 0.8849900156249881d,bottom: 0.16259691549011834d,left: 0.6207775747801603d),
new NpgsqlTypes.NpgsqlBox(top: 0.2913045294024522d,right: 0.5206696310273826d,bottom: 0.16877130573203025d,left: 0.3945785087876583d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5670770776591437d,right: 0.7262176288570217d,bottom: 0.24014539748138686d,left: 0.4633084699683693d),
new NpgsqlTypes.NpgsqlBox(top: 0.7450773409356312d,right: 0.9472365470062171d,bottom: 0.47639103989224996d,left: 0.6124622905128546d),
new NpgsqlTypes.NpgsqlBox(top: 0.9940974035251225d,right: 0.7440485185821232d,bottom: 0.2774245844517086d,left: 0.2433141905509979d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7232289876156538d,right: 0.9503069600090382d,bottom: 0.2983883984830107d,left: 0.748066340295698d),
new NpgsqlTypes.NpgsqlBox(top: 0.6942226610049387d,right: 0.9037160965862372d,bottom: 0.6272750475608255d,left: 0.5217455518416775d),
new NpgsqlTypes.NpgsqlBox(top: 0.4798767435474077d,right: 0.8902686190989683d,bottom: 0.036352325704209654d,left: 0.3490359256424438d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.866372289084222d,right: 0.774449381166678d,bottom: 0.22540594571479045d,left: 0.34660099961754154d),
new NpgsqlTypes.NpgsqlBox(top: 0.9667086475266912d,right: 0.7058493652291727d,bottom: 0.6736341268591476d,left: 0.648500935386209d),
new NpgsqlTypes.NpgsqlBox(top: 0.958792975118901d,right: 0.9427330015820486d,bottom: 0.6608822243888061d,left: 0.6625208672535702d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5902735707482518d,right: 0.8461321257180757d,bottom: 0.20386914391719413d,left: 0.3397642414807226d),
new NpgsqlTypes.NpgsqlBox(top: 0.8479313963127069d,right: 0.7783429466508682d,bottom: 0.6961684755500903d,left: 0.6720623850630705d),
new NpgsqlTypes.NpgsqlBox(top: 0.08462574977978932d,right: 0.15255663243901318d,bottom: 0.06605033575312347d,left: 0.05539703672401253d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8216132687011073d,right: 0.8888664215952221d,bottom: 0.5342380894870168d,left: 0.8287617349992752d),
new NpgsqlTypes.NpgsqlBox(top: 0.7062228323645282d,right: 0.8094523410934276d,bottom: 0.36067254305380825d,left: 0.2770896456309466d),
new NpgsqlTypes.NpgsqlBox(top: 0.25739613886164814d,right: 0.4378870533205209d,bottom: 0.16479266226126943d,left: 0.10237836427683267d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5124453601320443d,right: 0.9771578676267483d,bottom: 0.12528267922579472d,left: 0.8254264926300149d),
new NpgsqlTypes.NpgsqlBox(top: 0.7520544437945947d,right: 0.5929356618676888d,bottom: 0.26723601136408315d,left: 0.3505940291032815d),
new NpgsqlTypes.NpgsqlBox(top: 0.9587919263301358d,right: 0.3028212660551375d,bottom: 0.9067205396022382d,left: 0.1679096346590978d),
new NpgsqlTypes.NpgsqlBox(top: 0.6076353050789279d,right: 0.8062204276187699d,bottom: 0.5192425617787525d,left: 0.5481301494716422d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2754476252461131d,right: 0.9151731968177853d,bottom: 0.2266249658689835d,left: 0.011878757817061714d),
new NpgsqlTypes.NpgsqlBox(top: 0.9162795506242343d,right: 0.9354871242045599d,bottom: 0.13191969048149343d,left: 0.07298748716125503d),
new NpgsqlTypes.NpgsqlBox(top: 0.7237251845135524d,right: 0.14498659055970553d,bottom: 0.6859945727066415d,left: 0.013938623367522496d),
new NpgsqlTypes.NpgsqlBox(top: 0.8830791526541898d,right: 0.3001720176257133d,bottom: 0.4874572785350846d,left: 0.08229912911637716d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5482169399170349d,right: 0.6999904555234564d,bottom: 0.47649529459700246d,left: 0.47925134358886035d),
new NpgsqlTypes.NpgsqlBox(top: 0.8746017583454907d,right: 0.7806397333493369d,bottom: 0.22653792814956508d,left: 0.3913886599971107d),
new NpgsqlTypes.NpgsqlBox(top: 0.7807917447432904d,right: 0.875835022460056d,bottom: 0.45635029386086146d,left: 0.4556176199395807d),
new NpgsqlTypes.NpgsqlBox(top: 0.19789104762109977d,right: 0.6590182221522609d,bottom: 0.09134024376420491d,left: 0.268295944793031d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5850519918660083d,right: 0.2692333642060766d,bottom: 0.3062770828138258d,left: 0.03796508547511579d),
new NpgsqlTypes.NpgsqlBox(top: 0.8746708642576914d,right: 0.9139541580912658d,bottom: 0.8037321033289178d,left: 0.6383428467956359d),
new NpgsqlTypes.NpgsqlBox(top: 0.9134812085374574d,right: 0.41287937840939204d,bottom: 0.3525143116766146d,left: 0.3637996506714062d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8753984753902252d,right: 0.1982101045201098d,bottom: 0.5349028651433031d,left: 0.10345717738399218d),
new NpgsqlTypes.NpgsqlBox(top: 0.4757607543999768d,right: 0.8748919084483034d,bottom: 0.23133224418375964d,left: 0.09127382681093088d),
new NpgsqlTypes.NpgsqlBox(top: 0.9142629626798039d,right: 0.9860264239999911d,bottom: 0.4708726599373715d,left: 0.633205658962936d),
new NpgsqlTypes.NpgsqlBox(top: 0.490554418662253d,right: 0.9267609568168157d,bottom: 0.13965239194047552d,left: 0.4664067260450414d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7718951320714202d,right: 0.9848585011478803d,bottom: 0.30360056296135307d,left: 0.15886170365877006d),
new NpgsqlTypes.NpgsqlBox(top: 0.8173274037342363d,right: 0.12524575081551892d,bottom: 0.5582750282590051d,left: 0.07873780323484592d),
new NpgsqlTypes.NpgsqlBox(top: 0.21577078249504378d,right: 0.5259710239924948d,bottom: 0.13279995209524464d,left: 0.2206833392985187d),
new NpgsqlTypes.NpgsqlBox(top: 0.22543310691082064d,right: 0.7869990676155734d,bottom: 0.10186683417550291d,left: 0.46882760946582314d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5437777094456088d,right: 0.2160864674891293d,bottom: 0.07582809966860271d,left: 0.01717285259011947d),
new NpgsqlTypes.NpgsqlBox(top: 0.9534562499201812d,right: 0.9573620053416045d,bottom: 0.3393873113433059d,left: 0.38789151731447225d),
new NpgsqlTypes.NpgsqlBox(top: 0.751600222655758d,right: 0.8436899979151135d,bottom: 0.22989690703479004d,left: 0.5036445374110339d),
new NpgsqlTypes.NpgsqlBox(top: 0.9776355150477584d,right: 0.9227967371978293d,bottom: 0.9100963017122662d,left: 0.1369839306472569d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7584000588441678d,right: 0.47896412110449627d,bottom: 0.04912521988366825d,left: 0.04698800470147235d),
new NpgsqlTypes.NpgsqlBox(top: 0.962040398732856d,right: 0.8677645596702305d,bottom: 0.8495723445888114d,left: 0.7145978189948051d),
new NpgsqlTypes.NpgsqlBox(top: 0.7129165266455463d,right: 0.7829151467252787d,bottom: 0.11288474984644403d,left: 0.1368286456346881d),
new NpgsqlTypes.NpgsqlBox(top: 0.9144431141670389d,right: 0.8095365155849575d,bottom: 0.2190594438768645d,left: 0.1394596825090032d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6052587986281408d,right: 0.7934530111461116d,bottom: 0.41016063108557577d,left: 0.28584165189844124d),
new NpgsqlTypes.NpgsqlBox(top: 0.5898394485642011d,right: 0.9441795972800802d,bottom: 0.32265453275609834d,left: 0.7275763368690188d),
new NpgsqlTypes.NpgsqlBox(top: 0.4892634809898988d,right: 0.35415766952840255d,bottom: 0.43614159435845956d,left: 0.32827608523386875d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9080601539893045d,right: 0.9230990261953896d,bottom: 0.3681231955536812d,left: 0.000864017249712079d),
new NpgsqlTypes.NpgsqlBox(top: 0.9972832663477365d,right: 0.7017025657498029d,bottom: 0.05867248393584079d,left: 0.48600196346459834d),
new NpgsqlTypes.NpgsqlBox(top: 0.4045962500564473d,right: 0.9821066146370471d,bottom: 0.15457454842318852d,left: 0.39884375206531253d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5058578377968974d,right: 0.7408638981009736d,bottom: 0.37900146951757163d,left: 0.4758534126049463d),
new NpgsqlTypes.NpgsqlBox(top: 0.5819366166215644d,right: 0.853215274013754d,bottom: 0.3268635943916547d,left: 0.21143840246673684d),
new NpgsqlTypes.NpgsqlBox(top: 0.7786191968365138d,right: 0.6971257524498085d,bottom: 0.45414932639790373d,left: 0.510645001230488d),
new NpgsqlTypes.NpgsqlBox(top: 0.46520426863622266d,right: 0.7503321570593708d,bottom: 0.2865664865737312d,left: 0.6316861383901798d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8326911705636736d,right: 0.3247488961971452d,bottom: 0.48944397270553486d,left: 0.1795242350513877d),
new NpgsqlTypes.NpgsqlBox(top: 0.3194784711506088d,right: 0.6408926850982606d,bottom: 0.08957774572243749d,left: 0.4611802717695216d),
new NpgsqlTypes.NpgsqlBox(top: 0.9288939696882171d,right: 0.23773852620596758d,bottom: 0.7209624505930924d,left: 0.05275737794712776d),
new NpgsqlTypes.NpgsqlBox(top: 0.5661500144501136d,right: 0.46163145125952576d,bottom: 0.1037484507409413d,left: 0.015046449269775386d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4800520732536451d,right: 0.5894582155929694d,bottom: 0.4065073185058037d,left: 0.5153190432771091d),
new NpgsqlTypes.NpgsqlBox(top: 0.9481795343315942d,right: 0.25492871832238106d,bottom: 0.5189011669176441d,left: 0.011373483636782034d),
new NpgsqlTypes.NpgsqlBox(top: 0.4794148648226735d,right: 0.738260095443898d,bottom: 0.29806357279877504d,left: 0.18972682807815d),
new NpgsqlTypes.NpgsqlBox(top: 0.3181976346859803d,right: 0.9972559789253803d,bottom: 0.11012028010795272d,left: 0.04473252375599035d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.09467280724461236d,right: 0.6301347369276514d,bottom: 0.00820224265538183d,left: 0.12155765963856724d),
new NpgsqlTypes.NpgsqlBox(top: 0.3115711460600684d,right: 0.6326074617798262d,bottom: 0.19356056306980995d,left: 0.09162258444651616d),
new NpgsqlTypes.NpgsqlBox(top: 0.7885125737668791d,right: 0.9459137373120956d,bottom: 0.1300769959129876d,left: 0.49360792991783464d),
new NpgsqlTypes.NpgsqlBox(top: 0.6356330415141785d,right: 0.8054113435981279d,bottom: 0.3631938165780645d,left: 0.1348860916897322d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5873171257146576d,right: 0.9262920226244568d,bottom: 0.4880233506370163d,left: 0.27901403167425076d),
new NpgsqlTypes.NpgsqlBox(top: 0.7500957012439377d,right: 0.24786690951162482d,bottom: 0.11075614082575369d,left: 0.1363910296766574d),
new NpgsqlTypes.NpgsqlBox(top: 0.9043330293338052d,right: 0.9219723175409209d,bottom: 0.3452575806630763d,left: 0.12228888822657358d),
new NpgsqlTypes.NpgsqlBox(top: 0.7307071319906268d,right: 0.5360857526901438d,bottom: 0.7208116464228118d,left: 0.0925077854723172d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9242520204151033d,right: 0.8978788476359102d,bottom: 0.30155693506655357d,left: 0.20400317480142638d),
new NpgsqlTypes.NpgsqlBox(top: 0.732481562667141d,right: 0.5699748197413227d,bottom: 0.03398986817251526d,left: 0.4524409795253188d),
new NpgsqlTypes.NpgsqlBox(top: 0.9909669392860286d,right: 0.49115801713659113d,bottom: 0.9147774747704093d,left: 0.32830511829778475d),
new NpgsqlTypes.NpgsqlBox(top: 0.6919046871263979d,right: 0.4605251871856828d,bottom: 0.1668691792508007d,left: 0.3078903233369257d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5674974886432728d,right: 0.6765561714052399d,bottom: 0.5335300275456869d,left: 0.45420656206037835d),
new NpgsqlTypes.NpgsqlBox(top: 0.9127977597729994d,right: 0.7230746933360611d,bottom: 0.3885855623566725d,left: 0.004796083876104307d),
new NpgsqlTypes.NpgsqlBox(top: 0.2585552489698928d,right: 0.36944233286484285d,bottom: 0.11713112967344141d,left: 0.2616221597135455d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7587877524748755d,right: 0.3246682985368453d,bottom: 0.03487848713255759d,left: 0.23637598661273962d),
new NpgsqlTypes.NpgsqlBox(top: 0.3347719469530036d,right: 0.5101365893952191d,bottom: 0.23429248467994312d,left: 0.4371535105494817d),
new NpgsqlTypes.NpgsqlBox(top: 0.9154593897105571d,right: 0.8625757517620342d,bottom: 0.270318557506833d,left: 0.8293319240224133d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.18957501122054887d,right: 0.955731435848422d,bottom: 0.18223831086638276d,left: 0.12891947853368835d),
new NpgsqlTypes.NpgsqlBox(top: 0.7299754901114991d,right: 0.776848600414674d,bottom: 0.7222051096402212d,left: 0.14191272077571992d),
new NpgsqlTypes.NpgsqlBox(top: 0.9797771145201666d,right: 0.9351367425221774d,bottom: 0.070288664622146d,left: 0.3963342578635951d),
new NpgsqlTypes.NpgsqlBox(top: 0.9170234255181262d,right: 0.5955142179306109d,bottom: 0.6873275574801001d,left: 0.4768644567552105d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9915324795722451d,right: 0.8900699521115734d,bottom: 0.47261272318341363d,left: 0.8828568436838701d),
new NpgsqlTypes.NpgsqlBox(top: 0.8296307415619115d,right: 0.48984587365692367d,bottom: 0.11147047349744921d,left: 0.370303454471541d),
new NpgsqlTypes.NpgsqlBox(top: 0.823303336709347d,right: 0.5989577557463912d,bottom: 0.006231572498968441d,left: 0.16516915696091983d),
new NpgsqlTypes.NpgsqlBox(top: 0.8936726785453457d,right: 0.9345267153454881d,bottom: 0.33268574236376625d,left: 0.2973737600842795d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9421271558325843d,right: 0.2795543051989523d,bottom: 0.5253582405017202d,left: 0.06296187027691813d),
new NpgsqlTypes.NpgsqlBox(top: 0.9067306550873379d,right: 0.7760991271579346d,bottom: 0.618368135782404d,left: 0.05232740391544444d),
new NpgsqlTypes.NpgsqlBox(top: 0.7454757974425417d,right: 0.08412545840951435d,bottom: 0.7120408787204502d,left: 0.0089698035643202d),
new NpgsqlTypes.NpgsqlBox(top: 0.6838786045931686d,right: 0.47540730824714117d,bottom: 0.08333299696488372d,left: 0.3995947155754934d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5308894253532648d,right: 0.9935574654746128d,bottom: 0.3218948283007189d,left: 0.9129216230634104d),
new NpgsqlTypes.NpgsqlBox(top: 0.7108432163405731d,right: 0.7854966146803528d,bottom: 0.1307649732062962d,left: 0.13573645622051866d),
new NpgsqlTypes.NpgsqlBox(top: 0.027183445025928954d,right: 0.8285775732712006d,bottom: 0.012281267586504607d,left: 0.5465632427613588d),
new NpgsqlTypes.NpgsqlBox(top: 0.6575881603703102d,right: 0.8340100192511171d,bottom: 0.39135071372651087d,left: 0.04961615555172172d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5320108554252683d,right: 0.6503539058867048d,bottom: 0.27030131181228634d,left: 0.0669299819623631d),
new NpgsqlTypes.NpgsqlBox(top: 0.566599104795989d,right: 0.8197420944570909d,bottom: 0.19737712763788018d,left: 0.7449301202189577d),
new NpgsqlTypes.NpgsqlBox(top: 0.7784035316399777d,right: 0.4518847936430659d,bottom: 0.7598587865661741d,left: 0.13226525799730593d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9745045800279553d,right: 0.8529377873045183d,bottom: 0.8342045474059928d,left: 0.5310205315907834d),
new NpgsqlTypes.NpgsqlBox(top: 0.582150546387792d,right: 0.5567698558711244d,bottom: 0.5177647758659113d,left: 0.11469090363431422d),
new NpgsqlTypes.NpgsqlBox(top: 0.635551822771237d,right: 0.22753461275250297d,bottom: 0.18543039033135356d,left: 0.06019880928674104d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7299912996451525d,right: 0.9557882753432322d,bottom: 0.15292559585416898d,left: 0.827606739063702d),
new NpgsqlTypes.NpgsqlBox(top: 0.6065921228826994d,right: 0.37934646868245814d,bottom: 0.23384355161914683d,left: 0.0019499803512481595d),
new NpgsqlTypes.NpgsqlBox(top: 0.8222396747752484d,right: 0.6667512747327712d,bottom: 0.32237532920110823d,left: 0.6372135247045235d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7751066291874342d,right: 0.7814523907950981d,bottom: 0.22795420251758214d,left: 0.18751288667819666d),
new NpgsqlTypes.NpgsqlBox(top: 0.588301805966864d,right: 0.645946207344258d,bottom: 0.5610694076049012d,left: 0.1199359415788378d),
new NpgsqlTypes.NpgsqlBox(top: 0.8270647924392673d,right: 0.3236660954108278d,bottom: 0.1570261417979708d,left: 0.10362611902326602d),
new NpgsqlTypes.NpgsqlBox(top: 0.7708430153443842d,right: 0.6967129081972973d,bottom: 0.20345275261187323d,left: 0.6568648344739431d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8120863556084551d,right: 0.8871658365291202d,bottom: 0.447599836917427d,left: 0.019342076383616402d),
new NpgsqlTypes.NpgsqlBox(top: 0.8997862448504129d,right: 0.8966173510159705d,bottom: 0.06298343238275372d,left: 0.3137742300621885d),
new NpgsqlTypes.NpgsqlBox(top: 0.9081634996525485d,right: 0.8718550446529018d,bottom: 0.19596766468725146d,left: 0.8049754052656546d),
new NpgsqlTypes.NpgsqlBox(top: 0.7560056049174085d,right: 0.33166478243837316d,bottom: 0.08515044318248288d,left: 0.004096086570215096d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9240671751378372d,right: 0.5205025483579772d,bottom: 0.5892247071627563d,left: 0.43682324998659006d),
new NpgsqlTypes.NpgsqlBox(top: 0.5236194882143099d,right: 0.9888811334111577d,bottom: 0.020796858622168513d,left: 0.7704506220826253d),
new NpgsqlTypes.NpgsqlBox(top: 0.6958219665630963d,right: 0.7987776285097509d,bottom: 0.6460504475947725d,left: 0.22007884974152636d),
new NpgsqlTypes.NpgsqlBox(top: 0.5897870650014342d,right: 0.5916515397596663d,bottom: 0.20671650039445377d,left: 0.5913187195479747d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.20147819741679662d,right: 0.9576526056535503d,bottom: 0.12892038391406346d,left: 0.22585469933866575d),
new NpgsqlTypes.NpgsqlBox(top: 0.753482717836933d,right: 0.5653716594098166d,bottom: 0.6686111515246564d,left: 0.4216574363259401d),
new NpgsqlTypes.NpgsqlBox(top: 0.7321324655424798d,right: 0.7090483528620275d,bottom: 0.7320492033517265d,left: 0.5589025274080995d),
new NpgsqlTypes.NpgsqlBox(top: 0.6105524638321108d,right: 0.983395089978222d,bottom: 0.07343986793233248d,left: 0.15888255294776876d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 173,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6745783835680819d,right: 0.9176059245728547d,bottom: 0.5331426167877532d,left: 0.28389886169697376d),
new NpgsqlTypes.NpgsqlBox(top: 0.3478045295022294d,right: 0.4636054311988417d,bottom: 0.11597124006846515d,left: 0.35648769728446494d),
new NpgsqlTypes.NpgsqlBox(top: 0.4414404050544882d,right: 0.8042857592916165d,bottom: 0.2830145845358265d,left: 0.25463667433122705d),
new NpgsqlTypes.NpgsqlBox(top: 0.3042624816313516d,right: 0.9565490469745538d,bottom: 0.2107456201851151d,left: 0.21453528486324858d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9740319623056553d,right: 0.8805829210676516d,bottom: 0.044604021148174855d,left: 0.626216774663642d),
new NpgsqlTypes.NpgsqlBox(top: 0.7450892834842572d,right: 0.9294923201398416d,bottom: 0.6779396250614836d,left: 0.34955054519287976d),
new NpgsqlTypes.NpgsqlBox(top: 0.9954162007185464d,right: 0.3169624161578457d,bottom: 0.6532781985253762d,left: 0.30502582988299665d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.847919714931708d,right: 0.6790578388914515d,bottom: 0.2126919045089386d,left: 0.028878232769334322d),
new NpgsqlTypes.NpgsqlBox(top: 0.4365963090132019d,right: 0.7413983810264919d,bottom: 0.3214293513425759d,left: 0.6202927688432205d),
new NpgsqlTypes.NpgsqlBox(top: 0.41466214529067835d,right: 0.9222508858953591d,bottom: 0.21947390520195575d,left: 0.24378908641583197d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.42182465644251044d,right: 0.5780054761744343d,bottom: 0.1697440022019734d,left: 0.1712300562048661d),
new NpgsqlTypes.NpgsqlBox(top: 0.9299135461962224d,right: 0.5198765436197554d,bottom: 0.3384901449734592d,left: 0.36332656859471757d),
new NpgsqlTypes.NpgsqlBox(top: 0.8928675384597818d,right: 0.7503798745498628d,bottom: 0.5317736190858864d,left: 0.6904750353799637d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9986160202353452d,right: 0.2605376571548853d,bottom: 0.10473190384619513d,left: 0.22882575896425905d),
new NpgsqlTypes.NpgsqlBox(top: 0.6316427058316851d,right: 0.8479331845269482d,bottom: 0.20454314199729806d,left: 0.6832869616317432d),
new NpgsqlTypes.NpgsqlBox(top: 0.7486118120072387d,right: 0.6787472252142933d,bottom: 0.16022530065311313d,left: 0.26746304535683896d),
new NpgsqlTypes.NpgsqlBox(top: 0.8099406612613783d,right: 0.8707733113959794d,bottom: 0.42421744665148664d,left: 0.2653619753997476d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
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

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7405838661287384d,right: 0.8004887748030087d,bottom: 0.03563033404571614d,left: 0.28191751959803146d),
new NpgsqlTypes.NpgsqlBox(top: 0.6807080699489335d,right: 0.4572402009027524d,bottom: 0.07386282735982552d,left: 0.3149195210471546d),
new NpgsqlTypes.NpgsqlBox(top: 0.6970015962246833d,right: 0.3264724178055275d,bottom: 0.384196466014213d,left: 0.224858774956196d),
new NpgsqlTypes.NpgsqlBox(top: 0.3719442477903203d,right: 0.5175562653608587d,bottom: 0.29142732063103427d,left: 0.3091651881976073d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.47027454658548307d,right: 0.8360418540074268d,bottom: 0.10107053592976456d,left: 0.3939174510746857d),
new NpgsqlTypes.NpgsqlBox(top: 0.2512162573453208d,right: 0.8170860569314792d,bottom: 0.16914421236008903d,left: 0.46919566092037956d),
new NpgsqlTypes.NpgsqlBox(top: 0.9918119077778494d,right: 0.40213025929228097d,bottom: 0.8823832159202025d,left: 0.2392021888020861d),
new NpgsqlTypes.NpgsqlBox(top: 0.2620246646080352d,right: 0.331865238649965d,bottom: 0.22742796885323746d,left: 0.12491631844769424d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.365673621763245d,right: 0.8121613186024967d,bottom: 0.18104327594489933d,left: 0.038902305695876827d),
new NpgsqlTypes.NpgsqlBox(top: 0.796982256588004d,right: 0.9489241525769728d,bottom: 0.10289525209856976d,left: 0.24144715251004034d),
new NpgsqlTypes.NpgsqlBox(top: 0.7234294574880445d,right: 0.23436001899711223d,bottom: 0.5427860241043463d,left: 0.056220855139611614d),
}));
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 101, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 96, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 61, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 93, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 120, query1, 157, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 61, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 67, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 87, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 88, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 84, 4))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[29], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[30], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 157);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[34], false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MI),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray1M),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1m m
LEFT JOIN public.binary_npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI), typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                await ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

