

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16609740627202074d, b: 0.12246806689056422d, c: 0.8920337085333185d),

new NpgsqlTypes.NpgsqlLine(a: 0.21952863565832925d, b: 0.15853740134631922d, c: 0.25506961891925606d),

new NpgsqlTypes.NpgsqlLine(a: 0.3941317070168011d, b: 0.8295947191869731d, c: 0.596551636665273d),

new NpgsqlTypes.NpgsqlLine(a: 0.26422485660389217d, b: 0.8484588759231975d, c: 0.0026857765208396778d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.522512796136702d, b: 0.05653655237676569d, c: 0.40576524550720927d),

new NpgsqlTypes.NpgsqlLine(a: 0.22370703274473613d, b: 0.24703441451141261d, c: 0.3850030829742468d),

new NpgsqlTypes.NpgsqlLine(a: 0.15453449499581084d, b: 0.8293554739004697d, c: 0.03699952373824944d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.05852915473131304d, b: 0.09105507821079961d, c: 0.8987372573726908d),

new NpgsqlTypes.NpgsqlLine(a: 0.7700753951203926d, b: 0.1974963583454855d, c: 0.7768281030974904d),

new NpgsqlTypes.NpgsqlLine(a: 0.784492167926077d, b: 0.8998259604928102d, c: 0.5451076851128154d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.34548037157323164d, b: 0.46278442175291357d, c: 0.7632094766460503d),

new NpgsqlTypes.NpgsqlLine(a: 0.6649934194840512d, b: 0.7512949569760602d, c: 0.7526651297828293d),

new NpgsqlTypes.NpgsqlLine(a: 0.38878657399591665d, b: 0.4804224411679435d, c: 0.7768902976003015d),

new NpgsqlTypes.NpgsqlLine(a: 0.6583667226213828d, b: 0.148832802479118d, c: 0.5650391462339162d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.594714979442233d, b: 0.602628586914084d, c: 0.8894733594195045d),

new NpgsqlTypes.NpgsqlLine(a: 0.47531423109877835d, b: 0.6577021882609982d, c: 0.2269607852869301d),

new NpgsqlTypes.NpgsqlLine(a: 0.08425721503640338d, b: 0.9857568400836142d, c: 0.7861895352479165d),

new NpgsqlTypes.NpgsqlLine(a: 0.3555878324860967d, b: 0.6698775760473895d, c: 0.08915175838128309d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2662542241876754d, b: 0.5711809600908138d, c: 0.5921321459586001d),

new NpgsqlTypes.NpgsqlLine(a: 0.9541272005327948d, b: 0.9809210460699355d, c: 0.577586269626547d),

new NpgsqlTypes.NpgsqlLine(a: 0.15882401546128477d, b: 0.0225017791306259d, c: 0.8039505939647212d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.024316143802520562d, b: 0.5654828789467268d, c: 0.28561279286310237d),

new NpgsqlTypes.NpgsqlLine(a: 0.5466557740329718d, b: 0.8894421555874116d, c: 0.019362505357206294d),

new NpgsqlTypes.NpgsqlLine(a: 0.8684618141546326d, b: 0.28674815818499166d, c: 0.7466606658592323d),

new NpgsqlTypes.NpgsqlLine(a: 0.38873518295865717d, b: 0.31306425776277647d, c: 0.03116974851721599d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07354895213415424d, b: 0.46725994402020943d, c: 0.715868945916103d),

new NpgsqlTypes.NpgsqlLine(a: 0.16740697041974018d, b: 0.52118415582306d, c: 0.22353646825702922d),

new NpgsqlTypes.NpgsqlLine(a: 0.5853150433890176d, b: 0.997073531392755d, c: 0.6866773820562164d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7548173876844978d, b: 0.24521488082621945d, c: 0.36318327564376895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979303080981232d, b: 0.49658113007138927d, c: 0.7585782307926241d),

new NpgsqlTypes.NpgsqlLine(a: 0.17682365194509397d, b: 0.33451539802997055d, c: 0.1377935398117036d),

new NpgsqlTypes.NpgsqlLine(a: 0.9324846582882796d, b: 0.34888437483033363d, c: 0.5407838808678556d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24454945783850712d, b: 0.45784513145665207d, c: 0.35189522603745615d),

new NpgsqlTypes.NpgsqlLine(a: 0.4441450619206829d, b: 0.4409175631873987d, c: 0.996218588244312d),

new NpgsqlTypes.NpgsqlLine(a: 0.7699731465493729d, b: 0.04145265447677393d, c: 0.7085864759044282d),

new NpgsqlTypes.NpgsqlLine(a: 0.9858914338753277d, b: 0.23988114121926474d, c: 0.1642426287390767d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5190562806177452d, b: 0.6729706215492802d, c: 0.035243249598230664d),

new NpgsqlTypes.NpgsqlLine(a: 0.5720885732082531d, b: 0.9477280121662993d, c: 0.3424021462827045d),

new NpgsqlTypes.NpgsqlLine(a: 0.3002499328479742d, b: 0.0023995863950495577d, c: 0.14917322815526113d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.49581657969560367d, b: 0.3386377289363439d, c: 0.17551021081464702d),

new NpgsqlTypes.NpgsqlLine(a: 0.29718550189181714d, b: 0.5518523611281115d, c: 0.3327172098012706d),

new NpgsqlTypes.NpgsqlLine(a: 0.6241904131661857d, b: 0.11653841354371164d, c: 0.6823059410958712d),

new NpgsqlTypes.NpgsqlLine(a: 0.4126522800055198d, b: 0.2726412581599651d, c: 0.6112376995695201d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.09864497629503044d, b: 0.5419140962707645d, c: 0.3776720046660139d),

new NpgsqlTypes.NpgsqlLine(a: 0.6715585780442949d, b: 0.4955020807513407d, c: 0.1597621473636145d),

new NpgsqlTypes.NpgsqlLine(a: 0.6527191710614516d, b: 0.6509922166700141d, c: 0.20650029630146238d),

new NpgsqlTypes.NpgsqlLine(a: 0.7135290131816044d, b: 0.05165628661810173d, c: 0.6562777436196069d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.37034109689478545d, b: 0.9229515393363317d, c: 0.9973486825202811d),

new NpgsqlTypes.NpgsqlLine(a: 0.5339011584655796d, b: 0.536465755524387d, c: 0.06973275958453073d),

new NpgsqlTypes.NpgsqlLine(a: 0.23467199993728172d, b: 0.43847141825475566d, c: 0.12779463959653414d),

new NpgsqlTypes.NpgsqlLine(a: 0.8675061735354215d, b: 0.14422762385441357d, c: 0.32263324813725025d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7026134308009494d, b: 0.9670636449824018d, c: 0.8412447240572224d),

new NpgsqlTypes.NpgsqlLine(a: 0.8210799420608581d, b: 0.00991959985072366d, c: 0.5014013783895701d),

new NpgsqlTypes.NpgsqlLine(a: 0.008725433960864226d, b: 0.35747497280490514d, c: 0.09239590332709302d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5675753790215923d, b: 0.6408030887626752d, c: 0.646687143100631d),

new NpgsqlTypes.NpgsqlLine(a: 0.07296341389843575d, b: 0.49610121047135936d, c: 0.7532619193651235d),

new NpgsqlTypes.NpgsqlLine(a: 0.18235555181909424d, b: 0.2693487958873997d, c: 0.8338336360853531d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9730133746900734d, b: 0.5359946359736806d, c: 0.9094670607576837d),

new NpgsqlTypes.NpgsqlLine(a: 0.13792307413152338d, b: 0.8930293092314553d, c: 0.5945645499871842d),

new NpgsqlTypes.NpgsqlLine(a: 0.9983578758470175d, b: 0.5707357085815659d, c: 0.5515369254557182d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4116486631515327d, b: 0.5894665716216588d, c: 0.14732914272294462d),

new NpgsqlTypes.NpgsqlLine(a: 0.7968975874479884d, b: 0.9049735587754796d, c: 0.5082397747206029d),

new NpgsqlTypes.NpgsqlLine(a: 0.32518336598264963d, b: 0.29737517360763277d, c: 0.5614870586397609d),

new NpgsqlTypes.NpgsqlLine(a: 0.2753995125202935d, b: 0.23225492737193776d, c: 0.6639685898407651d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7097070834853278d, b: 0.5559551671015169d, c: 0.19570666011111504d),

new NpgsqlTypes.NpgsqlLine(a: 0.09018781055177183d, b: 0.09250572887440711d, c: 0.9666712878825587d),

new NpgsqlTypes.NpgsqlLine(a: 0.36138807827437247d, b: 0.4461226396187935d, c: 0.6873792144405533d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10610480541265954d, b: 0.30083416436008026d, c: 0.3288820276756925d),

new NpgsqlTypes.NpgsqlLine(a: 0.03879015550292353d, b: 0.6727490324414748d, c: 0.7967307664855815d),

new NpgsqlTypes.NpgsqlLine(a: 0.9008462159739951d, b: 0.41723468163514443d, c: 0.02765237649132002d),

new NpgsqlTypes.NpgsqlLine(a: 0.09732382598481415d, b: 0.16851042733238075d, c: 0.9452887114331082d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.39592881054392315d, b: 0.19902205077983015d, c: 0.7071305902407398d),

new NpgsqlTypes.NpgsqlLine(a: 0.3255878183726819d, b: 0.07253463764812929d, c: 0.645473981511575d),

new NpgsqlTypes.NpgsqlLine(a: 0.46244570398917817d, b: 0.1992620953655726d, c: 0.07745666492108172d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7195620391156936d, b: 0.16585859881092768d, c: 0.37915097042033064d),

new NpgsqlTypes.NpgsqlLine(a: 0.5512185569544745d, b: 0.5163599827183792d, c: 0.6555692950067056d),

new NpgsqlTypes.NpgsqlLine(a: 0.6767593363379687d, b: 0.03699135789936503d, c: 0.7351800763182582d),

new NpgsqlTypes.NpgsqlLine(a: 0.3714495578556727d, b: 0.7525273770193163d, c: 0.7456652705081729d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.48882857981311323d, b: 0.2766000099160546d, c: 0.7695135795740017d),

new NpgsqlTypes.NpgsqlLine(a: 0.6780092509041317d, b: 0.03978503588587279d, c: 0.020559454988464676d),

new NpgsqlTypes.NpgsqlLine(a: 0.49669656505436643d, b: 0.814460343643667d, c: 0.5848125834169761d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23101499608505827d, b: 0.2380574059742826d, c: 0.04107384424254612d),

new NpgsqlTypes.NpgsqlLine(a: 0.12808697053977502d, b: 0.26577369164650744d, c: 0.07646902181997484d),

new NpgsqlTypes.NpgsqlLine(a: 0.22915543913162728d, b: 0.3617533519384487d, c: 0.38913360201397584d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.461834682632847d, b: 0.43609121111170346d, c: 0.5197038375150669d),

new NpgsqlTypes.NpgsqlLine(a: 0.3663331460972644d, b: 0.26410320858957226d, c: 0.8325403388175396d),

new NpgsqlTypes.NpgsqlLine(a: 0.31350610163029435d, b: 0.9331807931182468d, c: 0.8109894687943523d),

new NpgsqlTypes.NpgsqlLine(a: 0.3706392944140545d, b: 0.009179271456584148d, c: 0.16016504143459642d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8205768541140157d, b: 0.44395865029259074d, c: 0.4660417567266719d),

new NpgsqlTypes.NpgsqlLine(a: 0.9076738579528594d, b: 0.05401304978862842d, c: 0.975763166953217d),

new NpgsqlTypes.NpgsqlLine(a: 0.08946703105276022d, b: 0.456211228214242d, c: 0.7989983209727279d),

new NpgsqlTypes.NpgsqlLine(a: 0.9898650162199323d, b: 0.8906067698905034d, c: 0.32750304189999924d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9079684239169444d, b: 0.35421821432383205d, c: 0.2751281693178771d),

new NpgsqlTypes.NpgsqlLine(a: 0.14538500224351913d, b: 0.4388890605963408d, c: 0.04831222589065709d),

new NpgsqlTypes.NpgsqlLine(a: 0.7186234497165385d, b: 0.05842692283394535d, c: 0.04555987044097276d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9993103749715815d, b: 0.7339731533394589d, c: 0.4877954171318051d),

new NpgsqlTypes.NpgsqlLine(a: 0.5412176123532955d, b: 0.21253277143777172d, c: 0.39728035959429475d),

new NpgsqlTypes.NpgsqlLine(a: 0.17999800002939226d, b: 0.7230662152618748d, c: 0.33394487545037066d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6828708308216148d, b: 0.08781747386154459d, c: 0.9776676332248503d),

new NpgsqlTypes.NpgsqlLine(a: 0.9816403840690933d, b: 0.9116024050626399d, c: 0.888462897026374d),

new NpgsqlTypes.NpgsqlLine(a: 0.08033860502063905d, b: 0.26620063301318375d, c: 0.05180588667024577d),

new NpgsqlTypes.NpgsqlLine(a: 0.9557788329329114d, b: 0.1360130632345684d, c: 0.6281738552004535d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.918506707866002d, b: 0.987678247427565d, c: 0.25783622660319905d),

new NpgsqlTypes.NpgsqlLine(a: 0.02350904849603186d, b: 0.004487157315425594d, c: 0.7975525058809041d),

new NpgsqlTypes.NpgsqlLine(a: 0.8072871425662956d, b: 0.392985482499839d, c: 0.4898588683045342d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7590075877915418d, b: 0.40496125839342256d, c: 0.5961245130638028d),

new NpgsqlTypes.NpgsqlLine(a: 0.25635637765731834d, b: 0.6672419154535218d, c: 0.9926489864218029d),

new NpgsqlTypes.NpgsqlLine(a: 0.34402345039247284d, b: 0.5477316226104098d, c: 0.39810100640471413d),

new NpgsqlTypes.NpgsqlLine(a: 0.10375195470770149d, b: 0.10184940270279919d, c: 0.3326644577098554d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26720418761567344d, b: 0.6894015214856253d, c: 0.9720136459780107d),

new NpgsqlTypes.NpgsqlLine(a: 0.8870251816551183d, b: 0.1633505822563882d, c: 0.5248628448626629d),

new NpgsqlTypes.NpgsqlLine(a: 0.4235586231569253d, b: 0.591139378106507d, c: 0.32628357324893276d),

new NpgsqlTypes.NpgsqlLine(a: 0.6619898398887346d, b: 0.017396458955994953d, c: 0.7316388263777914d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4068724927210039d, b: 0.7642303220227172d, c: 0.7123354648608536d),

new NpgsqlTypes.NpgsqlLine(a: 0.008882049921663082d, b: 0.7303192324786119d, c: 0.029078050536547884d),

new NpgsqlTypes.NpgsqlLine(a: 0.285838773017156d, b: 0.16295259398142325d, c: 0.4698996058631315d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5236272776432365d, b: 0.7747150273556898d, c: 0.12908424056691725d),

new NpgsqlTypes.NpgsqlLine(a: 0.14144420814176661d, b: 0.8653295482877921d, c: 0.6046495754935619d),

new NpgsqlTypes.NpgsqlLine(a: 0.03946281792686257d, b: 0.5215537341766978d, c: 0.6960526940724246d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6272445713311248d, b: 0.22683004791027606d, c: 0.8460975004315324d),

new NpgsqlTypes.NpgsqlLine(a: 0.4830210665130813d, b: 0.8106594696089133d, c: 0.41095265381643675d),

new NpgsqlTypes.NpgsqlLine(a: 0.6695319095717005d, b: 0.7885467700646666d, c: 0.9984930581533441d),

new NpgsqlTypes.NpgsqlLine(a: 0.25971981908865294d, b: 0.4175362541408907d, c: 0.8761823476454521d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6841461841309991d, b: 0.7710215787920914d, c: 0.6220713320518776d),

new NpgsqlTypes.NpgsqlLine(a: 0.6803464223613467d, b: 0.7124666069547511d, c: 0.48445852626090113d),

new NpgsqlTypes.NpgsqlLine(a: 0.6527935562818478d, b: 0.4929342919269383d, c: 0.4766081490348286d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.33164410736191974d, b: 0.8776449652734878d, c: 0.6581674193248672d),

new NpgsqlTypes.NpgsqlLine(a: 0.24455797169240356d, b: 0.039073800823756444d, c: 0.14019680587877725d),

new NpgsqlTypes.NpgsqlLine(a: 0.6692971305028758d, b: 0.15085120108293237d, c: 0.2700965691700188d),

new NpgsqlTypes.NpgsqlLine(a: 0.11365700543330282d, b: 0.9231051762822824d, c: 0.6321166863685015d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13826261112534788d, b: 0.25376183969835553d, c: 0.12222707108871533d),

new NpgsqlTypes.NpgsqlLine(a: 0.38076923566646625d, b: 0.22184131021982179d, c: 0.27389402254198836d),

new NpgsqlTypes.NpgsqlLine(a: 0.39298163572668876d, b: 0.9133254615720674d, c: 0.04363921383538005d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4926158475681427d, b: 0.821673359519896d, c: 0.4415216020235815d),

new NpgsqlTypes.NpgsqlLine(a: 0.6203256399192938d, b: 0.8738916204792628d, c: 0.7158787753471911d),

new NpgsqlTypes.NpgsqlLine(a: 0.40453371402854976d, b: 0.3960229173339782d, c: 0.3344716683877884d),

new NpgsqlTypes.NpgsqlLine(a: 0.3099694830764044d, b: 0.8709830077672053d, c: 0.24167670900192983d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1675400635023555d, b: 0.8285786239366778d, c: 0.7303046135580662d),

new NpgsqlTypes.NpgsqlLine(a: 0.20661259062847281d, b: 0.9025492035559529d, c: 0.3326483884591872d),

new NpgsqlTypes.NpgsqlLine(a: 0.894342619640456d, b: 0.2532931278559476d, c: 0.5032468956462777d),

new NpgsqlTypes.NpgsqlLine(a: 0.009378709518939932d, b: 0.7896346164800045d, c: 0.06985479870849365d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4319681503808983d, b: 0.5049400899590013d, c: 0.26969379429398177d),

new NpgsqlTypes.NpgsqlLine(a: 0.04572220955552164d, b: 0.2030533524023328d, c: 0.2594543255979116d),

new NpgsqlTypes.NpgsqlLine(a: 0.9079501368108978d, b: 0.20599108045643344d, c: 0.749125312524981d),

new NpgsqlTypes.NpgsqlLine(a: 0.5696524383562818d, b: 0.688293827775027d, c: 0.404642427026653d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7485089872023833d, b: 0.5728086429318655d, c: 0.29436785220170225d),

new NpgsqlTypes.NpgsqlLine(a: 0.6712879390609905d, b: 0.9185046327041575d, c: 0.6471113333861518d),

new NpgsqlTypes.NpgsqlLine(a: 0.8093910829151619d, b: 0.8997698771455392d, c: 0.6720577478267366d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.345010886439607d, b: 0.42511987043879995d, c: 0.3001277837025924d),

new NpgsqlTypes.NpgsqlLine(a: 0.1357202752880028d, b: 0.2613625323385729d, c: 0.1778590038922554d),

new NpgsqlTypes.NpgsqlLine(a: 0.022924375390813156d, b: 0.41074292386681444d, c: 0.19189444402122213d),

new NpgsqlTypes.NpgsqlLine(a: 0.23980967679493015d, b: 0.8122314551165711d, c: 0.8467328098902818d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.27214473886793045d, b: 0.11211437196347052d, c: 0.21795159285728638d),

new NpgsqlTypes.NpgsqlLine(a: 0.8770710351204165d, b: 0.2114932638284034d, c: 0.5540021001972661d),

new NpgsqlTypes.NpgsqlLine(a: 0.9798823630983323d, b: 0.12070597981485298d, c: 0.3718327965281356d),

new NpgsqlTypes.NpgsqlLine(a: 0.47300718180920187d, b: 0.386968265015454d, c: 0.9123591618176787d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7224543878539971d, b: 0.8520935455997635d, c: 0.8802672842525467d),

new NpgsqlTypes.NpgsqlLine(a: 0.460393127799395d, b: 0.9686441363024714d, c: 0.12334764804200304d),

new NpgsqlTypes.NpgsqlLine(a: 0.043822434167627544d, b: 0.9970086852826362d, c: 0.0530729643406721d),

new NpgsqlTypes.NpgsqlLine(a: 0.7777235587948181d, b: 0.06793999366009063d, c: 0.46576588945437825d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8535314564652873d, b: 0.1403359357215922d, c: 0.3223115155578282d),

new NpgsqlTypes.NpgsqlLine(a: 0.5713438603593731d, b: 0.8257548225256753d, c: 0.7747705063840424d),

new NpgsqlTypes.NpgsqlLine(a: 0.24038218759235896d, b: 0.3625720366251386d, c: 0.6272174235307872d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07170270768952736d, b: 0.6947432111694083d, c: 0.004385254808071837d),

new NpgsqlTypes.NpgsqlLine(a: 0.7864964939913696d, b: 0.8126093266875226d, c: 0.31765247213485115d),

new NpgsqlTypes.NpgsqlLine(a: 0.15223243017812427d, b: 0.12394424776102253d, c: 0.12812669484661554d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28148413104153447d, b: 0.15318996642881555d, c: 0.4250359851733071d),

new NpgsqlTypes.NpgsqlLine(a: 0.07769466333820829d, b: 0.47372477833384896d, c: 0.035648508365082265d),

new NpgsqlTypes.NpgsqlLine(a: 0.05490705312013289d, b: 0.5095947117362696d, c: 0.5552228146897403d),

new NpgsqlTypes.NpgsqlLine(a: 0.9139451446432136d, b: 0.6123919027893236d, c: 0.7555335658063196d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47924792059322086d, b: 0.054865677683147984d, c: 0.342857821145661d),

new NpgsqlTypes.NpgsqlLine(a: 0.23662673432164694d, b: 0.8757857724668364d, c: 0.21057944966791697d),

new NpgsqlTypes.NpgsqlLine(a: 0.29574223935438093d, b: 0.9947149710092623d, c: 0.6804163585254674d),

new NpgsqlTypes.NpgsqlLine(a: 0.8155015076250617d, b: 0.23475727106104494d, c: 0.1888853691582717d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8424658196783157d, b: 0.48845267334741593d, c: 0.5345780016067981d),

new NpgsqlTypes.NpgsqlLine(a: 0.26873265038162986d, b: 0.21265306734607314d, c: 0.9605120600373264d),

new NpgsqlTypes.NpgsqlLine(a: 0.6059167850268453d, b: 0.25765398221958935d, c: 0.23359368510060718d),

new NpgsqlTypes.NpgsqlLine(a: 0.88537921048456d, b: 0.5110370437449797d, c: 0.1563312224642045d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7754652204045923d, b: 0.07873785056259353d, c: 0.37387625629436083d),

new NpgsqlTypes.NpgsqlLine(a: 0.21243065542041728d, b: 0.8553256830043673d, c: 0.38581071051430593d),

new NpgsqlTypes.NpgsqlLine(a: 0.7797781205695824d, b: 0.5974428321141982d, c: 0.398741854596085d),

new NpgsqlTypes.NpgsqlLine(a: 0.25267202260054744d, b: 0.18675056520897348d, c: 0.1945289325348062d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5882402074463479d, b: 0.8748362144076663d, c: 0.7356362425241294d),

new NpgsqlTypes.NpgsqlLine(a: 0.9269863768520951d, b: 0.10703354644579255d, c: 0.10027763678814605d),

new NpgsqlTypes.NpgsqlLine(a: 0.8087890261334206d, b: 0.7903621958178118d, c: 0.8265655779231927d),

new NpgsqlTypes.NpgsqlLine(a: 0.8436019932559271d, b: 0.8274619678351384d, c: 0.08918005345589264d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7191292848748957d, b: 0.9544906601105274d, c: 0.22175925258172702d),

new NpgsqlTypes.NpgsqlLine(a: 0.009380390953978246d, b: 0.30751682374260414d, c: 0.04624248474725978d),

new NpgsqlTypes.NpgsqlLine(a: 0.1261376161202118d, b: 0.9470117600516873d, c: 0.8657508833951146d),

new NpgsqlTypes.NpgsqlLine(a: 0.7523609150272688d, b: 0.8034066544197883d, c: 0.9172187609992292d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.19353895747389316d, b: 0.5981348033705006d, c: 0.3947969685457172d),

new NpgsqlTypes.NpgsqlLine(a: 0.4427777482161851d, b: 0.6944606711400365d, c: 0.6447998948302366d),

new NpgsqlTypes.NpgsqlLine(a: 0.23056230198345884d, b: 0.6336474707768385d, c: 0.16999235136962798d),

new NpgsqlTypes.NpgsqlLine(a: 0.9656148212378469d, b: 0.13640908316951694d, c: 0.2259546266867657d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.544640157356595d, b: 0.09179456408173414d, c: 0.4543564793390117d),

new NpgsqlTypes.NpgsqlLine(a: 0.4938310625092659d, b: 0.6244990965493769d, c: 0.26128238660312986d),

new NpgsqlTypes.NpgsqlLine(a: 0.5191550005414985d, b: 0.6235993693055114d, c: 0.2929771268802479d),

new NpgsqlTypes.NpgsqlLine(a: 0.2575381326874343d, b: 0.4645545319292904d, c: 0.8807590436466898d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5997400992323254d, b: 0.16701378056062044d, c: 0.45368919836075383d),

new NpgsqlTypes.NpgsqlLine(a: 0.9064265501448217d, b: 0.03600369066814901d, c: 0.5053471609751353d),

new NpgsqlTypes.NpgsqlLine(a: 0.5239233444610707d, b: 0.768402522335033d, c: 0.6398958764495493d),

new NpgsqlTypes.NpgsqlLine(a: 0.5809057604150453d, b: 0.855616504293742d, c: 0.023621670608969914d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.877894665474835d, b: 0.4705150901655888d, c: 0.770996183258676d),

new NpgsqlTypes.NpgsqlLine(a: 0.8290369846245398d, b: 0.8395444225292242d, c: 0.8533031002852398d),

new NpgsqlTypes.NpgsqlLine(a: 0.1522457824751523d, b: 0.3421871411473587d, c: 0.47051351388964735d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0019015889113104256d, b: 0.0874990670777509d, c: 0.31514257260416256d),

new NpgsqlTypes.NpgsqlLine(a: 0.09847754701817768d, b: 0.6537044152018023d, c: 0.26384654721648104d),

new NpgsqlTypes.NpgsqlLine(a: 0.30024204531138987d, b: 0.25234290255322833d, c: 0.3393190611412171d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8483393125736871d, b: 0.03670638521836411d, c: 0.7193564806474355d),

new NpgsqlTypes.NpgsqlLine(a: 0.026517224556093733d, b: 0.5627695199348565d, c: 0.23815564842908232d),

new NpgsqlTypes.NpgsqlLine(a: 0.6892651900967492d, b: 0.26636747665547156d, c: 0.5111659540091091d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8901643691248048d, b: 0.7683996105969831d, c: 0.3854945987175805d),

new NpgsqlTypes.NpgsqlLine(a: 0.8985450416772385d, b: 0.09090058711886562d, c: 0.35841542582241026d),

new NpgsqlTypes.NpgsqlLine(a: 0.17805447660559492d, b: 0.17654427553616336d, c: 0.05943937017234768d),

new NpgsqlTypes.NpgsqlLine(a: 0.6690441580630895d, b: 0.028792574320138486d, c: 0.5623875745390357d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6883483042471823d, b: 0.47681364130072224d, c: 0.47220068178264984d),

new NpgsqlTypes.NpgsqlLine(a: 0.5379243722475939d, b: 0.782820481807712d, c: 0.7481559718194662d),

new NpgsqlTypes.NpgsqlLine(a: 0.20768247316951582d, b: 0.7586878410003128d, c: 0.9925758268393639d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.30471728937833087d, b: 0.8070932129438511d, c: 0.3306152772119374d),

new NpgsqlTypes.NpgsqlLine(a: 0.4712755245072796d, b: 0.01996434734841923d, c: 0.9380814825457484d),

new NpgsqlTypes.NpgsqlLine(a: 0.04828618201535573d, b: 0.9729309972735577d, c: 0.19187017852989907d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7248790320970515d, b: 0.040547790338076095d, c: 0.7889143976773908d),

new NpgsqlTypes.NpgsqlLine(a: 0.230031656404726d, b: 0.1672585540960524d, c: 0.7654746243093795d),

new NpgsqlTypes.NpgsqlLine(a: 0.3606811401211224d, b: 0.7076168262422527d, c: 0.21893117818021646d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10692216556185774d, b: 0.7915596678695846d, c: 0.1767034270355171d),

new NpgsqlTypes.NpgsqlLine(a: 0.6624664825788265d, b: 0.47993591627821697d, c: 0.17445946110469435d),

new NpgsqlTypes.NpgsqlLine(a: 0.8750044774907928d, b: 0.020465933815333237d, c: 0.8700933346781042d),

new NpgsqlTypes.NpgsqlLine(a: 0.6663398521963956d, b: 0.41678666131273245d, c: 0.05444233134335186d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16879384355915072d, b: 0.9372813523596485d, c: 0.765880302183765d),

new NpgsqlTypes.NpgsqlLine(a: 0.08206586339863231d, b: 0.09207145097738989d, c: 0.9453281881978763d),

new NpgsqlTypes.NpgsqlLine(a: 0.7963693295423783d, b: 0.034424515747152995d, c: 0.21072632889090015d),

new NpgsqlTypes.NpgsqlLine(a: 0.5233055577795853d, b: 0.9912154508727032d, c: 0.1797415427483111d),

},
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[2], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[3], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[26],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[27],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 138, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 101, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatchAsync(connection, 92, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatch(connection, 75, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[29], false);
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
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[2], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[3], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[26],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2M>(15);

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
                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlLinelineArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlLinelineArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

