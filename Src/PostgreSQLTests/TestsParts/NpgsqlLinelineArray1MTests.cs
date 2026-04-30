

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
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5405018022846702d, b: 0.12428962417035139d, c: 0.676740491792959d),
new NpgsqlTypes.NpgsqlLine(a: 0.06920199332925303d, b: 0.060526208204487286d, c: 0.3815461797147782d),
new NpgsqlTypes.NpgsqlLine(a: 0.47768990361587593d, b: 0.12991400877889703d, c: 0.10899284565397971d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5951918381034829d, b: 0.44486172066550966d, c: 0.3948336838305446d),
new NpgsqlTypes.NpgsqlLine(a: 0.30503344259237286d, b: 0.30025779687073695d, c: 0.7751900854493075d),
new NpgsqlTypes.NpgsqlLine(a: 0.38803039277987683d, b: 0.27428133033918134d, c: 0.5814837258440808d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1323667394835616d, b: 0.11117459848940725d, c: 0.6720435642195698d),
new NpgsqlTypes.NpgsqlLine(a: 0.6118831169079667d, b: 0.04856046051720997d, c: 0.38234508044978477d),
new NpgsqlTypes.NpgsqlLine(a: 0.058393443193271555d, b: 0.023732124932284382d, c: 0.8896193134158592d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12790067039600894d, b: 0.2380708644846753d, c: 0.9325529387726658d),
new NpgsqlTypes.NpgsqlLine(a: 0.5316933615107499d, b: 0.9049263423929034d, c: 0.06785078271712408d),
new NpgsqlTypes.NpgsqlLine(a: 0.9299741911242645d, b: 0.32898337330082317d, c: 0.14745610636958273d),
new NpgsqlTypes.NpgsqlLine(a: 0.41348220310118844d, b: 0.5238514256553229d, c: 0.8264229563401191d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.41542123044446777d, b: 0.37995050875000413d, c: 0.91220225828418d),
new NpgsqlTypes.NpgsqlLine(a: 0.24074119067785982d, b: 0.7721816730962932d, c: 0.17599345939693423d),
new NpgsqlTypes.NpgsqlLine(a: 0.20489910634877073d, b: 0.3653782742440226d, c: 0.4052182495407728d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7936978053867563d, b: 0.9246510321188116d, c: 0.6084740328089946d),
new NpgsqlTypes.NpgsqlLine(a: 0.8368185582994617d, b: 0.1573199990101729d, c: 0.11322661619034502d),
new NpgsqlTypes.NpgsqlLine(a: 0.011822528574673474d, b: 0.8914930087346111d, c: 0.2931529457957499d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9504156329677802d, b: 0.6348045063494728d, c: 0.5633127582282391d),
new NpgsqlTypes.NpgsqlLine(a: 0.19044711011084559d, b: 0.2587544744191691d, c: 0.00940959738323588d),
new NpgsqlTypes.NpgsqlLine(a: 0.3897478991576122d, b: 0.843601203011667d, c: 0.07674664142462695d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6775474756795609d, b: 0.4744365988434487d, c: 0.49652425362649155d),
new NpgsqlTypes.NpgsqlLine(a: 0.2865017607784519d, b: 0.8731612149662801d, c: 0.14434738324013618d),
new NpgsqlTypes.NpgsqlLine(a: 0.8405543891027548d, b: 0.011318052723624294d, c: 0.4640502941602406d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8172805767087653d, b: 0.5894913541849055d, c: 0.905574403648378d),
new NpgsqlTypes.NpgsqlLine(a: 0.4345150416220155d, b: 0.4048484111087839d, c: 0.36270932519630483d),
new NpgsqlTypes.NpgsqlLine(a: 0.425372300141337d, b: 0.8344936635996361d, c: 0.6187223066047721d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8860034726347722d, b: 0.74770514033192d, c: 0.9332749030174732d),
new NpgsqlTypes.NpgsqlLine(a: 0.3910807011477001d, b: 0.48213001953470225d, c: 0.44166619483853564d),
new NpgsqlTypes.NpgsqlLine(a: 0.6560435665716154d, b: 0.3901003897779183d, c: 0.8322640034144171d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.043180137527191964d, b: 0.2649490049398563d, c: 0.513203909987827d),
new NpgsqlTypes.NpgsqlLine(a: 0.06768328961920411d, b: 0.9866847520724618d, c: 0.9540588682892387d),
new NpgsqlTypes.NpgsqlLine(a: 0.6826044575182582d, b: 0.3268600883362237d, c: 0.7616937450292993d),
new NpgsqlTypes.NpgsqlLine(a: 0.7872149388143209d, b: 0.9170796083565373d, c: 0.36573478159765105d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9080248743538458d, b: 0.5054907136364007d, c: 0.784370999497996d),
new NpgsqlTypes.NpgsqlLine(a: 0.919893758713538d, b: 0.3468711530327644d, c: 0.6686983267219501d),
new NpgsqlTypes.NpgsqlLine(a: 0.45320554674709035d, b: 0.45757728397162034d, c: 0.5150373637050373d),
new NpgsqlTypes.NpgsqlLine(a: 0.11289821571320291d, b: 0.622088294457457d, c: 0.7418307654914226d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7544610087638313d, b: 0.9611543672031256d, c: 0.6184584136965771d),
new NpgsqlTypes.NpgsqlLine(a: 0.8611778113143415d, b: 0.7679403508525956d, c: 0.0018925922779500226d),
new NpgsqlTypes.NpgsqlLine(a: 0.5852097487800912d, b: 0.8920256344309299d, c: 0.05850643451691706d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9175807045321244d, b: 0.8041875492656966d, c: 0.9723340110576457d),
new NpgsqlTypes.NpgsqlLine(a: 0.9127405229203069d, b: 0.05576662713149605d, c: 0.4886868512372555d),
new NpgsqlTypes.NpgsqlLine(a: 0.023658266964005636d, b: 0.25863171046493005d, c: 0.40802723173888733d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3953023524354111d, b: 0.7682618316646248d, c: 0.67841648365057d),
new NpgsqlTypes.NpgsqlLine(a: 0.09163384351500725d, b: 0.16099846235056703d, c: 0.8416004252494912d),
new NpgsqlTypes.NpgsqlLine(a: 0.622512242690671d, b: 0.7888185490062886d, c: 0.9173503845925904d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.66719597469285d, b: 0.8657107876939235d, c: 0.9106654790772885d),
new NpgsqlTypes.NpgsqlLine(a: 0.5319280876124103d, b: 0.16464903104646422d, c: 0.8527700876978566d),
new NpgsqlTypes.NpgsqlLine(a: 0.6421042172804333d, b: 0.42331708761551823d, c: 0.28483770566613453d),
new NpgsqlTypes.NpgsqlLine(a: 0.7072625423341291d, b: 0.35452025608386784d, c: 0.370014033376474d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10632325745890792d, b: 0.1666835879967995d, c: 0.6295427338171041d),
new NpgsqlTypes.NpgsqlLine(a: 0.5267106488248837d, b: 0.0769838046219925d, c: 0.6301364713045976d),
new NpgsqlTypes.NpgsqlLine(a: 0.8691403278874698d, b: 0.7060140700913263d, c: 0.06754037854331696d),
new NpgsqlTypes.NpgsqlLine(a: 0.5915165217967403d, b: 0.19660040476594132d, c: 0.030540907812583784d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5637753841705299d, b: 0.929038780647315d, c: 0.3615014878603783d),
new NpgsqlTypes.NpgsqlLine(a: 0.06133949978874531d, b: 0.2720448270058483d, c: 0.7735643905042823d),
new NpgsqlTypes.NpgsqlLine(a: 0.6465356097754954d, b: 0.7760244365775412d, c: 0.26281525690162755d),
new NpgsqlTypes.NpgsqlLine(a: 0.598875749721384d, b: 0.3579511436851438d, c: 0.003950541134038366d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.006281197288007134d, b: 0.7027481577950558d, c: 0.11680684984131673d),
new NpgsqlTypes.NpgsqlLine(a: 0.7848660582338605d, b: 0.7961863360514561d, c: 0.5430396897946003d),
new NpgsqlTypes.NpgsqlLine(a: 0.8773117319016297d, b: 0.6556881152367681d, c: 0.9521944525733844d),
new NpgsqlTypes.NpgsqlLine(a: 0.3424637388138587d, b: 0.30300421864761784d, c: 0.025346932569152547d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.06768826321390464d, b: 0.6249634526992164d, c: 0.45519869455347695d),
new NpgsqlTypes.NpgsqlLine(a: 0.3769354330835907d, b: 0.8037589419977089d, c: 0.6401539020249569d),
new NpgsqlTypes.NpgsqlLine(a: 0.7225958809220447d, b: 0.4483545536666993d, c: 0.7043824111155736d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3569784827407195d, b: 0.33965732351817823d, c: 0.5830320204769872d),
new NpgsqlTypes.NpgsqlLine(a: 0.8566068613533677d, b: 0.578015633658878d, c: 0.8956744699669815d),
new NpgsqlTypes.NpgsqlLine(a: 0.3807904002220974d, b: 0.10274774388270225d, c: 0.7112865775437093d),
new NpgsqlTypes.NpgsqlLine(a: 0.5000829529192545d, b: 0.6667314360623843d, c: 0.25568939696435655d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6581842242093608d, b: 0.08479255631548166d, c: 0.04305327493722455d),
new NpgsqlTypes.NpgsqlLine(a: 0.44010921053834984d, b: 0.7596762849200407d, c: 0.10571302735273413d),
new NpgsqlTypes.NpgsqlLine(a: 0.7032475456887851d, b: 0.17346875496035263d, c: 0.543191824919086d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09620410253410006d, b: 0.6453686554542972d, c: 0.3981134214117342d),
new NpgsqlTypes.NpgsqlLine(a: 0.9332747751491693d, b: 0.696215208584733d, c: 0.8060182131273705d),
new NpgsqlTypes.NpgsqlLine(a: 0.26808497060663883d, b: 0.22338511751902723d, c: 0.09217902681853185d),
new NpgsqlTypes.NpgsqlLine(a: 0.9697603157897708d, b: 0.9657208493754101d, c: 0.238428622211734d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5668491201815448d, b: 0.5932903507111701d, c: 0.5422633814635917d),
new NpgsqlTypes.NpgsqlLine(a: 0.5601286847783468d, b: 0.3377228863977473d, c: 0.5580261860758274d),
new NpgsqlTypes.NpgsqlLine(a: 0.37425328158907434d, b: 0.6012891516741304d, c: 0.7292973105961793d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6341553270468504d, b: 0.04274322647890849d, c: 0.14211615262937238d),
new NpgsqlTypes.NpgsqlLine(a: 0.5537645945142848d, b: 0.7991150096238859d, c: 0.28928518531527736d),
new NpgsqlTypes.NpgsqlLine(a: 0.9803000267702415d, b: 0.31102175417669353d, c: 0.9799644831774268d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05092033179338473d, b: 0.28205309948208157d, c: 0.13283704492886572d),
new NpgsqlTypes.NpgsqlLine(a: 0.34677116269938213d, b: 0.9585173888292067d, c: 0.5287923715867611d),
new NpgsqlTypes.NpgsqlLine(a: 0.39113833521881713d, b: 0.5609450479399863d, c: 0.04235440677636304d),
new NpgsqlTypes.NpgsqlLine(a: 0.5754180737867169d, b: 0.10062212719051511d, c: 0.8559926960831047d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49224789012955084d, b: 0.7765854598116472d, c: 0.3106381745345137d),
new NpgsqlTypes.NpgsqlLine(a: 0.8218281314016029d, b: 0.38584030605623887d, c: 0.1155591614927648d),
new NpgsqlTypes.NpgsqlLine(a: 0.07781419666052858d, b: 0.26159786427669385d, c: 0.06927854120242172d),
new NpgsqlTypes.NpgsqlLine(a: 0.1259303421175597d, b: 0.4017966328590068d, c: 0.8194074862040367d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43897293893512535d, b: 0.9133540307581595d, c: 0.6462565645082748d),
new NpgsqlTypes.NpgsqlLine(a: 0.7006625034378415d, b: 0.8919831711687278d, c: 0.8287950622195119d),
new NpgsqlTypes.NpgsqlLine(a: 0.16444313274485056d, b: 0.5444068140737304d, c: 0.9604545557936462d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.02162879022121722d, b: 0.29873932313588647d, c: 0.314711529967008d),
new NpgsqlTypes.NpgsqlLine(a: 0.9102444057231596d, b: 0.360022390984871d, c: 0.11000888579424473d),
new NpgsqlTypes.NpgsqlLine(a: 0.9706234001874707d, b: 0.594487063869066d, c: 0.14641872289765456d),
new NpgsqlTypes.NpgsqlLine(a: 0.06691347321554497d, b: 0.6821366286145095d, c: 0.7241506054922688d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5647971273840307d, b: 0.1474231644681384d, c: 0.7519791877378195d),
new NpgsqlTypes.NpgsqlLine(a: 0.841129830706699d, b: 0.5210763148663327d, c: 0.11797208930927472d),
new NpgsqlTypes.NpgsqlLine(a: 0.5269535052034043d, b: 0.2673567092101369d, c: 0.6307069018447361d),
new NpgsqlTypes.NpgsqlLine(a: 0.3269659217537947d, b: 0.8719200687277266d, c: 0.13035671834678086d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.42919772575249104d, b: 0.809096835171754d, c: 0.47847814231406816d),
new NpgsqlTypes.NpgsqlLine(a: 0.5509907925789601d, b: 0.24227441544608552d, c: 0.2255727425298244d),
new NpgsqlTypes.NpgsqlLine(a: 0.9649588482007156d, b: 0.08505122727351211d, c: 0.5208761906220559d),
new NpgsqlTypes.NpgsqlLine(a: 0.281034278932595d, b: 0.5090085407074466d, c: 0.8236829763858622d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9068840183231147d, b: 0.7213030500559378d, c: 0.6521890380868389d),
new NpgsqlTypes.NpgsqlLine(a: 0.9353987697383446d, b: 0.6314535715062732d, c: 0.6934298572801452d),
new NpgsqlTypes.NpgsqlLine(a: 0.7960894013018294d, b: 0.3476125965110868d, c: 0.7966334856527292d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3346598735013411d, b: 0.7181393611563256d, c: 0.6794963864499577d),
new NpgsqlTypes.NpgsqlLine(a: 0.5119783657883265d, b: 0.1803860912143782d, c: 0.1673359952095428d),
new NpgsqlTypes.NpgsqlLine(a: 0.3722300675975857d, b: 0.5100739060892259d, c: 0.9785844528530941d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08292143569149557d, b: 0.8084137329928311d, c: 0.5168291779435439d),
new NpgsqlTypes.NpgsqlLine(a: 0.9101485347296698d, b: 0.7874096829230569d, c: 0.22429947614816648d),
new NpgsqlTypes.NpgsqlLine(a: 0.7090197958798168d, b: 0.5514905540239421d, c: 0.5811009750474488d),
new NpgsqlTypes.NpgsqlLine(a: 0.25631280179711213d, b: 0.47689464360171097d, c: 0.634257072928767d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3048411057567314d, b: 0.96348369373899d, c: 0.014975627090595744d),
new NpgsqlTypes.NpgsqlLine(a: 0.5131094540689926d, b: 0.42767584924804325d, c: 0.8271563405453134d),
new NpgsqlTypes.NpgsqlLine(a: 0.6312492460975868d, b: 0.06711148528152588d, c: 0.9862766531055722d),
new NpgsqlTypes.NpgsqlLine(a: 0.046720549970662106d, b: 0.24563920140842466d, c: 0.6419016580607062d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1972865500904739d, b: 0.5640917432259469d, c: 0.2585374321080879d),
new NpgsqlTypes.NpgsqlLine(a: 0.8573297741926116d, b: 0.013367686249418309d, c: 0.38678478386370774d),
new NpgsqlTypes.NpgsqlLine(a: 0.4192076795223675d, b: 0.9316663736724322d, c: 0.9623556920454637d),
new NpgsqlTypes.NpgsqlLine(a: 0.9718081604281471d, b: 0.7273044405540547d, c: 0.6879319062609062d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04746872208847075d, b: 0.7890701064413327d, c: 0.7806756654035554d),
new NpgsqlTypes.NpgsqlLine(a: 0.48172541536876d, b: 0.8451822803859762d, c: 0.3090158508925268d),
new NpgsqlTypes.NpgsqlLine(a: 0.28932175402817306d, b: 0.8553818002443816d, c: 0.0004196458366503286d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09268637311706118d, b: 0.8140219888905994d, c: 0.14221768660478507d),
new NpgsqlTypes.NpgsqlLine(a: 0.8740066445581807d, b: 0.1328845048147741d, c: 0.42209435984051924d),
new NpgsqlTypes.NpgsqlLine(a: 0.7700163879855068d, b: 0.6867928572325668d, c: 0.13927247030837187d),
new NpgsqlTypes.NpgsqlLine(a: 0.1567310902094825d, b: 0.6890778471996276d, c: 0.5567301278298058d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10788944580002335d, b: 0.8689560561904519d, c: 0.7850656456579151d),
new NpgsqlTypes.NpgsqlLine(a: 0.15112076574917344d, b: 0.05597308292532688d, c: 0.021584249642944697d),
new NpgsqlTypes.NpgsqlLine(a: 0.0056817690906089124d, b: 0.43706855150937374d, c: 0.7623030870696245d),
new NpgsqlTypes.NpgsqlLine(a: 0.40827926315172813d, b: 0.46779846457239693d, c: 0.6881039481744556d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4713581130609026d, b: 0.7205896441342162d, c: 0.3508487166792691d),
new NpgsqlTypes.NpgsqlLine(a: 0.6884042132986247d, b: 0.9760902290774637d, c: 0.3630259902237186d),
new NpgsqlTypes.NpgsqlLine(a: 0.9691222306693777d, b: 0.8382800617195223d, c: 0.6921406479290911d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9206970779531509d, b: 0.2368629481777763d, c: 0.15477516226312793d),
new NpgsqlTypes.NpgsqlLine(a: 0.533618246609025d, b: 0.7575549527824339d, c: 0.6451415945015948d),
new NpgsqlTypes.NpgsqlLine(a: 0.25526025035143707d, b: 0.8955977955096586d, c: 0.9748975839544352d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.06869859454230831d, b: 0.3261604566152394d, c: 0.6606063960373056d),
new NpgsqlTypes.NpgsqlLine(a: 0.08221521751233651d, b: 0.8329731037752067d, c: 0.5968041382528994d),
new NpgsqlTypes.NpgsqlLine(a: 0.8269555856691948d, b: 0.22155343486521983d, c: 0.09418827808937769d),
new NpgsqlTypes.NpgsqlLine(a: 0.42268814175656955d, b: 0.9747374461993163d, c: 0.1308456853955522d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9223169621858024d, b: 0.7217161795803007d, c: 0.2678744030244341d),
new NpgsqlTypes.NpgsqlLine(a: 0.011350769751426792d, b: 0.686144492847248d, c: 0.6415457772423075d),
new NpgsqlTypes.NpgsqlLine(a: 0.19449117574503338d, b: 0.11360985385693112d, c: 0.5841115495439749d),
new NpgsqlTypes.NpgsqlLine(a: 0.08212264392290403d, b: 0.48446851483095654d, c: 0.010258880509211532d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5961142443613778d, b: 0.2835377340441403d, c: 0.27650298192857947d),
new NpgsqlTypes.NpgsqlLine(a: 0.2741944568282676d, b: 0.08980286990763664d, c: 0.7601361370538416d),
new NpgsqlTypes.NpgsqlLine(a: 0.0399710711028155d, b: 0.4444557554464298d, c: 0.8798435622350573d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30094704803805616d, b: 0.6876916673174284d, c: 0.7074362982455855d),
new NpgsqlTypes.NpgsqlLine(a: 0.5336133533366881d, b: 0.753402148613d, c: 0.6317319459228452d),
new NpgsqlTypes.NpgsqlLine(a: 0.9979342150574242d, b: 0.6095903115871513d, c: 0.5745554534871639d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7896456813827981d, b: 0.9393006331795204d, c: 0.5625075293124766d),
new NpgsqlTypes.NpgsqlLine(a: 0.37447758908650697d, b: 0.4986409701289156d, c: 0.3632778752875092d),
new NpgsqlTypes.NpgsqlLine(a: 0.13764756370386244d, b: 0.005207890617774491d, c: 0.29229432802140465d),
new NpgsqlTypes.NpgsqlLine(a: 0.3328508137704361d, b: 0.06951257801211841d, c: 0.38809728215538297d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09608850193568086d, b: 0.7474656149157719d, c: 0.9276672956422021d),
new NpgsqlTypes.NpgsqlLine(a: 0.8005815361145727d, b: 0.945053528332394d, c: 0.5581987832397381d),
new NpgsqlTypes.NpgsqlLine(a: 0.8926445566687305d, b: 0.4501717938836851d, c: 0.657866375908253d),
new NpgsqlTypes.NpgsqlLine(a: 0.3264851642768448d, b: 0.335452342052893d, c: 0.042316840523553556d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21680206327354912d, b: 0.07276521358132737d, c: 0.928080999278201d),
new NpgsqlTypes.NpgsqlLine(a: 0.5757319110628717d, b: 0.8002810744505984d, c: 0.6002890826275686d),
new NpgsqlTypes.NpgsqlLine(a: 0.3061868100683912d, b: 0.7926321094167944d, c: 0.8024198625566623d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6885156452973997d, b: 0.3921443415706578d, c: 0.9280243734618612d),
new NpgsqlTypes.NpgsqlLine(a: 0.29210251724105096d, b: 0.4500108811384471d, c: 0.5990621021757296d),
new NpgsqlTypes.NpgsqlLine(a: 0.48163831627937614d, b: 0.9614420378444694d, c: 0.04454063886811643d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8501655031237523d, b: 0.7461071798871366d, c: 0.9434113844037341d),
new NpgsqlTypes.NpgsqlLine(a: 0.30450046377039364d, b: 0.8849195062229811d, c: 0.22150695722228686d),
new NpgsqlTypes.NpgsqlLine(a: 0.9430053624126028d, b: 0.13414249302340853d, c: 0.6252609642948329d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.945329415240199d, b: 0.8164256037469458d, c: 0.2607430254338857d),
new NpgsqlTypes.NpgsqlLine(a: 0.8982292635521729d, b: 0.21608930929859171d, c: 0.2907836489994682d),
new NpgsqlTypes.NpgsqlLine(a: 0.46009108567088963d, b: 0.8053341886898403d, c: 0.846625568607271d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07378007712968593d, b: 0.5662898153366898d, c: 0.3516839292978299d),
new NpgsqlTypes.NpgsqlLine(a: 0.9106931587821293d, b: 0.4257699423479032d, c: 0.3994856211457867d),
new NpgsqlTypes.NpgsqlLine(a: 0.5688159373273812d, b: 0.5039739482482727d, c: 0.7134950136957511d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.38035682547674d, b: 0.3308462105401785d, c: 0.391288539958063d),
new NpgsqlTypes.NpgsqlLine(a: 0.4713030136792985d, b: 0.31179252669482493d, c: 0.18318192528138044d),
new NpgsqlTypes.NpgsqlLine(a: 0.4107913958702203d, b: 0.2713727255112053d, c: 0.3484289790523938d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11990361816487705d, b: 0.30917205414986526d, c: 0.05333782582738167d),
new NpgsqlTypes.NpgsqlLine(a: 0.48785212250965526d, b: 0.28225242383107063d, c: 0.730346673426957d),
new NpgsqlTypes.NpgsqlLine(a: 0.030138474807296367d, b: 0.5323152181335209d, c: 0.5423794393702707d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3180511511329662d, b: 0.4248524150997055d, c: 0.6606463183543858d),
new NpgsqlTypes.NpgsqlLine(a: 0.6760408664628311d, b: 0.07691362813187352d, c: 0.007268136056755248d),
new NpgsqlTypes.NpgsqlLine(a: 0.8609045967615891d, b: 0.9314970385392537d, c: 0.28326585036119045d),
new NpgsqlTypes.NpgsqlLine(a: 0.10692132802223975d, b: 0.3456432301582494d, c: 0.652937446871025d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7828999269854477d, b: 0.2165437377465339d, c: 0.03703820150851689d),
new NpgsqlTypes.NpgsqlLine(a: 0.9630414609793029d, b: 0.7142105708730576d, c: 0.15263965185931183d),
new NpgsqlTypes.NpgsqlLine(a: 0.09572161286356828d, b: 0.37803778918408704d, c: 0.47993665594702317d),
new NpgsqlTypes.NpgsqlLine(a: 0.15012240443736513d, b: 0.7781670459286338d, c: 0.8763670701135743d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8476589943601043d, b: 0.9215476336123885d, c: 0.9699505106738754d),
new NpgsqlTypes.NpgsqlLine(a: 0.35317951951319615d, b: 0.24224182700832886d, c: 0.7525154205669521d),
new NpgsqlTypes.NpgsqlLine(a: 0.0637719227754121d, b: 0.38437823074338195d, c: 0.6302979846409092d),
new NpgsqlTypes.NpgsqlLine(a: 0.605715867533056d, b: 0.6255907405146673d, c: 0.26333421133015966d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8400504236921918d, b: 0.06142932033134252d, c: 0.17755855373089524d),
new NpgsqlTypes.NpgsqlLine(a: 0.010913348539594137d, b: 0.5981691308937127d, c: 0.021532668623499007d),
new NpgsqlTypes.NpgsqlLine(a: 0.5433462773287092d, b: 0.4833197164408497d, c: 0.9533428954007331d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6627460891010689d, b: 0.9902438838890383d, c: 0.6239463443578406d),
new NpgsqlTypes.NpgsqlLine(a: 0.48341843530506334d, b: 0.16058167547848645d, c: 0.33692702447795053d),
new NpgsqlTypes.NpgsqlLine(a: 0.5852875367589795d, b: 0.837026437193188d, c: 0.5556091919525646d),
new NpgsqlTypes.NpgsqlLine(a: 0.5822975099474715d, b: 0.17655095887170213d, c: 0.2586408674801325d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5160039524898102d, b: 0.25485884949273097d, c: 0.20557702631108266d),
new NpgsqlTypes.NpgsqlLine(a: 0.8779861031294212d, b: 0.05488247786095879d, c: 0.863335352985223d),
new NpgsqlTypes.NpgsqlLine(a: 0.14504246977253488d, b: 0.3645379213061055d, c: 0.9938815364932198d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5239001173971679d, b: 0.08383728812060809d, c: 0.8038537627639879d),
new NpgsqlTypes.NpgsqlLine(a: 0.8382834813813957d, b: 0.9562175687923432d, c: 0.23451466479005934d),
new NpgsqlTypes.NpgsqlLine(a: 0.3505822740485617d, b: 0.5162212117942387d, c: 0.7102650138538377d),
new NpgsqlTypes.NpgsqlLine(a: 0.28453431025341147d, b: 0.8527473058813825d, c: 0.08684597233671631d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3758730152653015d, b: 0.19059535208814915d, c: 0.8261448993493584d),
new NpgsqlTypes.NpgsqlLine(a: 0.4363097216148971d, b: 0.6729455459518704d, c: 0.4819313367003467d),
new NpgsqlTypes.NpgsqlLine(a: 0.6718822305858004d, b: 0.5597089400830387d, c: 0.9611494653336221d),
new NpgsqlTypes.NpgsqlLine(a: 0.42691227098949946d, b: 0.553280416772527d, c: 0.3995876899511983d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.558206391955471d, b: 0.5087404194756026d, c: 0.9451411054793772d),
new NpgsqlTypes.NpgsqlLine(a: 0.8260611076088463d, b: 0.04652474205923329d, c: 0.06403424097771593d),
new NpgsqlTypes.NpgsqlLine(a: 0.4758968189225412d, b: 0.6861835169793962d, c: 0.7449092615302546d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6764025883558693d, b: 0.45552791201421305d, c: 0.3264569556462089d),
new NpgsqlTypes.NpgsqlLine(a: 0.9680491258735069d, b: 0.5557380784909871d, c: 0.6007963713104295d),
new NpgsqlTypes.NpgsqlLine(a: 0.36008884677847997d, b: 0.3422072508873224d, c: 0.8489189043787274d),
new NpgsqlTypes.NpgsqlLine(a: 0.32712517048449974d, b: 0.14306913475554472d, c: 0.16148770711078209d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4383499237958244d, b: 0.35879975799296293d, c: 0.686525560282426d),
new NpgsqlTypes.NpgsqlLine(a: 0.5329052116018518d, b: 0.06460728972224894d, c: 0.05576334244599679d),
new NpgsqlTypes.NpgsqlLine(a: 0.19351839041169727d, b: 0.9689762596972524d, c: 0.7873147885643615d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7277482827457091d, b: 0.4258957624640832d, c: 0.6121658274203832d),
new NpgsqlTypes.NpgsqlLine(a: 0.7484370130061094d, b: 0.23214281104886691d, c: 0.8373419539715604d),
new NpgsqlTypes.NpgsqlLine(a: 0.03249017479334759d, b: 0.16034325593785959d, c: 0.5193850701880254d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6919191010785662d, b: 0.9074886520252371d, c: 0.3537274716431864d),
new NpgsqlTypes.NpgsqlLine(a: 0.15902259557545906d, b: 0.9200215671808586d, c: 0.4741412285910199d),
new NpgsqlTypes.NpgsqlLine(a: 0.5781843434549205d, b: 0.15863123689592928d, c: 0.433653551675664d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8782031246376404d, b: 0.22602904143995695d, c: 0.5089353617846387d),
new NpgsqlTypes.NpgsqlLine(a: 0.42608930743774d, b: 0.3316862103827585d, c: 0.6404959597631393d),
new NpgsqlTypes.NpgsqlLine(a: 0.3307106408294529d, b: 0.05842178029309919d, c: 0.4377572420061069d),
new NpgsqlTypes.NpgsqlLine(a: 0.29275159137027496d, b: 0.08248586892583032d, c: 0.820591576106272d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2278687495170869d, b: 0.03658982752792994d, c: 0.7875896782587399d),
new NpgsqlTypes.NpgsqlLine(a: 0.31813687963836346d, b: 0.04834053342032962d, c: 0.9551263236840906d),
new NpgsqlTypes.NpgsqlLine(a: 0.007132642388625765d, b: 0.4101255299813513d, c: 0.5678958844370298d),
new NpgsqlTypes.NpgsqlLine(a: 0.09071497059718203d, b: 0.026956338042770978d, c: 0.3648865154436449d),
},
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
new NpgsqlTypes.NpgsqlLine(a: 0.3953023524354111d, b: 0.7682618316646248d, c: 0.67841648365057d),
new NpgsqlTypes.NpgsqlLine(a: 0.09163384351500725d, b: 0.16099846235056703d, c: 0.8416004252494912d),
new NpgsqlTypes.NpgsqlLine(a: 0.622512242690671d, b: 0.7888185490062886d, c: 0.9173503845925904d),
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlLine(a: 0.006281197288007134d, b: 0.7027481577950558d, c: 0.11680684984131673d),
new NpgsqlTypes.NpgsqlLine(a: 0.7848660582338605d, b: 0.7961863360514561d, c: 0.5430396897946003d),
new NpgsqlTypes.NpgsqlLine(a: 0.8773117319016297d, b: 0.6556881152367681d, c: 0.9521944525733844d),
new NpgsqlTypes.NpgsqlLine(a: 0.3424637388138587d, b: 0.30300421864761784d, c: 0.025346932569152547d),
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
new NpgsqlTypes.NpgsqlLine(a: 0.3569784827407195d, b: 0.33965732351817823d, c: 0.5830320204769872d),
new NpgsqlTypes.NpgsqlLine(a: 0.8566068613533677d, b: 0.578015633658878d, c: 0.8956744699669815d),
new NpgsqlTypes.NpgsqlLine(a: 0.3807904002220974d, b: 0.10274774388270225d, c: 0.7112865775437093d),
new NpgsqlTypes.NpgsqlLine(a: 0.5000829529192545d, b: 0.6667314360623843d, c: 0.25568939696435655d),
}));
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6341553270468504d, b: 0.04274322647890849d, c: 0.14211615262937238d),
new NpgsqlTypes.NpgsqlLine(a: 0.5537645945142848d, b: 0.7991150096238859d, c: 0.28928518531527736d),
new NpgsqlTypes.NpgsqlLine(a: 0.9803000267702415d, b: 0.31102175417669353d, c: 0.9799644831774268d),
}));
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43897293893512535d, b: 0.9133540307581595d, c: 0.6462565645082748d),
new NpgsqlTypes.NpgsqlLine(a: 0.7006625034378415d, b: 0.8919831711687278d, c: 0.8287950622195119d),
new NpgsqlTypes.NpgsqlLine(a: 0.16444313274485056d, b: 0.5444068140737304d, c: 0.9604545557936462d),
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[29], false);
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[29], false);
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 58, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 41, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 82, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 25, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 111, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 65, query1, 53, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 78, query1, 78, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[29], false);
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
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
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 84, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 19, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[29], false);
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
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 102);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[29], false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
            queryMapType: typeof(NpgsqlLinelineArray1MI),
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlLinelineArray1M),
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlLineArraylineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(6)]
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

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
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

