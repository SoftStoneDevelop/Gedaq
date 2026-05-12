

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
    internal partial interface INpgsqlPathMArraypathMMArrayD1
    {
    }
    
    internal partial class NpgsqlPathMArraypathMMArrayD1 : INpgsqlPathMArraypathMMArrayD1
    {


#region TestData

        private readonly NpgsqlPathpathMMArrayD1E1M[] _testData = new NpgsqlPathpathMMArrayD1E1M[]
        {
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09038244355189073d, y: 0.5632334775931894d), new NpgsqlTypes.NpgsqlPoint(x: 0.3313423268124853d, y: 0.060898457521450844d), new NpgsqlTypes.NpgsqlPoint(x: 0.20221712895584543d, y: 0.7799652789721869d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9860355301563949d, y: 0.4046146598431821d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833020392768959d, y: 0.29585416182753066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7574456558719044d, y: 0.5961644733186708d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.616307971827307d, y: 0.7165301335143719d), new NpgsqlTypes.NpgsqlPoint(x: 0.4025004448891293d, y: 0.890324840938412d), new NpgsqlTypes.NpgsqlPoint(x: 0.19410602226385454d, y: 0.022678424756346738d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2778758138569962d, y: 0.479258105361701d), new NpgsqlTypes.NpgsqlPoint(x: 0.42724918584898874d, y: 0.2399963228961811d), new NpgsqlTypes.NpgsqlPoint(x: 0.22329939340860727d, y: 0.3885006685419927d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3782006428307628d, y: 0.9971497074943122d), new NpgsqlTypes.NpgsqlPoint(x: 0.18950120743948506d, y: 0.5247025863972097d), new NpgsqlTypes.NpgsqlPoint(x: 0.26140924381433417d, y: 0.40845013040501255d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5875658094249431d, y: 0.21215669331667364d), new NpgsqlTypes.NpgsqlPoint(x: 0.4766534960968516d, y: 0.14701872068853494d), new NpgsqlTypes.NpgsqlPoint(x: 0.20439795769729618d, y: 0.22793780578035205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2993081052292157d, y: 0.2978604176210078d), new NpgsqlTypes.NpgsqlPoint(x: 0.2154918131788951d, y: 0.8615182878396209d), new NpgsqlTypes.NpgsqlPoint(x: 0.23596116743382278d, y: 0.2018305195115203d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30780208959779465d, y: 0.768343491308364d), new NpgsqlTypes.NpgsqlPoint(x: 0.4241611443969765d, y: 0.9809573899753149d), new NpgsqlTypes.NpgsqlPoint(x: 0.9057852485990765d, y: 0.852690721610488d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28841330043785807d, y: 0.47339810028939766d), new NpgsqlTypes.NpgsqlPoint(x: 0.28549294492810473d, y: 0.7843361328861927d), new NpgsqlTypes.NpgsqlPoint(x: 0.9115622570279059d, y: 0.6216024881478096d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8602515401067267d, y: 0.41479042833990787d), new NpgsqlTypes.NpgsqlPoint(x: 0.6962290047922259d, y: 0.07884612913090883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6014590268778107d, y: 0.8327810498917778d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3709615366091822d, y: 0.17697521604015376d), new NpgsqlTypes.NpgsqlPoint(x: 0.8408743794195582d, y: 0.28402674566103214d), new NpgsqlTypes.NpgsqlPoint(x: 0.09480083872336287d, y: 0.9397256935212995d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5204704536078923d, y: 0.4016690407952306d), new NpgsqlTypes.NpgsqlPoint(x: 0.15907279877746217d, y: 0.7244462952455201d), new NpgsqlTypes.NpgsqlPoint(x: 0.17269633926746097d, y: 0.04250177497457519d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3029020358838336d, y: 0.45522447285939005d), new NpgsqlTypes.NpgsqlPoint(x: 0.48787035435790904d, y: 0.3309627641822287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086763649549076d, y: 0.13812116842037103d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6277245999096643d, y: 0.49487372916807726d), new NpgsqlTypes.NpgsqlPoint(x: 0.49856005934500447d, y: 0.7174165009646214d), new NpgsqlTypes.NpgsqlPoint(x: 0.7468499494573646d, y: 0.035462445824051114d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2083438103347076d, y: 0.9154945839111419d), new NpgsqlTypes.NpgsqlPoint(x: 0.8105904802126906d, y: 0.5024307613542677d), new NpgsqlTypes.NpgsqlPoint(x: 0.1543310634107823d, y: 0.37709243138781545d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.052073086844480865d, y: 0.8947558166421755d), new NpgsqlTypes.NpgsqlPoint(x: 0.9152808327336021d, y: 0.6782190109969657d), new NpgsqlTypes.NpgsqlPoint(x: 0.6790420205586662d, y: 0.28326880965432477d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24971713017509078d, y: 0.31084015995760716d), new NpgsqlTypes.NpgsqlPoint(x: 0.9609551705712074d, y: 0.16020802130255885d), new NpgsqlTypes.NpgsqlPoint(x: 0.6271383667177273d, y: 0.3376353703182885d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8984175494625348d, y: 0.03687459916090874d), new NpgsqlTypes.NpgsqlPoint(x: 0.47996965831779304d, y: 0.6542008948363716d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848999476756237d, y: 0.7784662648440178d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8278475537359968d, y: 0.8919503076573694d), new NpgsqlTypes.NpgsqlPoint(x: 0.8160046905940198d, y: 0.4514174509875173d), new NpgsqlTypes.NpgsqlPoint(x: 0.3033304055414817d, y: 0.0717967864840332d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006566543164215899d, y: 0.9042126409596319d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006830245685016d, y: 0.31614800855004066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5434454509825217d, y: 0.6740339913817353d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08228335181602242d, y: 0.8234333267095353d), new NpgsqlTypes.NpgsqlPoint(x: 0.5051796690716638d, y: 0.12962591291455816d), new NpgsqlTypes.NpgsqlPoint(x: 0.6598153531203186d, y: 0.501840725318872d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8122124546393604d, y: 0.4452414031889559d), new NpgsqlTypes.NpgsqlPoint(x: 0.2936499284160782d, y: 0.5202804000392267d), new NpgsqlTypes.NpgsqlPoint(x: 0.7470017137584507d, y: 0.07423591051469369d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3808325687219478d, y: 0.8918433530589678d), new NpgsqlTypes.NpgsqlPoint(x: 0.46423966836637853d, y: 0.25456158032737064d), new NpgsqlTypes.NpgsqlPoint(x: 0.48473581779286556d, y: 0.48842208767311646d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.987226423865146d, y: 0.021089199938442715d), new NpgsqlTypes.NpgsqlPoint(x: 0.8629575056076758d, y: 0.7025165579672951d), new NpgsqlTypes.NpgsqlPoint(x: 0.8147641595727609d, y: 0.42936518714163807d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7565320950506706d, y: 0.1701313410268459d), new NpgsqlTypes.NpgsqlPoint(x: 0.412728341061829d, y: 0.29644891375535254d), new NpgsqlTypes.NpgsqlPoint(x: 0.7384526728088213d, y: 0.9034715265242318d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5216739860516489d, y: 0.9312394853119157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9547751773305698d, y: 0.7249072155242123d), new NpgsqlTypes.NpgsqlPoint(x: 0.8346445814898171d, y: 0.14448778690830122d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7343597635730281d, y: 0.542998920788059d), new NpgsqlTypes.NpgsqlPoint(x: 0.7112691826517361d, y: 0.5219968692191652d), new NpgsqlTypes.NpgsqlPoint(x: 0.358995768531845d, y: 0.2243974208755971d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12530736228158867d, y: 0.49319679529335936d), new NpgsqlTypes.NpgsqlPoint(x: 0.6966023445949289d, y: 0.42031813478226143d), new NpgsqlTypes.NpgsqlPoint(x: 0.22068059229812198d, y: 0.5885160195514207d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49566742040229184d, y: 0.14325116022072515d), new NpgsqlTypes.NpgsqlPoint(x: 0.8101861195980931d, y: 0.003145193482668951d), new NpgsqlTypes.NpgsqlPoint(x: 0.2371427961028285d, y: 0.7233626908556237d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1563569714628006d, y: 0.3428205953848662d), new NpgsqlTypes.NpgsqlPoint(x: 0.27184511082854523d, y: 0.3807290921619634d), new NpgsqlTypes.NpgsqlPoint(x: 0.021723454078514615d, y: 0.548383312223304d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09362391055196873d, y: 0.5943208231706296d), new NpgsqlTypes.NpgsqlPoint(x: 0.9567477613001889d, y: 0.8345688010411156d), new NpgsqlTypes.NpgsqlPoint(x: 0.4342707627147906d, y: 0.1664749452362435d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4460418016966583d, y: 0.09883728104925471d), new NpgsqlTypes.NpgsqlPoint(x: 0.3987709658946539d, y: 0.26700248254712267d), new NpgsqlTypes.NpgsqlPoint(x: 0.4970564084450606d, y: 0.12080037275949951d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0812733026947674d, y: 0.9918046769227558d), new NpgsqlTypes.NpgsqlPoint(x: 0.053456364724673744d, y: 0.7171509089495223d), new NpgsqlTypes.NpgsqlPoint(x: 0.07643837036666634d, y: 0.6212221631436236d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9781109557944403d, y: 0.8280700610687635d), new NpgsqlTypes.NpgsqlPoint(x: 0.7456839535740464d, y: 0.022041485392319093d), new NpgsqlTypes.NpgsqlPoint(x: 0.39525151140763626d, y: 0.2295152903005897d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9956416346193114d, y: 0.3700760984727093d), new NpgsqlTypes.NpgsqlPoint(x: 0.23044899192403812d, y: 0.526725486141983d), new NpgsqlTypes.NpgsqlPoint(x: 0.7127284709093069d, y: 0.7923801490386656d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7408517353062394d, y: 0.31204585726437506d), new NpgsqlTypes.NpgsqlPoint(x: 0.3003668628362597d, y: 0.8967830700866462d), new NpgsqlTypes.NpgsqlPoint(x: 0.802308919340442d, y: 0.43093871164286657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38554121643323935d, y: 0.3254172413111631d), new NpgsqlTypes.NpgsqlPoint(x: 0.5252486837463646d, y: 0.054486023666417416d), new NpgsqlTypes.NpgsqlPoint(x: 0.055692194673473194d, y: 0.09755321911997872d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0968517772208708d, y: 0.016754403068367618d), new NpgsqlTypes.NpgsqlPoint(x: 0.28603923290615685d, y: 0.6470020477829531d), new NpgsqlTypes.NpgsqlPoint(x: 0.3952597119929001d, y: 0.6831401721056355d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7667578872776408d, y: 0.7501643300377986d), new NpgsqlTypes.NpgsqlPoint(x: 0.08143100630082367d, y: 0.4751618204424276d), new NpgsqlTypes.NpgsqlPoint(x: 0.9119826528459116d, y: 0.6050841438569229d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05373353221185051d, y: 0.8136447793857259d), new NpgsqlTypes.NpgsqlPoint(x: 0.032782196349003034d, y: 0.7963670163712957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6760453785111742d, y: 0.24700584308629192d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5795726999273952d, y: 0.021054094050393157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9562259340054379d, y: 0.5049926353110377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8560981323857385d, y: 0.02359778573221505d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.078205093779671d, y: 0.7191748335197248d), new NpgsqlTypes.NpgsqlPoint(x: 0.4003493150848628d, y: 0.7240884167112436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5712897865517983d, y: 0.774958305096788d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9960660453953787d, y: 0.05619395280121198d), new NpgsqlTypes.NpgsqlPoint(x: 0.5024482196119329d, y: 0.7245620081010986d), new NpgsqlTypes.NpgsqlPoint(x: 0.3697382632776477d, y: 0.9729278245250988d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7231229301115637d, y: 0.8156971001674661d), new NpgsqlTypes.NpgsqlPoint(x: 0.3947039225424239d, y: 0.7963752283158191d), new NpgsqlTypes.NpgsqlPoint(x: 0.04072790657195635d, y: 0.7178712975583486d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9045292907992808d, y: 0.3719578144807716d), new NpgsqlTypes.NpgsqlPoint(x: 0.6132223935084438d, y: 0.9295444533785543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5408905426595169d, y: 0.10218448381736478d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5384814137486875d, y: 0.27144499964774993d), new NpgsqlTypes.NpgsqlPoint(x: 0.7732286124902308d, y: 0.7048006603591834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077112199474471d, y: 0.6427942258749137d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6038991709025969d, y: 0.32945970438640537d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598359489621353d, y: 0.8507016470354518d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843786663569657d, y: 0.21992717588188204d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.810296388471742d, y: 0.3268239222166235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6436493355330375d, y: 0.7606088700238878d), new NpgsqlTypes.NpgsqlPoint(x: 0.767799933818148d, y: 0.7333903934463214d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8527111292680758d, y: 0.9263663736232793d), new NpgsqlTypes.NpgsqlPoint(x: 0.5080753823018965d, y: 0.04656620122884869d), new NpgsqlTypes.NpgsqlPoint(x: 0.887389619965877d, y: 0.3440997742982612d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18961163290349625d, y: 0.1413172661870601d), new NpgsqlTypes.NpgsqlPoint(x: 0.22049406075377742d, y: 0.25142806142344243d), new NpgsqlTypes.NpgsqlPoint(x: 0.5512785875498567d, y: 0.8889822987860035d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5507205000667839d, y: 0.13354076441028284d), new NpgsqlTypes.NpgsqlPoint(x: 0.278918601938977d, y: 0.8339898189467946d), new NpgsqlTypes.NpgsqlPoint(x: 0.15554515836588867d, y: 0.8224374716895123d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6846692516279309d, y: 0.6689051042870318d), new NpgsqlTypes.NpgsqlPoint(x: 0.6096326408778462d, y: 0.047834875721043724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5389364418437501d, y: 0.10900713561244524d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9268346501185786d, y: 0.20474553495212522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5699189889022663d, y: 0.5567270190248816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8180576056738842d, y: 0.6151926872444377d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2027230971076046d, y: 0.6519360460660755d), new NpgsqlTypes.NpgsqlPoint(x: 0.47844004109559624d, y: 0.030289662286750008d), new NpgsqlTypes.NpgsqlPoint(x: 0.8018934833343396d, y: 0.34572026349126395d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21231765160801686d, y: 0.022512507888739486d), new NpgsqlTypes.NpgsqlPoint(x: 0.1231378905828946d, y: 0.4477825820658319d), new NpgsqlTypes.NpgsqlPoint(x: 0.6371206489324646d, y: 0.3404776177449843d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6193170111413431d, y: 0.028985616892693522d), new NpgsqlTypes.NpgsqlPoint(x: 0.14960609218626153d, y: 0.22075701803956893d), new NpgsqlTypes.NpgsqlPoint(x: 0.9071841326014393d, y: 0.028010907346932346d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18684132834934175d, y: 0.22690234848932334d), new NpgsqlTypes.NpgsqlPoint(x: 0.26969337812606475d, y: 0.26472487398460554d), new NpgsqlTypes.NpgsqlPoint(x: 0.47797816788395564d, y: 0.4614615070464917d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45732410279700875d, y: 0.19781820445855403d), new NpgsqlTypes.NpgsqlPoint(x: 0.826986698296462d, y: 0.32519113303919345d), new NpgsqlTypes.NpgsqlPoint(x: 0.4357243436853574d, y: 0.6922173127929562d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8368311863071127d, y: 0.5974832209239203d), new NpgsqlTypes.NpgsqlPoint(x: 0.5822503656698109d, y: 0.5692434172743165d), new NpgsqlTypes.NpgsqlPoint(x: 0.8613526546051762d, y: 0.7939528787895054d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.122779507420953d, y: 0.5817055752926279d), new NpgsqlTypes.NpgsqlPoint(x: 0.3405806407141736d, y: 0.6283979117822225d), new NpgsqlTypes.NpgsqlPoint(x: 0.5904576105734314d, y: 0.35504111621738865d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39282291580602113d, y: 0.17876171742630542d), new NpgsqlTypes.NpgsqlPoint(x: 0.31399926214568585d, y: 0.43861952307048313d), new NpgsqlTypes.NpgsqlPoint(x: 0.20478030284597815d, y: 0.8228123114111954d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.684856455770357d, y: 0.902434137216473d), new NpgsqlTypes.NpgsqlPoint(x: 0.5879732779226949d, y: 0.27662299805288515d), new NpgsqlTypes.NpgsqlPoint(x: 0.0770322370660127d, y: 0.7425729675348858d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.774409531374479d, y: 0.3790596241551807d), new NpgsqlTypes.NpgsqlPoint(x: 0.020376795629504563d, y: 0.7701585162290149d), new NpgsqlTypes.NpgsqlPoint(x: 0.9968756718566187d, y: 0.2161286617580237d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8076198280443742d, y: 0.42099256620798575d), new NpgsqlTypes.NpgsqlPoint(x: 0.8014469820429612d, y: 0.2019664840157286d), new NpgsqlTypes.NpgsqlPoint(x: 0.952840672305548d, y: 0.12661310816196159d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8173037170692224d, y: 0.536523834284481d), new NpgsqlTypes.NpgsqlPoint(x: 0.19481284832531331d, y: 0.5934804001253199d), new NpgsqlTypes.NpgsqlPoint(x: 0.3413693184378791d, y: 0.5003411923662923d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2924420288833689d, y: 0.5770222277881383d), new NpgsqlTypes.NpgsqlPoint(x: 0.5537992504857341d, y: 0.5718230562325092d), new NpgsqlTypes.NpgsqlPoint(x: 0.696231917315479d, y: 0.6574321755644861d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3047950359237904d, y: 0.28445529942629055d), new NpgsqlTypes.NpgsqlPoint(x: 0.37537661240960407d, y: 0.05677918028083373d), new NpgsqlTypes.NpgsqlPoint(x: 0.2634771315879201d, y: 0.9190750349987982d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.958932155713969d, y: 0.6294229519414036d), new NpgsqlTypes.NpgsqlPoint(x: 0.7590593990704109d, y: 0.21956735042609943d), new NpgsqlTypes.NpgsqlPoint(x: 0.6116464488743454d, y: 0.24946118100101433d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06014273352382171d, y: 0.6448838534136557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6436219220100521d, y: 0.725638021058948d), new NpgsqlTypes.NpgsqlPoint(x: 0.28832002468403495d, y: 0.04882066048461775d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06256346693563686d, y: 0.3821800595390734d), new NpgsqlTypes.NpgsqlPoint(x: 0.8023982822659722d, y: 0.6691461368903675d), new NpgsqlTypes.NpgsqlPoint(x: 0.4852203854068803d, y: 0.6841500587048603d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5514585454722178d, y: 0.2436622805558275d), new NpgsqlTypes.NpgsqlPoint(x: 0.6252676345019582d, y: 0.9015647073248657d), new NpgsqlTypes.NpgsqlPoint(x: 0.2865978288433423d, y: 0.5735340630346655d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32035797939499744d, y: 0.9481577345677632d), new NpgsqlTypes.NpgsqlPoint(x: 0.06618557917660628d, y: 0.33533749051418726d), new NpgsqlTypes.NpgsqlPoint(x: 0.4936416291494309d, y: 0.602498881913756d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.655525583911654d, y: 0.9842401981954139d), new NpgsqlTypes.NpgsqlPoint(x: 0.3581603089551564d, y: 0.7607801450245877d), new NpgsqlTypes.NpgsqlPoint(x: 0.7827643409348233d, y: 0.3053214022974894d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7155999258955172d, y: 0.10264742612899203d), new NpgsqlTypes.NpgsqlPoint(x: 0.21258736477535345d, y: 0.7427233295438058d), new NpgsqlTypes.NpgsqlPoint(x: 0.22277016747504874d, y: 0.08504578568706789d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06560452764597613d, y: 0.4162252095124588d), new NpgsqlTypes.NpgsqlPoint(x: 0.5945226377009151d, y: 0.513779946584965d), new NpgsqlTypes.NpgsqlPoint(x: 0.7455039342925674d, y: 0.37451476656259997d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01662997314549064d, y: 0.040838948241331274d), new NpgsqlTypes.NpgsqlPoint(x: 0.11182335439489921d, y: 0.8144867188015946d), new NpgsqlTypes.NpgsqlPoint(x: 0.3107002365032019d, y: 0.4098466531556285d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09623992228450373d, y: 0.6786095409714388d), new NpgsqlTypes.NpgsqlPoint(x: 0.3157043002984017d, y: 0.10054747055337154d), new NpgsqlTypes.NpgsqlPoint(x: 0.1924927901900746d, y: 0.6124648976544418d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25044385748110753d, y: 0.7091405401516472d), new NpgsqlTypes.NpgsqlPoint(x: 0.791197773937944d, y: 0.0670612524105334d), new NpgsqlTypes.NpgsqlPoint(x: 0.521074968263865d, y: 0.8712232358638128d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9443267895779364d, y: 0.1586552572478206d), new NpgsqlTypes.NpgsqlPoint(x: 0.3608935888786151d, y: 0.2737545222043478d), new NpgsqlTypes.NpgsqlPoint(x: 0.683127791171361d, y: 0.48812315540993245d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020291604852162415d, y: 0.020915164773779527d), new NpgsqlTypes.NpgsqlPoint(x: 0.27556832494210526d, y: 0.9311195343493864d), new NpgsqlTypes.NpgsqlPoint(x: 0.05743159930556063d, y: 0.1247018127830376d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7915440553504586d, y: 0.8462837525168806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8571264908872962d, y: 0.6512892809297125d), new NpgsqlTypes.NpgsqlPoint(x: 0.19604951753161848d, y: 0.6672320703725387d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5773077227137521d, y: 0.041230222824338525d), new NpgsqlTypes.NpgsqlPoint(x: 0.034940162095654315d, y: 0.698686479417842d), new NpgsqlTypes.NpgsqlPoint(x: 0.6751255173637871d, y: 0.9312576041761069d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7914406492756875d, y: 0.6812093154778199d), new NpgsqlTypes.NpgsqlPoint(x: 0.06875058960356328d, y: 0.23732346184755904d), new NpgsqlTypes.NpgsqlPoint(x: 0.0860204871972744d, y: 0.905753769964579d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48414504691202764d, y: 0.2523983615377975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936924821679485d, y: 0.822393181848794d), new NpgsqlTypes.NpgsqlPoint(x: 0.011584846080203604d, y: 0.5940539521315594d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.777069919200026d, y: 0.541439506721454d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397499764118927d, y: 0.2412131627716696d), new NpgsqlTypes.NpgsqlPoint(x: 0.46388441165714867d, y: 0.4160191813048978d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4711528297392491d, y: 0.598344927368882d), new NpgsqlTypes.NpgsqlPoint(x: 0.7897465148966613d, y: 0.12765187823337054d), new NpgsqlTypes.NpgsqlPoint(x: 0.3242427444565392d, y: 0.9972142268247205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4220419800983102d, y: 0.28787451549578025d), new NpgsqlTypes.NpgsqlPoint(x: 0.18641538090781595d, y: 0.41492354785118934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9765201433014339d, y: 0.15904096265806622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0746518354207173d, y: 0.017528322150356934d), new NpgsqlTypes.NpgsqlPoint(x: 0.7208304703242671d, y: 0.3836749715210809d), new NpgsqlTypes.NpgsqlPoint(x: 0.9340230772880422d, y: 0.5109758316872136d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5532704687211083d, y: 0.26227638856819646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8172715629238652d, y: 0.6413244504054182d), new NpgsqlTypes.NpgsqlPoint(x: 0.10464201682676533d, y: 0.1005699071107945d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6118977190129077d, y: 0.8273410783259674d), new NpgsqlTypes.NpgsqlPoint(x: 0.4486908315998064d, y: 0.18170827609259788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7062019386739432d, y: 0.9901716394959981d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7248673054774684d, y: 0.2099790267626459d), new NpgsqlTypes.NpgsqlPoint(x: 0.8986639553967114d, y: 0.9834811882081009d), new NpgsqlTypes.NpgsqlPoint(x: 0.7977472003969671d, y: 0.44249162181902d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9997734948487063d, y: 0.4701697763495515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570388547484083d, y: 0.24172135313695553d), new NpgsqlTypes.NpgsqlPoint(x: 0.07339612800530793d, y: 0.5074777853299132d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31766029617865843d, y: 0.003618098162707639d), new NpgsqlTypes.NpgsqlPoint(x: 0.15834760916717094d, y: 0.2243774085796001d), new NpgsqlTypes.NpgsqlPoint(x: 0.6019429358185483d, y: 0.1978710288563107d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6966300970195396d, y: 0.7073158493677081d), new NpgsqlTypes.NpgsqlPoint(x: 0.09999207375866226d, y: 0.683355219463783d), new NpgsqlTypes.NpgsqlPoint(x: 0.38596472838115214d, y: 0.36755125587018356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11493497748670412d, y: 0.0022826987659150255d), new NpgsqlTypes.NpgsqlPoint(x: 0.8148990386534618d, y: 0.6057608171939368d), new NpgsqlTypes.NpgsqlPoint(x: 0.626943983743405d, y: 0.990814478494487d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44363201044956735d, y: 0.707599089763278d), new NpgsqlTypes.NpgsqlPoint(x: 0.3052561943752006d, y: 0.7903283127396484d), new NpgsqlTypes.NpgsqlPoint(x: 0.39844480261791515d, y: 0.18608927270108822d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9318386384495747d, y: 0.30150392318242525d), new NpgsqlTypes.NpgsqlPoint(x: 0.765426138851079d, y: 0.5602567384593962d), new NpgsqlTypes.NpgsqlPoint(x: 0.611945507546054d, y: 0.031442965890079666d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6174553817608452d, y: 0.36225587426964323d), new NpgsqlTypes.NpgsqlPoint(x: 0.05660484061533799d, y: 0.6344007186561111d), new NpgsqlTypes.NpgsqlPoint(x: 0.3680364260357074d, y: 0.2785970536545904d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08759567475644447d, y: 0.9682846496869045d), new NpgsqlTypes.NpgsqlPoint(x: 0.4847118851099309d, y: 0.4661187211181307d), new NpgsqlTypes.NpgsqlPoint(x: 0.909082483097181d, y: 0.46223468733886663d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6163815346034258d, y: 0.10904199778842427d), new NpgsqlTypes.NpgsqlPoint(x: 0.8577146721193408d, y: 0.17735736728017437d), new NpgsqlTypes.NpgsqlPoint(x: 0.578770973841077d, y: 0.857216463944454d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43460787430216596d, y: 0.5760278884390312d), new NpgsqlTypes.NpgsqlPoint(x: 0.36865808732688654d, y: 0.18738915017213742d), new NpgsqlTypes.NpgsqlPoint(x: 0.31734112083617916d, y: 0.4109862179322201d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31999320496698047d, y: 0.6112190786047293d), new NpgsqlTypes.NpgsqlPoint(x: 0.3302263872003123d, y: 0.9214891158488283d), new NpgsqlTypes.NpgsqlPoint(x: 0.5872177237450413d, y: 0.753908343685047d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39890783996005963d, y: 0.009279661491853775d), new NpgsqlTypes.NpgsqlPoint(x: 0.4932885078079201d, y: 0.01132001787607606d), new NpgsqlTypes.NpgsqlPoint(x: 0.515427900270848d, y: 0.03255286367854826d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21543026487010464d, y: 0.8890329346985654d), new NpgsqlTypes.NpgsqlPoint(x: 0.5491451000036437d, y: 0.7683189108085479d), new NpgsqlTypes.NpgsqlPoint(x: 0.35525409154583565d, y: 0.6526869384463948d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0605699614561549d, y: 0.2582629681662376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9284140723715945d, y: 0.09415830208587195d), new NpgsqlTypes.NpgsqlPoint(x: 0.9209861518804223d, y: 0.057112717472383334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.508882251913319d, y: 0.05521048864402356d), new NpgsqlTypes.NpgsqlPoint(x: 0.6771673467355652d, y: 0.9608830305700986d), new NpgsqlTypes.NpgsqlPoint(x: 0.8743013367997599d, y: 0.5813642973462642d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04655712290489744d, y: 0.3446469228659039d), new NpgsqlTypes.NpgsqlPoint(x: 0.5877236170870394d, y: 0.9722590875167813d), new NpgsqlTypes.NpgsqlPoint(x: 0.169633903811359d, y: 0.8105720542814868d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7552207719198268d, y: 0.09140237347033964d), new NpgsqlTypes.NpgsqlPoint(x: 0.476317629665694d, y: 0.13300463270874197d), new NpgsqlTypes.NpgsqlPoint(x: 0.5568092452546016d, y: 0.3032915660933876d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6410718128214057d, y: 0.08333578482980675d), new NpgsqlTypes.NpgsqlPoint(x: 0.11795892765733929d, y: 0.5423684639461889d), new NpgsqlTypes.NpgsqlPoint(x: 0.8504535305335295d, y: 0.7906528556367108d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4684046396397735d, y: 0.5343635592038165d), new NpgsqlTypes.NpgsqlPoint(x: 0.6536404077371535d, y: 0.6531354221868333d), new NpgsqlTypes.NpgsqlPoint(x: 0.30438746283063356d, y: 0.3734201515666328d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12692547944866162d, y: 0.34441946905299947d), new NpgsqlTypes.NpgsqlPoint(x: 0.8235323419132612d, y: 0.43697100017567114d), new NpgsqlTypes.NpgsqlPoint(x: 0.381475266973045d, y: 0.9835115937369369d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2815633666360997d, y: 0.9200516130773322d), new NpgsqlTypes.NpgsqlPoint(x: 0.832495488419064d, y: 0.25790536467122027d), new NpgsqlTypes.NpgsqlPoint(x: 0.2774453106038034d, y: 0.8165860444991638d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5417431135280992d, y: 0.9456386023016222d), new NpgsqlTypes.NpgsqlPoint(x: 0.2710778308778161d, y: 0.4629413979697927d), new NpgsqlTypes.NpgsqlPoint(x: 0.3961711409763189d, y: 0.1563404371113034d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5242560343896441d, y: 0.890082004195889d), new NpgsqlTypes.NpgsqlPoint(x: 0.2002147557535101d, y: 0.5832585030250426d), new NpgsqlTypes.NpgsqlPoint(x: 0.373963842735926d, y: 0.9241209861548646d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7161138121122751d, y: 0.27578831476992205d), new NpgsqlTypes.NpgsqlPoint(x: 0.19562042591335294d, y: 0.927876511889695d), new NpgsqlTypes.NpgsqlPoint(x: 0.1469143089201259d, y: 0.9961186872331617d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40203501694156885d, y: 0.14200452771617644d), new NpgsqlTypes.NpgsqlPoint(x: 0.5197861758587834d, y: 0.7622773273304881d), new NpgsqlTypes.NpgsqlPoint(x: 0.4096333660019954d, y: 0.6801921952470278d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19151368414337744d, y: 0.7924660615000477d), new NpgsqlTypes.NpgsqlPoint(x: 0.9533386926247069d, y: 0.23823430833464565d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752513229505289d, y: 0.9568045413771854d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3774060453555167d, y: 0.3488846934031715d), new NpgsqlTypes.NpgsqlPoint(x: 0.07556534720565722d, y: 0.9797308456200413d), new NpgsqlTypes.NpgsqlPoint(x: 0.11786030289382199d, y: 0.6217165707356835d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18091168790590995d, y: 0.9845069544785842d), new NpgsqlTypes.NpgsqlPoint(x: 0.10781541279677198d, y: 0.3324541290726636d), new NpgsqlTypes.NpgsqlPoint(x: 0.8380436851483554d, y: 0.9846095543156357d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40847498827230466d, y: 0.21856914483216094d), new NpgsqlTypes.NpgsqlPoint(x: 0.9337475404390925d, y: 0.8996333840537579d), new NpgsqlTypes.NpgsqlPoint(x: 0.9169931775679305d, y: 0.5621882637325423d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5625715048860487d, y: 0.3207205044549999d), new NpgsqlTypes.NpgsqlPoint(x: 0.8087393226274113d, y: 0.9604203943966468d), new NpgsqlTypes.NpgsqlPoint(x: 0.9383697777894691d, y: 0.16406926340996186d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1899395843368442d, y: 0.16244875530362768d), new NpgsqlTypes.NpgsqlPoint(x: 0.628828162638845d, y: 0.43862048193724d), new NpgsqlTypes.NpgsqlPoint(x: 0.61131312230011d, y: 0.9290751273308437d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28253143960318117d, y: 0.17910798460469268d), new NpgsqlTypes.NpgsqlPoint(x: 0.6701975314225098d, y: 0.5514547874399188d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335381980872058d, y: 0.15915268328844068d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7583359023425453d, y: 0.37909027811428164d), new NpgsqlTypes.NpgsqlPoint(x: 0.6888197677592492d, y: 0.6934465738558111d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223227647109926d, y: 0.09413599112860627d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7570328772393434d, y: 0.6062916644556561d), new NpgsqlTypes.NpgsqlPoint(x: 0.12927822770112085d, y: 0.767968150697334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7584277094077672d, y: 0.4685437199845819d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.871519153003484d, y: 0.47109205815018396d), new NpgsqlTypes.NpgsqlPoint(x: 0.8619102866926074d, y: 0.07924432758352129d), new NpgsqlTypes.NpgsqlPoint(x: 0.12111381859228032d, y: 0.6464007618655654d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10858297868267885d, y: 0.8607943676283893d), new NpgsqlTypes.NpgsqlPoint(x: 0.7112511962370104d, y: 0.4391651491085614d), new NpgsqlTypes.NpgsqlPoint(x: 0.9695830434747514d, y: 0.5323606481214469d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.045067056762903235d, y: 0.2976983844579004d), new NpgsqlTypes.NpgsqlPoint(x: 0.5660698049113274d, y: 0.772362877089382d), new NpgsqlTypes.NpgsqlPoint(x: 0.19194854200069533d, y: 0.3867802934470379d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34867037351413177d, y: 0.07985530264237017d), new NpgsqlTypes.NpgsqlPoint(x: 0.06586281605336541d, y: 0.06183334403090868d), new NpgsqlTypes.NpgsqlPoint(x: 0.0302599414105863d, y: 0.4420111770993833d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18361271067317808d, y: 0.9198418212095917d), new NpgsqlTypes.NpgsqlPoint(x: 0.6035524990363721d, y: 0.228530348756677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6255782817519243d, y: 0.18318266576520792d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06335557062929609d, y: 0.03337693828994159d), new NpgsqlTypes.NpgsqlPoint(x: 0.13757253288097715d, y: 0.8688403004604522d), new NpgsqlTypes.NpgsqlPoint(x: 0.7492920846387124d, y: 0.04103231082246239d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45551115311030965d, y: 0.43273287147195616d), new NpgsqlTypes.NpgsqlPoint(x: 0.389355512154583d, y: 0.8457645834417823d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833243575379986d, y: 0.6668726848213608d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8225691101549313d, y: 0.06537408912414278d), new NpgsqlTypes.NpgsqlPoint(x: 0.41135928951202083d, y: 0.6612928806884029d), new NpgsqlTypes.NpgsqlPoint(x: 0.02010285940852541d, y: 0.6472660941753814d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5171122608860155d, y: 0.05702429235296791d), new NpgsqlTypes.NpgsqlPoint(x: 0.47888681242992204d, y: 0.6309780547239409d), new NpgsqlTypes.NpgsqlPoint(x: 0.10488971852811702d, y: 0.3044402547943412d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04251367938796846d, y: 0.5071320675564975d), new NpgsqlTypes.NpgsqlPoint(x: 0.08860757812647824d, y: 0.7700710181811354d), new NpgsqlTypes.NpgsqlPoint(x: 0.028196907243301816d, y: 0.4910664000234559d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5476213949043767d, y: 0.5190240143361329d), new NpgsqlTypes.NpgsqlPoint(x: 0.10841275019146179d, y: 0.7186731421511574d), new NpgsqlTypes.NpgsqlPoint(x: 0.32038380839903735d, y: 0.9224126410093139d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4758689619047194d, y: 0.1578091142487419d), new NpgsqlTypes.NpgsqlPoint(x: 0.5688442682340286d, y: 0.4811591391634118d), new NpgsqlTypes.NpgsqlPoint(x: 0.05318230404256985d, y: 0.30005222834252654d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.454633597246637d, y: 0.43201507808082906d), new NpgsqlTypes.NpgsqlPoint(x: 0.01965971502482544d, y: 0.7155919032195794d), new NpgsqlTypes.NpgsqlPoint(x: 0.19034117388123095d, y: 0.23646527603993106d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09547639392743135d, y: 0.4127120434925934d), new NpgsqlTypes.NpgsqlPoint(x: 0.21396367183595033d, y: 0.7095392984211146d), new NpgsqlTypes.NpgsqlPoint(x: 0.36258923941911836d, y: 0.7310710690669311d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2042642946123061d, y: 0.5758772906763236d), new NpgsqlTypes.NpgsqlPoint(x: 0.8771453573852359d, y: 0.14781371664677712d), new NpgsqlTypes.NpgsqlPoint(x: 0.42482404194469603d, y: 0.028617595077915392d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6566739292882454d, y: 0.2810298227760625d), new NpgsqlTypes.NpgsqlPoint(x: 0.38775463556296386d, y: 0.872575591277872d), new NpgsqlTypes.NpgsqlPoint(x: 0.5977609443169494d, y: 0.1775204165255473d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23464699711688208d, y: 0.35221016657625226d), new NpgsqlTypes.NpgsqlPoint(x: 0.806052373603708d, y: 0.23727384364778414d), new NpgsqlTypes.NpgsqlPoint(x: 0.19902771420824117d, y: 0.7855337364942475d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33146960308824314d, y: 0.32616817196435566d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510678125933401d, y: 0.4614561398502325d), new NpgsqlTypes.NpgsqlPoint(x: 0.41874472333304535d, y: 0.8132791096611135d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4044969614973605d, y: 0.09236252357300045d), new NpgsqlTypes.NpgsqlPoint(x: 0.7570161432063929d, y: 0.8291565336352634d), new NpgsqlTypes.NpgsqlPoint(x: 0.9305027676005422d, y: 0.620006086833478d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.375450965158899d, y: 0.5392639494436592d), new NpgsqlTypes.NpgsqlPoint(x: 0.28243669059004284d, y: 0.8997458068696277d), new NpgsqlTypes.NpgsqlPoint(x: 0.38078811657341105d, y: 0.27438751900109504d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5052760540803949d, y: 0.21415205961614014d), new NpgsqlTypes.NpgsqlPoint(x: 0.9792560429080297d, y: 0.6228308292955406d), new NpgsqlTypes.NpgsqlPoint(x: 0.009092508076741002d, y: 0.6079872540327184d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6259833837435899d, y: 0.48024330239188595d), new NpgsqlTypes.NpgsqlPoint(x: 0.6514881243758106d, y: 0.6994186734513402d), new NpgsqlTypes.NpgsqlPoint(x: 0.4895196244065687d, y: 0.20998308711789115d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4522394909550139d, y: 0.5385071214935213d), new NpgsqlTypes.NpgsqlPoint(x: 0.3093775711319977d, y: 0.1716119673756239d), new NpgsqlTypes.NpgsqlPoint(x: 0.41316906312295976d, y: 0.8481594073704569d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31807088470985234d, y: 0.12790442719967832d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785553404341075d, y: 0.9027179135554961d), new NpgsqlTypes.NpgsqlPoint(x: 0.18607761036664794d, y: 0.6443991128950072d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8409911640038314d, y: 0.6368611827217171d), new NpgsqlTypes.NpgsqlPoint(x: 0.447842473439107d, y: 0.20409592473974014d), new NpgsqlTypes.NpgsqlPoint(x: 0.42306143670164587d, y: 0.8205401621307064d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7643718364903009d, y: 0.4949186081308842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8760768156717202d, y: 0.6969696180901503d), new NpgsqlTypes.NpgsqlPoint(x: 0.5929793185461208d, y: 0.31083054112367714d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36244931868373986d, y: 0.9686073003736176d), new NpgsqlTypes.NpgsqlPoint(x: 0.037808350153599846d, y: 0.813889922634626d), new NpgsqlTypes.NpgsqlPoint(x: 0.3223765014197174d, y: 0.27366329967751446d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6088201123959558d, y: 0.32705164884756155d), new NpgsqlTypes.NpgsqlPoint(x: 0.60880448515055d, y: 0.1801025733401016d), new NpgsqlTypes.NpgsqlPoint(x: 0.2898082500868632d, y: 0.43859229700298974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14812035141336077d, y: 0.7468407970862883d), new NpgsqlTypes.NpgsqlPoint(x: 0.2704993990296415d, y: 0.5382711637532567d), new NpgsqlTypes.NpgsqlPoint(x: 0.08579899120659351d, y: 0.7100343104489466d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.509880447884228d, y: 0.9545447357411121d), new NpgsqlTypes.NpgsqlPoint(x: 0.13191659864857785d, y: 0.23334037325128043d), new NpgsqlTypes.NpgsqlPoint(x: 0.11793579606070048d, y: 0.8445715468081798d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9543773411503236d, y: 0.3505448787476484d), new NpgsqlTypes.NpgsqlPoint(x: 0.2673134242628613d, y: 0.6260037155988704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9008766886880446d, y: 0.03932359120482287d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7404578292658154d, y: 0.2420232240351935d), new NpgsqlTypes.NpgsqlPoint(x: 0.7830591217926661d, y: 0.34335454968311796d), new NpgsqlTypes.NpgsqlPoint(x: 0.11827045044601792d, y: 0.7188795291348085d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30538350807233916d, y: 0.8809825118588052d), new NpgsqlTypes.NpgsqlPoint(x: 0.5827405828680116d, y: 0.2284128654676939d), new NpgsqlTypes.NpgsqlPoint(x: 0.521976737499586d, y: 0.7919927501952511d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11791880510453834d, y: 0.21425824159165752d), new NpgsqlTypes.NpgsqlPoint(x: 0.7485815135224887d, y: 0.3349568761376991d), new NpgsqlTypes.NpgsqlPoint(x: 0.536171279352315d, y: 0.5438542936556466d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49143940533587926d, y: 0.5376102145274888d), new NpgsqlTypes.NpgsqlPoint(x: 0.5376817287866117d, y: 0.8045664640340783d), new NpgsqlTypes.NpgsqlPoint(x: 0.8547777855853019d, y: 0.4935293625038376d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4924094586375043d, y: 0.6585965444317234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6342885418988655d, y: 0.4487152645961996d), new NpgsqlTypes.NpgsqlPoint(x: 0.562138566877788d, y: 0.8124122525542862d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1942886012895476d, y: 0.11080721400036753d), new NpgsqlTypes.NpgsqlPoint(x: 0.08543925761867122d, y: 0.3271200184081836d), new NpgsqlTypes.NpgsqlPoint(x: 0.414247680297272d, y: 0.38638716445542276d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6978611322067478d, y: 0.3197101779432747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7617725126464212d, y: 0.9823802480350332d), new NpgsqlTypes.NpgsqlPoint(x: 0.6348122042810264d, y: 0.7453337880879983d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5493688282947071d, y: 0.6856200335417597d), new NpgsqlTypes.NpgsqlPoint(x: 0.2645272826324022d, y: 0.6903387830236152d), new NpgsqlTypes.NpgsqlPoint(x: 0.0437948159206355d, y: 0.45818816698619536d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8194735529472212d, y: 0.5491155552590368d), new NpgsqlTypes.NpgsqlPoint(x: 0.37350821665740086d, y: 0.45386244873771964d), new NpgsqlTypes.NpgsqlPoint(x: 0.584391541195666d, y: 0.6949078026618983d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6026089307102134d, y: 0.14841738373384805d), new NpgsqlTypes.NpgsqlPoint(x: 0.22083943277690254d, y: 0.6011299091783906d), new NpgsqlTypes.NpgsqlPoint(x: 0.9741103380027063d, y: 0.1269150994036975d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3897658024299746d, y: 0.7296272715145646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9382042434032904d, y: 0.8562445974512878d), new NpgsqlTypes.NpgsqlPoint(x: 0.4441609485151823d, y: 0.4749254548160554d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4455088126842818d, y: 0.9683535330016836d), new NpgsqlTypes.NpgsqlPoint(x: 0.45018925290635725d, y: 0.4272897013154513d), new NpgsqlTypes.NpgsqlPoint(x: 0.15724452072106088d, y: 0.4063520479332573d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21241663912725262d, y: 0.35795776682721925d), new NpgsqlTypes.NpgsqlPoint(x: 0.6638263439152933d, y: 0.6669364081667501d), new NpgsqlTypes.NpgsqlPoint(x: 0.25959071610182693d, y: 0.5725998044427713d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32629180643413325d, y: 0.9168740798336763d), new NpgsqlTypes.NpgsqlPoint(x: 0.48832107266648295d, y: 0.996755380908036d), new NpgsqlTypes.NpgsqlPoint(x: 0.2424012216593282d, y: 0.11215358672453724d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26834023374797966d, y: 0.32354053511998804d), new NpgsqlTypes.NpgsqlPoint(x: 0.21376596169497508d, y: 0.2929951127152087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5833145996632312d, y: 7.490589129877101E-05d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8887580546415295d, y: 0.826996202721626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6398710685031954d, y: 0.08232184895855077d), new NpgsqlTypes.NpgsqlPoint(x: 0.640978745319712d, y: 0.9318604694743978d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9814422006484024d, y: 0.8752606930957527d), new NpgsqlTypes.NpgsqlPoint(x: 0.8880184569139276d, y: 0.7458344949386811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9590531071337163d, y: 0.8623512211635879d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20081610200719024d, y: 0.8859581177219268d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158559283801375d, y: 0.7168800230000268d), new NpgsqlTypes.NpgsqlPoint(x: 0.09235953706504585d, y: 0.7991131377997662d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8160540251983431d, y: 0.06337379548837596d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962421225137541d, y: 0.7011055466024154d), new NpgsqlTypes.NpgsqlPoint(x: 0.5929157717677215d, y: 0.7363291576680939d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6606523827486392d, y: 0.8660565154156099d), new NpgsqlTypes.NpgsqlPoint(x: 0.3163227930305581d, y: 0.23920508645163074d), new NpgsqlTypes.NpgsqlPoint(x: 0.16466129938227247d, y: 0.9775729456825037d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3500910057872859d, y: 0.5885527754867924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213805793915415d, y: 0.8485450588831109d), new NpgsqlTypes.NpgsqlPoint(x: 0.32292299884896547d, y: 0.2524621580052473d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31829028611495014d, y: 0.43456547652865196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5647053578385627d, y: 0.79172956765954d), new NpgsqlTypes.NpgsqlPoint(x: 0.21287454802960426d, y: 0.5578395602766453d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4794112308170846d, y: 0.8098671960641671d), new NpgsqlTypes.NpgsqlPoint(x: 0.6421703235177653d, y: 0.9239152669026447d), new NpgsqlTypes.NpgsqlPoint(x: 0.5110963644282086d, y: 0.9897564270500795d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24410724742698076d, y: 0.9485388716189697d), new NpgsqlTypes.NpgsqlPoint(x: 0.6260526205225185d, y: 0.3218406386376226d), new NpgsqlTypes.NpgsqlPoint(x: 0.22665119336908923d, y: 0.06667810599245183d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34090348497463774d, y: 0.3296378860927158d), new NpgsqlTypes.NpgsqlPoint(x: 0.5835235853382683d, y: 0.5798075564920587d), new NpgsqlTypes.NpgsqlPoint(x: 0.09961178000728144d, y: 0.32412864498497507d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022204545276285126d, y: 0.17443759619636456d), new NpgsqlTypes.NpgsqlPoint(x: 0.15373538168978818d, y: 0.21611796260785576d), new NpgsqlTypes.NpgsqlPoint(x: 0.7444499838669235d, y: 0.17884627221361227d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7154541723178645d, y: 0.4972681946636226d), new NpgsqlTypes.NpgsqlPoint(x: 0.16722405431917386d, y: 0.847983797787839d), new NpgsqlTypes.NpgsqlPoint(x: 0.04066177086349676d, y: 0.12904262932189636d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4400670974130404d, y: 0.13191158213724752d), new NpgsqlTypes.NpgsqlPoint(x: 0.09118268762347659d, y: 0.8627922783448292d), new NpgsqlTypes.NpgsqlPoint(x: 0.7082333929204933d, y: 0.1772877775975512d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8448280884981485d, y: 0.7267303854694891d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005047919564014d, y: 0.49316152462346174d), new NpgsqlTypes.NpgsqlPoint(x: 0.34091318514149105d, y: 0.739242033639435d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9051961949898867d, y: 0.30892945449166376d), new NpgsqlTypes.NpgsqlPoint(x: 0.4466186311661047d, y: 0.8122506093416421d), new NpgsqlTypes.NpgsqlPoint(x: 0.45745726097021766d, y: 0.7845481322106828d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04890428969417926d, y: 0.7411090430774225d), new NpgsqlTypes.NpgsqlPoint(x: 0.4986328447905233d, y: 0.7105395827697427d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624309542810699d, y: 0.0824357822071814d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8798907939352364d, y: 0.8304320304125709d), new NpgsqlTypes.NpgsqlPoint(x: 0.43285643450678934d, y: 0.11922552075676496d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327976013177462d, y: 0.04156633959008704d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6476425358815171d, y: 0.912423744692945d), new NpgsqlTypes.NpgsqlPoint(x: 0.2649589833877102d, y: 0.5166125377947476d), new NpgsqlTypes.NpgsqlPoint(x: 0.7598665846754414d, y: 0.6193499553475312d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27390146241982116d, y: 0.6658700275050485d), new NpgsqlTypes.NpgsqlPoint(x: 0.5002413505046107d, y: 0.7676879478665947d), new NpgsqlTypes.NpgsqlPoint(x: 0.6251757453128078d, y: 0.007115423361667816d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16503441839360045d, y: 0.8494477292321166d), new NpgsqlTypes.NpgsqlPoint(x: 0.8806896721243667d, y: 0.836350488083494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8709936553325776d, y: 0.059013896798172594d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4635979835970887d, y: 0.7467161127002807d), new NpgsqlTypes.NpgsqlPoint(x: 0.20462072059793002d, y: 0.11776108041486477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8952313747877352d, y: 0.2665251559316242d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6919420599178377d, y: 0.4419530994295088d), new NpgsqlTypes.NpgsqlPoint(x: 0.9770538079618383d, y: 0.8828398625784858d), new NpgsqlTypes.NpgsqlPoint(x: 0.7170176315941964d, y: 0.389258649691686d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13582280518702383d, y: 0.7226214891962951d), new NpgsqlTypes.NpgsqlPoint(x: 0.9177244865627763d, y: 0.5859259819081879d), new NpgsqlTypes.NpgsqlPoint(x: 0.46805335512480783d, y: 0.16408169936000494d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.031232617892241743d, y: 0.8549655330488627d), new NpgsqlTypes.NpgsqlPoint(x: 0.38942318683849986d, y: 0.9186944067387486d), new NpgsqlTypes.NpgsqlPoint(x: 0.10036095429937175d, y: 0.44905022173151865d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7779392851935629d, y: 0.767871330283109d), new NpgsqlTypes.NpgsqlPoint(x: 0.30167756033492965d, y: 0.7943921462146256d), new NpgsqlTypes.NpgsqlPoint(x: 0.4078314143559232d, y: 0.7463953507499926d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6730595122195348d, y: 0.07981599318897292d), new NpgsqlTypes.NpgsqlPoint(x: 0.7342596466419029d, y: 0.43267546272763147d), new NpgsqlTypes.NpgsqlPoint(x: 0.7249423231949136d, y: 0.4924843963249803d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6356561868686461d, y: 0.10698844732779311d), new NpgsqlTypes.NpgsqlPoint(x: 0.3484499813983565d, y: 0.1746112589945189d), new NpgsqlTypes.NpgsqlPoint(x: 0.2936368110981624d, y: 0.9586890246754406d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39560971061283445d, y: 0.19873584591694105d), new NpgsqlTypes.NpgsqlPoint(x: 0.4642845669645692d, y: 0.7064835506990186d), new NpgsqlTypes.NpgsqlPoint(x: 0.2408780512438804d, y: 0.2851383694016457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03729239007038654d, y: 0.33121916524326056d), new NpgsqlTypes.NpgsqlPoint(x: 0.6671715025352052d, y: 0.057410537371216264d), new NpgsqlTypes.NpgsqlPoint(x: 0.4001237192375098d, y: 0.34698057096232937d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3124008658703993d, y: 0.7846895355145288d), new NpgsqlTypes.NpgsqlPoint(x: 0.6283806749671788d, y: 0.09302699311110663d), new NpgsqlTypes.NpgsqlPoint(x: 0.7176833548621216d, y: 0.39428102156686984d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8798836163958338d, y: 0.021291796943068375d), new NpgsqlTypes.NpgsqlPoint(x: 0.36052827125651976d, y: 0.7797534211123354d), new NpgsqlTypes.NpgsqlPoint(x: 0.989293469820567d, y: 0.902268033010584d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6441212472917964d, y: 0.525875677493135d), new NpgsqlTypes.NpgsqlPoint(x: 0.7298825482532029d, y: 0.8477416065905687d), new NpgsqlTypes.NpgsqlPoint(x: 0.013828170394557082d, y: 0.6519813783248989d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4173662161413346d, y: 0.6879470920997903d), new NpgsqlTypes.NpgsqlPoint(x: 0.5804761127744821d, y: 0.8414158613625092d), new NpgsqlTypes.NpgsqlPoint(x: 0.440967316639735d, y: 0.06605447270542053d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8692589058284198d, y: 0.040037184378549306d), new NpgsqlTypes.NpgsqlPoint(x: 0.5528359742056963d, y: 0.7223177624107007d), new NpgsqlTypes.NpgsqlPoint(x: 0.6753060299964599d, y: 0.023302946311001826d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9064595772755151d, y: 0.6049374671856863d), new NpgsqlTypes.NpgsqlPoint(x: 0.3907772393969974d, y: 0.07724197178677306d), new NpgsqlTypes.NpgsqlPoint(x: 0.4629755226146488d, y: 0.4508337729023726d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.445224709438789d, y: 0.3843801186899217d), new NpgsqlTypes.NpgsqlPoint(x: 0.5665678696873261d, y: 0.5353676574117489d), new NpgsqlTypes.NpgsqlPoint(x: 0.6127320449210072d, y: 5.293546836271368E-05d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15176882817446213d, y: 0.8738499440072366d), new NpgsqlTypes.NpgsqlPoint(x: 0.7609104454109229d, y: 0.667372325920741d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318151860280088d, y: 0.35134709510385964d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9915089542196949d, y: 0.37158200726529966d), new NpgsqlTypes.NpgsqlPoint(x: 0.6934288986124904d, y: 0.8375293469876669d), new NpgsqlTypes.NpgsqlPoint(x: 0.20148809799871692d, y: 0.22341293640591064d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8815745203954319d, y: 0.920392835143545d), new NpgsqlTypes.NpgsqlPoint(x: 0.6493050067908717d, y: 0.5674852474612491d), new NpgsqlTypes.NpgsqlPoint(x: 0.6453748460603087d, y: 0.39834419301286283d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.59304836737064d, y: 0.6020245857550934d), new NpgsqlTypes.NpgsqlPoint(x: 0.4919182135553991d, y: 0.9762312849854516d), new NpgsqlTypes.NpgsqlPoint(x: 0.305079106052367d, y: 0.6127188627000109d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9801089520370769d, y: 0.887215132044811d), new NpgsqlTypes.NpgsqlPoint(x: 0.3866818489229825d, y: 0.9224627492055263d), new NpgsqlTypes.NpgsqlPoint(x: 0.7044760257710743d, y: 0.3054186490478419d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4034251987828913d, y: 0.04328843898973833d), new NpgsqlTypes.NpgsqlPoint(x: 0.2876458134471215d, y: 0.9542325646002116d), new NpgsqlTypes.NpgsqlPoint(x: 0.21016781462556366d, y: 0.599210745253727d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3539501535149523d, y: 0.6667668357231635d), new NpgsqlTypes.NpgsqlPoint(x: 0.9768534641016047d, y: 0.8054953081038717d), new NpgsqlTypes.NpgsqlPoint(x: 0.39365666366989105d, y: 0.6157529538283306d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7184860426853518d, y: 0.45338395432404366d), new NpgsqlTypes.NpgsqlPoint(x: 0.8635756548874162d, y: 0.4061373348676284d), new NpgsqlTypes.NpgsqlPoint(x: 0.9509682777317247d, y: 0.5788045893061304d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1343352097006757d, y: 0.2706677673195361d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899970204069187d, y: 0.7284681512936653d), new NpgsqlTypes.NpgsqlPoint(x: 0.2643534182308932d, y: 0.9277792037838636d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05485116393865286d, y: 0.5659224967546441d), new NpgsqlTypes.NpgsqlPoint(x: 0.08099821068290936d, y: 0.48733302711272675d), new NpgsqlTypes.NpgsqlPoint(x: 0.9335083111681112d, y: 0.9423247364591001d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14991238185863687d, y: 0.856340576203884d), new NpgsqlTypes.NpgsqlPoint(x: 0.13099042605465283d, y: 0.4241543154542534d), new NpgsqlTypes.NpgsqlPoint(x: 0.08415368381133415d, y: 0.4549260844285147d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11692776972949714d, y: 0.6830939046652686d), new NpgsqlTypes.NpgsqlPoint(x: 0.3833343366335834d, y: 0.8941383794976263d), new NpgsqlTypes.NpgsqlPoint(x: 0.22377536645604434d, y: 0.9632304836316326d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24655810811411005d, y: 0.49795116963862396d), new NpgsqlTypes.NpgsqlPoint(x: 0.5046128755188073d, y: 0.6345712578421083d), new NpgsqlTypes.NpgsqlPoint(x: 0.8122757315296522d, y: 0.2946482482079501d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4498275585311873d, y: 0.7304062956599815d), new NpgsqlTypes.NpgsqlPoint(x: 0.26945688337174734d, y: 0.07242085496307171d), new NpgsqlTypes.NpgsqlPoint(x: 0.4394007299545165d, y: 0.5636401462812337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5350136170955088d, y: 0.710251679729081d), new NpgsqlTypes.NpgsqlPoint(x: 0.5093773486775878d, y: 0.2910298497855017d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189640114318916d, y: 0.5220041437782037d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5439393571138567d, y: 0.1487647032061692d), new NpgsqlTypes.NpgsqlPoint(x: 0.03571899942094481d, y: 0.49382939338973986d), new NpgsqlTypes.NpgsqlPoint(x: 0.7315525311809982d, y: 0.6770472652395813d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30695906518093674d, y: 0.9703196705904698d), new NpgsqlTypes.NpgsqlPoint(x: 0.710239481880643d, y: 0.8110664469079957d), new NpgsqlTypes.NpgsqlPoint(x: 0.4109231949553971d, y: 0.9538707802348487d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5118234518934047d, y: 0.08586463059644533d), new NpgsqlTypes.NpgsqlPoint(x: 0.7274951711684569d, y: 0.18328499851567215d), new NpgsqlTypes.NpgsqlPoint(x: 0.40537586994060226d, y: 0.3050227492189367d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39490147496164485d, y: 0.6143677659023098d), new NpgsqlTypes.NpgsqlPoint(x: 0.2670973150470559d, y: 0.4485098312018019d), new NpgsqlTypes.NpgsqlPoint(x: 0.8412954402862666d, y: 0.933202179629082d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8994718101452911d, y: 0.09524889307924322d), new NpgsqlTypes.NpgsqlPoint(x: 0.5352146091319725d, y: 0.7680893208908507d), new NpgsqlTypes.NpgsqlPoint(x: 0.31610682903749276d, y: 0.9063252032409241d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9604104137539918d, y: 0.0693997618496236d), new NpgsqlTypes.NpgsqlPoint(x: 0.5686844812242883d, y: 0.9244493930462966d), new NpgsqlTypes.NpgsqlPoint(x: 0.9577149970089797d, y: 0.5485035836961609d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 181,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9590996757410446d, y: 0.334504337366225d), new NpgsqlTypes.NpgsqlPoint(x: 0.4620108496867693d, y: 0.15060937694653653d), new NpgsqlTypes.NpgsqlPoint(x: 0.7652738875412375d, y: 0.7905678220919395d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06500981891845647d, y: 0.6181512246665983d), new NpgsqlTypes.NpgsqlPoint(x: 0.6576208178919861d, y: 0.1749060499628543d), new NpgsqlTypes.NpgsqlPoint(x: 0.7623898856765566d, y: 0.6495530376992696d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9334861695233487d, y: 0.9467228014496571d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275546096481401d, y: 0.8360987959446048d), new NpgsqlTypes.NpgsqlPoint(x: 0.5958209845741261d, y: 0.055555563222381976d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3016977706664886d, y: 0.7936363585103265d), new NpgsqlTypes.NpgsqlPoint(x: 0.45923508808763625d, y: 0.8963008465495407d), new NpgsqlTypes.NpgsqlPoint(x: 0.9933814844425708d, y: 0.06533395415313181d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4996317966681997d, y: 0.7278230550773795d), new NpgsqlTypes.NpgsqlPoint(x: 0.9500520866101165d, y: 0.29204892211971256d), new NpgsqlTypes.NpgsqlPoint(x: 0.941088709119431d, y: 0.22577003042906274d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9498770092871939d, y: 0.0008566852254053847d), new NpgsqlTypes.NpgsqlPoint(x: 0.7017801731636942d, y: 0.9398168414482767d), new NpgsqlTypes.NpgsqlPoint(x: 0.6550683147464391d, y: 0.6161509903110297d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6323164242776491d, y: 0.6401777025757703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5235779350010872d, y: 0.11808540999182693d), new NpgsqlTypes.NpgsqlPoint(x: 0.888509285244371d, y: 0.7508631232170349d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4707987916448332d, y: 0.8773547348335858d), new NpgsqlTypes.NpgsqlPoint(x: 0.060565856565101495d, y: 0.41397243159705366d), new NpgsqlTypes.NpgsqlPoint(x: 0.2351259156730383d, y: 0.07799729193030358d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 184,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4751536392837803d, y: 0.05146907307353854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8942761269212727d, y: 0.35120887170838977d), new NpgsqlTypes.NpgsqlPoint(x: 0.47322812841927886d, y: 0.9927183355444925d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016268415252895574d, y: 0.7037377440418063d), new NpgsqlTypes.NpgsqlPoint(x: 0.8841420761166294d, y: 0.28805524365186197d), new NpgsqlTypes.NpgsqlPoint(x: 0.11591353271136184d, y: 0.23800165352445024d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48008201228523784d, y: 0.7547981494769282d), new NpgsqlTypes.NpgsqlPoint(x: 0.24893452259623194d, y: 0.3579639385546165d), new NpgsqlTypes.NpgsqlPoint(x: 0.4837790344765086d, y: 0.019276254341400012d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.669239419890434d, y: 0.9654104862755631d), new NpgsqlTypes.NpgsqlPoint(x: 0.4836334605920586d, y: 0.2823269277299516d), new NpgsqlTypes.NpgsqlPoint(x: 0.5375934052670676d, y: 0.374881226987288d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7061548131062936d, y: 0.37028575940186215d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163581231679518d, y: 0.09438933495159407d), new NpgsqlTypes.NpgsqlPoint(x: 0.26008034607076236d, y: 0.2643590192068127d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22198079546083083d, y: 0.8030325699294114d), new NpgsqlTypes.NpgsqlPoint(x: 0.2293078220976158d, y: 0.34655267492860564d), new NpgsqlTypes.NpgsqlPoint(x: 0.8635148461561406d, y: 0.3508227171690178d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.389974414467792d, y: 0.7947764635911219d), new NpgsqlTypes.NpgsqlPoint(x: 0.39860545646559997d, y: 0.2677452658932996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7230853014633237d, y: 0.40633267219831837d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9584613913654981d, y: 0.09860419679205512d), new NpgsqlTypes.NpgsqlPoint(x: 0.24764082623087336d, y: 0.892124695461497d), new NpgsqlTypes.NpgsqlPoint(x: 0.2992420825660663d, y: 0.392582597746291d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09777172409041524d, y: 0.47751595066342567d), new NpgsqlTypes.NpgsqlPoint(x: 0.16868606372938844d, y: 0.7672699394666671d), new NpgsqlTypes.NpgsqlPoint(x: 0.3065528652367008d, y: 0.4712028044108131d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 190,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6196303198914107d, y: 0.01692042929277815d), new NpgsqlTypes.NpgsqlPoint(x: 0.0718579997116432d, y: 0.9505639353470897d), new NpgsqlTypes.NpgsqlPoint(x: 0.009727157784654383d, y: 0.13898409972991554d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2588590213360352d, y: 0.3914460680894719d), new NpgsqlTypes.NpgsqlPoint(x: 0.8244477713120677d, y: 0.6405890273887734d), new NpgsqlTypes.NpgsqlPoint(x: 0.8025272506376991d, y: 0.5924634306367695d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08348087844883512d, y: 0.9299968739799759d), new NpgsqlTypes.NpgsqlPoint(x: 0.09905078935428169d, y: 0.4864471969496871d), new NpgsqlTypes.NpgsqlPoint(x: 0.7108394928117627d, y: 0.9119138347911722d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 197,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5341310768986098d, y: 0.19443514732307765d), new NpgsqlTypes.NpgsqlPoint(x: 0.4870429797803668d, y: 0.8528518541931717d), new NpgsqlTypes.NpgsqlPoint(x: 0.9279216790980859d, y: 0.3237949975496318d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6180072684218971d, y: 0.1809455492540757d), new NpgsqlTypes.NpgsqlPoint(x: 0.38422726422279463d, y: 0.6041642153798478d), new NpgsqlTypes.NpgsqlPoint(x: 0.6873497339440479d, y: 0.7443524473099261d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07971642970060777d, y: 0.36337266827789005d), new NpgsqlTypes.NpgsqlPoint(x: 0.7045538969510647d, y: 0.4707946163374127d), new NpgsqlTypes.NpgsqlPoint(x: 0.2509350069211135d, y: 0.9342389266186896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8925072393704396d, y: 0.8063259486596093d), new NpgsqlTypes.NpgsqlPoint(x: 0.5808009570385705d, y: 0.6462204424854764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6124885295011143d, y: 0.8778824701126641d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29268891386719087d, y: 0.6507483748928623d), new NpgsqlTypes.NpgsqlPoint(x: 0.27617642858040814d, y: 0.12982104952047024d), new NpgsqlTypes.NpgsqlPoint(x: 0.983233818391002d, y: 0.13445456163130676d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7810690102694636d, y: 0.18120823981016554d), new NpgsqlTypes.NpgsqlPoint(x: 0.8969184109051744d, y: 0.3239949725126149d), new NpgsqlTypes.NpgsqlPoint(x: 0.35189797074175755d, y: 0.34190886976160073d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2389301721669238d, y: 0.44960258639880024d), new NpgsqlTypes.NpgsqlPoint(x: 0.36413911990615155d, y: 0.9543771764547558d), new NpgsqlTypes.NpgsqlPoint(x: 0.37170468851995797d, y: 0.30518566974905303d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10150576258901611d, y: 0.6997586940113593d), new NpgsqlTypes.NpgsqlPoint(x: 0.07472185259583108d, y: 0.5904739905538176d), new NpgsqlTypes.NpgsqlPoint(x: 0.19321253730497345d, y: 0.05113653904182025d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8639897821120702d, y: 0.43769355925224107d), new NpgsqlTypes.NpgsqlPoint(x: 0.0128839965430394d, y: 0.7062722836402661d), new NpgsqlTypes.NpgsqlPoint(x: 0.1384582016385657d, y: 0.020869973410404086d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.687058817076169d, y: 0.7627934640789608d), new NpgsqlTypes.NpgsqlPoint(x: 0.8970523566775274d, y: 0.36579967908104494d), new NpgsqlTypes.NpgsqlPoint(x: 0.30860906294105206d, y: 0.6951895658350536d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30076423051605594d, y: 0.7995354452413812d), new NpgsqlTypes.NpgsqlPoint(x: 0.5037452397340044d, y: 0.2428895778367468d), new NpgsqlTypes.NpgsqlPoint(x: 0.9485379929187998d, y: 0.7011740833104528d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08133114517655704d, y: 0.3707560425020594d), new NpgsqlTypes.NpgsqlPoint(x: 0.4088972624776315d, y: 0.7123285326138843d), new NpgsqlTypes.NpgsqlPoint(x: 0.2285946159394382d, y: 0.237532004747655d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5183057103013d, y: 0.6618007933135391d), new NpgsqlTypes.NpgsqlPoint(x: 0.8955572859387283d, y: 0.8739516109127923d), new NpgsqlTypes.NpgsqlPoint(x: 0.13762948861597457d, y: 0.29258281470571335d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8679556287482241d, y: 0.9101607927909824d), new NpgsqlTypes.NpgsqlPoint(x: 0.7471242160585494d, y: 0.16662929448638242d), new NpgsqlTypes.NpgsqlPoint(x: 0.4348846715695075d, y: 0.13053213990208767d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6892106624897156d, y: 0.4685731062917441d), new NpgsqlTypes.NpgsqlPoint(x: 0.9887110491964952d, y: 0.5049201820208818d), new NpgsqlTypes.NpgsqlPoint(x: 0.14652817118754968d, y: 0.5920135909646687d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 198,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7755205301698108d, y: 0.404070296835762d), new NpgsqlTypes.NpgsqlPoint(x: 0.5571273692311278d, y: 0.05101773819377087d), new NpgsqlTypes.NpgsqlPoint(x: 0.1949369012088853d, y: 0.9161191732488289d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3438760151756335d, y: 0.6098640823547825d), new NpgsqlTypes.NpgsqlPoint(x: 0.7182852614081557d, y: 0.8772260760398275d), new NpgsqlTypes.NpgsqlPoint(x: 0.21185768299765606d, y: 0.7688751888146929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03891914477103953d, y: 0.6657804080539422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9199019794885414d, y: 0.1508063728763206d), new NpgsqlTypes.NpgsqlPoint(x: 0.13911741425287538d, y: 0.9417564386763092d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003195873307589081d, y: 0.6542084461639351d), new NpgsqlTypes.NpgsqlPoint(x: 0.7056963386344445d, y: 0.48873825798700654d), new NpgsqlTypes.NpgsqlPoint(x: 0.4696240153058622d, y: 0.9099522073600336d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5235844083040633d, y: 0.5060927557461612d), new NpgsqlTypes.NpgsqlPoint(x: 0.49406645833114216d, y: 0.2609135729315505d), new NpgsqlTypes.NpgsqlPoint(x: 0.38230874377608104d, y: 0.8167831600771369d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10010815629296788d, y: 0.8047465197204666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114018355612118d, y: 0.4841218745286743d), new NpgsqlTypes.NpgsqlPoint(x: 0.13775229065168793d, y: 0.04484536355325952d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
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

                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4460418016966583d, y: 0.09883728104925471d), new NpgsqlTypes.NpgsqlPoint(x: 0.3987709658946539d, y: 0.26700248254712267d), new NpgsqlTypes.NpgsqlPoint(x: 0.4970564084450606d, y: 0.12080037275949951d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0812733026947674d, y: 0.9918046769227558d), new NpgsqlTypes.NpgsqlPoint(x: 0.053456364724673744d, y: 0.7171509089495223d), new NpgsqlTypes.NpgsqlPoint(x: 0.07643837036666634d, y: 0.6212221631436236d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9781109557944403d, y: 0.8280700610687635d), new NpgsqlTypes.NpgsqlPoint(x: 0.7456839535740464d, y: 0.022041485392319093d), new NpgsqlTypes.NpgsqlPoint(x: 0.39525151140763626d, y: 0.2295152903005897d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5795726999273952d, y: 0.021054094050393157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9562259340054379d, y: 0.5049926353110377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8560981323857385d, y: 0.02359778573221505d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.078205093779671d, y: 0.7191748335197248d), new NpgsqlTypes.NpgsqlPoint(x: 0.4003493150848628d, y: 0.7240884167112436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5712897865517983d, y: 0.774958305096788d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9960660453953787d, y: 0.05619395280121198d), new NpgsqlTypes.NpgsqlPoint(x: 0.5024482196119329d, y: 0.7245620081010986d), new NpgsqlTypes.NpgsqlPoint(x: 0.3697382632776477d, y: 0.9729278245250988d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.684856455770357d, y: 0.902434137216473d), new NpgsqlTypes.NpgsqlPoint(x: 0.5879732779226949d, y: 0.27662299805288515d), new NpgsqlTypes.NpgsqlPoint(x: 0.0770322370660127d, y: 0.7425729675348858d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.774409531374479d, y: 0.3790596241551807d), new NpgsqlTypes.NpgsqlPoint(x: 0.020376795629504563d, y: 0.7701585162290149d), new NpgsqlTypes.NpgsqlPoint(x: 0.9968756718566187d, y: 0.2161286617580237d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8076198280443742d, y: 0.42099256620798575d), new NpgsqlTypes.NpgsqlPoint(x: 0.8014469820429612d, y: 0.2019664840157286d), new NpgsqlTypes.NpgsqlPoint(x: 0.952840672305548d, y: 0.12661310816196159d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8173037170692224d, y: 0.536523834284481d), new NpgsqlTypes.NpgsqlPoint(x: 0.19481284832531331d, y: 0.5934804001253199d), new NpgsqlTypes.NpgsqlPoint(x: 0.3413693184378791d, y: 0.5003411923662923d)),
}));
                nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.777069919200026d, y: 0.541439506721454d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397499764118927d, y: 0.2412131627716696d), new NpgsqlTypes.NpgsqlPoint(x: 0.46388441165714867d, y: 0.4160191813048978d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4711528297392491d, y: 0.598344927368882d), new NpgsqlTypes.NpgsqlPoint(x: 0.7897465148966613d, y: 0.12765187823337054d), new NpgsqlTypes.NpgsqlPoint(x: 0.3242427444565392d, y: 0.9972142268247205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4220419800983102d, y: 0.28787451549578025d), new NpgsqlTypes.NpgsqlPoint(x: 0.18641538090781595d, y: 0.41492354785118934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9765201433014339d, y: 0.15904096265806622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0746518354207173d, y: 0.017528322150356934d), new NpgsqlTypes.NpgsqlPoint(x: 0.7208304703242671d, y: 0.3836749715210809d), new NpgsqlTypes.NpgsqlPoint(x: 0.9340230772880422d, y: 0.5109758316872136d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD1E1M> models = null;

                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD1E1M> models = null;

                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 190;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 174;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 156, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 123, query1, 184, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 50, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 99, query1, 184, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 41, query1, 135, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 113, query1, 105, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 143, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 190, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 126, 105))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 126, 174))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 181);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 83);
                var models =  ((INpgsqlPathMArraypathMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
FROM public.binary_npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathMArraypathMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI), typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

