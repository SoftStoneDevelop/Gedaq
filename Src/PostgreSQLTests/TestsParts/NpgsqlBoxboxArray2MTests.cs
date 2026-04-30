

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
    internal partial interface INpgsqlBoxListboxArray
    {
    }
    
    internal partial class NpgsqlBoxListboxArray : INpgsqlBoxListboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray2M[] _testData = new NpgsqlBoxboxArray2M[]
        {
            new NpgsqlBoxboxArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8541565977792814d,right: 0.6788099411401807d,bottom: 0.6964942478773564d,left: 0.33605057924092274d),

new NpgsqlTypes.NpgsqlBox(top: 0.9055329542348199d,right: 0.5271044330674632d,bottom: 0.8933877541650078d,left: 0.039868604224765125d),

new NpgsqlTypes.NpgsqlBox(top: 0.9631316245833298d,right: 0.9016568309946192d,bottom: 0.21390518044211604d,left: 0.31399654982803826d),

new NpgsqlTypes.NpgsqlBox(top: 0.6613697395349017d,right: 0.9746949173005504d,bottom: 0.6249783238650714d,left: 0.3793364720814697d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8989835595800978d,right: 0.47797923710236334d,bottom: 0.889640691616949d,left: 0.2738228681976368d),

new NpgsqlTypes.NpgsqlBox(top: 0.3432320563608615d,right: 0.2638479631925419d,bottom: 0.2212893333558037d,left: 0.10862698583777897d),

new NpgsqlTypes.NpgsqlBox(top: 0.8012700545391392d,right: 0.544492427933641d,bottom: 0.4248616408814603d,left: 0.3656609852696673d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4872212785202925d,right: 0.677274393724643d,bottom: 0.4151737590973982d,left: 0.3854023682594633d),

new NpgsqlTypes.NpgsqlBox(top: 0.4890024154930642d,right: 0.20387890007347464d,bottom: 0.1795046303003388d,left: 0.15010792558425579d),

new NpgsqlTypes.NpgsqlBox(top: 0.8574751340117063d,right: 0.23828954744922248d,bottom: 0.4870270201161433d,left: 0.016362785899226462d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5601678117190497d,right: 0.6962835728105806d,bottom: 0.5482989454358209d,left: 0.2970538753123323d),

new NpgsqlTypes.NpgsqlBox(top: 0.8053975343778915d,right: 0.4346634796380838d,bottom: 0.7697978602500042d,left: 0.016295616674367408d),

new NpgsqlTypes.NpgsqlBox(top: 0.557379783782779d,right: 0.9994971099734031d,bottom: 0.21952700453723462d,left: 0.3417170580081781d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7889645763226341d,right: 0.2715993083335785d,bottom: 0.6022233438082873d,left: 0.12449951732187903d),

new NpgsqlTypes.NpgsqlBox(top: 0.8572460007637162d,right: 0.8399430528697058d,bottom: 0.4296625052249091d,left: 0.4656712562884713d),

new NpgsqlTypes.NpgsqlBox(top: 0.6870022224129383d,right: 0.8287870762022129d,bottom: 0.5488267442579583d,left: 0.08109385199530816d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.775685548317951d,right: 0.8097794694853747d,bottom: 0.2542570612042686d,left: 0.19283567795359402d),

new NpgsqlTypes.NpgsqlBox(top: 0.6153785321853624d,right: 0.5180852445712014d,bottom: 0.21425677985340708d,left: 0.32573349014609365d),

new NpgsqlTypes.NpgsqlBox(top: 0.46772281567682417d,right: 0.9843327922923396d,bottom: 0.04350527939335669d,left: 0.628480303087731d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4648380579874809d,right: 0.8469987786323704d,bottom: 0.3374142926170406d,left: 0.7257763307234024d),

new NpgsqlTypes.NpgsqlBox(top: 0.9035767421965755d,right: 0.5737375326678905d,bottom: 0.08194966799967518d,left: 0.08919021073162559d),

new NpgsqlTypes.NpgsqlBox(top: 0.48827967269580563d,right: 0.9824733686796023d,bottom: 0.4006302397889113d,left: 0.9109385823413807d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9504646840701697d,right: 0.8913501703728507d,bottom: 0.1322571953529914d,left: 0.020346462032178714d),

new NpgsqlTypes.NpgsqlBox(top: 0.5541404144891964d,right: 0.850697803533587d,bottom: 0.19796568203672782d,left: 0.26444759267296924d),

new NpgsqlTypes.NpgsqlBox(top: 0.8862157805917952d,right: 0.595887904278742d,bottom: 0.1307653731696241d,left: 0.4650977392945643d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6905483498737964d,right: 0.5307614691675097d,bottom: 0.4508740411022686d,left: 0.06760253457893084d),

new NpgsqlTypes.NpgsqlBox(top: 0.2150977902770459d,right: 0.35690119195809167d,bottom: 0.05413572140443779d,left: 0.12674496930620016d),

new NpgsqlTypes.NpgsqlBox(top: 0.9347610572614115d,right: 0.22532944111246234d,bottom: 0.8743835626739074d,left: 0.020396188667131332d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3355893213451461d,right: 0.3556666134809442d,bottom: 0.08873332600628614d,left: 0.15357947539688654d),

new NpgsqlTypes.NpgsqlBox(top: 0.7680366185831756d,right: 0.5950133022342711d,bottom: 0.16224092213421726d,left: 0.5032819043888553d),

new NpgsqlTypes.NpgsqlBox(top: 0.45024704840102014d,right: 0.8733942589699346d,bottom: 0.10503277696905622d,left: 0.3271781508741759d),

new NpgsqlTypes.NpgsqlBox(top: 0.72175421891679d,right: 0.8904252992769569d,bottom: 0.06737300010251634d,left: 0.027090122424510144d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4464065610096244d,right: 0.1338777273544629d,bottom: 0.2729054201121409d,left: 2.68934751354033E-05d),

new NpgsqlTypes.NpgsqlBox(top: 0.626993889750621d,right: 0.669138927914545d,bottom: 0.2618292153444025d,left: 0.48623269341036834d),

new NpgsqlTypes.NpgsqlBox(top: 0.7148955772768724d,right: 0.27892903883568554d,bottom: 0.147481892471374d,left: 0.2619477600864787d),

new NpgsqlTypes.NpgsqlBox(top: 0.14360320284073513d,right: 0.8218448873172349d,bottom: 0.09775923904211081d,left: 0.14264605868950408d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.11073780865648575d,right: 0.9633493591312715d,bottom: 0.014970691022854754d,left: 0.06476126832306783d),

new NpgsqlTypes.NpgsqlBox(top: 0.7746908653743901d,right: 0.3454716519134424d,bottom: 0.1905719443444739d,left: 0.10593042343026993d),

new NpgsqlTypes.NpgsqlBox(top: 0.7604492817682627d,right: 0.07294534081508519d,bottom: 0.5783380316772874d,left: 0.05812772245817843d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7907430089028646d,right: 0.8782876229075375d,bottom: 0.2792699641615233d,left: 0.4162079130997298d),

new NpgsqlTypes.NpgsqlBox(top: 0.34114866732705684d,right: 0.5557490727698603d,bottom: 0.07552659145650142d,left: 0.5091294858303078d),

new NpgsqlTypes.NpgsqlBox(top: 0.4104138826258362d,right: 0.9624819695142155d,bottom: 0.05833545413361152d,left: 0.1590045615410679d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4959166918571031d,right: 0.909844436356623d,bottom: 0.17528676184783853d,left: 0.2901509547209352d),

new NpgsqlTypes.NpgsqlBox(top: 0.7923154553272214d,right: 0.8677130135392691d,bottom: 0.24611920802074416d,left: 0.8280766329131773d),

new NpgsqlTypes.NpgsqlBox(top: 0.3296182385417121d,right: 0.5661525491412923d,bottom: 0.18510391872954457d,left: 0.02179354604781303d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7596458125323271d,right: 0.998522634107803d,bottom: 0.4609064069897779d,left: 0.2863938825439879d),

new NpgsqlTypes.NpgsqlBox(top: 0.6566430643928586d,right: 0.4086922811545064d,bottom: 0.5085677845250606d,left: 0.08287305191375083d),

new NpgsqlTypes.NpgsqlBox(top: 0.6017131391937692d,right: 0.8205897533992584d,bottom: 0.5936603035968884d,left: 0.6949027466163239d),

new NpgsqlTypes.NpgsqlBox(top: 0.3411930244327528d,right: 0.8739235607017585d,bottom: 0.10393333437999497d,left: 0.45476723299546196d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6102264356461575d,right: 0.8407113930681621d,bottom: 0.44351202664499756d,left: 0.06882818887931563d),

new NpgsqlTypes.NpgsqlBox(top: 0.9403983687641922d,right: 0.3215106549595248d,bottom: 0.7930554068562892d,left: 0.050301417030284123d),

new NpgsqlTypes.NpgsqlBox(top: 0.4804820843430815d,right: 0.7335305258325029d,bottom: 0.35358624712386966d,left: 0.09156908789454132d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8301522027062023d,right: 0.6477489003522946d,bottom: 0.4455036039377338d,left: 0.1426188399901106d),

new NpgsqlTypes.NpgsqlBox(top: 0.9392933321941114d,right: 0.23195885069601685d,bottom: 0.07980533013356794d,left: 0.21590623149252708d),

new NpgsqlTypes.NpgsqlBox(top: 0.5494975362995369d,right: 0.974722931207184d,bottom: 0.06496799377871365d,left: 0.21538502110584445d),

new NpgsqlTypes.NpgsqlBox(top: 0.772097146901033d,right: 0.8707041270906729d,bottom: 0.009298669420677919d,left: 0.0028747906670640866d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5841590602835911d,right: 0.6293927253351753d,bottom: 0.18620942027070753d,left: 0.2656352333259815d),

new NpgsqlTypes.NpgsqlBox(top: 0.7307094380458893d,right: 0.8605860276661291d,bottom: 0.5745886672887855d,left: 0.33931436642361157d),

new NpgsqlTypes.NpgsqlBox(top: 0.8297096444142226d,right: 0.4895262816369481d,bottom: 0.23031318338823625d,left: 0.029949904074084155d),

new NpgsqlTypes.NpgsqlBox(top: 0.9353138497550149d,right: 0.8761309803881503d,bottom: 0.25210419264434303d,left: 0.44330741081510194d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8231196367914208d,right: 0.6195237634434884d,bottom: 0.01179101308018038d,left: 0.3674808557383492d),

new NpgsqlTypes.NpgsqlBox(top: 0.9967231256910845d,right: 0.46347824415778804d,bottom: 0.7835604991950779d,left: 0.08214520837229777d),

new NpgsqlTypes.NpgsqlBox(top: 0.9517791100263812d,right: 0.6597080411804627d,bottom: 0.7550524167369969d,left: 0.3574099088261784d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6525135684023877d,right: 0.8941677153301583d,bottom: 0.17311411277611488d,left: 0.8541351965640479d),

new NpgsqlTypes.NpgsqlBox(top: 0.6373339739124966d,right: 0.31904071990007166d,bottom: 0.23137301837730329d,left: 0.20903878608245752d),

new NpgsqlTypes.NpgsqlBox(top: 0.638982560202111d,right: 0.3062115830815726d,bottom: 0.18841676237013705d,left: 0.15788107484444036d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6488324981715079d,right: 0.7272851706934537d,bottom: 0.03954138970880683d,left: 0.02666820985343299d),

new NpgsqlTypes.NpgsqlBox(top: 0.6778915133857277d,right: 0.7497977209446411d,bottom: 0.11617436330070141d,left: 0.2860104493157848d),

new NpgsqlTypes.NpgsqlBox(top: 0.4004433228803532d,right: 0.5104743510779568d,bottom: 0.2654118146703254d,left: 0.13683465542112205d),

new NpgsqlTypes.NpgsqlBox(top: 0.8726379162475231d,right: 0.4982837146212262d,bottom: 0.37072798613898983d,left: 0.009789703169964303d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.602897456890907d,right: 0.1662890436278951d,bottom: 0.10626912534852928d,left: 0.060832308264373025d),

new NpgsqlTypes.NpgsqlBox(top: 0.7425047460628886d,right: 0.7287662530071046d,bottom: 0.5603432254608721d,left: 0.09096693875239603d),

new NpgsqlTypes.NpgsqlBox(top: 0.99459328375403d,right: 0.6017625516422772d,bottom: 0.1256850033872624d,left: 0.044586369889120125d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4959817750326009d,right: 0.8459128690703764d,bottom: 0.02964448299959599d,left: 0.3453177223557692d),

new NpgsqlTypes.NpgsqlBox(top: 0.3851552760375342d,right: 0.8167546770977715d,bottom: 0.19320732745622937d,left: 0.48085054340723665d),

new NpgsqlTypes.NpgsqlBox(top: 0.3198819657323795d,right: 0.8416281748108765d,bottom: 0.026286637313027383d,left: 0.140126825306086d),

new NpgsqlTypes.NpgsqlBox(top: 0.6810065828438148d,right: 0.6613126585679419d,bottom: 0.35901135402233075d,left: 0.33326699006433746d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.27295234596525964d,right: 0.540382403316904d,bottom: 0.0096199070974754d,left: 0.4265316486184041d),

new NpgsqlTypes.NpgsqlBox(top: 0.23260416667052874d,right: 0.4882739948284547d,bottom: 0.21127121109019642d,left: 0.30828998917920303d),

new NpgsqlTypes.NpgsqlBox(top: 0.4660288452290441d,right: 0.6540566092600771d,bottom: 0.40074188883087836d,left: 0.1425795870485732d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8211548316296217d,right: 0.5549291626694542d,bottom: 0.6140145410284412d,left: 0.38810355028833543d),

new NpgsqlTypes.NpgsqlBox(top: 0.901644383815355d,right: 0.9406015174173482d,bottom: 0.37001548657904404d,left: 0.3146063774508894d),

new NpgsqlTypes.NpgsqlBox(top: 0.8671921545034436d,right: 0.5350473542848083d,bottom: 0.7824875376811169d,left: 0.1521135925594408d),

new NpgsqlTypes.NpgsqlBox(top: 0.8964550574191851d,right: 0.37865833468673504d,bottom: 0.29093387451352626d,left: 0.33741192291652367d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5639944346507119d,right: 0.2013351564692476d,bottom: 0.5064943771486685d,left: 0.12499772476641735d),

new NpgsqlTypes.NpgsqlBox(top: 0.3348426908059866d,right: 0.760256180645493d,bottom: 0.15896040864504324d,left: 0.2806217455798069d),

new NpgsqlTypes.NpgsqlBox(top: 0.7816267438732859d,right: 0.9115315343109286d,bottom: 0.5523780461355883d,left: 0.7558994799515386d),

new NpgsqlTypes.NpgsqlBox(top: 0.532656300032004d,right: 0.5784555682722002d,bottom: 0.2354237725317062d,left: 0.04136370091861952d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7950450541249114d,right: 0.5197369328135758d,bottom: 0.43313474960045073d,left: 0.21527825443600968d),

new NpgsqlTypes.NpgsqlBox(top: 0.5022767158214454d,right: 0.5490987810547175d,bottom: 0.2850292823799955d,left: 0.4815801736150621d),

new NpgsqlTypes.NpgsqlBox(top: 0.6965795121068135d,right: 0.9117746984185542d,bottom: 0.21043437478880433d,left: 0.4276262372129007d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9723893549131628d,right: 0.5440291468874353d,bottom: 0.4943658025933151d,left: 0.15630542081302412d),

new NpgsqlTypes.NpgsqlBox(top: 0.9819378238961718d,right: 0.9419837024628737d,bottom: 0.6220733170189011d,left: 0.43648721322241024d),

new NpgsqlTypes.NpgsqlBox(top: 0.8839111439359865d,right: 0.3174417239217946d,bottom: 0.6295205958056805d,left: 0.2637453720455285d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6600389670295109d,right: 0.34255040742873233d,bottom: 0.20492244040382301d,left: 0.2800447137084606d),

new NpgsqlTypes.NpgsqlBox(top: 0.9255715825850385d,right: 0.4181186037767898d,bottom: 0.5877505602675063d,left: 0.3921433937350567d),

new NpgsqlTypes.NpgsqlBox(top: 0.39426508617195954d,right: 0.32303785322815726d,bottom: 0.2943597385747264d,left: 0.039626274818177154d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5946447259247892d,right: 0.998297146888212d,bottom: 0.5035592104691463d,left: 0.06798430835938885d),

new NpgsqlTypes.NpgsqlBox(top: 0.4247642491714211d,right: 0.9134144988556652d,bottom: 0.04308603102055586d,left: 0.7502059177787749d),

new NpgsqlTypes.NpgsqlBox(top: 0.6549841797207424d,right: 0.6023881220160326d,bottom: 0.3481674746796515d,left: 0.3309246778096755d),

new NpgsqlTypes.NpgsqlBox(top: 0.7627153526354666d,right: 0.1985148650682108d,bottom: 0.33216444234919096d,left: 0.03846310358024352d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7068597070200481d,right: 0.8966256752964132d,bottom: 0.061525425286255486d,left: 0.26028864282884634d),

new NpgsqlTypes.NpgsqlBox(top: 0.7269457497159253d,right: 0.8974387385542765d,bottom: 0.18576925574186698d,left: 0.7758568369587332d),

new NpgsqlTypes.NpgsqlBox(top: 0.7240229006546275d,right: 0.938813199841807d,bottom: 0.02414662158539138d,left: 0.7518843630677918d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8260812105382995d,right: 0.996962041208604d,bottom: 0.3649309348029348d,left: 0.33033147942510155d),

new NpgsqlTypes.NpgsqlBox(top: 0.8513178455894844d,right: 0.845604854944153d,bottom: 0.6477081612943973d,left: 0.7577638087686044d),

new NpgsqlTypes.NpgsqlBox(top: 0.9820764820735388d,right: 0.2999865324855173d,bottom: 0.6446461577019256d,left: 0.2997597804743608d),

new NpgsqlTypes.NpgsqlBox(top: 0.9173880693930465d,right: 0.9631454698759045d,bottom: 0.7034596646605517d,left: 0.1276256623946873d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.46498769892044634d,right: 0.7143592950785127d,bottom: 0.4264634097803527d,left: 0.36100855239744356d),

new NpgsqlTypes.NpgsqlBox(top: 0.7254070328266684d,right: 0.4363588534695153d,bottom: 0.7110747183621501d,left: 0.14477178589186113d),

new NpgsqlTypes.NpgsqlBox(top: 0.7565206061017479d,right: 0.36907401862328937d,bottom: 0.1992389387337974d,left: 0.31945871916660906d),

new NpgsqlTypes.NpgsqlBox(top: 0.41979890799989394d,right: 0.5657486417291251d,bottom: 0.2791794557631969d,left: 0.14571990430512038d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8603192141959224d,right: 0.8530082755590727d,bottom: 0.6621044499594395d,left: 0.5871912663257105d),

new NpgsqlTypes.NpgsqlBox(top: 0.27115066422401257d,right: 0.9892352922485055d,bottom: 0.036332026597898026d,left: 0.5625268527014909d),

new NpgsqlTypes.NpgsqlBox(top: 0.8656299033220813d,right: 0.718852173402294d,bottom: 0.40437849882838584d,left: 0.1535049800909749d),

new NpgsqlTypes.NpgsqlBox(top: 0.902815768769275d,right: 0.9299676414055267d,bottom: 0.6685128477974752d,left: 0.44104068444233424d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6979766792055364d,right: 0.5923708721883717d,bottom: 0.34229335904712177d,left: 0.25947205449227717d),

new NpgsqlTypes.NpgsqlBox(top: 0.6021898903572355d,right: 0.13368228973508578d,bottom: 0.4095879720081923d,left: 0.009153529872857225d),

new NpgsqlTypes.NpgsqlBox(top: 0.8254558989467337d,right: 0.14775054966219103d,bottom: 0.4293634849653064d,left: 0.08004416157527516d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3595288672505693d,right: 0.7405003944165905d,bottom: 0.2654521594364563d,left: 0.5696513351476783d),

new NpgsqlTypes.NpgsqlBox(top: 0.3886634510650152d,right: 0.6587603201537023d,bottom: 0.06379380278907387d,left: 0.47452230746200985d),

new NpgsqlTypes.NpgsqlBox(top: 0.8505879773702272d,right: 0.837337262871203d,bottom: 0.4321983348608056d,left: 0.3155380380753806d),

new NpgsqlTypes.NpgsqlBox(top: 0.5001233276263236d,right: 0.6470911745585117d,bottom: 0.08401674993036057d,left: 0.5822901365467515d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9497850020187188d,right: 0.7216492558577068d,bottom: 0.8601203587429496d,left: 0.6329816693835125d),

new NpgsqlTypes.NpgsqlBox(top: 0.8516455723056319d,right: 0.9912313011127396d,bottom: 0.0922177262716517d,left: 0.843595869125039d),

new NpgsqlTypes.NpgsqlBox(top: 0.7715660910115455d,right: 0.2921704569542559d,bottom: 0.6588343918755698d,left: 0.2521427164555232d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3095843983356311d,right: 0.2565397858314947d,bottom: 0.17199699089586917d,left: 0.018736016542956202d),

new NpgsqlTypes.NpgsqlBox(top: 0.7746333346592584d,right: 0.3139221959291152d,bottom: 0.4438656064860158d,left: 0.09982537248813494d),

new NpgsqlTypes.NpgsqlBox(top: 0.47555908732739893d,right: 0.20709317059578314d,bottom: 0.023300311189476397d,left: 0.017981035254899025d),

new NpgsqlTypes.NpgsqlBox(top: 0.7192952451298796d,right: 0.3964988215930425d,bottom: 0.051637619500948584d,left: 0.19655707292025637d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9062364242274458d,right: 0.6152819027928444d,bottom: 0.7071489043137082d,left: 0.10324111182939266d),

new NpgsqlTypes.NpgsqlBox(top: 0.5824389804996422d,right: 0.03286575363734101d,bottom: 0.3365177924940287d,left: 0.01728554895627943d),

new NpgsqlTypes.NpgsqlBox(top: 0.79494534576213d,right: 0.5077520808868894d,bottom: 0.39929336571034035d,left: 0.3369966703478404d),

new NpgsqlTypes.NpgsqlBox(top: 0.6571981803243602d,right: 0.3669797603202338d,bottom: 0.1255372783894716d,left: 0.32793619195746604d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7205786992057213d,right: 0.38932150119317566d,bottom: 0.4951679838408761d,left: 0.05587723066076966d),

new NpgsqlTypes.NpgsqlBox(top: 0.8858658295057806d,right: 0.7551880855880063d,bottom: 0.41073447297948407d,left: 0.34108591808839483d),

new NpgsqlTypes.NpgsqlBox(top: 0.8811413630290255d,right: 0.5484110418303055d,bottom: 0.37198240205697275d,left: 0.5076429116885887d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9996239193797816d,right: 0.30864295463836533d,bottom: 0.92377748576943d,left: 0.29296713153972875d),

new NpgsqlTypes.NpgsqlBox(top: 0.6499653283717809d,right: 0.6958149187551316d,bottom: 0.2110153245203944d,left: 0.015175885725298155d),

new NpgsqlTypes.NpgsqlBox(top: 0.9886039269929497d,right: 0.8494165442610674d,bottom: 0.07845390996098645d,left: 0.4257233032202178d),

new NpgsqlTypes.NpgsqlBox(top: 0.5100877649490547d,right: 0.6917518468708601d,bottom: 0.22756782078457005d,left: 0.23206608825496322d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6293390680264814d,right: 0.6809230789835639d,bottom: 0.44834227547182204d,left: 0.5995638553833518d),

new NpgsqlTypes.NpgsqlBox(top: 0.7765433494360304d,right: 0.8649404720668084d,bottom: 0.5039010921084961d,left: 0.32711724806725906d),

new NpgsqlTypes.NpgsqlBox(top: 0.8402181341412359d,right: 0.8366395071675563d,bottom: 0.4980008923355458d,left: 0.4955636434365397d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8976405605886191d,right: 0.34827085567411387d,bottom: 0.09635085736584648d,left: 0.20498935138307817d),

new NpgsqlTypes.NpgsqlBox(top: 0.894859560671071d,right: 0.8472425546728483d,bottom: 0.05741036897493779d,left: 0.7507738860099296d),

new NpgsqlTypes.NpgsqlBox(top: 0.40538984894415353d,right: 0.7981643257182336d,bottom: 0.23014587483441873d,left: 0.32832148925105686d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6308716883249932d,right: 0.904841699212291d,bottom: 0.5100628159778596d,left: 0.6003775106073594d),

new NpgsqlTypes.NpgsqlBox(top: 0.7634283996138812d,right: 0.8942558085718791d,bottom: 0.0812860891322863d,left: 0.44728912218742956d),

new NpgsqlTypes.NpgsqlBox(top: 0.8394881203762264d,right: 0.7895185362417751d,bottom: 0.038550087658485555d,left: 0.5267381990249546d),

new NpgsqlTypes.NpgsqlBox(top: 0.7414573409713476d,right: 0.962094886517001d,bottom: 0.17605782353536126d,left: 0.7627686590624894d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8526001863554639d,right: 0.9000788671693326d,bottom: 0.19946236485525926d,left: 0.13252338369613137d),

new NpgsqlTypes.NpgsqlBox(top: 0.5338409014925896d,right: 0.6696205273460674d,bottom: 0.0312638194369963d,left: 0.021948721881501987d),

new NpgsqlTypes.NpgsqlBox(top: 0.27666600481835957d,right: 0.9908713490633904d,bottom: 0.11676895902304818d,left: 0.13283318993646065d),

new NpgsqlTypes.NpgsqlBox(top: 0.9403420977044632d,right: 0.43465376293549474d,bottom: 0.5804727057438984d,left: 0.02055095094474868d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8060301115487853d,right: 0.7562587321649915d,bottom: 0.1921992736783411d,left: 0.3290300733162378d),

new NpgsqlTypes.NpgsqlBox(top: 0.24465429957376983d,right: 0.8543153913989072d,bottom: 0.22693170827187525d,left: 0.12803879682824693d),

new NpgsqlTypes.NpgsqlBox(top: 0.39284610780432905d,right: 0.22650369447560703d,bottom: 0.20761165028473738d,left: 0.0030447152957404633d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8385706266174996d,right: 0.27162647158082165d,bottom: 0.4414551650080395d,left: 0.17658277471767103d),

new NpgsqlTypes.NpgsqlBox(top: 0.9288813031184342d,right: 0.6325736986466076d,bottom: 0.1863448907976888d,left: 0.28035327421224654d),

new NpgsqlTypes.NpgsqlBox(top: 0.9166112870742501d,right: 0.4567381293864847d,bottom: 0.2052445685203913d,left: 0.044289940321692756d),

new NpgsqlTypes.NpgsqlBox(top: 0.9517688572854146d,right: 0.47044668374596055d,bottom: 0.021603640704592197d,left: 0.42321924193997496d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7613210733065828d,right: 0.7590899710012292d,bottom: 0.108975168501252d,left: 0.4557552669246925d),

new NpgsqlTypes.NpgsqlBox(top: 0.5254682322097227d,right: 0.09789802010465853d,bottom: 0.039416713089076905d,left: 0.020396998867531213d),

new NpgsqlTypes.NpgsqlBox(top: 0.29154811283058213d,right: 0.9701385071036702d,bottom: 0.08029017317039766d,left: 0.6877229301310364d),

new NpgsqlTypes.NpgsqlBox(top: 0.48138471746775824d,right: 0.8502798138305364d,bottom: 0.4008659599632779d,left: 0.495763773807509d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6516976302745542d,right: 0.9574120350365182d,bottom: 0.3581552866200878d,left: 0.2474653839686083d),

new NpgsqlTypes.NpgsqlBox(top: 0.5312132853431168d,right: 0.7746533754085483d,bottom: 0.09238565659603548d,left: 0.2520180419596062d),

new NpgsqlTypes.NpgsqlBox(top: 0.9592278665514572d,right: 0.8643483415674954d,bottom: 0.20682434811333217d,left: 0.7436276908693146d),

new NpgsqlTypes.NpgsqlBox(top: 0.5132016570410289d,right: 0.9768394810854676d,bottom: 0.08147536405265421d,left: 0.6987421231020684d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9667889136023479d,right: 0.33835966840456544d,bottom: 0.35346803096920554d,left: 0.0691786427827431d),

new NpgsqlTypes.NpgsqlBox(top: 0.7255832185163195d,right: 0.7695684038934998d,bottom: 0.5297775977499098d,left: 0.47166655692655235d),

new NpgsqlTypes.NpgsqlBox(top: 0.5428167010590629d,right: 0.33787964912563817d,bottom: 0.18316887445068408d,left: 0.013040885176603956d),

new NpgsqlTypes.NpgsqlBox(top: 0.33675076613356913d,right: 0.9023731494968213d,bottom: 0.2753454229317853d,left: 0.7273055412533089d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.940497625061633d,right: 0.9648748401158034d,bottom: 0.14874543013296349d,left: 0.33846496653912905d),

new NpgsqlTypes.NpgsqlBox(top: 0.4842695166014631d,right: 0.9997887923735719d,bottom: 0.10609819348352412d,left: 0.7993437304796728d),

new NpgsqlTypes.NpgsqlBox(top: 0.9152464710397975d,right: 0.9420738849456519d,bottom: 0.10322411825837507d,left: 0.5841315545798164d),

new NpgsqlTypes.NpgsqlBox(top: 0.47777567093702344d,right: 0.9407439574277505d,bottom: 0.47146050347576784d,left: 0.44964028597731664d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9559168865639379d,right: 0.9688252980243213d,bottom: 0.5939755512392664d,left: 0.18259731774814303d),

new NpgsqlTypes.NpgsqlBox(top: 0.48034182823334826d,right: 0.47783121651351357d,bottom: 0.2494285589473011d,left: 0.11170737775027761d),

new NpgsqlTypes.NpgsqlBox(top: 0.33469153119438877d,right: 0.22212432928518933d,bottom: 0.03914887973856318d,left: 0.053504865350611275d),

new NpgsqlTypes.NpgsqlBox(top: 0.5953544246566211d,right: 0.7181999447518366d,bottom: 0.4084178297120955d,left: 0.512421187826681d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9738150716199561d,right: 0.7388065480607509d,bottom: 0.07626584089975608d,left: 0.2084554658161355d),

new NpgsqlTypes.NpgsqlBox(top: 0.8828112394101904d,right: 0.48797514490567506d,bottom: 0.0257521952772074d,left: 0.1317987341862682d),

new NpgsqlTypes.NpgsqlBox(top: 0.8315659877755911d,right: 0.8793112135226971d,bottom: 0.755592117040695d,left: 0.6621014519795259d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6364830265383479d,right: 0.9708549495055896d,bottom: 0.31906139781981824d,left: 0.6488512122057633d),

new NpgsqlTypes.NpgsqlBox(top: 0.5502004076288003d,right: 0.9875319889346672d,bottom: 0.12963601784275613d,left: 0.8871000185605893d),

new NpgsqlTypes.NpgsqlBox(top: 0.329886104548912d,right: 0.6622650204930561d,bottom: 0.029666452175429403d,left: 0.29440939495576934d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.37530146083036175d,right: 0.7753613826311765d,bottom: 0.14131528356446477d,left: 0.6552424568253986d),

new NpgsqlTypes.NpgsqlBox(top: 0.8498778504522367d,right: 0.9023348948743781d,bottom: 0.10471835663554041d,left: 0.6771452701023039d),

new NpgsqlTypes.NpgsqlBox(top: 0.4742971892991086d,right: 0.6496886981629257d,bottom: 0.3635612768436458d,left: 0.39205092483626724d),

new NpgsqlTypes.NpgsqlBox(top: 0.9598297767454583d,right: 0.7262613338848997d,bottom: 0.7062844423604216d,left: 0.4418886206851713d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7088155294848403d,right: 0.9150737722677504d,bottom: 0.5713692686395051d,left: 0.49282618498224473d),

new NpgsqlTypes.NpgsqlBox(top: 0.6676160142034194d,right: 0.7027035464846766d,bottom: 0.588341444059596d,left: 0.5614868307271758d),

new NpgsqlTypes.NpgsqlBox(top: 0.8034196602806821d,right: 0.392011756559669d,bottom: 0.6214664543176971d,left: 0.3257532794618805d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7327121489621053d,right: 0.8575018075428321d,bottom: 0.5690690986727701d,left: 0.38576392007423055d),

new NpgsqlTypes.NpgsqlBox(top: 0.8970322984481838d,right: 0.7413975792672158d,bottom: 0.4493403655969901d,left: 0.6950374645343509d),

new NpgsqlTypes.NpgsqlBox(top: 0.9392068828513599d,right: 0.523365184244584d,bottom: 0.48439948598714655d,left: 0.049526788379709696d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7244995953282782d,right: 0.4635106146170964d,bottom: 0.14652731887121484d,left: 0.1362604783173228d),

new NpgsqlTypes.NpgsqlBox(top: 0.802773182826564d,right: 0.8052781980754327d,bottom: 0.12321236202444219d,left: 0.45677502392059843d),

new NpgsqlTypes.NpgsqlBox(top: 0.5111694625458808d,right: 0.46777718446074223d,bottom: 0.37118988974754574d,left: 0.12386627959803231d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.463441182451687d,right: 0.40314123086065334d,bottom: 0.13373060157613237d,left: 0.33626026605678794d),

new NpgsqlTypes.NpgsqlBox(top: 0.34853135567907045d,right: 0.8009692955301909d,bottom: 0.051990988277618055d,left: 0.5361901162507409d),

new NpgsqlTypes.NpgsqlBox(top: 0.912866687193872d,right: 0.854508847144314d,bottom: 0.7184049484110008d,left: 0.09799145566367173d),

new NpgsqlTypes.NpgsqlBox(top: 0.28626781570526294d,right: 0.8783776166570614d,bottom: 0.20114128549779753d,left: 0.29752085875234047d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2718081974652595d,right: 0.9428447428989615d,bottom: 0.13323309447404152d,left: 0.06480717470435604d),

new NpgsqlTypes.NpgsqlBox(top: 0.3856286023857102d,right: 0.9631951858702036d,bottom: 0.009129488387779716d,left: 0.12384352302120094d),

new NpgsqlTypes.NpgsqlBox(top: 0.25039182066759d,right: 0.47648849514733016d,bottom: 0.04308887680487694d,left: 0.3939079495488035d),

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
INSERT INTO public.npgsqlboxboxarray2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
INSERT INTO public.npgsqlboxboxarray2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)), 
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
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                List<NpgsqlBoxboxArray2M> models = null;

                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray2M> models = null;

                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 76, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 89, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 124, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 133, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 54, query1, 108, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 54, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 24, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 76, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 139, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 24, 66))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 108);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MI),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray2M),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2m m
LEFT JOIN public.binary_npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2M>(15);

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
                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
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
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

