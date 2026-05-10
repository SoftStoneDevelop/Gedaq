

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
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.625102149436149d, y: 0.1109856976859167d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09428589152801048d, y: 0.8315515168608296d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8029708544907919d, y: 0.7906320160804651d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7507085880511273d, y: 0.9154770450813409d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5881265420479551d, y: 0.20481618960890258d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6161480770996094d, y: 0.12160236794684176d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.62538070544288d, y: 0.6340724103727599d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7970260594273173d, y: 0.011252130876892363d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14683751246072463d, y: 0.6378819593195646d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19767046111661146d, y: 0.32712570794394635d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09146123772277681d, y: 0.7842062857834476d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2292825070998451d, y: 0.027882844249437766d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5022904064481277d, y: 0.9818418678762534d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3834762138084339d, y: 0.21258892806313923d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4259374660471552d, y: 0.6797166424295704d),
new NpgsqlTypes.NpgsqlPoint(x: 0.75957291349578d, y: 0.3482758904341141d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7507095170068618d, y: 0.095610978729459d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6437285851249042d, y: 0.36292750787894634d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7796115767583852d, y: 0.2207974108079337d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16390548829724272d, y: 0.3451286362228938d),
new NpgsqlTypes.NpgsqlPoint(x: 0.971647045512034d, y: 0.8662281603595462d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5822046965689185d, y: 0.7492219417337986d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2049562928832276d, y: 0.02057314523825493d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6612773184692117d, y: 0.6617354440864278d),
new NpgsqlTypes.NpgsqlPoint(x: 0.882057039438477d, y: 0.04558253009764757d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9045029281420183d, y: 0.38495443308016d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7883038588509852d, y: 0.49445798387027284d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8081647711063881d, y: 0.6538833908920051d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9462377908641546d, y: 0.7464498108131512d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25126138373129403d, y: 0.32254502705794574d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2723846936052612d, y: 0.7402094442571984d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12129793392948751d, y: 0.8025901603490151d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10222520839858451d, y: 0.6368156406208345d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7749046265710504d, y: 0.7453971346476647d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3144714498559317d, y: 0.15847482954917225d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5555680603762041d, y: 0.9532711876799826d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06007222320388228d, y: 0.8620130110793625d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9435391095796618d, y: 0.6347576907708279d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8360733500941363d, y: 0.36714128368912446d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2968752060238651d, y: 0.43947957821001526d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6645208785266631d, y: 0.4742241650694319d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9089010001770077d, y: 0.21147837768790612d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6909720196847821d, y: 0.8610007030369554d),
new NpgsqlTypes.NpgsqlPoint(x: 0.567905685976676d, y: 0.539249572811703d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9212001411365359d, y: 0.5952757976525127d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8051759331920884d, y: 0.8786222093521017d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3996295830813109d, y: 0.937482883678833d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49747893435446d, y: 0.834577698166646d),
new NpgsqlTypes.NpgsqlPoint(x: 0.983303731493231d, y: 0.10010701830124646d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5749120352912316d, y: 0.36341568664972124d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5870704557277152d, y: 0.5635471612553802d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12927673515241367d, y: 0.08956842392612485d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0940923632635211d, y: 0.5171742822627227d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6723262320020905d, y: 0.8458121912819127d),
new NpgsqlTypes.NpgsqlPoint(x: 0.012585481158991385d, y: 0.8092563755198373d),
new NpgsqlTypes.NpgsqlPoint(x: 0.78118590071229d, y: 0.5262256995320308d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2111839887162681d, y: 0.7282651746481277d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5566247561712298d, y: 0.5732761564821846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5759980791313104d, y: 0.5664795029094787d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36360663920311753d, y: 0.7965517022895748d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3050303913481065d, y: 0.6059164343529513d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6190616354161881d, y: 0.3860633970990296d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34114160131680715d, y: 0.9140987084181215d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9395396724764095d, y: 0.9678308736212832d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7469494674863335d, y: 0.8896411980948015d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8793968835771669d, y: 0.3188900772282369d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6646220615602512d, y: 0.2842798335730262d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0913498274148915d, y: 0.7755100459244801d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03458788415479552d, y: 0.012011889657771557d),
new NpgsqlTypes.NpgsqlPoint(x: 0.545771459855082d, y: 0.6647753443853274d),
new NpgsqlTypes.NpgsqlPoint(x: 0.518465258414173d, y: 0.2613491816189091d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11674782337692313d, y: 0.4786720393373768d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3417992279170817d, y: 0.42685922170753143d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9033264663703914d, y: 0.1692465231997512d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8495544405402721d, y: 0.3586610694525172d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5801433275929306d, y: 0.040422269863621074d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8055639824723365d, y: 0.4747331621424835d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26441487274826225d, y: 0.4285749048265275d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6335066458072011d, y: 0.05452557618423348d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4230781529598302d, y: 0.4413098348771072d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4073000613019223d, y: 0.17189466545496146d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5991117324405012d, y: 0.8476506145761763d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36874568780906725d, y: 0.2930860160502631d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12736449684538198d, y: 0.06655466654386932d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33466885600490603d, y: 0.5744731344116658d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27814954159975247d, y: 0.5894872257877021d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2580697026692115d, y: 0.15177832072536657d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9210948400128388d, y: 0.02477685530629803d),
new NpgsqlTypes.NpgsqlPoint(x: 0.652469313898057d, y: 0.6479601223315331d),
new NpgsqlTypes.NpgsqlPoint(x: 0.005982193284279291d, y: 0.9814777041319475d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9094328963268516d, y: 0.6986550714762202d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23753681116815561d, y: 0.7952926661464704d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12839794476609345d, y: 0.35390115412639367d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9870168218763601d, y: 0.8789816427871755d),
new NpgsqlTypes.NpgsqlPoint(x: 0.057057442263290126d, y: 0.35307800216453944d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7894578528135655d, y: 0.8187788565405988d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9922676634424584d, y: 0.04979941996090076d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9476053234699651d, y: 0.6608701774589699d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11857731010688233d, y: 0.5376378291072205d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7012318544924496d, y: 0.060051840644269716d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2622869414988188d, y: 0.04375189005390967d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6871854319876675d, y: 0.2859113193179186d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9964367020654294d, y: 0.7525138285375208d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9898301802163648d, y: 0.8281616312741007d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7481773096727713d, y: 0.866584921310006d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.053980200716570725d, y: 0.21740399295706636d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5325284748246233d, y: 0.09863487141685823d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9169747840843548d, y: 0.3574737984729248d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7987910796571374d, y: 0.5080712651236099d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6733770340589839d, y: 0.7338505998603466d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8113583840784305d, y: 0.5421039247244921d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14971638571726775d, y: 0.03547093609746588d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4771852220172279d, y: 0.8835988990937912d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6881723005328171d, y: 0.8254350338309273d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0354542448204872d, y: 0.07267649187364322d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8521505056526986d, y: 0.12740522192823367d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20355585010473298d, y: 0.7400778240702042d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7865825653315306d, y: 0.584188191599044d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3949183581692517d, y: 0.3118023336041663d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23815735781663327d, y: 0.8887908444388056d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8284046175531752d, y: 0.7313063494718186d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10743708986487654d, y: 0.6940649877082751d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9620081338803702d, y: 0.3866273131593845d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2135004529628015d, y: 0.48722927730166166d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06788141825441862d, y: 0.9627737288193929d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6766609922341291d, y: 0.06824645539865182d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5690610720462015d, y: 0.34654768750655884d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07717023556281266d, y: 0.0037373502982664952d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5479302266773362d, y: 0.4892684284620191d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5334321639261809d, y: 0.1419165541649633d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6909880007767983d, y: 0.11615131377197618d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9427977632648885d, y: 0.9827545417080215d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21436532602939462d, y: 0.37536673327768355d),
new NpgsqlTypes.NpgsqlPoint(x: 0.034332398840873024d, y: 0.8594989804116463d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7249222945619312d, y: 0.7095128850923248d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7344004994684344d, y: 0.6824515226274068d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43958944559090873d, y: 0.5336866534201988d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4925998597659935d, y: 0.022684562936696073d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9808371528659706d, y: 0.47877505546686105d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12261476994637366d, y: 0.27938510376424364d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8249415508108339d, y: 0.07006756652911217d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03128021257717539d, y: 0.6387451158285361d),
new NpgsqlTypes.NpgsqlPoint(x: 0.691190069663616d, y: 0.05811095488499529d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04097645446113396d, y: 0.5057767818064715d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0618594835102787d, y: 0.04441089375931573d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2880699469695893d, y: 0.5805465698242487d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3133281351251348d, y: 0.002513313067507905d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05428200686992124d, y: 0.6745908789280889d),
new NpgsqlTypes.NpgsqlPoint(x: 0.046493484821914954d, y: 0.8633208323233661d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33709736836310866d, y: 0.45943941464185256d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3468462321588205d, y: 0.24402111478822963d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.303714611358339d, y: 0.7488653050434146d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4586913157397967d, y: 0.6847982194458158d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4286449514087466d, y: 0.4616166532140449d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5607123039065014d, y: 0.7900921340054894d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1217876447198879d, y: 0.6341617662833232d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8077104703714525d, y: 0.9796441222820913d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4555598546406767d, y: 0.9658545933092041d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8738006017509984d, y: 0.3306018078342694d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6863981469526201d, y: 0.06959912681013247d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9170851863670321d, y: 0.6118806395079425d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5297008643447413d, y: 0.3363780468816061d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39668836406855035d, y: 0.9154818613846518d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0031861710722146386d, y: 0.23317879197757585d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9391753411469614d, y: 0.7719100889093448d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5958798093078613d, y: 0.9518635947433551d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13178405108037938d, y: 0.6193014989814996d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3793899326979979d, y: 0.2273415756362166d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8700978524145567d, y: 0.31717138838903725d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5013712878101544d, y: 0.5769503370638795d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31399409259221d, y: 0.22449475540620822d),
new NpgsqlTypes.NpgsqlPoint(x: 0.139830916054977d, y: 0.7125938548640658d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34872057842773385d, y: 0.8652102455597848d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6571507888883854d, y: 0.20855171401630523d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6691311766393664d, y: 0.6369176898041282d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38111937371775995d, y: 0.2342016897753244d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17867679298872907d, y: 0.1309662617119015d),
new NpgsqlTypes.NpgsqlPoint(x: 0.420653235346201d, y: 0.6659976660288983d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8255218026384932d, y: 0.5976943485161849d),
new NpgsqlTypes.NpgsqlPoint(x: 0.032489822323574225d, y: 0.4850190744560413d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6522652749746324d, y: 0.7305406749438182d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8528070839327323d, y: 0.6702947206623663d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8101417415257012d, y: 0.631147804590503d),
new NpgsqlTypes.NpgsqlPoint(x: 0.56406854138416d, y: 0.7381161242205452d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20272004461199566d, y: 0.5967291190145738d),
new NpgsqlTypes.NpgsqlPoint(x: 0.008038292163443428d, y: 0.8487635150775628d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5133999055893057d, y: 0.13270131864785495d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5966631596633775d, y: 0.35936425806845185d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5947197222808908d, y: 0.44416769165924996d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8457991512005576d, y: 0.8341715657900635d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3856500035172673d, y: 0.18541732097076236d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6668379599132223d, y: 0.9296365190976397d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6932705474904931d, y: 0.8487881417960093d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27668320872681085d, y: 0.3729865686373234d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7480563585930804d, y: 0.10911694001530625d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4967966360163225d, y: 0.39161447325498344d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0007243024928033082d, y: 0.7527023777116865d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2703725783248053d, y: 0.26310635395583726d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5426675593330202d, y: 0.9177836618744273d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9752382055591047d, y: 0.1025132917169862d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4397381938483971d, y: 0.6098886679246834d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7516889703573194d, y: 0.12102578658270224d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2252087581622182d, y: 0.6410783421968248d),
new NpgsqlTypes.NpgsqlPoint(x: 0.923292345228181d, y: 0.8427338710525967d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.923965952618535d, y: 0.2907387098427703d),
new NpgsqlTypes.NpgsqlPoint(x: 0.327330378178886d, y: 0.7947922323341188d),
new NpgsqlTypes.NpgsqlPoint(x: 0.041020813786463384d, y: 0.23734785419308635d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25961391663884015d, y: 0.6467482514244669d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24854043331914488d, y: 0.4592732103036953d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2716165692279241d, y: 0.21736171831521367d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9628278037291947d, y: 0.052525310427979144d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5302464996035225d, y: 0.0833782756750655d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7753806269165023d, y: 0.6616915199195692d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8750154367670964d, y: 0.023622466185461932d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5104551827790001d, y: 0.28437534439722767d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6206555208474813d, y: 0.7422330931049811d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4941728639998313d, y: 0.5668390558193331d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8830074962357859d, y: 0.33890283594214266d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8184324075308765d, y: 0.4165007287525241d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10953537928176837d, y: 0.46396010485156347d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29890382836846274d, y: 0.5877013128229783d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6919939576125067d, y: 0.1870655108338637d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7511205222015181d, y: 0.8275534930564756d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7085375387750971d, y: 0.2638955361789471d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4744773849089975d, y: 0.27331042014297613d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5846470451480877d, y: 0.9125025424442618d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4301230780641352d, y: 0.9629880862708822d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5081477025420011d, y: 0.0700071490853793d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.026558326807370136d, y: 0.6005738341865405d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33432444579608267d, y: 0.9034876591257007d),
new NpgsqlTypes.NpgsqlPoint(x: 0.667676594562865d, y: 0.8164711818888815d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6646573483734195d, y: 0.3516465835774736d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6578459502633504d, y: 0.09884085379566276d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6628896976232009d, y: 0.9228171330866611d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4772640674349049d, y: 0.1369097509392384d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.007619104669989274d, y: 0.07016791972601188d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39253251449604987d, y: 0.30574641036644357d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21800024226507697d, y: 0.4531880707953584d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6295738615096369d, y: 0.5241878555260067d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09618776055054135d, y: 0.6176348104645614d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8784618701559413d, y: 0.4415319908881671d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8968426008785524d, y: 0.7933762285615923d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6137721625682134d, y: 0.3577826471762401d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7850395130361942d, y: 0.27341152027111026d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1798739266099636d, y: 0.8639307361222642d),
new NpgsqlTypes.NpgsqlPoint(x: 0.008692587534761098d, y: 0.2513104874029668d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3783696333463191d, y: 0.845715274690292d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7662483555769217d, y: 0.7128601636899327d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8448089076234869d, y: 0.5941498136263643d),
new NpgsqlTypes.NpgsqlPoint(x: 0.687715910852926d, y: 0.9314811842497634d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07737678931480685d, y: 0.6939237556999932d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23522832388314863d, y: 0.5388035366669968d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3375717965154287d, y: 0.4801035615090944d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7011431432024569d, y: 0.07571426139511395d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8584419838162747d, y: 0.9043670440604222d),
new NpgsqlTypes.NpgsqlPoint(x: 0.560918121503537d, y: 0.7196672579438644d),
new NpgsqlTypes.NpgsqlPoint(x: 0.008242850993257833d, y: 0.4791907945983219d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7557542815728491d, y: 0.2304737229704913d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9631809513839122d, y: 0.850491104895371d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2557336805635332d, y: 0.11359867680465241d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21279909534806174d, y: 0.2761361176941276d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46771941985170196d, y: 0.3652303430011199d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6297148796350625d, y: 0.21489975864257682d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2638713274233512d, y: 0.0253556618163151d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7615396005687155d, y: 0.5867565791257237d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5923922470904708d, y: 0.4993063690034375d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7940376138089899d, y: 0.05941945093974588d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8078480219927903d, y: 0.9549961493791029d),
new NpgsqlTypes.NpgsqlPoint(x: 0.731002480465653d, y: 0.5046408287925229d),
new NpgsqlTypes.NpgsqlPoint(x: 0.847289660382604d, y: 0.012463992759387699d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5687023203749834d, y: 0.7602938171434429d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5409148499663956d, y: 0.4917670609755064d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7959675995367733d, y: 0.6221456596449343d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34310081419585026d, y: 0.709689196558288d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14027924927913948d, y: 0.2924673837285483d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3976781151953761d, y: 0.30839127613692685d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6629194770510246d, y: 0.5287870093340478d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5653177684281159d, y: 0.6853094562226781d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6855191227825225d, y: 0.14878011791185464d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3943079724693702d, y: 0.18458116645022393d),
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9435391095796618d, y: 0.6347576907708279d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8360733500941363d, y: 0.36714128368912446d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2968752060238651d, y: 0.43947957821001526d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6645208785266631d, y: 0.4742241650694319d),
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
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5749120352912316d, y: 0.36341568664972124d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5870704557277152d, y: 0.5635471612553802d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12927673515241367d, y: 0.08956842392612485d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2111839887162681d, y: 0.7282651746481277d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5566247561712298d, y: 0.5732761564821846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5759980791313104d, y: 0.5664795029094787d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36360663920311753d, y: 0.7965517022895748d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03458788415479552d, y: 0.012011889657771557d),
new NpgsqlTypes.NpgsqlPoint(x: 0.545771459855082d, y: 0.6647753443853274d),
new NpgsqlTypes.NpgsqlPoint(x: 0.518465258414173d, y: 0.2613491816189091d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5801433275929306d, y: 0.040422269863621074d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8055639824723365d, y: 0.4747331621424835d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26441487274826225d, y: 0.4285749048265275d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6335066458072011d, y: 0.05452557618423348d),
}));
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.053980200716570725d, y: 0.21740399295706636d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5325284748246233d, y: 0.09863487141685823d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9169747840843548d, y: 0.3574737984729248d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7987910796571374d, y: 0.5080712651236099d),
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
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
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
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
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
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 71;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

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
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
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
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 87, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 58, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 101, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 10, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
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
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 4, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[34], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 46, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 15, query1, 92, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[34], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 48, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 74, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 69, 104))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[34], false);
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
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[30], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[31], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[32], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[33], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 17);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[29], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[30], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[31], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[32], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[33], false);
                NpgsqlPointpointArray1M.AssertModel(models[29],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void WASelectImportModelInnerConfig()
        {
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI), typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                await ((INpgsqlPointArraypointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                ((INpgsqlPointArraypointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointArraypointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

