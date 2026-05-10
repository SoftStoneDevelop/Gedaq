

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
    internal partial interface INpgsqlLineListlineArray
    {
    }
    
    internal partial class NpgsqlLineListlineArray : INpgsqlLineListlineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray2M[] _testData = new NpgsqlLinelineArray2M[]
        {
            new NpgsqlLinelineArray2M
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8843115979659265d, b: 0.1383617335551005d, c: 0.09525131988797353d),

new NpgsqlTypes.NpgsqlLine(a: 0.7183380301462927d, b: 0.7947619385068555d, c: 0.4019690024181656d),

new NpgsqlTypes.NpgsqlLine(a: 0.3676111440127987d, b: 0.7424280443558077d, c: 0.1638053726057127d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1131715237202865d, b: 0.366674834275585d, c: 0.9404529449497061d),

new NpgsqlTypes.NpgsqlLine(a: 0.7758085046238861d, b: 0.21643833964455905d, c: 0.1636874247980734d),

new NpgsqlTypes.NpgsqlLine(a: 0.2082497322804333d, b: 0.04860593531139723d, c: 0.2389414188923158d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.29692897811463825d, b: 0.9476258494267625d, c: 0.034275276015269585d),

new NpgsqlTypes.NpgsqlLine(a: 0.4034493699042152d, b: 0.564639259433261d, c: 0.6593836723455997d),

new NpgsqlTypes.NpgsqlLine(a: 0.4073343870771434d, b: 0.8574947670326863d, c: 0.6094984119172286d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.012879328158075798d, b: 0.9513208386683013d, c: 0.290693813880749d),

new NpgsqlTypes.NpgsqlLine(a: 0.33730500382971995d, b: 0.014656848398775235d, c: 0.893315359450537d),

new NpgsqlTypes.NpgsqlLine(a: 0.4381045354815958d, b: 0.6107894860301781d, c: 0.9512572882708815d),

new NpgsqlTypes.NpgsqlLine(a: 0.983536588353411d, b: 0.5680758758485223d, c: 0.9773466467333267d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.929769376093042d, b: 0.822686460513006d, c: 0.21382650856639773d),

new NpgsqlTypes.NpgsqlLine(a: 0.7669246156597255d, b: 0.5791267795742415d, c: 0.2557614270384585d),

new NpgsqlTypes.NpgsqlLine(a: 0.48420336413200893d, b: 0.5061437852031154d, c: 0.005332176872397398d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4295685735263177d, b: 0.36902841005958653d, c: 0.2434836469370928d),

new NpgsqlTypes.NpgsqlLine(a: 0.5339639109229913d, b: 0.8765901174192682d, c: 0.5685522710319896d),

new NpgsqlTypes.NpgsqlLine(a: 0.21606664958449406d, b: 0.9937643214163111d, c: 0.8919778093255053d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6242960832019745d, b: 0.704711193562893d, c: 0.5778901807798231d),

new NpgsqlTypes.NpgsqlLine(a: 0.07352989890046169d, b: 0.2628255386810453d, c: 0.03547044785623987d),

new NpgsqlTypes.NpgsqlLine(a: 0.36643859488527464d, b: 0.7770634387006923d, c: 0.5924551747867156d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.653675484125953d, b: 0.4395061226433161d, c: 0.7682267494574628d),

new NpgsqlTypes.NpgsqlLine(a: 0.5319278935762136d, b: 0.16892700724981424d, c: 0.6316906791402728d),

new NpgsqlTypes.NpgsqlLine(a: 0.6589561613892756d, b: 0.6406754279274309d, c: 0.7909153911534357d),

new NpgsqlTypes.NpgsqlLine(a: 0.46031897770918884d, b: 0.08449597420257393d, c: 0.7572996024715739d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25044096913620173d, b: 0.22395452698753604d, c: 0.16922291080010154d),

new NpgsqlTypes.NpgsqlLine(a: 0.8237743403771497d, b: 0.6329243115828589d, c: 0.5951048606547574d),

new NpgsqlTypes.NpgsqlLine(a: 0.03521492884603916d, b: 0.3022164962127998d, c: 0.441506443560332d),

new NpgsqlTypes.NpgsqlLine(a: 0.49586674708290834d, b: 0.5123264142862289d, c: 0.5314999928483897d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1658655482701108d, b: 0.4133332344913888d, c: 0.7446293497433377d),

new NpgsqlTypes.NpgsqlLine(a: 0.5152071694515084d, b: 0.8459387618265818d, c: 0.6619833626350822d),

new NpgsqlTypes.NpgsqlLine(a: 0.6519179715633431d, b: 0.28390573287803045d, c: 0.0595824939741737d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2471719470043926d, b: 0.40730819819867425d, c: 0.9692650393137007d),

new NpgsqlTypes.NpgsqlLine(a: 0.07213593442808164d, b: 0.828151031042297d, c: 0.4688554401397844d),

new NpgsqlTypes.NpgsqlLine(a: 0.6066559454791656d, b: 0.21453134832235266d, c: 0.9281254860629632d),

new NpgsqlTypes.NpgsqlLine(a: 0.8682086668125866d, b: 0.0010474736543636398d, c: 0.8593287229922679d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8415555429730545d, b: 0.5649378241354028d, c: 0.8610703406339071d),

new NpgsqlTypes.NpgsqlLine(a: 0.3251276986828082d, b: 0.49179012936442645d, c: 0.9400413320512555d),

new NpgsqlTypes.NpgsqlLine(a: 0.27619488651100066d, b: 0.7088023105594293d, c: 0.2371871060781766d),

new NpgsqlTypes.NpgsqlLine(a: 0.2604873902864856d, b: 0.42089864810433864d, c: 0.5746675992131253d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4142514133021955d, b: 0.05175310187334248d, c: 0.34973183823802234d),

new NpgsqlTypes.NpgsqlLine(a: 0.5466810398865377d, b: 0.2728764123867127d, c: 0.508479522245291d),

new NpgsqlTypes.NpgsqlLine(a: 0.5886871024940248d, b: 0.0067005514727206394d, c: 0.20698878494865203d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4476892072774784d, b: 0.1681301801629722d, c: 0.5978480542222804d),

new NpgsqlTypes.NpgsqlLine(a: 0.21909645643139664d, b: 0.3894652016179728d, c: 0.18023003577286223d),

new NpgsqlTypes.NpgsqlLine(a: 0.7904680761586433d, b: 0.8690892442218588d, c: 0.4465475818854283d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7734374625703745d, b: 0.25690582153176933d, c: 0.8955321538501277d),

new NpgsqlTypes.NpgsqlLine(a: 0.8634450051235576d, b: 0.19008859670381062d, c: 0.1516232146278299d),

new NpgsqlTypes.NpgsqlLine(a: 0.5908505532179323d, b: 0.22818249075122132d, c: 0.3129985068031913d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3071441208848198d, b: 0.9134479428414094d, c: 0.43915840291219954d),

new NpgsqlTypes.NpgsqlLine(a: 0.5233793035509736d, b: 0.3044199086489944d, c: 0.740599829450582d),

new NpgsqlTypes.NpgsqlLine(a: 0.2526934367656323d, b: 0.6943180391114849d, c: 0.7656670766544212d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5370580839941065d, b: 0.5244410683844403d, c: 0.04131583607760603d),

new NpgsqlTypes.NpgsqlLine(a: 0.8645250760043619d, b: 0.216559706816283d, c: 0.18152870837514634d),

new NpgsqlTypes.NpgsqlLine(a: 0.4688843431284321d, b: 0.7119005197082772d, c: 0.3939729685300085d),

new NpgsqlTypes.NpgsqlLine(a: 0.8296449298854688d, b: 0.1477195609313916d, c: 0.921126937481387d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6993446037356417d, b: 0.11082807757069513d, c: 0.3749354699281181d),

new NpgsqlTypes.NpgsqlLine(a: 0.7146762452806341d, b: 0.44771514269639d, c: 0.05534997705159839d),

new NpgsqlTypes.NpgsqlLine(a: 0.6925149517969729d, b: 0.7217901813175228d, c: 0.30013056547596906d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3135578110703202d, b: 0.8058932185058523d, c: 0.3171663752167837d),

new NpgsqlTypes.NpgsqlLine(a: 0.00354951092846878d, b: 0.7703169746213487d, c: 0.5547148315542869d),

new NpgsqlTypes.NpgsqlLine(a: 0.27963038785228556d, b: 0.6997681826650676d, c: 0.09810521872001121d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32734822528212115d, b: 0.8278515035288083d, c: 0.7636485555114543d),

new NpgsqlTypes.NpgsqlLine(a: 0.8727837780860396d, b: 0.3769842299713536d, c: 0.8585393152858115d),

new NpgsqlTypes.NpgsqlLine(a: 0.18399123349493407d, b: 0.7272771660534201d, c: 0.6625392387421768d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2668473198241954d, b: 0.060810614072019376d, c: 0.4282325006034735d),

new NpgsqlTypes.NpgsqlLine(a: 0.27170853173460097d, b: 0.837028089706388d, c: 0.31372548757243957d),

new NpgsqlTypes.NpgsqlLine(a: 0.7847436250622004d, b: 0.8790103193845519d, c: 0.7174814981836714d),

new NpgsqlTypes.NpgsqlLine(a: 0.35269962269653965d, b: 0.30486540781403015d, c: 0.670679568249975d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4585827922928507d, b: 0.18036293900539813d, c: 0.39241321725111533d),

new NpgsqlTypes.NpgsqlLine(a: 0.8112665211371617d, b: 0.21271822077906488d, c: 0.842606371225062d),

new NpgsqlTypes.NpgsqlLine(a: 0.8517490495033159d, b: 0.7909835865154228d, c: 0.4718185904458637d),

new NpgsqlTypes.NpgsqlLine(a: 0.8176059092166877d, b: 0.8145027889842428d, c: 0.04558772496457819d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5248969642836285d, b: 0.7485323839794141d, c: 0.09785358293871871d),

new NpgsqlTypes.NpgsqlLine(a: 0.47791585052149266d, b: 0.2410730912873723d, c: 0.5004837432095443d),

new NpgsqlTypes.NpgsqlLine(a: 0.5170291361999478d, b: 0.06167670873555475d, c: 0.7704683309930525d),

new NpgsqlTypes.NpgsqlLine(a: 0.8100049921345783d, b: 0.8204665130464132d, c: 0.29573425079964233d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32786417446925054d, b: 0.6748118843091057d, c: 0.9139705851662263d),

new NpgsqlTypes.NpgsqlLine(a: 0.824677950105938d, b: 0.4367532096203238d, c: 0.4674963886478428d),

new NpgsqlTypes.NpgsqlLine(a: 0.15580614018097083d, b: 0.8832647246715021d, c: 0.2743866750895917d),

new NpgsqlTypes.NpgsqlLine(a: 0.6647437753215103d, b: 0.4145458764414729d, c: 0.6241454108828579d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26942541669507436d, b: 0.1843494330488087d, c: 0.7208392812889926d),

new NpgsqlTypes.NpgsqlLine(a: 0.6711885008273926d, b: 0.4470515421770237d, c: 0.9571011835803714d),

new NpgsqlTypes.NpgsqlLine(a: 0.8568660012165921d, b: 0.0827441382920252d, c: 0.6748141327536474d),

new NpgsqlTypes.NpgsqlLine(a: 0.3941098056795125d, b: 0.8890402906130314d, c: 0.15513537918881948d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.639260205778498d, b: 0.33191287793993085d, c: 0.05391326337814062d),

new NpgsqlTypes.NpgsqlLine(a: 0.6656325048293744d, b: 0.18286103895103822d, c: 0.20938027611189047d),

new NpgsqlTypes.NpgsqlLine(a: 0.00021934011409763254d, b: 0.7901765117985793d, c: 0.292059180759738d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.48794528556139705d, b: 0.4512154133871058d, c: 0.660965800495718d),

new NpgsqlTypes.NpgsqlLine(a: 0.6619707454143826d, b: 0.7004400121147455d, c: 0.10747843971881677d),

new NpgsqlTypes.NpgsqlLine(a: 0.5318956315781097d, b: 0.1848876414891113d, c: 0.06769006097262464d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5311621621925193d, b: 0.35169161478973077d, c: 0.8969723173753711d),

new NpgsqlTypes.NpgsqlLine(a: 0.8188080031445796d, b: 0.6941585123384346d, c: 0.9292398168007414d),

new NpgsqlTypes.NpgsqlLine(a: 0.22263484067668815d, b: 0.1260570519480273d, c: 0.40926995775160124d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6388438688937542d, b: 0.5008651713419464d, c: 0.31664037659666566d),

new NpgsqlTypes.NpgsqlLine(a: 0.849488558352491d, b: 0.7925258374479811d, c: 0.4915653787794949d),

new NpgsqlTypes.NpgsqlLine(a: 0.03971313079609695d, b: 0.6197479109929283d, c: 0.06220461209470285d),

new NpgsqlTypes.NpgsqlLine(a: 0.4276507919122515d, b: 0.12810955596878515d, c: 0.9448741396634602d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8550398813755983d, b: 0.13121382829448802d, c: 0.4156929574939795d),

new NpgsqlTypes.NpgsqlLine(a: 0.443071954659386d, b: 0.09973705316397197d, c: 0.11514820320537533d),

new NpgsqlTypes.NpgsqlLine(a: 0.40877293618197363d, b: 0.4026265542390789d, c: 0.5074889892418837d),

new NpgsqlTypes.NpgsqlLine(a: 0.565246354186026d, b: 0.037714510790584854d, c: 0.6334644259268251d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9447762549445847d, b: 0.6680330073568724d, c: 0.5543983042784738d),

new NpgsqlTypes.NpgsqlLine(a: 0.07532000581197373d, b: 0.8498214677560864d, c: 0.7425043860112049d),

new NpgsqlTypes.NpgsqlLine(a: 0.7099799228254583d, b: 0.46464703128600304d, c: 0.5766556351629688d),

new NpgsqlTypes.NpgsqlLine(a: 0.5782238616811519d, b: 0.8678711565498071d, c: 0.8704019176253632d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9249898466291149d, b: 0.10102036427412797d, c: 0.5597192046824382d),

new NpgsqlTypes.NpgsqlLine(a: 0.0514179237879111d, b: 0.7386559253134322d, c: 0.8873493201643456d),

new NpgsqlTypes.NpgsqlLine(a: 0.6129724691515259d, b: 0.19301820173207618d, c: 0.26374357148079075d),

new NpgsqlTypes.NpgsqlLine(a: 0.6365281881110045d, b: 0.2142291687885689d, c: 0.6352192730110775d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4878449815169116d, b: 0.3676265407112417d, c: 0.5253791647114873d),

new NpgsqlTypes.NpgsqlLine(a: 0.6416712879160963d, b: 0.9579377015833027d, c: 0.7939668280044054d),

new NpgsqlTypes.NpgsqlLine(a: 0.010244360623045679d, b: 0.9175732667518117d, c: 0.18056358597735545d),

new NpgsqlTypes.NpgsqlLine(a: 0.8748196063974035d, b: 0.6758163739940466d, c: 0.2848317653011193d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12065452357552264d, b: 0.006226194580699174d, c: 0.5512139900255596d),

new NpgsqlTypes.NpgsqlLine(a: 0.16682082639540563d, b: 0.6034410963025708d, c: 0.8724746614685314d),

new NpgsqlTypes.NpgsqlLine(a: 0.8156231796878429d, b: 0.36810968448694614d, c: 0.45601555012213124d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.036639180394679394d, b: 0.5545571995085624d, c: 0.2549403627173177d),

new NpgsqlTypes.NpgsqlLine(a: 0.07156003917073417d, b: 0.847063014629949d, c: 0.47238332396980875d),

new NpgsqlTypes.NpgsqlLine(a: 0.5802976472101876d, b: 0.05948661682036627d, c: 0.3246858990507451d),

new NpgsqlTypes.NpgsqlLine(a: 0.047738997271849715d, b: 0.03712368844647085d, c: 0.3591407135297061d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.018321707727443126d, b: 0.0625612824175018d, c: 0.6651423240261196d),

new NpgsqlTypes.NpgsqlLine(a: 0.7283049797470212d, b: 0.7430876484883465d, c: 0.7413659513050938d),

new NpgsqlTypes.NpgsqlLine(a: 0.8488267155606151d, b: 0.9043755756236616d, c: 0.29079414940979087d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7514069557827336d, b: 0.5883413275628228d, c: 0.8413225519283741d),

new NpgsqlTypes.NpgsqlLine(a: 0.41165351836835384d, b: 0.5796109803480397d, c: 0.8807844006662533d),

new NpgsqlTypes.NpgsqlLine(a: 0.2181109111629087d, b: 0.852752483064278d, c: 0.7695261680750249d),

new NpgsqlTypes.NpgsqlLine(a: 0.9857312003276513d, b: 0.013885766594095905d, c: 0.8932603816599409d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.734079054759202d, b: 0.48146816421092564d, c: 0.1871563110019433d),

new NpgsqlTypes.NpgsqlLine(a: 0.37606458699771395d, b: 0.4414148185047456d, c: 0.5910534938717036d),

new NpgsqlTypes.NpgsqlLine(a: 0.4099681148244818d, b: 0.06264312410378525d, c: 0.41636554609028076d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7082232183541092d, b: 0.5459460791268029d, c: 0.021949317200026797d),

new NpgsqlTypes.NpgsqlLine(a: 0.15233724645031754d, b: 0.8014939827504954d, c: 0.7369761051987939d),

new NpgsqlTypes.NpgsqlLine(a: 0.9510400147182736d, b: 0.9548281654530655d, c: 0.6356066304899713d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18228420627936837d, b: 0.10948116959507037d, c: 0.36364659970639046d),

new NpgsqlTypes.NpgsqlLine(a: 0.6033959879837134d, b: 0.004159642101703276d, c: 0.28974471201404806d),

new NpgsqlTypes.NpgsqlLine(a: 0.07691815388838619d, b: 0.9234484644281504d, c: 0.3471144477882291d),

new NpgsqlTypes.NpgsqlLine(a: 0.4843796279856133d, b: 0.7316965002491507d, c: 0.5149135868537235d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5118722435907096d, b: 0.4995508402919615d, c: 0.7943617280758223d),

new NpgsqlTypes.NpgsqlLine(a: 0.5160802922749527d, b: 0.7514804881026504d, c: 0.6733171319282416d),

new NpgsqlTypes.NpgsqlLine(a: 0.5884655088269508d, b: 0.9089325105144319d, c: 0.6435887723435046d),

new NpgsqlTypes.NpgsqlLine(a: 0.12022454792466197d, b: 0.4150346661298069d, c: 0.1601015930826376d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5119684144559657d, b: 0.05552980102188265d, c: 0.10563051507404198d),

new NpgsqlTypes.NpgsqlLine(a: 0.3049750856878035d, b: 0.16108171335897847d, c: 0.6547509295110128d),

new NpgsqlTypes.NpgsqlLine(a: 0.9910348332003889d, b: 0.45442151353737925d, c: 0.29051067361594374d),

new NpgsqlTypes.NpgsqlLine(a: 0.6146902768842772d, b: 0.0456573563478575d, c: 0.8389582498422109d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17435053334094486d, b: 0.9348159942164459d, c: 0.8887136776646435d),

new NpgsqlTypes.NpgsqlLine(a: 0.6975142494589561d, b: 0.8711751138878738d, c: 0.1362459769115374d),

new NpgsqlTypes.NpgsqlLine(a: 0.53607803432953d, b: 0.8145533859677607d, c: 0.1325438595887043d),

new NpgsqlTypes.NpgsqlLine(a: 0.784671894409479d, b: 0.08111346388439633d, c: 0.7630772680294465d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07083080831375532d, b: 0.46005156908468525d, c: 0.6182068007534688d),

new NpgsqlTypes.NpgsqlLine(a: 0.29611040235119723d, b: 0.56141426440265d, c: 0.6637530768951393d),

new NpgsqlTypes.NpgsqlLine(a: 0.7314824270295234d, b: 0.5890677504704304d, c: 0.23466096857329033d),

new NpgsqlTypes.NpgsqlLine(a: 0.8695581896659206d, b: 0.7324336082186217d, c: 0.842911319255929d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.27551857129126645d, b: 0.3014831155432378d, c: 0.8725118504022185d),

new NpgsqlTypes.NpgsqlLine(a: 0.3016544505168859d, b: 0.5039867384453643d, c: 0.8171636168421331d),

new NpgsqlTypes.NpgsqlLine(a: 0.6361552070756402d, b: 0.7609309401414021d, c: 0.40300347441137363d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.026805264903110637d, b: 0.38672095100257886d, c: 0.04202449697328148d),

new NpgsqlTypes.NpgsqlLine(a: 0.333634830144212d, b: 0.9570109142304385d, c: 0.2151928715290451d),

new NpgsqlTypes.NpgsqlLine(a: 0.47620966094152883d, b: 0.4573996575710616d, c: 0.015885439680358382d),

new NpgsqlTypes.NpgsqlLine(a: 0.12824479801221222d, b: 0.8972918456561664d, c: 0.2973074892102434d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28372236408160745d, b: 0.9909019964469132d, c: 0.016763379964065628d),

new NpgsqlTypes.NpgsqlLine(a: 0.6182854501435326d, b: 0.489560176891947d, c: 0.6668435874561753d),

new NpgsqlTypes.NpgsqlLine(a: 0.4982789624847722d, b: 0.03251952294448657d, c: 0.9598960496671766d),

new NpgsqlTypes.NpgsqlLine(a: 0.404119121670548d, b: 0.03331443591865901d, c: 0.2034236818618943d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2921937489007631d, b: 0.14769139326714942d, c: 0.22923685311943076d),

new NpgsqlTypes.NpgsqlLine(a: 0.9437865232369861d, b: 0.7207622253154392d, c: 0.9529901055283602d),

new NpgsqlTypes.NpgsqlLine(a: 0.5032919500190306d, b: 0.9081931840701112d, c: 0.26350285083374847d),

new NpgsqlTypes.NpgsqlLine(a: 0.24801694290744436d, b: 0.5030413969278912d, c: 0.9319949580771724d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.05584699471891108d, b: 0.784215850224321d, c: 0.9200111077673593d),

new NpgsqlTypes.NpgsqlLine(a: 0.9287222713546d, b: 0.29995246168258416d, c: 0.9957271552113263d),

new NpgsqlTypes.NpgsqlLine(a: 0.11352604446397763d, b: 0.487496795945323d, c: 0.23550970199504906d),

new NpgsqlTypes.NpgsqlLine(a: 0.5039748188870334d, b: 0.7200950161998763d, c: 0.38921341152191136d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3669586687696731d, b: 0.6589736791210054d, c: 0.3843704864081353d),

new NpgsqlTypes.NpgsqlLine(a: 0.46092427285071613d, b: 0.8380970174362905d, c: 0.7788765605665782d),

new NpgsqlTypes.NpgsqlLine(a: 0.7937798090014988d, b: 0.7332279242229675d, c: 0.10924448307241419d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24943569314431902d, b: 0.5420338547851582d, c: 0.9310608727234592d),

new NpgsqlTypes.NpgsqlLine(a: 0.011685162144683514d, b: 0.9210398925925591d, c: 0.7058463109242867d),

new NpgsqlTypes.NpgsqlLine(a: 0.9880282108433583d, b: 0.1275310672947899d, c: 0.4842758884119268d),

new NpgsqlTypes.NpgsqlLine(a: 0.5813723321870934d, b: 0.39631767908720383d, c: 0.652517932680399d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4785241057639952d, b: 0.25235397769562096d, c: 0.2129109062808735d),

new NpgsqlTypes.NpgsqlLine(a: 0.0480713121394345d, b: 0.6411103613930875d, c: 0.6287202754291806d),

new NpgsqlTypes.NpgsqlLine(a: 0.9838091156349136d, b: 0.6575458390603801d, c: 0.2389372331700489d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5395866318365385d, b: 0.908802805965591d, c: 0.5137686515878597d),

new NpgsqlTypes.NpgsqlLine(a: 0.8002773289006164d, b: 0.12895373771424712d, c: 0.05007689042266894d),

new NpgsqlTypes.NpgsqlLine(a: 0.18232278106850286d, b: 0.45948468305039947d, c: 0.22459268501577878d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.19246857778888615d, b: 0.8284770243175072d, c: 0.9597369286204693d),

new NpgsqlTypes.NpgsqlLine(a: 0.5495266602523196d, b: 0.3477016087222238d, c: 0.11128713235740384d),

new NpgsqlTypes.NpgsqlLine(a: 0.7139782177791806d, b: 0.7514592004447427d, c: 0.3879653613953864d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9673192599284471d, b: 0.14923513711497727d, c: 0.2493276833344884d),

new NpgsqlTypes.NpgsqlLine(a: 0.8096434222709985d, b: 0.5379148333958842d, c: 0.9791711562698564d),

new NpgsqlTypes.NpgsqlLine(a: 0.6674301016571295d, b: 0.039382207159528226d, c: 0.5875018672693885d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7848142833176074d, b: 0.2363456501408958d, c: 0.6189314194327986d),

new NpgsqlTypes.NpgsqlLine(a: 0.15741064050794695d, b: 0.8423008837422242d, c: 0.12659885329739817d),

new NpgsqlTypes.NpgsqlLine(a: 0.6733091300018232d, b: 0.4086470930896453d, c: 0.6714218220527619d),

new NpgsqlTypes.NpgsqlLine(a: 0.7085480099676208d, b: 0.04735508968731217d, c: 0.5912875877029031d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2416297017253619d, b: 0.9257806447213047d, c: 0.1680644427335497d),

new NpgsqlTypes.NpgsqlLine(a: 0.08846770067024212d, b: 0.8531232132191725d, c: 0.29363468891087696d),

new NpgsqlTypes.NpgsqlLine(a: 0.845773559878482d, b: 0.8824913344462696d, c: 0.9690405920576358d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3761418461138525d, b: 0.8836309005862868d, c: 0.7612159529856273d),

new NpgsqlTypes.NpgsqlLine(a: 0.7291122404545748d, b: 0.8288981165047276d, c: 0.782717047897793d),

new NpgsqlTypes.NpgsqlLine(a: 0.4167370967930778d, b: 0.5457687243447396d, c: 0.626890114177673d),

new NpgsqlTypes.NpgsqlLine(a: 0.3775574228472507d, b: 0.7312130283265056d, c: 0.4656036150554562d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07269753627235898d, b: 0.4957437361409064d, c: 0.5723612363695919d),

new NpgsqlTypes.NpgsqlLine(a: 0.3831179243070877d, b: 0.56601178946378d, c: 0.6541806873878232d),

new NpgsqlTypes.NpgsqlLine(a: 0.9220992852898001d, b: 0.18306994961594092d, c: 0.8135266277432908d),

new NpgsqlTypes.NpgsqlLine(a: 0.7305053054691246d, b: 0.6066473682070592d, c: 0.2817739918445138d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31219857081770663d, b: 0.8812788875087687d, c: 0.49239620312977694d),

new NpgsqlTypes.NpgsqlLine(a: 0.6151371676962566d, b: 0.08094378146572456d, c: 0.988663312065519d),

new NpgsqlTypes.NpgsqlLine(a: 0.3009689321941482d, b: 0.602598476571996d, c: 0.0501558303312839d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08060092008534536d, b: 0.12296391228089543d, c: 0.5050285481889071d),

new NpgsqlTypes.NpgsqlLine(a: 0.3016765377341326d, b: 0.23811113294423847d, c: 0.9026542734520346d),

new NpgsqlTypes.NpgsqlLine(a: 0.4662134781141981d, b: 0.1193057375785157d, c: 0.4040088507538291d),

new NpgsqlTypes.NpgsqlLine(a: 0.5216558520646122d, b: 0.25573181041196813d, c: 0.12933011352989499d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.458012652595269d, b: 0.9920218546754483d, c: 0.6878963969688954d),

new NpgsqlTypes.NpgsqlLine(a: 0.8837999873827583d, b: 0.15207062062021715d, c: 0.9672356321802871d),

new NpgsqlTypes.NpgsqlLine(a: 0.36401559077153756d, b: 0.7520692633582111d, c: 0.7773022446044248d),

new NpgsqlTypes.NpgsqlLine(a: 0.7986692764501033d, b: 0.5663489463758274d, c: 0.3021829315628852d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4261854594245156d, b: 0.31895025550764045d, c: 0.5530665885589378d),

new NpgsqlTypes.NpgsqlLine(a: 0.7689952984737736d, b: 0.9627856469035924d, c: 0.7552959562965461d),

new NpgsqlTypes.NpgsqlLine(a: 0.8719840439515935d, b: 0.7902307356349472d, c: 0.9925655710818554d),

new NpgsqlTypes.NpgsqlLine(a: 0.7320024757423103d, b: 0.46969502449393086d, c: 0.6407937127251184d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9828907791990465d, b: 0.18855091845806782d, c: 0.8903301951559593d),

new NpgsqlTypes.NpgsqlLine(a: 0.9415896249303922d, b: 0.48063065032514063d, c: 0.2609098823069116d),

new NpgsqlTypes.NpgsqlLine(a: 0.9679709669415738d, b: 0.03295818775409709d, c: 0.6548640245614887d),

new NpgsqlTypes.NpgsqlLine(a: 0.12454621494201823d, b: 0.26730118840805106d, c: 0.4115708673471592d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.013479168418044418d, b: 0.7614201256542631d, c: 0.6850563774521389d),

new NpgsqlTypes.NpgsqlLine(a: 0.8075581566423155d, b: 0.9763284249251913d, c: 0.08454420750552727d),

new NpgsqlTypes.NpgsqlLine(a: 0.5028784724636868d, b: 0.5501408688012164d, c: 0.40224354988965916d),

new NpgsqlTypes.NpgsqlLine(a: 0.5511124608860647d, b: 0.6706582514356079d, c: 0.3455343279516462d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4589201411810728d, b: 0.865685999089268d, c: 0.9164977243272214d),

new NpgsqlTypes.NpgsqlLine(a: 0.7469278233630513d, b: 0.44389370614157997d, c: 0.2419085915419953d),

new NpgsqlTypes.NpgsqlLine(a: 0.9583600633568571d, b: 0.02354481865993685d, c: 0.19965954884888937d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9560202341401258d, b: 0.14489236478093237d, c: 0.5389882947498176d),

new NpgsqlTypes.NpgsqlLine(a: 0.7570508210651667d, b: 0.8534961055055823d, c: 0.9937672720161345d),

new NpgsqlTypes.NpgsqlLine(a: 0.7451722563805602d, b: 0.2229995620406705d, c: 0.9946708900171081d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8354970287884096d, b: 0.7047382026005963d, c: 0.48863161007730205d),

new NpgsqlTypes.NpgsqlLine(a: 0.8119314234742715d, b: 0.25658591689297294d, c: 0.13927943830705192d),

new NpgsqlTypes.NpgsqlLine(a: 0.360921456646902d, b: 0.3170572134398394d, c: 0.7330786119149195d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4197597526870973d, b: 0.21835360962083172d, c: 0.5929574026631746d),

new NpgsqlTypes.NpgsqlLine(a: 0.6547283553970378d, b: 0.3458523775794634d, c: 0.7211486927956979d),

new NpgsqlTypes.NpgsqlLine(a: 0.6743097662217384d, b: 0.3952376333370482d, c: 0.7321571209700801d),

new NpgsqlTypes.NpgsqlLine(a: 0.11353874004001496d, b: 0.5897396513757464d, c: 0.48293555057627524d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5356681344890784d, b: 0.6647383082663414d, c: 0.4712793617485035d),

new NpgsqlTypes.NpgsqlLine(a: 0.640215466530122d, b: 0.7903647238326224d, c: 0.1175262100215888d),

new NpgsqlTypes.NpgsqlLine(a: 0.10181788731863362d, b: 0.06678687612116918d, c: 0.8213668346944129d),

new NpgsqlTypes.NpgsqlLine(a: 0.8317506222026053d, b: 0.23598241428167144d, c: 0.023834439296534504d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08419188690669299d, b: 0.5807074029431362d, c: 0.4073024728291331d),

new NpgsqlTypes.NpgsqlLine(a: 0.6453610784801085d, b: 0.552116261816969d, c: 0.9343753908531294d),

new NpgsqlTypes.NpgsqlLine(a: 0.9386165591972203d, b: 0.5509549053872572d, c: 0.7362782117664989d),

new NpgsqlTypes.NpgsqlLine(a: 0.8936316749172601d, b: 0.08417542915928489d, c: 0.9596335742960679d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6858154879500654d, b: 0.48381488254027716d, c: 0.423095411087942d),

new NpgsqlTypes.NpgsqlLine(a: 0.9814071873081777d, b: 0.729964285093184d, c: 0.20806910199062756d),

new NpgsqlTypes.NpgsqlLine(a: 0.5390039947712582d, b: 0.3410260033804673d, c: 0.3228840127781879d),

new NpgsqlTypes.NpgsqlLine(a: 0.9856840412382676d, b: 0.21910644852584793d, c: 0.8183853332836402d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44978830944356907d, b: 0.5132833565965104d, c: 0.8147112968951101d),

new NpgsqlTypes.NpgsqlLine(a: 0.03421017145183003d, b: 0.36784283758209146d, c: 0.7670729534062045d),

new NpgsqlTypes.NpgsqlLine(a: 0.46792924919838563d, b: 0.29196687119693754d, c: 0.8352339826836717d),

new NpgsqlTypes.NpgsqlLine(a: 0.10136093353856412d, b: 0.23422123744580514d, c: 0.698298531920584d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.049804195242175164d, b: 0.67098364291648d, c: 0.456534467906355d),

new NpgsqlTypes.NpgsqlLine(a: 0.6157496681598847d, b: 0.4980367811972587d, c: 0.03625069172912376d),

new NpgsqlTypes.NpgsqlLine(a: 0.04222297710081002d, b: 0.14733599919852003d, c: 0.047811355608477824d),

new NpgsqlTypes.NpgsqlLine(a: 0.2801530050935712d, b: 0.36375923982360503d, c: 0.07798206639799987d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8714757676804473d, b: 0.3033518794008945d, c: 0.33654538454328553d),

new NpgsqlTypes.NpgsqlLine(a: 0.9142679029417964d, b: 0.9076682558250744d, c: 0.26146181960447257d),

new NpgsqlTypes.NpgsqlLine(a: 0.6580291393557565d, b: 0.2879264715148251d, c: 0.631268716077848d),

new NpgsqlTypes.NpgsqlLine(a: 0.27434293789898156d, b: 0.8487587238182541d, c: 0.5496576467126952d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
INSERT INTO public.npgsqllinelinearray2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineArray)), 
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
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                List<NpgsqlLinelineArray2M> models = null;

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray2M> models = null;

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 60;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 15;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 45;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 128, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 151, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 32, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 20, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 112, query1, 81, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 70, query1, 151, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 9, 151))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 88, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[26],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[27],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[28],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[29],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[30],_testData[34], false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MI),
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray2M),
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2m m
LEFT JOIN public.binary_npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models =  ((INpgsqlLineListlineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI), typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                await ((INpgsqlLineListlineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                ((INpgsqlLineListlineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

