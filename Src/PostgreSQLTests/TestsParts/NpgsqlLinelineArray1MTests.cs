

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
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8031695553354045d, b: 0.812480313449635d, c: 0.16527646747487512d),
new NpgsqlTypes.NpgsqlLine(a: 0.16635884088373987d, b: 0.5364756565928208d, c: 0.31087887682054827d),
new NpgsqlTypes.NpgsqlLine(a: 0.5582401227218055d, b: 0.34286752056075664d, c: 0.4074149935777889d),
new NpgsqlTypes.NpgsqlLine(a: 0.9064818650848703d, b: 0.9080781308261587d, c: 0.5337027033345136d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8035568792343266d, b: 0.3012148999008545d, c: 0.5389916295602587d),
new NpgsqlTypes.NpgsqlLine(a: 0.023941915683865167d, b: 0.9290435812409776d, c: 0.17393474325404013d),
new NpgsqlTypes.NpgsqlLine(a: 0.38670486547090466d, b: 0.8557502059327284d, c: 0.6539543520303324d),
new NpgsqlTypes.NpgsqlLine(a: 0.04550773581775969d, b: 0.8879867946983014d, c: 0.6030602131895006d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.82179123833732d, b: 0.009047940068392268d, c: 0.9376411910492227d),
new NpgsqlTypes.NpgsqlLine(a: 0.3862580591127728d, b: 0.9450810940721989d, c: 0.7664832447064426d),
new NpgsqlTypes.NpgsqlLine(a: 0.7904492341879624d, b: 0.8791754793019436d, c: 0.9346349456929881d),
new NpgsqlTypes.NpgsqlLine(a: 0.323536908417115d, b: 0.03438747781276186d, c: 0.06394926566002013d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12576200147606098d, b: 0.30707736376483363d, c: 0.3438629928362966d),
new NpgsqlTypes.NpgsqlLine(a: 0.7908308339304307d, b: 0.9874763313989715d, c: 0.9941926124131432d),
new NpgsqlTypes.NpgsqlLine(a: 0.254459588951664d, b: 0.9481861999959772d, c: 0.8326805315257226d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7399982820318901d, b: 0.7268955425745323d, c: 0.014020681595934836d),
new NpgsqlTypes.NpgsqlLine(a: 0.4695318258405806d, b: 0.25421922343069703d, c: 0.5663467198323402d),
new NpgsqlTypes.NpgsqlLine(a: 0.3293078193475736d, b: 0.42789906917285736d, c: 0.23781642390102908d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5150537656499791d, b: 0.8715801103514912d, c: 0.849585563549908d),
new NpgsqlTypes.NpgsqlLine(a: 0.6053606489410384d, b: 0.907386187711092d, c: 0.6617322193807121d),
new NpgsqlTypes.NpgsqlLine(a: 0.34990008226487934d, b: 0.0655297242908699d, c: 0.3660958355528072d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5359308942843317d, b: 0.4707195741366704d, c: 0.4712742274451609d),
new NpgsqlTypes.NpgsqlLine(a: 0.1542662139855846d, b: 0.3730896486992086d, c: 0.8958082934727194d),
new NpgsqlTypes.NpgsqlLine(a: 0.947006857625904d, b: 0.46092140356863254d, c: 0.5620645212515833d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5742891725497697d, b: 0.3636585344311758d, c: 0.6787418883658244d),
new NpgsqlTypes.NpgsqlLine(a: 0.4937531344603583d, b: 0.08968889955409853d, c: 0.8723160634225925d),
new NpgsqlTypes.NpgsqlLine(a: 0.28298134889235704d, b: 0.06650149479418521d, c: 0.13399491903181548d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8236607257408424d, b: 0.9737910297288174d, c: 0.906111808608387d),
new NpgsqlTypes.NpgsqlLine(a: 0.686600512721279d, b: 0.9102052851229774d, c: 0.9217792733523207d),
new NpgsqlTypes.NpgsqlLine(a: 0.8166297867525143d, b: 0.7198380916098078d, c: 0.28273695833126367d),
new NpgsqlTypes.NpgsqlLine(a: 0.9396357760305408d, b: 0.06139709805703353d, c: 0.07258891693406155d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2014742630845897d, b: 0.8120618281203791d, c: 0.87146357693652d),
new NpgsqlTypes.NpgsqlLine(a: 0.4489284221386354d, b: 0.8814885621341416d, c: 0.15251285209350973d),
new NpgsqlTypes.NpgsqlLine(a: 0.2865839025886535d, b: 0.7219057846428985d, c: 0.3412635598969813d),
new NpgsqlTypes.NpgsqlLine(a: 0.4119391579225994d, b: 0.8823357519433797d, c: 0.23409954778240438d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2350059234551004d, b: 0.3450261755308123d, c: 0.6951576778348667d),
new NpgsqlTypes.NpgsqlLine(a: 0.41570106480659463d, b: 0.8587397860531011d, c: 0.1679477886264189d),
new NpgsqlTypes.NpgsqlLine(a: 0.2142189543608488d, b: 0.7582073455447559d, c: 0.41859355108566954d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5022374130954126d, b: 0.6360086143175494d, c: 0.32708782635864053d),
new NpgsqlTypes.NpgsqlLine(a: 0.646924931796837d, b: 0.9114470183244268d, c: 0.25153696613669174d),
new NpgsqlTypes.NpgsqlLine(a: 0.5387365112932591d, b: 0.00729893835421902d, c: 0.08438198136427644d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18672037795348095d, b: 0.33495307577434796d, c: 0.9291286282439698d),
new NpgsqlTypes.NpgsqlLine(a: 0.7527388339034775d, b: 0.04046625841795748d, c: 0.5304378551942759d),
new NpgsqlTypes.NpgsqlLine(a: 0.3794056830702529d, b: 0.046815899397805505d, c: 0.8325678155927364d),
new NpgsqlTypes.NpgsqlLine(a: 0.4491242515388869d, b: 0.7201253845705741d, c: 0.29880276018379004d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9298862117230822d, b: 0.7975620487090784d, c: 0.6191241626420417d),
new NpgsqlTypes.NpgsqlLine(a: 0.599281036145215d, b: 0.4835339738128088d, c: 0.4723377180700804d),
new NpgsqlTypes.NpgsqlLine(a: 0.47602513126387636d, b: 0.6006630037532755d, c: 0.8513358109544807d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0638744744599482d, b: 0.9069292144931764d, c: 0.6130637945197471d),
new NpgsqlTypes.NpgsqlLine(a: 0.06445665278908519d, b: 0.6223659107203448d, c: 0.15977110740522626d),
new NpgsqlTypes.NpgsqlLine(a: 0.8765809297093243d, b: 0.9739826747766949d, c: 0.02200943107117137d),
new NpgsqlTypes.NpgsqlLine(a: 0.2792537648767489d, b: 0.13385079227035301d, c: 0.27772578543634907d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7953901115322155d, b: 0.8269897915226756d, c: 0.29234974785835854d),
new NpgsqlTypes.NpgsqlLine(a: 0.42735998448346724d, b: 0.025423024045830855d, c: 0.001157273124469671d),
new NpgsqlTypes.NpgsqlLine(a: 0.5983931000579528d, b: 0.8581317085069541d, c: 0.10825499464069666d),
new NpgsqlTypes.NpgsqlLine(a: 0.5718493196351406d, b: 0.8523339688891789d, c: 0.9362818157045193d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30064598929798536d, b: 0.6311797948278274d, c: 0.969648204730501d),
new NpgsqlTypes.NpgsqlLine(a: 0.5865763643994367d, b: 0.12824636374437637d, c: 0.663180224895782d),
new NpgsqlTypes.NpgsqlLine(a: 0.4991106371994173d, b: 0.6732182185134421d, c: 0.1109614582119105d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.648773591095091d, b: 0.8948811853811129d, c: 0.8856320609305478d),
new NpgsqlTypes.NpgsqlLine(a: 0.5112033066956255d, b: 0.782786271492041d, c: 0.08246894218221157d),
new NpgsqlTypes.NpgsqlLine(a: 0.41186837625848016d, b: 0.8038075001073777d, c: 0.2329399666159665d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7140506816155466d, b: 0.8063676108250696d, c: 0.3095172678059751d),
new NpgsqlTypes.NpgsqlLine(a: 0.5796791184771042d, b: 0.8916280660917901d, c: 0.6278091832840931d),
new NpgsqlTypes.NpgsqlLine(a: 0.12136266391816042d, b: 0.7127074818528668d, c: 0.66077739379601d),
new NpgsqlTypes.NpgsqlLine(a: 0.6376472858355442d, b: 0.3222384312461052d, c: 0.1684187466000222d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04886964620162604d, b: 0.44705354062723945d, c: 0.14939181911550525d),
new NpgsqlTypes.NpgsqlLine(a: 0.17133893972817427d, b: 0.8293098391975592d, c: 0.3626706285438187d),
new NpgsqlTypes.NpgsqlLine(a: 0.784792944220586d, b: 0.13074501575415365d, c: 0.6569355661463877d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8917444854189789d, b: 0.9001398447357726d, c: 0.777420744428556d),
new NpgsqlTypes.NpgsqlLine(a: 0.8457070307723573d, b: 0.14378267232671404d, c: 0.18398908210887688d),
new NpgsqlTypes.NpgsqlLine(a: 0.5614264596862756d, b: 0.5467833795097533d, c: 0.8924888089671511d),
new NpgsqlTypes.NpgsqlLine(a: 0.30880575713241765d, b: 0.2641504240276308d, c: 0.8576520990246193d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8296279874732152d, b: 0.06102817100834479d, c: 0.23163153754021093d),
new NpgsqlTypes.NpgsqlLine(a: 0.17528127445046193d, b: 0.21380024727357694d, c: 0.20625246883635884d),
new NpgsqlTypes.NpgsqlLine(a: 0.10136164511174872d, b: 0.38499822889835666d, c: 0.719776065301031d),
new NpgsqlTypes.NpgsqlLine(a: 0.45855088664361376d, b: 0.8027020166188853d, c: 0.16644371965890392d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5833801860419559d, b: 0.9500124354651288d, c: 0.7411404330401283d),
new NpgsqlTypes.NpgsqlLine(a: 0.3099135810217988d, b: 0.1354848540401754d, c: 0.8084245079167349d),
new NpgsqlTypes.NpgsqlLine(a: 0.33651629077824696d, b: 0.3946042970793264d, c: 0.6217932097139066d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.511089027342206d, b: 0.502148390183326d, c: 0.7240838643278317d),
new NpgsqlTypes.NpgsqlLine(a: 0.5648110005974407d, b: 0.15054277224158086d, c: 0.38742322167801835d),
new NpgsqlTypes.NpgsqlLine(a: 0.3295796866298647d, b: 0.24954368055258225d, c: 0.01614288159520383d),
new NpgsqlTypes.NpgsqlLine(a: 0.4664523479533528d, b: 0.0011151435742465798d, c: 0.37487140551701614d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9832064571541465d, b: 0.49414400962086946d, c: 0.9379473254659663d),
new NpgsqlTypes.NpgsqlLine(a: 0.49704451482351764d, b: 0.2014818266951669d, c: 0.962191814907303d),
new NpgsqlTypes.NpgsqlLine(a: 0.6258166876011259d, b: 0.5693228548561675d, c: 0.9399688877512627d),
new NpgsqlTypes.NpgsqlLine(a: 0.7773646724080272d, b: 0.22391095213289225d, c: 0.6851505526531171d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23002262940260632d, b: 0.8420626525155168d, c: 0.17481641781802326d),
new NpgsqlTypes.NpgsqlLine(a: 0.505545075051217d, b: 0.5839391578061959d, c: 0.3055031234868488d),
new NpgsqlTypes.NpgsqlLine(a: 0.444571923572352d, b: 0.008843162635666535d, c: 0.6020220986031749d),
new NpgsqlTypes.NpgsqlLine(a: 0.054380051534117624d, b: 0.2232970364907917d, c: 0.6225081977314565d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6715433633376203d, b: 0.8626878964284888d, c: 0.17170859668570082d),
new NpgsqlTypes.NpgsqlLine(a: 0.779508809625046d, b: 0.8406593573132768d, c: 0.45651623319460843d),
new NpgsqlTypes.NpgsqlLine(a: 0.23103798698162847d, b: 0.3462975360536331d, c: 0.49183461937420636d),
new NpgsqlTypes.NpgsqlLine(a: 0.9493045001286994d, b: 0.5543589125412114d, c: 0.08529748823027583d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43163409446437806d, b: 0.5898592517280301d, c: 0.9060345226985835d),
new NpgsqlTypes.NpgsqlLine(a: 0.09623596647376287d, b: 0.22474701003234243d, c: 0.4401415629515104d),
new NpgsqlTypes.NpgsqlLine(a: 0.4134187129253415d, b: 0.15900938616987725d, c: 0.21548930285874346d),
new NpgsqlTypes.NpgsqlLine(a: 0.6247374109475599d, b: 0.8813968918961022d, c: 0.08644596719133169d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6757500970751958d, b: 0.6368114321156586d, c: 0.6430077611967339d),
new NpgsqlTypes.NpgsqlLine(a: 0.2885421326972176d, b: 0.07922576489582223d, c: 0.6606889539682446d),
new NpgsqlTypes.NpgsqlLine(a: 0.3261388935776507d, b: 0.9959650175309771d, c: 0.9848588047342697d),
new NpgsqlTypes.NpgsqlLine(a: 0.0820377033922105d, b: 0.7197536966727008d, c: 0.41525833798463463d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1843904139011484d, b: 0.4001870488267949d, c: 0.7907821848405214d),
new NpgsqlTypes.NpgsqlLine(a: 0.5656909376723119d, b: 0.8514805435088976d, c: 0.7030609961776918d),
new NpgsqlTypes.NpgsqlLine(a: 0.038279188374408135d, b: 0.6121487145226545d, c: 0.15157565884682533d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3603251272125655d, b: 0.15689744286541996d, c: 0.6252948309969902d),
new NpgsqlTypes.NpgsqlLine(a: 0.9287085670184825d, b: 0.13277446921247693d, c: 0.7114831427135054d),
new NpgsqlTypes.NpgsqlLine(a: 0.8232549115033267d, b: 0.0695858763951761d, c: 0.07174392584784672d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8554929050501133d, b: 0.012372843914289389d, c: 0.07817655892458797d),
new NpgsqlTypes.NpgsqlLine(a: 0.19205820570995957d, b: 0.67522781126166d, c: 0.531393237535508d),
new NpgsqlTypes.NpgsqlLine(a: 0.912897541780173d, b: 0.01858947839743952d, c: 0.8895822158347547d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.02828019145936378d, b: 0.6817296805832744d, c: 0.30106000598699667d),
new NpgsqlTypes.NpgsqlLine(a: 0.14700508544146196d, b: 0.05555131350222242d, c: 0.054096297298518614d),
new NpgsqlTypes.NpgsqlLine(a: 0.9479059456417179d, b: 0.762448261751791d, c: 0.907264631620467d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5154164627737984d, b: 0.0526155897293451d, c: 0.5349258754011873d),
new NpgsqlTypes.NpgsqlLine(a: 0.23297266162083663d, b: 0.5240432025977212d, c: 0.8932563962504015d),
new NpgsqlTypes.NpgsqlLine(a: 0.4807170211205274d, b: 0.11536751146667212d, c: 0.00597010501094597d),
new NpgsqlTypes.NpgsqlLine(a: 0.5295028544770325d, b: 0.7384072427405426d, c: 0.4732849264518396d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18722926730482947d, b: 0.1076269361914105d, c: 0.08509075905426189d),
new NpgsqlTypes.NpgsqlLine(a: 0.12926868446325857d, b: 0.7792698676265636d, c: 0.41149473522762836d),
new NpgsqlTypes.NpgsqlLine(a: 0.6936133161178235d, b: 0.8861938924383296d, c: 0.1385795637661671d),
new NpgsqlTypes.NpgsqlLine(a: 0.18245778505912646d, b: 0.11129411354842222d, c: 0.602215814111732d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27816414219774277d, b: 0.9962348354003083d, c: 0.5794456084476736d),
new NpgsqlTypes.NpgsqlLine(a: 0.5424522470494307d, b: 0.6938880625998579d, c: 0.9715057022266662d),
new NpgsqlTypes.NpgsqlLine(a: 0.28321863379724854d, b: 0.009569827251922458d, c: 0.681369972410414d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9151357335851851d, b: 0.13525133427208902d, c: 0.9309069114841745d),
new NpgsqlTypes.NpgsqlLine(a: 0.5695189577239516d, b: 0.5749089636811552d, c: 0.6460117636225446d),
new NpgsqlTypes.NpgsqlLine(a: 0.7308189438062977d, b: 0.6951475562557902d, c: 0.0379122751542178d),
new NpgsqlTypes.NpgsqlLine(a: 0.08942864863609368d, b: 0.1328208221471694d, c: 0.4301947774693148d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6790498131045732d, b: 0.7601047026166189d, c: 0.9866313909270455d),
new NpgsqlTypes.NpgsqlLine(a: 0.31444731263447645d, b: 0.8339980944542273d, c: 0.13375707858278996d),
new NpgsqlTypes.NpgsqlLine(a: 0.9911505832907942d, b: 0.7879742919848473d, c: 0.9966357158897934d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5398319890898727d, b: 0.8242505120531314d, c: 0.8418542399412525d),
new NpgsqlTypes.NpgsqlLine(a: 0.8496041705346079d, b: 0.8436268988235665d, c: 0.8030484690442956d),
new NpgsqlTypes.NpgsqlLine(a: 0.2700387265209392d, b: 0.18684441923297712d, c: 0.9219881216831358d),
new NpgsqlTypes.NpgsqlLine(a: 0.4643374922086272d, b: 0.2246917748053957d, c: 0.0017062883192292544d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14315023209399347d, b: 0.5523087089309069d, c: 0.9780648079728199d),
new NpgsqlTypes.NpgsqlLine(a: 0.16664171367399416d, b: 0.49046187794655927d, c: 0.8098945798759912d),
new NpgsqlTypes.NpgsqlLine(a: 0.23256438444615546d, b: 0.8369614424518118d, c: 0.11688926286466483d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6553276648527947d, b: 0.763908140305775d, c: 0.24797156070066073d),
new NpgsqlTypes.NpgsqlLine(a: 0.2180180648660599d, b: 0.19401675951439312d, c: 0.6173550590461726d),
new NpgsqlTypes.NpgsqlLine(a: 0.9436682506848966d, b: 0.24336095916111655d, c: 0.832786672155963d),
new NpgsqlTypes.NpgsqlLine(a: 0.5373907208802915d, b: 0.21744185157919216d, c: 0.5611217108706472d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7850088224943734d, b: 0.7545882354558874d, c: 0.5940015588541206d),
new NpgsqlTypes.NpgsqlLine(a: 0.7986974068015802d, b: 0.506924801385853d, c: 0.9353274221212238d),
new NpgsqlTypes.NpgsqlLine(a: 0.2527502521521513d, b: 0.029626723290612333d, c: 0.10554587542564509d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7276355831845724d, b: 0.30431385779983633d, c: 0.2015569494829489d),
new NpgsqlTypes.NpgsqlLine(a: 0.664571175611927d, b: 0.74190185067198d, c: 0.5280886155637946d),
new NpgsqlTypes.NpgsqlLine(a: 0.7715209669057723d, b: 0.2787427597841856d, c: 0.6943201736273719d),
new NpgsqlTypes.NpgsqlLine(a: 0.8828639160870598d, b: 0.10912848304881928d, c: 0.20204781523528492d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8712659634722083d, b: 0.376549330657475d, c: 0.9715901643200484d),
new NpgsqlTypes.NpgsqlLine(a: 0.7996010163915434d, b: 0.8805101748528229d, c: 0.3044436462800031d),
new NpgsqlTypes.NpgsqlLine(a: 0.35216414734992063d, b: 0.3673429667463811d, c: 0.3601798234069996d),
new NpgsqlTypes.NpgsqlLine(a: 0.41034350152045773d, b: 0.41078480660969474d, c: 0.8061753344885199d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7949946510712514d, b: 0.48617031117654885d, c: 0.0012365870216967112d),
new NpgsqlTypes.NpgsqlLine(a: 0.8124022898193574d, b: 0.5625267241423183d, c: 0.4667181455332735d),
new NpgsqlTypes.NpgsqlLine(a: 0.8791710691308755d, b: 0.27518626376891864d, c: 0.42759824587957784d),
new NpgsqlTypes.NpgsqlLine(a: 0.7709167529399181d, b: 0.7408189897831613d, c: 0.16519785029983602d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8967228615857858d, b: 0.32253374160037185d, c: 0.8220356557874976d),
new NpgsqlTypes.NpgsqlLine(a: 0.6127795625797905d, b: 0.7840123978604605d, c: 0.4742596857407486d),
new NpgsqlTypes.NpgsqlLine(a: 0.6894641971429539d, b: 0.8693740641972133d, c: 0.3871623899502238d),
new NpgsqlTypes.NpgsqlLine(a: 0.8697554950290671d, b: 0.29439161674497116d, c: 0.29782639652380993d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7566516574501352d, b: 0.5283770732431459d, c: 0.271390019596754d),
new NpgsqlTypes.NpgsqlLine(a: 0.7009733538472364d, b: 0.01169857823888254d, c: 0.6929047868129931d),
new NpgsqlTypes.NpgsqlLine(a: 0.25057516261694857d, b: 0.43361474935379973d, c: 0.9593864666981131d),
new NpgsqlTypes.NpgsqlLine(a: 0.4157036784033249d, b: 0.6977188311831404d, c: 0.48415721489939845d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.33277817667252596d, b: 0.02504452979891847d, c: 0.18773076643033237d),
new NpgsqlTypes.NpgsqlLine(a: 0.08166247343341104d, b: 0.904878859994948d, c: 0.09798446111347214d),
new NpgsqlTypes.NpgsqlLine(a: 0.5422673986376848d, b: 0.13764396547768043d, c: 0.06365124467719052d),
new NpgsqlTypes.NpgsqlLine(a: 0.2906519982598754d, b: 0.4462278133030855d, c: 0.16069259778646094d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40614600109248644d, b: 0.32072514290710097d, c: 0.07946813141113984d),
new NpgsqlTypes.NpgsqlLine(a: 0.6417852840750236d, b: 0.6228632454225735d, c: 0.4284463469901818d),
new NpgsqlTypes.NpgsqlLine(a: 0.8240755043104544d, b: 0.05370448444421727d, c: 0.3972557502835905d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9021577842186814d, b: 0.7378255136566589d, c: 0.8061415228438605d),
new NpgsqlTypes.NpgsqlLine(a: 0.9924844186731306d, b: 0.11784522621571492d, c: 0.3394893796639862d),
new NpgsqlTypes.NpgsqlLine(a: 0.8217966925952135d, b: 0.30756923528636315d, c: 0.6035128591452912d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8482094007425891d, b: 0.9789267088674511d, c: 0.13451530647643728d),
new NpgsqlTypes.NpgsqlLine(a: 0.6920033716221319d, b: 0.6196389315093727d, c: 0.48572143605098417d),
new NpgsqlTypes.NpgsqlLine(a: 0.19654704381072108d, b: 0.6851499602545604d, c: 0.5720302907001478d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2791572620032903d, b: 0.9269136291583585d, c: 0.029193166977487195d),
new NpgsqlTypes.NpgsqlLine(a: 0.11573164030025207d, b: 0.7989239213010421d, c: 0.3086883272911569d),
new NpgsqlTypes.NpgsqlLine(a: 0.24750282561276538d, b: 0.3386227214302442d, c: 0.6698478616001056d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9488252212197491d, b: 0.6700615459413614d, c: 0.6867169347388798d),
new NpgsqlTypes.NpgsqlLine(a: 0.012593250658454958d, b: 0.2099688337418414d, c: 0.36252913303992285d),
new NpgsqlTypes.NpgsqlLine(a: 0.5402797663418121d, b: 0.1696565674279099d, c: 0.2752294173822788d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.02056700879516149d, b: 0.36769443514370703d, c: 0.10628573520989415d),
new NpgsqlTypes.NpgsqlLine(a: 0.1923073607361775d, b: 0.2035775355458408d, c: 0.11839192096627604d),
new NpgsqlTypes.NpgsqlLine(a: 0.20609621685712243d, b: 0.5660759804529186d, c: 0.40014041290970537d),
new NpgsqlTypes.NpgsqlLine(a: 0.12727863702722297d, b: 0.16623644000385907d, c: 0.27515522912838597d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3001634626841989d, b: 0.5754275820514254d, c: 0.3833486529238761d),
new NpgsqlTypes.NpgsqlLine(a: 0.33747390304790614d, b: 0.8669916399954768d, c: 0.5809845269168972d),
new NpgsqlTypes.NpgsqlLine(a: 0.7877749477803372d, b: 0.13940690843059622d, c: 0.04979095674944667d),
new NpgsqlTypes.NpgsqlLine(a: 0.2290356553476255d, b: 0.3320496711072801d, c: 0.4165413258670124d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5060145064321131d, b: 0.42014163984160724d, c: 0.10766136876432186d),
new NpgsqlTypes.NpgsqlLine(a: 0.8444718530799636d, b: 0.42879658555598577d, c: 0.3447577058224298d),
new NpgsqlTypes.NpgsqlLine(a: 0.28525475716166915d, b: 0.736367037444692d, c: 0.4647022589978844d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9788310086300834d, b: 0.9589707022568745d, c: 0.42734022982450626d),
new NpgsqlTypes.NpgsqlLine(a: 0.7306804113897968d, b: 0.263327334458889d, c: 0.6579065600203814d),
new NpgsqlTypes.NpgsqlLine(a: 0.4316452103546913d, b: 0.24961353533621422d, c: 0.800395077320054d),
new NpgsqlTypes.NpgsqlLine(a: 0.4446579718490885d, b: 0.2831068978215956d, c: 0.0849074214717388d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2854784876549583d, b: 0.8879271475314557d, c: 0.17223736432042636d),
new NpgsqlTypes.NpgsqlLine(a: 0.1806247644232244d, b: 0.5393761924365259d, c: 0.6185496379441174d),
new NpgsqlTypes.NpgsqlLine(a: 0.8859778372633335d, b: 0.7639060592810807d, c: 0.7787314485027881d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5501555468144681d, b: 0.3291171626321283d, c: 0.265948306855987d),
new NpgsqlTypes.NpgsqlLine(a: 0.44663584655018573d, b: 0.07463614854224809d, c: 0.0490374513168067d),
new NpgsqlTypes.NpgsqlLine(a: 0.20893424958231244d, b: 0.38166184133211634d, c: 0.24920675941889192d),
new NpgsqlTypes.NpgsqlLine(a: 0.7638736581185126d, b: 0.6738388655263867d, c: 0.6189546135618972d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5641702794486514d, b: 0.6132288185982062d, c: 0.7025489635120026d),
new NpgsqlTypes.NpgsqlLine(a: 0.038737624193201925d, b: 0.3027350199351525d, c: 0.17789047556699944d),
new NpgsqlTypes.NpgsqlLine(a: 0.8105636333671293d, b: 0.07880503380493498d, c: 0.1150073736754611d),
new NpgsqlTypes.NpgsqlLine(a: 0.9735293100564051d, b: 0.19907202668433244d, c: 0.09454083436067451d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2673479626485814d, b: 0.2901864448521766d, c: 0.5894861124751464d),
new NpgsqlTypes.NpgsqlLine(a: 0.175461152896064d, b: 0.3738620994888917d, c: 0.4633560218834718d),
new NpgsqlTypes.NpgsqlLine(a: 0.0475070637168431d, b: 0.8126501172310557d, c: 0.04514383912757036d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4001286998153518d, b: 0.20813811879406496d, c: 0.1368063392702107d),
new NpgsqlTypes.NpgsqlLine(a: 0.2929110196814044d, b: 0.9011626589044394d, c: 0.7095205473643577d),
new NpgsqlTypes.NpgsqlLine(a: 0.6990442451992026d, b: 0.9239637319862863d, c: 0.2868981469758297d),
new NpgsqlTypes.NpgsqlLine(a: 0.6655540052660629d, b: 0.4520620977901406d, c: 0.25138593706034185d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7267434077676996d, b: 0.0979743756940823d, c: 0.914649559136462d),
new NpgsqlTypes.NpgsqlLine(a: 0.9272692730722017d, b: 0.533449497550369d, c: 0.5307252841842363d),
new NpgsqlTypes.NpgsqlLine(a: 0.7307433797538517d, b: 0.2016042613874225d, c: 0.5689304839479183d),
new NpgsqlTypes.NpgsqlLine(a: 0.8184128900652765d, b: 0.5252629350833732d, c: 0.031684810907025684d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9880634032822985d, b: 0.27929390709244517d, c: 0.050864087026244675d),
new NpgsqlTypes.NpgsqlLine(a: 0.5592967815996697d, b: 0.893695859349277d, c: 0.3013890240465473d),
new NpgsqlTypes.NpgsqlLine(a: 0.5745730499871489d, b: 0.8841616054406356d, c: 0.19658569170325535d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19485318213811276d, b: 0.5841658909931242d, c: 0.9230952741431045d),
new NpgsqlTypes.NpgsqlLine(a: 0.7902439034053201d, b: 0.909481184327465d, c: 0.8413918134126034d),
new NpgsqlTypes.NpgsqlLine(a: 0.5305946042173185d, b: 0.45145761812480756d, c: 0.4593368617562341d),
new NpgsqlTypes.NpgsqlLine(a: 0.8793804372905055d, b: 0.23583616116752992d, c: 0.15551891812577578d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9593135638777535d, b: 0.5310307580146001d, c: 0.2698017988369771d),
new NpgsqlTypes.NpgsqlLine(a: 0.08059760502168323d, b: 0.9452758324576542d, c: 0.1588442030334707d),
new NpgsqlTypes.NpgsqlLine(a: 0.9537773735101811d, b: 0.599782163471585d, c: 0.07334772787766797d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6498377443978325d, b: 0.5748140867825082d, c: 0.5076861080542724d),
new NpgsqlTypes.NpgsqlLine(a: 0.8716886209002512d, b: 0.1961866701522701d, c: 0.39080146907318847d),
new NpgsqlTypes.NpgsqlLine(a: 0.623241454115115d, b: 0.08221756982194617d, c: 0.5681866312235165d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 182,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.716269020713137d, b: 0.06280175256164844d, c: 0.13936997774990156d),
new NpgsqlTypes.NpgsqlLine(a: 0.4083809382846677d, b: 0.1186942968565885d, c: 0.8327185252435788d),
new NpgsqlTypes.NpgsqlLine(a: 0.4801238098526105d, b: 0.10637011464663282d, c: 0.6936596122523404d),
new NpgsqlTypes.NpgsqlLine(a: 0.6935354712763314d, b: 0.14355913605488346d, c: 0.3293701602882375d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3682425821227753d, b: 0.5940978048197736d, c: 0.774266660459965d),
new NpgsqlTypes.NpgsqlLine(a: 0.5780281182867876d, b: 0.11115343601281469d, c: 0.38411872133277514d),
new NpgsqlTypes.NpgsqlLine(a: 0.6809817973528268d, b: 0.272289948631367d, c: 0.9815272441011577d),
new NpgsqlTypes.NpgsqlLine(a: 0.40328340705806687d, b: 0.6688899308763269d, c: 0.12512044517413068d),
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2350059234551004d, b: 0.3450261755308123d, c: 0.6951576778348667d),
new NpgsqlTypes.NpgsqlLine(a: 0.41570106480659463d, b: 0.8587397860531011d, c: 0.1679477886264189d),
new NpgsqlTypes.NpgsqlLine(a: 0.2142189543608488d, b: 0.7582073455447559d, c: 0.41859355108566954d),
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
new NpgsqlTypes.NpgsqlLine(a: 0.18672037795348095d, b: 0.33495307577434796d, c: 0.9291286282439698d),
new NpgsqlTypes.NpgsqlLine(a: 0.7527388339034775d, b: 0.04046625841795748d, c: 0.5304378551942759d),
new NpgsqlTypes.NpgsqlLine(a: 0.3794056830702529d, b: 0.046815899397805505d, c: 0.8325678155927364d),
new NpgsqlTypes.NpgsqlLine(a: 0.4491242515388869d, b: 0.7201253845705741d, c: 0.29880276018379004d),
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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30064598929798536d, b: 0.6311797948278274d, c: 0.969648204730501d),
new NpgsqlTypes.NpgsqlLine(a: 0.5865763643994367d, b: 0.12824636374437637d, c: 0.663180224895782d),
new NpgsqlTypes.NpgsqlLine(a: 0.4991106371994173d, b: 0.6732182185134421d, c: 0.1109614582119105d),
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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7140506816155466d, b: 0.8063676108250696d, c: 0.3095172678059751d),
new NpgsqlTypes.NpgsqlLine(a: 0.5796791184771042d, b: 0.8916280660917901d, c: 0.6278091832840931d),
new NpgsqlTypes.NpgsqlLine(a: 0.12136266391816042d, b: 0.7127074818528668d, c: 0.66077739379601d),
new NpgsqlTypes.NpgsqlLine(a: 0.6376472858355442d, b: 0.3222384312461052d, c: 0.1684187466000222d),
}));
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8296279874732152d, b: 0.06102817100834479d, c: 0.23163153754021093d),
new NpgsqlTypes.NpgsqlLine(a: 0.17528127445046193d, b: 0.21380024727357694d, c: 0.20625246883635884d),
new NpgsqlTypes.NpgsqlLine(a: 0.10136164511174872d, b: 0.38499822889835666d, c: 0.719776065301031d),
new NpgsqlTypes.NpgsqlLine(a: 0.45855088664361376d, b: 0.8027020166188853d, c: 0.16644371965890392d),
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
new NpgsqlTypes.NpgsqlLine(a: 0.511089027342206d, b: 0.502148390183326d, c: 0.7240838643278317d),
new NpgsqlTypes.NpgsqlLine(a: 0.5648110005974407d, b: 0.15054277224158086d, c: 0.38742322167801835d),
new NpgsqlTypes.NpgsqlLine(a: 0.3295796866298647d, b: 0.24954368055258225d, c: 0.01614288159520383d),
new NpgsqlTypes.NpgsqlLine(a: 0.4664523479533528d, b: 0.0011151435742465798d, c: 0.37487140551701614d),
}));
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                parametr1.Value = 131;
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
FROM public.npgsqllinelinearray1m m
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
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 166, query1, 35, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 109, query1, 109, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatchAsync(connection, 35, 17))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[4], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[5], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[6], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[24],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[2], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[3], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[4], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[5], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[6], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[24],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[25],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[26],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[27],_testData[29], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatch(connection, 141, 131))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[29], false);
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
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 149);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
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

