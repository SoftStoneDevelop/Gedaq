

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29399324905065516d, y: 0.5634163078902868d), new NpgsqlTypes.NpgsqlPoint(x: 0.8283263970964344d, y: 0.6476376608982012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8262895177265105d, y: 0.5938453904622966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7623380182921938d, y: 0.23202263463298d), new NpgsqlTypes.NpgsqlPoint(x: 0.7352025551382447d, y: 0.17870292213118688d), new NpgsqlTypes.NpgsqlPoint(x: 0.4676197341351527d, y: 0.2704507521893541d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06128834022111307d, y: 0.30942837881693785d), new NpgsqlTypes.NpgsqlPoint(x: 0.4352110285450358d, y: 0.8045885262601159d), new NpgsqlTypes.NpgsqlPoint(x: 0.10142113680984843d, y: 0.05215065632806748d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.506568049641784d, y: 0.5591325993050709d), new NpgsqlTypes.NpgsqlPoint(x: 0.9368941250762359d, y: 0.5296626966431395d), new NpgsqlTypes.NpgsqlPoint(x: 0.6067407157727003d, y: 0.16197703819898834d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.031956451711220524d, y: 0.46996027024149956d), new NpgsqlTypes.NpgsqlPoint(x: 0.591914529742096d, y: 0.08879424844934936d), new NpgsqlTypes.NpgsqlPoint(x: 0.698832136875461d, y: 0.5764309021090783d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5282914921706766d, y: 0.5196527341833106d), new NpgsqlTypes.NpgsqlPoint(x: 0.07059170044347374d, y: 0.2306156849815012d), new NpgsqlTypes.NpgsqlPoint(x: 0.9515132648829547d, y: 0.9862154743917305d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2933335668314889d, y: 0.06299575897488552d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973107058580656d, y: 0.009992670010181448d), new NpgsqlTypes.NpgsqlPoint(x: 0.27221403248921705d, y: 0.7925469897585995d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1166738759018523d, y: 0.7739043897302246d), new NpgsqlTypes.NpgsqlPoint(x: 0.8027325468000683d, y: 0.7311421632557374d), new NpgsqlTypes.NpgsqlPoint(x: 0.07577799465453028d, y: 0.32765157314197724d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8311138167188266d, y: 0.9733589402723994d), new NpgsqlTypes.NpgsqlPoint(x: 0.11511959904079894d, y: 0.15067659346719675d), new NpgsqlTypes.NpgsqlPoint(x: 0.5591759287016023d, y: 0.8914989037554395d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7642317596826536d, y: 0.2719187211074341d), new NpgsqlTypes.NpgsqlPoint(x: 0.7191865639578559d, y: 0.26366895101574406d), new NpgsqlTypes.NpgsqlPoint(x: 0.658999716278381d, y: 0.25099014191839586d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4878274701968177d, y: 0.8460250947703614d), new NpgsqlTypes.NpgsqlPoint(x: 0.009530517834325347d, y: 0.2918686390798618d), new NpgsqlTypes.NpgsqlPoint(x: 0.10759714221267047d, y: 0.08584448775491893d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2481297574948057d, y: 0.3204984598651983d), new NpgsqlTypes.NpgsqlPoint(x: 0.5951899907195665d, y: 0.6094475882159642d), new NpgsqlTypes.NpgsqlPoint(x: 0.9340788046945576d, y: 0.2375692102303295d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6366208756608447d, y: 0.48193729110436756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5943319444526365d, y: 0.9614480655746489d), new NpgsqlTypes.NpgsqlPoint(x: 0.8194802210208115d, y: 0.3149562745034584d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28953266309340187d, y: 0.8152388028788995d), new NpgsqlTypes.NpgsqlPoint(x: 0.03831032629076536d, y: 0.16260239181667313d), new NpgsqlTypes.NpgsqlPoint(x: 0.897544911769943d, y: 0.14427395120666398d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6564118249217774d, y: 0.7202906739847433d), new NpgsqlTypes.NpgsqlPoint(x: 0.2799915640155267d, y: 0.651627244223275d), new NpgsqlTypes.NpgsqlPoint(x: 0.21612166652711595d, y: 0.2624189668329606d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8813201980077331d, y: 0.807545533878594d), new NpgsqlTypes.NpgsqlPoint(x: 0.13099152589073637d, y: 0.7998951002714394d), new NpgsqlTypes.NpgsqlPoint(x: 0.3959949318688134d, y: 0.7006676561921554d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9104069412632539d, y: 0.5522942034721362d), new NpgsqlTypes.NpgsqlPoint(x: 0.030189026745902847d, y: 0.29886400050090245d), new NpgsqlTypes.NpgsqlPoint(x: 0.23877889806924024d, y: 0.13439181183854498d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47978280967036524d, y: 0.6106622013041029d), new NpgsqlTypes.NpgsqlPoint(x: 0.4580094004479893d, y: 0.8688635446336945d), new NpgsqlTypes.NpgsqlPoint(x: 0.8549773850932246d, y: 0.10298886014058906d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03317203965559179d, y: 0.9302188173149402d), new NpgsqlTypes.NpgsqlPoint(x: 0.15368547376482122d, y: 0.7092559472783029d), new NpgsqlTypes.NpgsqlPoint(x: 0.8755990546339564d, y: 0.5722785432394799d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2493803192500328d, y: 0.47812545713166454d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671057088407389d, y: 0.129291264702181d), new NpgsqlTypes.NpgsqlPoint(x: 0.5968210528356891d, y: 0.6063806334579491d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5056829078645353d, y: 0.8366735396704088d), new NpgsqlTypes.NpgsqlPoint(x: 0.7948702365107755d, y: 0.08501295804067055d), new NpgsqlTypes.NpgsqlPoint(x: 0.9935893759477293d, y: 0.47771938205019016d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8459404571976497d, y: 0.2614824240285957d), new NpgsqlTypes.NpgsqlPoint(x: 0.3842716240473051d, y: 0.38502914547168643d), new NpgsqlTypes.NpgsqlPoint(x: 0.32653737398436145d, y: 0.06458033321358914d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8766046873086816d, y: 0.9493207220976633d), new NpgsqlTypes.NpgsqlPoint(x: 0.8571701239636852d, y: 0.8032694687016508d), new NpgsqlTypes.NpgsqlPoint(x: 0.16501135547616474d, y: 0.3278852423014611d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2473086840299531d, y: 0.9900752369465903d), new NpgsqlTypes.NpgsqlPoint(x: 0.20750493604906928d, y: 0.8503517497230703d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785489094841546d, y: 0.030743280951988083d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3911702556483434d, y: 0.9594920427495226d), new NpgsqlTypes.NpgsqlPoint(x: 0.3113120143578685d, y: 0.3483579849783247d), new NpgsqlTypes.NpgsqlPoint(x: 0.11713104681778752d, y: 0.04306327817476174d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02292193872409365d, y: 0.4846444260292002d), new NpgsqlTypes.NpgsqlPoint(x: 0.2409594885695423d, y: 0.02845452294243056d), new NpgsqlTypes.NpgsqlPoint(x: 0.13659104624718665d, y: 0.42013620695350284d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9438761050852891d, y: 0.8183870497947492d), new NpgsqlTypes.NpgsqlPoint(x: 0.979638797404005d, y: 0.5420737478421982d), new NpgsqlTypes.NpgsqlPoint(x: 0.8737522993863528d, y: 0.5494649104138308d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9167910221887687d, y: 0.6847496196436286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6391252672224943d, y: 0.8057900263852564d), new NpgsqlTypes.NpgsqlPoint(x: 0.3965499616620016d, y: 0.4915205874044185d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8281486728648818d, y: 0.07640311948131073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728109810741858d, y: 0.4449661130057949d), new NpgsqlTypes.NpgsqlPoint(x: 0.23170576580586788d, y: 0.33512708411745085d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22302757236588544d, y: 0.45553982457080655d), new NpgsqlTypes.NpgsqlPoint(x: 0.16480189357551656d, y: 0.30925369923736634d), new NpgsqlTypes.NpgsqlPoint(x: 0.6057929021349915d, y: 0.2806530373512377d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39248255526521525d, y: 0.8582317571796799d), new NpgsqlTypes.NpgsqlPoint(x: 0.816804873141611d, y: 0.9875670418087129d), new NpgsqlTypes.NpgsqlPoint(x: 0.9633746580423929d, y: 0.7872930147655478d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05802246836101688d, y: 0.17090175703413202d), new NpgsqlTypes.NpgsqlPoint(x: 0.6436782756613431d, y: 0.8045436449698314d), new NpgsqlTypes.NpgsqlPoint(x: 0.597601056162975d, y: 0.33247368883967265d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6318416157618618d, y: 0.7609215135480807d), new NpgsqlTypes.NpgsqlPoint(x: 0.26024877658252654d, y: 0.04263121076677423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5402096098434643d, y: 0.6870805683707173d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23902021181297273d, y: 0.3068867336588885d), new NpgsqlTypes.NpgsqlPoint(x: 0.21213814322215607d, y: 0.14065793321359377d), new NpgsqlTypes.NpgsqlPoint(x: 0.1605457743899974d, y: 0.9853120339252069d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7046285324011308d, y: 0.5785192364031116d), new NpgsqlTypes.NpgsqlPoint(x: 0.268659585744103d, y: 0.8154587929076185d), new NpgsqlTypes.NpgsqlPoint(x: 0.4041713446021181d, y: 0.11059984175478921d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5596789027206236d, y: 0.8333793957494594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005552178881087d, y: 0.19453625272807507d), new NpgsqlTypes.NpgsqlPoint(x: 0.0589233261084775d, y: 0.3270630750324901d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36822412189749953d, y: 0.06403773747279673d), new NpgsqlTypes.NpgsqlPoint(x: 0.18970145444358566d, y: 0.13672896736446316d), new NpgsqlTypes.NpgsqlPoint(x: 0.96718698164125d, y: 0.7521998585399999d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4108966142270637d, y: 0.06185771101677573d), new NpgsqlTypes.NpgsqlPoint(x: 0.15160160318589155d, y: 0.8653070033479412d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077382653603925d, y: 0.5905478890839307d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015294508184888422d, y: 0.20047733894675535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6790449788208993d, y: 0.698176653227223d), new NpgsqlTypes.NpgsqlPoint(x: 0.014044300661848252d, y: 0.17406995864550534d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29882963547914d, y: 0.34610966861549153d), new NpgsqlTypes.NpgsqlPoint(x: 0.3560013980968333d, y: 0.4355252537457419d), new NpgsqlTypes.NpgsqlPoint(x: 0.8094714399282683d, y: 0.40203708900333857d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19980094977770202d, y: 0.5952938286628079d), new NpgsqlTypes.NpgsqlPoint(x: 0.30083655051064073d, y: 0.7926365544847885d), new NpgsqlTypes.NpgsqlPoint(x: 0.33032517608000567d, y: 0.13838177347642988d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.081643825655907d, y: 0.24520284896857436d), new NpgsqlTypes.NpgsqlPoint(x: 0.8119103956921357d, y: 0.06970522791901423d), new NpgsqlTypes.NpgsqlPoint(x: 0.2915123132542361d, y: 0.811277091889692d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4111449951989139d, y: 0.5087436692681055d), new NpgsqlTypes.NpgsqlPoint(x: 0.7716209407029636d, y: 0.5930382708100032d), new NpgsqlTypes.NpgsqlPoint(x: 0.9670624787587754d, y: 0.2620148223102551d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9078678371354304d, y: 0.8021488974458907d), new NpgsqlTypes.NpgsqlPoint(x: 0.01258907509107099d, y: 0.35489336593861276d), new NpgsqlTypes.NpgsqlPoint(x: 0.8835401701293683d, y: 0.817260002641308d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8759717898354838d, y: 0.0073517914014511465d), new NpgsqlTypes.NpgsqlPoint(x: 0.21787252982240946d, y: 0.24670596689171287d), new NpgsqlTypes.NpgsqlPoint(x: 0.5663148120659329d, y: 0.7003092133067421d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9690435907065132d, y: 0.6687580975141497d), new NpgsqlTypes.NpgsqlPoint(x: 0.49342686110718104d, y: 0.964779783792712d), new NpgsqlTypes.NpgsqlPoint(x: 0.6321805331743667d, y: 0.5775354518770773d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6933413140757642d, y: 0.674014600046723d), new NpgsqlTypes.NpgsqlPoint(x: 0.38026818610204516d, y: 0.44996356981419294d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730825870900983d, y: 0.11272523051470618d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8525603195342452d, y: 0.7000477235956766d), new NpgsqlTypes.NpgsqlPoint(x: 0.0132766764900496d, y: 0.6522715128303813d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093653930807719d, y: 0.37013445861242933d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.034386492395382606d, y: 0.3184062059184125d), new NpgsqlTypes.NpgsqlPoint(x: 0.510769444891197d, y: 0.023261907510799484d), new NpgsqlTypes.NpgsqlPoint(x: 0.4365038437080869d, y: 0.23211526825382367d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6177355321822269d, y: 0.2595139761183999d), new NpgsqlTypes.NpgsqlPoint(x: 0.30966885405393185d, y: 0.2831948849856879d), new NpgsqlTypes.NpgsqlPoint(x: 0.7372811916206107d, y: 0.3909797714432579d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8078760142016643d, y: 0.3243910544954395d), new NpgsqlTypes.NpgsqlPoint(x: 0.177723071152605d, y: 0.9981887427084177d), new NpgsqlTypes.NpgsqlPoint(x: 0.13065557278904594d, y: 0.09026215661592829d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2236426890681269d, y: 0.8774232294330163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9426062441386325d, y: 0.28670965739230403d), new NpgsqlTypes.NpgsqlPoint(x: 0.8663656876383717d, y: 0.4257785770211512d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5780307539086209d, y: 0.31658037746908874d), new NpgsqlTypes.NpgsqlPoint(x: 0.5685508372311969d, y: 0.9047305760180796d), new NpgsqlTypes.NpgsqlPoint(x: 0.4679699246925968d, y: 0.15847815392977826d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.635922038648778d, y: 0.002319992368090107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7547456803648369d, y: 0.739959621674322d), new NpgsqlTypes.NpgsqlPoint(x: 0.17071295958619603d, y: 0.9955116145471775d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8878572926716343d, y: 0.2438431565693785d), new NpgsqlTypes.NpgsqlPoint(x: 0.8172015021136825d, y: 0.5235047582284493d), new NpgsqlTypes.NpgsqlPoint(x: 0.4437772785422234d, y: 0.006162035441328206d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.051690357543293874d, y: 0.2843259579864471d), new NpgsqlTypes.NpgsqlPoint(x: 0.935291827524462d, y: 0.3727487801970879d), new NpgsqlTypes.NpgsqlPoint(x: 0.697327720947189d, y: 0.9380740708589973d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6085637259549483d, y: 0.5478447238987465d), new NpgsqlTypes.NpgsqlPoint(x: 0.053436243293528696d, y: 0.11653927766787286d), new NpgsqlTypes.NpgsqlPoint(x: 0.26747140169861217d, y: 0.413836475308355d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3906658076180496d, y: 0.8100154174478649d), new NpgsqlTypes.NpgsqlPoint(x: 0.7624104105254451d, y: 0.78417276889316d), new NpgsqlTypes.NpgsqlPoint(x: 0.411457611815924d, y: 0.0211232198432999d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8756354173996218d, y: 0.37583114289717345d), new NpgsqlTypes.NpgsqlPoint(x: 0.08799686099294157d, y: 0.2593857308332942d), new NpgsqlTypes.NpgsqlPoint(x: 0.5684918530887227d, y: 0.06437992882234511d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18471348684029465d, y: 0.7257133169473998d), new NpgsqlTypes.NpgsqlPoint(x: 0.5648110566415949d, y: 0.5515956357332741d), new NpgsqlTypes.NpgsqlPoint(x: 0.0008388457948430572d, y: 0.7954048786960266d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8677054804755862d, y: 0.44667848616277206d), new NpgsqlTypes.NpgsqlPoint(x: 0.9615137236344877d, y: 0.2861417880173117d), new NpgsqlTypes.NpgsqlPoint(x: 0.38889667288500795d, y: 0.29301121475544056d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17287939142527575d, y: 0.05666053693446316d), new NpgsqlTypes.NpgsqlPoint(x: 0.7731129066166961d, y: 0.6285837653381804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8002926073657556d, y: 0.8722376600466087d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41634028600715733d, y: 0.8741630436251976d), new NpgsqlTypes.NpgsqlPoint(x: 0.004962779970671294d, y: 0.23841444158004854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9462259350977978d, y: 0.8593113656826833d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005874270932548886d, y: 0.5025080071310847d), new NpgsqlTypes.NpgsqlPoint(x: 0.5921614356600046d, y: 0.8109795807503517d), new NpgsqlTypes.NpgsqlPoint(x: 0.9071299944922141d, y: 0.3157095530603048d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25693366631199543d, y: 0.8751623965682528d), new NpgsqlTypes.NpgsqlPoint(x: 0.013330485791062663d, y: 0.4896483392974066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7169529049221579d, y: 0.8935335449492711d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7239268262530523d, y: 0.7793339224773662d), new NpgsqlTypes.NpgsqlPoint(x: 0.7468872145124812d, y: 0.3501849958069163d), new NpgsqlTypes.NpgsqlPoint(x: 0.24538656341341825d, y: 0.4611203567625577d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.573089689014561d, y: 0.23670287019768754d), new NpgsqlTypes.NpgsqlPoint(x: 0.557495760684368d, y: 0.5450755586829432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8558219368874859d, y: 0.0439337788679095d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3270561953223903d, y: 0.4799469857538534d), new NpgsqlTypes.NpgsqlPoint(x: 0.41082218112806834d, y: 0.5423631991944463d), new NpgsqlTypes.NpgsqlPoint(x: 0.3806587069251036d, y: 0.2699268272535368d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4274020660840562d, y: 0.7698010410617799d), new NpgsqlTypes.NpgsqlPoint(x: 0.9513513150312821d, y: 0.8545396508888734d), new NpgsqlTypes.NpgsqlPoint(x: 0.23893952240532357d, y: 0.4729275139686602d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5397561064148815d, y: 0.5950034205960822d), new NpgsqlTypes.NpgsqlPoint(x: 0.07071193140042686d, y: 0.5870852461746418d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875962451121694d, y: 0.6918342158502543d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5336664311251396d, y: 0.12277063046208736d), new NpgsqlTypes.NpgsqlPoint(x: 0.2644267629996535d, y: 0.5086156309164375d), new NpgsqlTypes.NpgsqlPoint(x: 0.5223633389017656d, y: 0.14504519903182866d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03092928530846173d, y: 0.9802344720876875d), new NpgsqlTypes.NpgsqlPoint(x: 0.0474886479355392d, y: 0.3149163306705476d), new NpgsqlTypes.NpgsqlPoint(x: 0.009138785117316361d, y: 0.24470789385894476d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13554391553738754d, y: 0.6770463722126209d), new NpgsqlTypes.NpgsqlPoint(x: 0.6288852823508493d, y: 0.9897244573218832d), new NpgsqlTypes.NpgsqlPoint(x: 0.7196870063918395d, y: 0.15728704421434825d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7147486821423782d, y: 0.08706465148872677d), new NpgsqlTypes.NpgsqlPoint(x: 0.9298794690128895d, y: 0.07501194584852333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7597236234500242d, y: 0.6182910835026938d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.829177226003773d, y: 0.989902177475662d), new NpgsqlTypes.NpgsqlPoint(x: 0.08606400548503412d, y: 0.45526020802957423d), new NpgsqlTypes.NpgsqlPoint(x: 0.16294271731307275d, y: 0.6416598035725922d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.716997135037392d, y: 0.25110498570646966d), new NpgsqlTypes.NpgsqlPoint(x: 0.12364445516759304d, y: 0.3720891378102812d), new NpgsqlTypes.NpgsqlPoint(x: 0.875439301549486d, y: 0.42269785949607874d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7141422937270278d, y: 0.7952688918529224d), new NpgsqlTypes.NpgsqlPoint(x: 0.5872695576984801d, y: 0.7347524951406075d), new NpgsqlTypes.NpgsqlPoint(x: 0.5183263551653972d, y: 0.8280461955880125d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14786374902490573d, y: 0.2596343138862739d), new NpgsqlTypes.NpgsqlPoint(x: 0.7101045488319644d, y: 0.9973710684046578d), new NpgsqlTypes.NpgsqlPoint(x: 0.8695024263211365d, y: 0.2542430755854629d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4470253308627934d, y: 0.1175156489116963d), new NpgsqlTypes.NpgsqlPoint(x: 0.22472718478432896d, y: 0.5468875910654862d), new NpgsqlTypes.NpgsqlPoint(x: 0.4488076639390737d, y: 0.7840031525129763d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6906900670712438d, y: 0.5171413519555608d), new NpgsqlTypes.NpgsqlPoint(x: 0.05587940107371092d, y: 0.3664707922838818d), new NpgsqlTypes.NpgsqlPoint(x: 0.013808779788201608d, y: 0.17470367483531068d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2942596825103302d, y: 0.6319929795009189d), new NpgsqlTypes.NpgsqlPoint(x: 0.4281704645625831d, y: 0.16843964339678974d), new NpgsqlTypes.NpgsqlPoint(x: 0.0783888696555356d, y: 0.6758511872827323d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028042106891251084d, y: 0.42067533527386536d), new NpgsqlTypes.NpgsqlPoint(x: 0.6506738560875681d, y: 0.515229495087865d), new NpgsqlTypes.NpgsqlPoint(x: 0.29654480733955846d, y: 0.4844206372241062d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03988638297168612d, y: 0.8981907738252001d), new NpgsqlTypes.NpgsqlPoint(x: 0.7103901295478878d, y: 0.8126066006254911d), new NpgsqlTypes.NpgsqlPoint(x: 0.6454692779155904d, y: 0.6828174716019774d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.676368871955794d, y: 0.29851785569085d), new NpgsqlTypes.NpgsqlPoint(x: 0.17695312914423122d, y: 0.34612243658084785d), new NpgsqlTypes.NpgsqlPoint(x: 0.8924526373874385d, y: 0.5103816810805929d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6313593410615306d, y: 0.13915372918974234d), new NpgsqlTypes.NpgsqlPoint(x: 0.3570480581413028d, y: 0.8764881683800763d), new NpgsqlTypes.NpgsqlPoint(x: 0.4762483967812934d, y: 0.35392800432394533d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6672242366730249d, y: 0.57669668130441d), new NpgsqlTypes.NpgsqlPoint(x: 0.8772610406753714d, y: 0.07993512184203944d), new NpgsqlTypes.NpgsqlPoint(x: 0.8915180224301824d, y: 0.6521911351493164d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6096142077579318d, y: 0.5026816309413513d), new NpgsqlTypes.NpgsqlPoint(x: 0.14134902010479122d, y: 0.09137397825145821d), new NpgsqlTypes.NpgsqlPoint(x: 0.5178085823184023d, y: 0.40184543134467476d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9947590753823529d, y: 0.0691147977371862d), new NpgsqlTypes.NpgsqlPoint(x: 0.8360637282571144d, y: 0.6190390376869872d), new NpgsqlTypes.NpgsqlPoint(x: 0.13117477582306136d, y: 0.4891691865635791d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002281797467177493d, y: 0.5413115008954634d), new NpgsqlTypes.NpgsqlPoint(x: 0.10971798930461352d, y: 0.9445567915147713d), new NpgsqlTypes.NpgsqlPoint(x: 0.33566055333613554d, y: 0.5868232202721155d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004087078194914828d, y: 0.538117797532025d), new NpgsqlTypes.NpgsqlPoint(x: 0.25596630325383485d, y: 0.12145736164167475d), new NpgsqlTypes.NpgsqlPoint(x: 0.6096914693198764d, y: 0.9880944236030772d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3707306337055144d, y: 0.5540090543971795d), new NpgsqlTypes.NpgsqlPoint(x: 0.4593189829186315d, y: 0.3207409878888222d), new NpgsqlTypes.NpgsqlPoint(x: 0.23393313767742896d, y: 0.8152319410299214d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06096176108800788d, y: 0.4850246633714712d), new NpgsqlTypes.NpgsqlPoint(x: 0.6291086235595892d, y: 0.09603937556664321d), new NpgsqlTypes.NpgsqlPoint(x: 0.32178419843678385d, y: 0.9431610588273571d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4467782750420597d, y: 0.7209996890047464d), new NpgsqlTypes.NpgsqlPoint(x: 0.4434115312390292d, y: 0.8776321477886757d), new NpgsqlTypes.NpgsqlPoint(x: 0.5893895422572084d, y: 0.7886282647686369d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2520594522625599d, y: 0.3019214159457584d), new NpgsqlTypes.NpgsqlPoint(x: 0.44491803642118366d, y: 0.047311200050789703d), new NpgsqlTypes.NpgsqlPoint(x: 0.016893174687493073d, y: 0.7875779306810211d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3772405237157562d, y: 0.2570509376693727d), new NpgsqlTypes.NpgsqlPoint(x: 0.1871379076412757d, y: 0.8559666596517285d), new NpgsqlTypes.NpgsqlPoint(x: 0.5583274615104269d, y: 0.1768185635416789d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3053739570222104d, y: 0.8229975557761494d), new NpgsqlTypes.NpgsqlPoint(x: 0.13629066932687617d, y: 0.6627457671601977d), new NpgsqlTypes.NpgsqlPoint(x: 0.3416100900736667d, y: 0.8421401942548561d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046122455241816906d, y: 0.08383060829254274d), new NpgsqlTypes.NpgsqlPoint(x: 0.18989287958657097d, y: 0.5200122037384858d), new NpgsqlTypes.NpgsqlPoint(x: 0.9326362140038083d, y: 0.5023725858986385d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45373500888646223d, y: 0.3739903888385564d), new NpgsqlTypes.NpgsqlPoint(x: 0.19459665692962969d, y: 0.9933095781587734d), new NpgsqlTypes.NpgsqlPoint(x: 0.30062297018352113d, y: 0.9067317796761899d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5587035947096911d, y: 0.023357210329840505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6034316244234932d, y: 0.43593488642041667d), new NpgsqlTypes.NpgsqlPoint(x: 0.00855192911198499d, y: 0.7373721866568929d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5869356502774327d, y: 0.593174882251713d), new NpgsqlTypes.NpgsqlPoint(x: 0.017673087721475023d, y: 0.002182628763974792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9424094931813047d, y: 0.03684834860714181d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20281035347255716d, y: 0.3636138480126566d), new NpgsqlTypes.NpgsqlPoint(x: 0.7244905259962592d, y: 0.6380741361093991d), new NpgsqlTypes.NpgsqlPoint(x: 0.07016942462317866d, y: 0.6093145681358005d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3685752776304808d, y: 0.7947320138992137d), new NpgsqlTypes.NpgsqlPoint(x: 0.724766591901049d, y: 0.17810164285626995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670675827205541d, y: 0.9033052015251635d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09137092888139975d, y: 0.14623067843063575d), new NpgsqlTypes.NpgsqlPoint(x: 0.3503014398981281d, y: 0.29858437456672193d), new NpgsqlTypes.NpgsqlPoint(x: 0.7290712251524831d, y: 0.665604006072911d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6866424227009034d, y: 0.7235954526675491d), new NpgsqlTypes.NpgsqlPoint(x: 0.23626091938983274d, y: 0.21536482846338378d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541564629756172d, y: 0.694175617244776d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8929065162790653d, y: 0.22109071928327728d), new NpgsqlTypes.NpgsqlPoint(x: 0.15465543600487897d, y: 0.7398667798865644d), new NpgsqlTypes.NpgsqlPoint(x: 0.38698955695584525d, y: 0.6230318806777323d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7361569821024435d, y: 0.755748674422138d), new NpgsqlTypes.NpgsqlPoint(x: 0.8311649360455796d, y: 0.3703927817679836d), new NpgsqlTypes.NpgsqlPoint(x: 0.25531175721702337d, y: 0.4462317847218217d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0945857690268429d, y: 0.617080387191879d), new NpgsqlTypes.NpgsqlPoint(x: 0.3797082098878334d, y: 0.47615678128205396d), new NpgsqlTypes.NpgsqlPoint(x: 0.3118986784947215d, y: 0.21446451918948317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5006274147384587d, y: 0.017615975320671717d), new NpgsqlTypes.NpgsqlPoint(x: 0.27012807414372475d, y: 0.8121369324930645d), new NpgsqlTypes.NpgsqlPoint(x: 0.07202625216086389d, y: 0.9914154563425729d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2171361072175223d, y: 0.6311469579836619d), new NpgsqlTypes.NpgsqlPoint(x: 0.7890561298391474d, y: 0.006093625733486263d), new NpgsqlTypes.NpgsqlPoint(x: 0.62768879243539d, y: 0.3191686455562027d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01927477239905795d, y: 0.6943383224567153d), new NpgsqlTypes.NpgsqlPoint(x: 0.12910598212064117d, y: 0.3335973683538319d), new NpgsqlTypes.NpgsqlPoint(x: 0.11187600517145069d, y: 0.17283912598511286d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0010134161768119432d, y: 0.5412635288496735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8567478724635136d, y: 0.15489624233953625d), new NpgsqlTypes.NpgsqlPoint(x: 0.019345786335145276d, y: 0.019851144765975937d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06328627399606934d, y: 0.696360136603994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7819658146569582d, y: 0.34361646300460624d), new NpgsqlTypes.NpgsqlPoint(x: 0.15151809412822026d, y: 0.7036148729865438d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39105061541781516d, y: 0.9426529658837679d), new NpgsqlTypes.NpgsqlPoint(x: 0.27269403517854585d, y: 0.8282890108895536d), new NpgsqlTypes.NpgsqlPoint(x: 0.5512442192600986d, y: 0.7369318569116318d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9038620025874132d, y: 0.9158538522207459d), new NpgsqlTypes.NpgsqlPoint(x: 0.3001924682442265d, y: 0.6891277378058376d), new NpgsqlTypes.NpgsqlPoint(x: 0.16502053116830706d, y: 0.9365624663703057d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4987209260158354d, y: 0.1736276662772014d), new NpgsqlTypes.NpgsqlPoint(x: 0.3676488690106817d, y: 0.8862630200355536d), new NpgsqlTypes.NpgsqlPoint(x: 0.5760667622233588d, y: 0.21226410873029522d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1388442813536377d, y: 0.4126051706722754d), new NpgsqlTypes.NpgsqlPoint(x: 0.2552580882834704d, y: 0.9410027458019861d), new NpgsqlTypes.NpgsqlPoint(x: 0.7021104430717366d, y: 0.9885860869216678d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6345100353096087d, y: 0.8588248809642004d), new NpgsqlTypes.NpgsqlPoint(x: 0.3039964445598988d, y: 0.5553597661341458d), new NpgsqlTypes.NpgsqlPoint(x: 0.23262052226686813d, y: 0.602480660194621d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4303525444174846d, y: 0.0012565073237843505d), new NpgsqlTypes.NpgsqlPoint(x: 0.14907447685296404d, y: 0.7351197117897773d), new NpgsqlTypes.NpgsqlPoint(x: 0.6643757805655045d, y: 0.6619823493340039d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7173581597051455d, y: 0.5192307383458314d), new NpgsqlTypes.NpgsqlPoint(x: 0.2361013684734814d, y: 0.2557147026509755d), new NpgsqlTypes.NpgsqlPoint(x: 0.35800491463252015d, y: 0.2104130622350674d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.70486003036841d, y: 0.72720280769878d), new NpgsqlTypes.NpgsqlPoint(x: 0.45222817933884407d, y: 0.8480924469261351d), new NpgsqlTypes.NpgsqlPoint(x: 0.12757820046794366d, y: 0.8922946575460095d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9597960724057915d, y: 0.7519815047841806d), new NpgsqlTypes.NpgsqlPoint(x: 0.07497640046105969d, y: 0.8269292733913153d), new NpgsqlTypes.NpgsqlPoint(x: 0.6704121926059768d, y: 0.0617520724378563d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40795895193053044d, y: 0.1875714201412647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5976185997751464d, y: 0.486845875023306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8235188840821531d, y: 0.7449224392502564d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10882939996922747d, y: 0.47373357870883726d), new NpgsqlTypes.NpgsqlPoint(x: 0.26769122212326013d, y: 0.17820432683827603d), new NpgsqlTypes.NpgsqlPoint(x: 0.6507154104515696d, y: 0.4344851800556475d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08219113560624003d, y: 0.7422526365469835d), new NpgsqlTypes.NpgsqlPoint(x: 0.8705582949320174d, y: 0.0794811808889977d), new NpgsqlTypes.NpgsqlPoint(x: 0.7533610367081538d, y: 0.03797125260407197d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.593760006450876d, y: 0.05980560647284916d), new NpgsqlTypes.NpgsqlPoint(x: 0.14480703277126594d, y: 0.7220214910345502d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728919632886816d, y: 0.83846633310691d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44736660950787654d, y: 0.945869929383001d), new NpgsqlTypes.NpgsqlPoint(x: 0.40542433801905864d, y: 0.7177158202335359d), new NpgsqlTypes.NpgsqlPoint(x: 0.3723112541529784d, y: 0.9547549002385702d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41556479737194385d, y: 0.3882722673788388d), new NpgsqlTypes.NpgsqlPoint(x: 0.5399546359087188d, y: 0.47730829739460245d), new NpgsqlTypes.NpgsqlPoint(x: 0.01629692899054236d, y: 0.5289585112142413d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8625409441840335d, y: 0.22362236390387025d), new NpgsqlTypes.NpgsqlPoint(x: 0.9708718001107187d, y: 0.9137718553136749d), new NpgsqlTypes.NpgsqlPoint(x: 0.9298052385802354d, y: 0.051700665060159356d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09716721371375947d, y: 0.5423594677923503d), new NpgsqlTypes.NpgsqlPoint(x: 0.05546558854655259d, y: 0.8754097675489313d), new NpgsqlTypes.NpgsqlPoint(x: 0.013343293321526284d, y: 0.07028517986856031d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7482831680845913d, y: 0.3610088248383525d), new NpgsqlTypes.NpgsqlPoint(x: 0.8767083035093733d, y: 0.13620795322639523d), new NpgsqlTypes.NpgsqlPoint(x: 0.9258467912161089d, y: 0.4542592875332868d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39656642338551407d, y: 0.021475839504605965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5586070190118558d, y: 0.2184372430032312d), new NpgsqlTypes.NpgsqlPoint(x: 0.5302434555242004d, y: 0.530600476704621d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11867430502908738d, y: 0.39248253188397064d), new NpgsqlTypes.NpgsqlPoint(x: 0.48192672445514895d, y: 0.04642817158157919d), new NpgsqlTypes.NpgsqlPoint(x: 0.19166614032387919d, y: 0.9583326236769169d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.997203121635921d, y: 0.07707930666637952d), new NpgsqlTypes.NpgsqlPoint(x: 0.9692411899586014d, y: 0.8649463106975839d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848001182408416d, y: 0.07727060906096284d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11348430505596252d, y: 0.9165779782558573d), new NpgsqlTypes.NpgsqlPoint(x: 0.34110546460661595d, y: 0.9733900316473828d), new NpgsqlTypes.NpgsqlPoint(x: 0.02981439990665924d, y: 0.8873838646667684d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6432601173067906d, y: 0.7907886069776506d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179241958275277d, y: 0.3599969013750046d), new NpgsqlTypes.NpgsqlPoint(x: 0.7288017416271231d, y: 0.4713895393489347d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3490246520439756d, y: 0.5559984407513958d), new NpgsqlTypes.NpgsqlPoint(x: 0.5371136461365419d, y: 0.34471468363724544d), new NpgsqlTypes.NpgsqlPoint(x: 0.5892144065954849d, y: 0.025907852702598322d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08912118016643034d, y: 0.04793556073253247d), new NpgsqlTypes.NpgsqlPoint(x: 0.03489640013698514d, y: 0.43162165684760234d), new NpgsqlTypes.NpgsqlPoint(x: 0.008746344101199233d, y: 0.6247802685860726d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4276446775634003d, y: 0.5621712767199478d), new NpgsqlTypes.NpgsqlPoint(x: 0.39914223411584815d, y: 0.7459047949091715d), new NpgsqlTypes.NpgsqlPoint(x: 0.541787769888852d, y: 0.17583611853516112d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8831210065707873d, y: 0.21141133432059545d), new NpgsqlTypes.NpgsqlPoint(x: 0.3127884508463712d, y: 0.882539083098034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8322231747600565d, y: 0.42473192485414535d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23733107520856978d, y: 0.7091300195226863d), new NpgsqlTypes.NpgsqlPoint(x: 0.4635500654415664d, y: 0.3323041227775154d), new NpgsqlTypes.NpgsqlPoint(x: 0.06870999534024214d, y: 0.04373111737114421d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6272249702890089d, y: 0.09500002643227978d), new NpgsqlTypes.NpgsqlPoint(x: 0.6039482464621084d, y: 0.016045947450096354d), new NpgsqlTypes.NpgsqlPoint(x: 0.04194662209717792d, y: 0.12241839780251573d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6467662918242196d, y: 0.899893390654353d), new NpgsqlTypes.NpgsqlPoint(x: 0.3071308678649991d, y: 0.1965883230038088d), new NpgsqlTypes.NpgsqlPoint(x: 0.04323920645374246d, y: 0.6962866591464949d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7422611612775426d, y: 0.9783836712993131d), new NpgsqlTypes.NpgsqlPoint(x: 0.10433877854083995d, y: 0.686776302124196d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138202651439138d, y: 0.25415630473840123d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01692021104523267d, y: 0.5325337945515451d), new NpgsqlTypes.NpgsqlPoint(x: 0.4793271043172491d, y: 0.6234475572554289d), new NpgsqlTypes.NpgsqlPoint(x: 0.04715461890495032d, y: 0.9522893257245721d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3083360268487668d, y: 0.8323174211836628d), new NpgsqlTypes.NpgsqlPoint(x: 0.06978282655243873d, y: 0.6369345143480191d), new NpgsqlTypes.NpgsqlPoint(x: 0.9529168620209669d, y: 0.4722402334429655d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6722540916789186d, y: 0.06712163473006516d), new NpgsqlTypes.NpgsqlPoint(x: 0.012690785431408225d, y: 0.8980275439254576d), new NpgsqlTypes.NpgsqlPoint(x: 0.8056566768451925d, y: 0.09253564767262668d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6124622351585548d, y: 0.29610824747827136d), new NpgsqlTypes.NpgsqlPoint(x: 0.6505534142160174d, y: 0.8228529629674852d), new NpgsqlTypes.NpgsqlPoint(x: 0.24663540250899896d, y: 0.1084118844594485d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6048987236148323d, y: 0.7654379434207468d), new NpgsqlTypes.NpgsqlPoint(x: 0.9123147907286746d, y: 0.19804066875189663d), new NpgsqlTypes.NpgsqlPoint(x: 0.09550366903927654d, y: 0.7808052780448506d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5466142537458729d, y: 0.5779824677152359d), new NpgsqlTypes.NpgsqlPoint(x: 0.8828685855217698d, y: 0.06917329182225218d), new NpgsqlTypes.NpgsqlPoint(x: 0.5280650499642767d, y: 0.731869519220709d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4380750505913922d, y: 0.276111940660299d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694975300012606d, y: 0.971618444216818d), new NpgsqlTypes.NpgsqlPoint(x: 0.9355602411121007d, y: 0.2704183045765942d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9508881790438782d, y: 0.9728843252467927d), new NpgsqlTypes.NpgsqlPoint(x: 0.04108939365245068d, y: 0.8912657552840573d), new NpgsqlTypes.NpgsqlPoint(x: 0.6295188350282225d, y: 0.2871781041912662d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2805310836287832d, y: 0.025284337869071027d), new NpgsqlTypes.NpgsqlPoint(x: 0.2979073722530239d, y: 0.5435700418629574d), new NpgsqlTypes.NpgsqlPoint(x: 0.009031927071957768d, y: 0.6481755379857964d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4925327384510766d, y: 0.7462248945281812d), new NpgsqlTypes.NpgsqlPoint(x: 0.9578499942010308d, y: 0.7333014535800978d), new NpgsqlTypes.NpgsqlPoint(x: 0.021456233283926984d, y: 0.25407584715889386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02591489667024771d, y: 0.5539957385638646d), new NpgsqlTypes.NpgsqlPoint(x: 0.12774415248305582d, y: 0.72538065111808d), new NpgsqlTypes.NpgsqlPoint(x: 0.6880569142721131d, y: 0.8285711637551533d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42041929816782997d, y: 0.2095157804647193d), new NpgsqlTypes.NpgsqlPoint(x: 0.14312276565235993d, y: 0.7364559544838825d), new NpgsqlTypes.NpgsqlPoint(x: 0.9882111554164701d, y: 0.9557985257543955d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24216822118712966d, y: 0.21555657901759306d), new NpgsqlTypes.NpgsqlPoint(x: 0.03950165042693421d, y: 0.3826387070918177d), new NpgsqlTypes.NpgsqlPoint(x: 0.4732352090666788d, y: 0.7040423494048458d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9288072410581052d, y: 0.5231898656908334d), new NpgsqlTypes.NpgsqlPoint(x: 0.22185629122232287d, y: 0.5034870525662426d), new NpgsqlTypes.NpgsqlPoint(x: 0.32187649515092864d, y: 0.7179350743999299d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9513097883805584d, y: 0.09420718424240493d), new NpgsqlTypes.NpgsqlPoint(x: 0.04043591258627177d, y: 0.4915551927945352d), new NpgsqlTypes.NpgsqlPoint(x: 0.20499326393949657d, y: 0.293595776790492d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1993244185641817d, y: 0.7005221014217211d), new NpgsqlTypes.NpgsqlPoint(x: 0.125383723987742d, y: 0.9038401170439991d), new NpgsqlTypes.NpgsqlPoint(x: 0.3982847644794898d, y: 0.9969589110948518d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7026976589132677d, y: 0.4992732370744647d), new NpgsqlTypes.NpgsqlPoint(x: 0.39420225179136803d, y: 0.1214681689039312d), new NpgsqlTypes.NpgsqlPoint(x: 0.2928569553079666d, y: 0.41674893558052817d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7880213950933329d, y: 0.47508814854934067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7305300312581199d, y: 0.7361834858856736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5391101157979948d, y: 0.6680454887279473d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26700294790259305d, y: 0.5336305400059237d), new NpgsqlTypes.NpgsqlPoint(x: 0.47929362141598064d, y: 0.14006102330696413d), new NpgsqlTypes.NpgsqlPoint(x: 0.5661383804140167d, y: 0.3949138327557289d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5220764716131472d, y: 0.9535569330253847d), new NpgsqlTypes.NpgsqlPoint(x: 0.4220896565224699d, y: 0.48782233436590383d), new NpgsqlTypes.NpgsqlPoint(x: 0.4411284842173884d, y: 0.4842325579986364d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5793716626648858d, y: 0.5604694332251937d), new NpgsqlTypes.NpgsqlPoint(x: 0.27047830425411d, y: 0.25797559186688823d), new NpgsqlTypes.NpgsqlPoint(x: 0.12862861193020458d, y: 0.022866717011181814d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8063176300284495d, y: 0.6571506183168586d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420105711458224d, y: 0.501893322313055d), new NpgsqlTypes.NpgsqlPoint(x: 0.2813493190929507d, y: 0.6500326207936264d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8777940428576957d, y: 0.7068000007669737d), new NpgsqlTypes.NpgsqlPoint(x: 0.486770128408912d, y: 0.9478591395039025d), new NpgsqlTypes.NpgsqlPoint(x: 0.7647987294893538d, y: 0.9087441756968031d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6218893461472949d, y: 0.1955121046258097d), new NpgsqlTypes.NpgsqlPoint(x: 0.10727991111278268d, y: 0.8549032519991847d), new NpgsqlTypes.NpgsqlPoint(x: 0.35506234881943044d, y: 0.6243090086517579d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1313964306196722d, y: 0.7774207533772638d), new NpgsqlTypes.NpgsqlPoint(x: 0.46150784759068253d, y: 0.8504142399889068d), new NpgsqlTypes.NpgsqlPoint(x: 0.6943283999369917d, y: 0.501286447925108d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0065150650399684595d, y: 0.5532514800660904d), new NpgsqlTypes.NpgsqlPoint(x: 0.2833249670265784d, y: 0.02725968136029533d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815593562295065d, y: 0.016630489356431966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33889632482133825d, y: 0.7409029252448665d), new NpgsqlTypes.NpgsqlPoint(x: 0.10413789815202845d, y: 0.06894796904743916d), new NpgsqlTypes.NpgsqlPoint(x: 0.18550941741230287d, y: 0.20473825316594096d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6523152997021434d, y: 0.551118797702484d), new NpgsqlTypes.NpgsqlPoint(x: 0.47514553933008363d, y: 0.6309487786452589d), new NpgsqlTypes.NpgsqlPoint(x: 0.3487497709974401d, y: 0.0007385093356885308d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3599631066625204d, y: 0.9486801217224377d), new NpgsqlTypes.NpgsqlPoint(x: 0.32269385892286084d, y: 0.4542982796048787d), new NpgsqlTypes.NpgsqlPoint(x: 0.7584349719788978d, y: 0.178373425784629d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5922540650574617d, y: 0.9793099740155927d), new NpgsqlTypes.NpgsqlPoint(x: 0.09119361012430327d, y: 0.2748076795837361d), new NpgsqlTypes.NpgsqlPoint(x: 0.5371195673217636d, y: 0.5829431843506923d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3512604211860454d, y: 0.2048317634639648d), new NpgsqlTypes.NpgsqlPoint(x: 0.1682373304476421d, y: 0.15101217600950012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8457651965620081d, y: 0.4022850958736637d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5275539374005568d, y: 0.46101093690290595d), new NpgsqlTypes.NpgsqlPoint(x: 0.4606237676959205d, y: 0.28671806740831063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601092519692595d, y: 0.9308925510479685d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17527262516814313d, y: 0.2324574156170206d), new NpgsqlTypes.NpgsqlPoint(x: 0.18855944041392225d, y: 0.7263708209407855d), new NpgsqlTypes.NpgsqlPoint(x: 0.7523966457739563d, y: 0.18068459301098727d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5708474487684175d, y: 0.43625943368969133d), new NpgsqlTypes.NpgsqlPoint(x: 0.6334315556138544d, y: 0.7829330474222642d), new NpgsqlTypes.NpgsqlPoint(x: 0.14939893616907673d, y: 0.1055489976829741d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2394723867345856d, y: 0.4715514406443476d), new NpgsqlTypes.NpgsqlPoint(x: 0.24198558318782182d, y: 0.4748562968047585d), new NpgsqlTypes.NpgsqlPoint(x: 0.9778836027608147d, y: 0.45093046667197356d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3815851679182063d, y: 0.331558914312051d), new NpgsqlTypes.NpgsqlPoint(x: 0.47536293285719955d, y: 0.7813951849875478d), new NpgsqlTypes.NpgsqlPoint(x: 0.9691212028037389d, y: 0.2907291246528706d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33209052229065694d, y: 0.5091759991838964d), new NpgsqlTypes.NpgsqlPoint(x: 0.5233124732884061d, y: 0.042288460415289886d), new NpgsqlTypes.NpgsqlPoint(x: 0.014670649300295269d, y: 0.20639633275869596d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6683056403037412d, y: 0.612230855110594d), new NpgsqlTypes.NpgsqlPoint(x: 0.5898691964450612d, y: 0.9073038639121382d), new NpgsqlTypes.NpgsqlPoint(x: 0.0278933963906165d, y: 0.6020437852211706d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23424952819211808d, y: 0.9704860042510208d), new NpgsqlTypes.NpgsqlPoint(x: 0.5502348416058407d, y: 0.11784981678383655d), new NpgsqlTypes.NpgsqlPoint(x: 0.981412232683704d, y: 0.3728336530997024d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3264940958635666d, y: 0.5957448093898864d), new NpgsqlTypes.NpgsqlPoint(x: 0.5530561322399162d, y: 0.5770371136293754d), new NpgsqlTypes.NpgsqlPoint(x: 0.9558619472997678d, y: 0.6366715605379899d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5259656154191458d, y: 0.6105352553728736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5179955329931852d, y: 0.9183316911926414d), new NpgsqlTypes.NpgsqlPoint(x: 0.14092638613070374d, y: 0.982059324853947d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0018838388040668397d, y: 0.5341566161146107d), new NpgsqlTypes.NpgsqlPoint(x: 0.6079669365301433d, y: 0.9211433240219168d), new NpgsqlTypes.NpgsqlPoint(x: 0.5650342922587961d, y: 0.6453294493766947d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09901537169424157d, y: 0.3060620071214575d), new NpgsqlTypes.NpgsqlPoint(x: 0.573788701557235d, y: 0.4797831352775255d), new NpgsqlTypes.NpgsqlPoint(x: 0.6022222858972034d, y: 0.30793780557400174d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07588357718091754d, y: 0.43749200584787673d), new NpgsqlTypes.NpgsqlPoint(x: 0.2742696974867054d, y: 0.9748344761081496d), new NpgsqlTypes.NpgsqlPoint(x: 0.6139552772830066d, y: 0.844606868235274d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6824640687837426d, y: 0.43133287923426245d), new NpgsqlTypes.NpgsqlPoint(x: 0.51291610743364d, y: 0.751464473515514d), new NpgsqlTypes.NpgsqlPoint(x: 0.47489512652839616d, y: 0.06720870124008083d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.863540883690073d, y: 0.7037702529523977d), new NpgsqlTypes.NpgsqlPoint(x: 0.2826652449033582d, y: 0.15475438466067337d), new NpgsqlTypes.NpgsqlPoint(x: 0.18174616252247633d, y: 0.9641922761256393d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28416819711020225d, y: 0.17376377590060588d), new NpgsqlTypes.NpgsqlPoint(x: 0.09391189514514209d, y: 0.8271818887833926d), new NpgsqlTypes.NpgsqlPoint(x: 0.44687080148490854d, y: 0.7885982531397807d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4968775822326027d, y: 0.08336107028541662d), new NpgsqlTypes.NpgsqlPoint(x: 0.05552470857155567d, y: 0.1575943705693431d), new NpgsqlTypes.NpgsqlPoint(x: 0.947425102067688d, y: 0.3932426263563026d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6561177882978341d, y: 0.1797279743412885d), new NpgsqlTypes.NpgsqlPoint(x: 0.7945726440893354d, y: 0.4305365383130133d), new NpgsqlTypes.NpgsqlPoint(x: 0.41690359813737987d, y: 0.7666265658744761d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48133879168763394d, y: 0.11880987851834857d), new NpgsqlTypes.NpgsqlPoint(x: 0.09849345940564691d, y: 0.6547569602641321d), new NpgsqlTypes.NpgsqlPoint(x: 0.08153097396015963d, y: 0.28194734365836005d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35835794834948087d, y: 0.60009803192272d), new NpgsqlTypes.NpgsqlPoint(x: 0.7325732613608222d, y: 0.47834473855283843d), new NpgsqlTypes.NpgsqlPoint(x: 0.11113052415518565d, y: 0.4643833853874163d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32593858192511704d, y: 0.33051128958808873d), new NpgsqlTypes.NpgsqlPoint(x: 0.7289956414080863d, y: 0.5320693638986561d), new NpgsqlTypes.NpgsqlPoint(x: 0.4037781243859139d, y: 0.4952424485078363d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16688704648478847d, y: 0.41666019939300036d), new NpgsqlTypes.NpgsqlPoint(x: 0.35309606725039056d, y: 0.006971439574950722d), new NpgsqlTypes.NpgsqlPoint(x: 0.26192352021972354d, y: 0.40941623882383615d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8567385452871459d, y: 0.7277961929686599d), new NpgsqlTypes.NpgsqlPoint(x: 0.5578312814857868d, y: 0.004202838756080407d), new NpgsqlTypes.NpgsqlPoint(x: 0.6126770731851053d, y: 0.9706509035435035d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025043605610854947d, y: 0.06146397715567553d), new NpgsqlTypes.NpgsqlPoint(x: 0.36464933183239234d, y: 0.6276919467491133d), new NpgsqlTypes.NpgsqlPoint(x: 0.5000950286627167d, y: 0.7771594429068125d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8028124605693369d, y: 0.5388906952040055d), new NpgsqlTypes.NpgsqlPoint(x: 0.7781565126573473d, y: 0.9114787418126331d), new NpgsqlTypes.NpgsqlPoint(x: 0.789249928365461d, y: 0.5875256731661821d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.781424385177649d, y: 0.04405252794477199d), new NpgsqlTypes.NpgsqlPoint(x: 0.9689181953928554d, y: 0.7856605460283114d), new NpgsqlTypes.NpgsqlPoint(x: 0.26340976227166857d, y: 0.863953730214727d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15451377825451051d, y: 0.22969100364784478d), new NpgsqlTypes.NpgsqlPoint(x: 0.057185013855097666d, y: 0.21130423250198072d), new NpgsqlTypes.NpgsqlPoint(x: 0.5721429484364781d, y: 0.23854925849927444d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14051271385862452d, y: 0.3137697737791675d), new NpgsqlTypes.NpgsqlPoint(x: 0.13626366620579788d, y: 0.28592516805234236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3522258268525198d, y: 0.7015799330232543d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22710135315813773d, y: 0.10944107729272057d), new NpgsqlTypes.NpgsqlPoint(x: 0.35341264749408274d, y: 0.9288855211222211d), new NpgsqlTypes.NpgsqlPoint(x: 0.3346553594715781d, y: 0.7879819849724773d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41684284785532577d, y: 0.02391416094345611d), new NpgsqlTypes.NpgsqlPoint(x: 0.44996251609194016d, y: 0.7830142101150337d), new NpgsqlTypes.NpgsqlPoint(x: 0.4861288537516397d, y: 0.5965946774579634d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9973869589105803d, y: 0.7166628966760787d), new NpgsqlTypes.NpgsqlPoint(x: 0.441234765728874d, y: 0.7832163969081942d), new NpgsqlTypes.NpgsqlPoint(x: 0.49189300210978704d, y: 0.39888398028714933d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4089404755525624d, y: 0.5677024794652709d), new NpgsqlTypes.NpgsqlPoint(x: 0.10349428184307541d, y: 0.12793839647411687d), new NpgsqlTypes.NpgsqlPoint(x: 0.35761376630455255d, y: 0.8109721530019329d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24354305488998618d, y: 0.5371094866083882d), new NpgsqlTypes.NpgsqlPoint(x: 0.4612289248558358d, y: 0.9448083695719067d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810529275907939d, y: 0.2248336407130933d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7912240398169248d, y: 0.32187401561334594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8617993610408136d, y: 0.6089227158361725d), new NpgsqlTypes.NpgsqlPoint(x: 0.02380009090559121d, y: 0.2849982740105226d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2754301962444602d, y: 0.23698460165156943d), new NpgsqlTypes.NpgsqlPoint(x: 0.21212050191337617d, y: 0.6951728317750707d), new NpgsqlTypes.NpgsqlPoint(x: 0.9588976412699433d, y: 0.9514200380823583d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7929611078129062d, y: 0.9021937192980967d), new NpgsqlTypes.NpgsqlPoint(x: 0.3089761595969106d, y: 0.31275517841322675d), new NpgsqlTypes.NpgsqlPoint(x: 0.0007305399801168511d, y: 0.2913919761498951d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6591587028160999d, y: 0.24359593891291575d), new NpgsqlTypes.NpgsqlPoint(x: 0.6255060518800001d, y: 0.6930254413714223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1968346483875475d, y: 0.11708570600647483d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5114830261888326d, y: 0.7275903592864342d), new NpgsqlTypes.NpgsqlPoint(x: 0.28382326531134017d, y: 0.458898306012826d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068639206363463d, y: 0.2872172289847278d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8324834710288306d, y: 0.7604840195036658d), new NpgsqlTypes.NpgsqlPoint(x: 0.666200557913174d, y: 0.1888991430652731d), new NpgsqlTypes.NpgsqlPoint(x: 0.27976988909281075d, y: 0.012043839069782236d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4375487694314262d, y: 0.7956780760670271d), new NpgsqlTypes.NpgsqlPoint(x: 0.7896591236678087d, y: 0.5639206768201961d), new NpgsqlTypes.NpgsqlPoint(x: 0.5298047204446094d, y: 0.30849551540311393d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9545315524450962d, y: 0.895572036299408d), new NpgsqlTypes.NpgsqlPoint(x: 0.5694393851120639d, y: 0.5765932435523765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8491614959456776d, y: 0.8572598180587397d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4243166898904187d, y: 0.4942386412429459d), new NpgsqlTypes.NpgsqlPoint(x: 0.16808562425451534d, y: 0.8102111072381277d), new NpgsqlTypes.NpgsqlPoint(x: 0.5039869624958407d, y: 0.6522548211049485d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4458683201188496d, y: 0.1592398515214214d), new NpgsqlTypes.NpgsqlPoint(x: 0.27101629444773834d, y: 0.9089132901582018d), new NpgsqlTypes.NpgsqlPoint(x: 0.40557467545656456d, y: 0.7467683992513113d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07461060224652616d, y: 0.8321278491200075d), new NpgsqlTypes.NpgsqlPoint(x: 0.7079324501692462d, y: 0.5876006201023928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6404853898808489d, y: 0.2968941230740345d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10152534183521367d, y: 0.015529707067508336d), new NpgsqlTypes.NpgsqlPoint(x: 0.4255620308600193d, y: 0.2970847607815177d), new NpgsqlTypes.NpgsqlPoint(x: 0.24095866695366563d, y: 0.8914489711965365d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36168696116799837d, y: 0.9563891820152445d), new NpgsqlTypes.NpgsqlPoint(x: 0.6480590465673954d, y: 0.5901325570990489d), new NpgsqlTypes.NpgsqlPoint(x: 0.10561175132750134d, y: 0.01964159023421319d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2855457604729561d, y: 0.9075859707335994d), new NpgsqlTypes.NpgsqlPoint(x: 0.13427409741348717d, y: 0.9191390177300597d), new NpgsqlTypes.NpgsqlPoint(x: 0.13296722616622325d, y: 0.9446928462393883d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9739341079775613d, y: 0.9769438209658666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3924187065362167d, y: 0.8494971570682546d), new NpgsqlTypes.NpgsqlPoint(x: 0.04663474711920157d, y: 0.8129526565506969d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8718533264321976d, y: 0.9246372665733986d), new NpgsqlTypes.NpgsqlPoint(x: 0.4454089218798083d, y: 0.5874203100354969d), new NpgsqlTypes.NpgsqlPoint(x: 0.41982450478795197d, y: 0.7287385985468097d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03968024263945502d, y: 0.7627099125546641d), new NpgsqlTypes.NpgsqlPoint(x: 0.23496197573632505d, y: 0.8226644597137949d), new NpgsqlTypes.NpgsqlPoint(x: 0.9601901176527464d, y: 0.08741092572458653d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8757629663477515d, y: 0.8374932301389392d), new NpgsqlTypes.NpgsqlPoint(x: 0.014944816500484182d, y: 0.3756884497695776d), new NpgsqlTypes.NpgsqlPoint(x: 0.7537781195803114d, y: 0.5443989709966585d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4011004920918032d, y: 0.24978398171609562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5831733028307418d, y: 0.45829720718922506d), new NpgsqlTypes.NpgsqlPoint(x: 0.7291045454233405d, y: 0.4762980836720798d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7434052422264019d, y: 0.27539336066930276d), new NpgsqlTypes.NpgsqlPoint(x: 0.10309915822377425d, y: 0.9961524232221973d), new NpgsqlTypes.NpgsqlPoint(x: 0.7568671173214302d, y: 0.7819446766422282d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9478193797731841d, y: 0.8345128692564623d), new NpgsqlTypes.NpgsqlPoint(x: 0.7466182934796717d, y: 0.2533937087374518d), new NpgsqlTypes.NpgsqlPoint(x: 0.398918725940696d, y: 0.7191636327783122d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9014819495558432d, y: 0.5727649269110974d), new NpgsqlTypes.NpgsqlPoint(x: 0.38475373056547757d, y: 0.06464112994269366d), new NpgsqlTypes.NpgsqlPoint(x: 0.003204349280087504d, y: 0.5340988695694188d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4662815585837351d, y: 0.7540063332841922d), new NpgsqlTypes.NpgsqlPoint(x: 0.35550974384609757d, y: 0.5451855770131189d), new NpgsqlTypes.NpgsqlPoint(x: 0.07600117073166912d, y: 0.046380515465514804d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8363640653681804d, y: 0.9146471406632618d), new NpgsqlTypes.NpgsqlPoint(x: 0.2737987440145313d, y: 0.5937165182409577d), new NpgsqlTypes.NpgsqlPoint(x: 0.3224267719122025d, y: 0.6623573884895668d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8364542238660714d, y: 0.8638961094114275d), new NpgsqlTypes.NpgsqlPoint(x: 0.2538920096037198d, y: 0.930205994556258d), new NpgsqlTypes.NpgsqlPoint(x: 0.2429347810079051d, y: 0.8136898981455639d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2276520343661056d, y: 0.5595253847125853d), new NpgsqlTypes.NpgsqlPoint(x: 0.15580827289337318d, y: 0.5753053742784969d), new NpgsqlTypes.NpgsqlPoint(x: 0.26623389875330095d, y: 0.8550231283064895d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7488608524360632d, y: 0.3394427219254531d), new NpgsqlTypes.NpgsqlPoint(x: 0.42045950231346163d, y: 0.9302373800735907d), new NpgsqlTypes.NpgsqlPoint(x: 0.9677108150516684d, y: 0.37183115439421754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015984191684713323d, y: 0.5930624550525688d), new NpgsqlTypes.NpgsqlPoint(x: 0.8431477088436912d, y: 0.8010829035525063d), new NpgsqlTypes.NpgsqlPoint(x: 0.3812079739992983d, y: 0.36737586228990826d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2816396980505481d, y: 0.739189809648775d), new NpgsqlTypes.NpgsqlPoint(x: 0.3685331332578128d, y: 0.7605603305157009d), new NpgsqlTypes.NpgsqlPoint(x: 0.3390158927851147d, y: 0.48087564354049384d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27038765020027467d, y: 0.9910285113185593d), new NpgsqlTypes.NpgsqlPoint(x: 0.5005133850777578d, y: 0.04875528314123989d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658811290626059d, y: 0.8206237667217934d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31015073773232293d, y: 0.4865151638907145d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654135179384629d, y: 0.5798405442046446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6008578413298754d, y: 0.6102258641452518d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8329863782491015d, y: 0.0018142703483349232d), new NpgsqlTypes.NpgsqlPoint(x: 0.9781684695984568d, y: 0.8054346141379242d), new NpgsqlTypes.NpgsqlPoint(x: 0.399680211350783d, y: 0.23011568381409675d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7255018794486219d, y: 0.462829893639899d), new NpgsqlTypes.NpgsqlPoint(x: 0.5145271552524066d, y: 0.5598065858465749d), new NpgsqlTypes.NpgsqlPoint(x: 0.8801221464605924d, y: 0.23920697657113732d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6541419447721389d, y: 0.5311550571065511d), new NpgsqlTypes.NpgsqlPoint(x: 0.7284032006239637d, y: 0.9294407434370562d), new NpgsqlTypes.NpgsqlPoint(x: 0.041826601804320185d, y: 0.21840188256388948d)),

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
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 99;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[29], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 34, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 66, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 11, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 58, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 91, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 42, query1, 73, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 49, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 66, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 92, 11))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 20, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[29], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2M>(15);

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
                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

