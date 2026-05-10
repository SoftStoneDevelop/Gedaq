

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
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3139308397912822d, b: 0.9706745193366693d, c: 0.628742739438371d),
new NpgsqlTypes.NpgsqlLine(a: 0.5725738681514622d, b: 0.11100818197808593d, c: 0.5900487100928353d),
new NpgsqlTypes.NpgsqlLine(a: 0.5401242723530475d, b: 0.7362349576287972d, c: 0.39062884629311456d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22304246563196717d, b: 0.5845713514940611d, c: 0.22681710104618868d),
new NpgsqlTypes.NpgsqlLine(a: 0.21603352128719633d, b: 0.9795940020496957d, c: 0.25284990379147d),
new NpgsqlTypes.NpgsqlLine(a: 0.7559672336191184d, b: 0.05762898443721842d, c: 0.7657786440208453d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5840173512392173d, b: 0.6731224948441383d, c: 0.12939417200228975d),
new NpgsqlTypes.NpgsqlLine(a: 0.8505994754137526d, b: 0.9651802815870857d, c: 0.13721657985172786d),
new NpgsqlTypes.NpgsqlLine(a: 0.8971785872725158d, b: 0.24308573169041048d, c: 0.9837431324797081d),
new NpgsqlTypes.NpgsqlLine(a: 0.5599652225444004d, b: 0.2764164991875224d, c: 0.4793053365385729d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08094912884035432d, b: 0.030150538912574243d, c: 0.3984456204453901d),
new NpgsqlTypes.NpgsqlLine(a: 0.1330412250709665d, b: 0.3002519660700441d, c: 0.9099452537872569d),
new NpgsqlTypes.NpgsqlLine(a: 0.4124315637680793d, b: 0.6725900675878207d, c: 0.7439550365501549d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.233757879694806d, b: 0.9224211023737988d, c: 0.9527053314557382d),
new NpgsqlTypes.NpgsqlLine(a: 0.8098538178020519d, b: 0.6877440301082383d, c: 0.053045323039021874d),
new NpgsqlTypes.NpgsqlLine(a: 0.70402784450167d, b: 0.7793155801372639d, c: 0.8713362420940608d),
new NpgsqlTypes.NpgsqlLine(a: 0.183441058999531d, b: 0.13732050946475305d, c: 0.7090961167192618d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9256560472924629d, b: 0.8479585490156394d, c: 0.07040664152471066d),
new NpgsqlTypes.NpgsqlLine(a: 0.7974368809719807d, b: 0.8249339420107955d, c: 0.7422951586769038d),
new NpgsqlTypes.NpgsqlLine(a: 0.035508561502006986d, b: 0.05268136339165708d, c: 0.91593157141152d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.059410753688537765d, b: 0.13019640587307912d, c: 0.1302205869117149d),
new NpgsqlTypes.NpgsqlLine(a: 0.032721798116857825d, b: 0.7297199908796241d, c: 0.32482182037079255d),
new NpgsqlTypes.NpgsqlLine(a: 0.4868495119225872d, b: 0.9899994903099845d, c: 0.7064059133651726d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7658452024528803d, b: 0.23985244278395623d, c: 0.23605717489444744d),
new NpgsqlTypes.NpgsqlLine(a: 0.20493666957212942d, b: 0.624929531520268d, c: 0.4949803023132203d),
new NpgsqlTypes.NpgsqlLine(a: 0.6587780326960255d, b: 0.7913298882964865d, c: 0.14347963770644567d),
new NpgsqlTypes.NpgsqlLine(a: 0.6980440094317828d, b: 0.9962910735007025d, c: 0.6713736701932511d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.34609246851187936d, b: 0.39251547551801025d, c: 0.32541761654649637d),
new NpgsqlTypes.NpgsqlLine(a: 0.46765336813743064d, b: 0.5764654867328483d, c: 0.7441488575516071d),
new NpgsqlTypes.NpgsqlLine(a: 0.10428831399683436d, b: 0.29698994425051417d, c: 0.6992844267686388d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12691540253718092d, b: 0.8300195702672797d, c: 0.6887746357101163d),
new NpgsqlTypes.NpgsqlLine(a: 0.2521708225428909d, b: 0.17080458496046091d, c: 0.2939650129314725d),
new NpgsqlTypes.NpgsqlLine(a: 0.3470058000780324d, b: 0.026677092144188452d, c: 0.08198028225743337d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25253775974953296d, b: 0.47837230283004983d, c: 0.49878227734808733d),
new NpgsqlTypes.NpgsqlLine(a: 0.5335450351259224d, b: 0.5165797064062488d, c: 0.5963631321973121d),
new NpgsqlTypes.NpgsqlLine(a: 0.5009874513591015d, b: 0.018464501531590183d, c: 0.40527210670411595d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6871587090124631d, b: 0.047620746155580984d, c: 0.33065840347811537d),
new NpgsqlTypes.NpgsqlLine(a: 0.7211969901831852d, b: 0.3547360158613555d, c: 0.972709095693869d),
new NpgsqlTypes.NpgsqlLine(a: 0.14922846566141412d, b: 0.493370056651957d, c: 0.905906456466475d),
new NpgsqlTypes.NpgsqlLine(a: 0.7978088508917298d, b: 0.1908495283086381d, c: 0.21746717439986052d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19239155578648592d, b: 0.0011320964355291396d, c: 0.0895865927705688d),
new NpgsqlTypes.NpgsqlLine(a: 0.7041261555311696d, b: 0.2699436812703164d, c: 0.10978531914891787d),
new NpgsqlTypes.NpgsqlLine(a: 0.6775499863227693d, b: 0.25741277545747954d, c: 0.30060214422917253d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4008460555830651d, b: 0.6419727198852884d, c: 0.3326227249870758d),
new NpgsqlTypes.NpgsqlLine(a: 0.0848561215860133d, b: 0.3767583360461826d, c: 0.7485990074389707d),
new NpgsqlTypes.NpgsqlLine(a: 0.0384111569873109d, b: 0.07094729327684723d, c: 0.0767955740445323d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24171023722278184d, b: 0.3447206564805224d, c: 0.980813051740245d),
new NpgsqlTypes.NpgsqlLine(a: 0.6824666060898713d, b: 0.7421499511145851d, c: 0.7107675893917467d),
new NpgsqlTypes.NpgsqlLine(a: 0.7989873293267894d, b: 0.7030337001482367d, c: 0.9756693706954875d),
new NpgsqlTypes.NpgsqlLine(a: 0.6980961296903048d, b: 0.09104382252341292d, c: 0.29530613741480927d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5822899220495753d, b: 0.5644281410954355d, c: 0.022370957359178933d),
new NpgsqlTypes.NpgsqlLine(a: 0.15170626802229092d, b: 0.563397059225121d, c: 0.0782048173331178d),
new NpgsqlTypes.NpgsqlLine(a: 0.23401171764707263d, b: 0.40327015353015117d, c: 0.13504609814644486d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09666169231187638d, b: 0.7283132305617894d, c: 0.8016625181925362d),
new NpgsqlTypes.NpgsqlLine(a: 0.5340514911124944d, b: 0.23881174444034092d, c: 0.033340037068604333d),
new NpgsqlTypes.NpgsqlLine(a: 0.17413387722975615d, b: 0.5843890222810783d, c: 0.11421692211936751d),
new NpgsqlTypes.NpgsqlLine(a: 0.04534301229335602d, b: 0.688868516515518d, c: 0.6616914589345873d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6853614677601814d, b: 0.8908196416107838d, c: 0.8599819918896275d),
new NpgsqlTypes.NpgsqlLine(a: 0.05469363946492567d, b: 0.7172640733055512d, c: 0.5325030300633132d),
new NpgsqlTypes.NpgsqlLine(a: 0.8256858920073677d, b: 0.2002048109308039d, c: 0.6054752339011817d),
new NpgsqlTypes.NpgsqlLine(a: 0.8280635775350932d, b: 0.7657101490588539d, c: 0.16891623526923705d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2722983139235794d, b: 0.622145436930459d, c: 0.967988773166025d),
new NpgsqlTypes.NpgsqlLine(a: 0.5449112915919373d, b: 0.7722277810940942d, c: 0.47848378270818126d),
new NpgsqlTypes.NpgsqlLine(a: 0.4227589804855395d, b: 0.34063455451220437d, c: 0.009786445344032058d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.619368138262164d, b: 0.9079258531989756d, c: 0.6083299446908722d),
new NpgsqlTypes.NpgsqlLine(a: 0.892588436526807d, b: 0.19849119997545972d, c: 0.4431982207145845d),
new NpgsqlTypes.NpgsqlLine(a: 0.27657777872917255d, b: 0.032343872513222016d, c: 0.4829724846386463d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11760563515047384d, b: 0.997411021435913d, c: 0.1865175982946794d),
new NpgsqlTypes.NpgsqlLine(a: 0.4901401884910457d, b: 0.8640679181936579d, c: 0.42963595850519043d),
new NpgsqlTypes.NpgsqlLine(a: 0.8060651535485944d, b: 0.5867414693004075d, c: 0.33188225641584523d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8304188445108406d, b: 0.4594583067037301d, c: 0.9869090560578612d),
new NpgsqlTypes.NpgsqlLine(a: 0.3379747210128896d, b: 0.14302520575885502d, c: 0.8000206188804473d),
new NpgsqlTypes.NpgsqlLine(a: 0.027058565689371816d, b: 0.3489930202226845d, c: 0.6262450835750689d),
new NpgsqlTypes.NpgsqlLine(a: 0.7547556927953766d, b: 0.9083165498677327d, c: 0.5187234841309054d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7418234027949231d, b: 0.521176676719149d, c: 0.7969690380418849d),
new NpgsqlTypes.NpgsqlLine(a: 0.7571064109677913d, b: 0.6118850494488178d, c: 0.044620282602677475d),
new NpgsqlTypes.NpgsqlLine(a: 0.8338035518809668d, b: 0.9338945510836979d, c: 0.24205153406375135d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4892841183612068d, b: 0.6628023162529851d, c: 0.23775100645940184d),
new NpgsqlTypes.NpgsqlLine(a: 0.16682606002246392d, b: 0.17682439574717734d, c: 0.1739215310500043d),
new NpgsqlTypes.NpgsqlLine(a: 0.41627066665955836d, b: 0.7416508675807767d, c: 0.3709931460184902d),
new NpgsqlTypes.NpgsqlLine(a: 0.028661154443934134d, b: 0.6226255872111796d, c: 0.736573418619408d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7761910257025811d, b: 0.8297707046940364d, c: 0.08790263546318855d),
new NpgsqlTypes.NpgsqlLine(a: 0.9773262498680002d, b: 0.6040198302798284d, c: 0.26080991608323134d),
new NpgsqlTypes.NpgsqlLine(a: 0.4748454236502607d, b: 0.5430097300716685d, c: 0.6430522249187982d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3446915487872726d, b: 0.10417059338294621d, c: 0.28422208530687987d),
new NpgsqlTypes.NpgsqlLine(a: 0.17990649580699014d, b: 0.12164093520541042d, c: 0.6949303623229006d),
new NpgsqlTypes.NpgsqlLine(a: 0.8117784454681672d, b: 0.6656881446272537d, c: 0.26202372450935363d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9844999610554741d, b: 0.5744003102060892d, c: 0.6025776138951012d),
new NpgsqlTypes.NpgsqlLine(a: 0.7435433787211194d, b: 0.24989097454987885d, c: 0.6720746405808766d),
new NpgsqlTypes.NpgsqlLine(a: 0.8044478166356988d, b: 0.23201333670816493d, c: 0.47635478637813145d),
new NpgsqlTypes.NpgsqlLine(a: 0.25429974888655993d, b: 0.9585946919740315d, c: 0.5456476362137062d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9803942885281275d, b: 0.2368289416078091d, c: 0.9931753815897602d),
new NpgsqlTypes.NpgsqlLine(a: 0.7403775866829669d, b: 0.7131650196438692d, c: 3.578821540528576E-05d),
new NpgsqlTypes.NpgsqlLine(a: 0.5551941869960522d, b: 0.008679912363629194d, c: 0.8682684375769252d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43521471851284677d, b: 0.01181006790658834d, c: 0.8181406587797065d),
new NpgsqlTypes.NpgsqlLine(a: 0.958195642112112d, b: 0.32505259571479017d, c: 0.4777193820095387d),
new NpgsqlTypes.NpgsqlLine(a: 0.8367152050540546d, b: 0.8767285237604612d, c: 0.19937162784680462d),
new NpgsqlTypes.NpgsqlLine(a: 0.8679473952450628d, b: 0.29265149581536154d, c: 0.515062321831476d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.011874563832182994d, b: 0.9496422434379402d, c: 0.751329829343914d),
new NpgsqlTypes.NpgsqlLine(a: 0.2792057200470708d, b: 0.9493645210291262d, c: 0.6996036568761193d),
new NpgsqlTypes.NpgsqlLine(a: 0.3264342123134516d, b: 0.6557082958610828d, c: 0.027677148386518025d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.373813803129054d, b: 0.9934801149361842d, c: 0.1920867764377574d),
new NpgsqlTypes.NpgsqlLine(a: 0.246659641939747d, b: 0.45048458265470503d, c: 0.7897925942156216d),
new NpgsqlTypes.NpgsqlLine(a: 0.8035158797448627d, b: 0.7553198195742405d, c: 0.716470831171731d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5649862640852757d, b: 0.39009514657911026d, c: 0.013257121321585297d),
new NpgsqlTypes.NpgsqlLine(a: 0.43698551529647944d, b: 0.8424441288786192d, c: 0.3661071275783042d),
new NpgsqlTypes.NpgsqlLine(a: 0.9356439811638907d, b: 0.01461303268815839d, c: 0.8891859850725653d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7461421472142048d, b: 0.8820167790319976d, c: 0.890425269431659d),
new NpgsqlTypes.NpgsqlLine(a: 0.197443442412084d, b: 0.992249659598611d, c: 0.23536531551693252d),
new NpgsqlTypes.NpgsqlLine(a: 0.6518650305161645d, b: 0.1439112113406582d, c: 0.7163581067198372d),
new NpgsqlTypes.NpgsqlLine(a: 0.24817546758139508d, b: 0.017478232858774145d, c: 0.030472605139372222d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09896988686363761d, b: 0.4063861329564561d, c: 0.9658725235670345d),
new NpgsqlTypes.NpgsqlLine(a: 0.3144331676176183d, b: 0.5668024886448031d, c: 0.35571147258308955d),
new NpgsqlTypes.NpgsqlLine(a: 0.7791602014246642d, b: 0.30578454587084225d, c: 0.9171807639946449d),
new NpgsqlTypes.NpgsqlLine(a: 0.2833249853663612d, b: 0.7549547533613404d, c: 0.5598773066298327d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3144974052058972d, b: 0.14584970883435266d, c: 0.35338782203399677d),
new NpgsqlTypes.NpgsqlLine(a: 0.5008117408676884d, b: 0.6951183147887581d, c: 0.08897166710927829d),
new NpgsqlTypes.NpgsqlLine(a: 0.4339371349534342d, b: 0.715581251337426d, c: 0.1221475466011418d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2988511925674764d, b: 0.25561705193880213d, c: 0.28032848227618024d),
new NpgsqlTypes.NpgsqlLine(a: 0.13161042583285631d, b: 0.23943024969753768d, c: 0.34540605953123005d),
new NpgsqlTypes.NpgsqlLine(a: 0.7228583730583081d, b: 0.3849761785623558d, c: 0.4820747335575437d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6428570897235983d, b: 0.5258745624183064d, c: 0.039777615789098886d),
new NpgsqlTypes.NpgsqlLine(a: 0.4023843402162317d, b: 0.5565443042560793d, c: 0.7690355437653362d),
new NpgsqlTypes.NpgsqlLine(a: 0.305104598231818d, b: 0.5991763488272631d, c: 0.33322060679082344d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4044095837361932d, b: 0.13093385477383424d, c: 0.33751932742145463d),
new NpgsqlTypes.NpgsqlLine(a: 0.2610914813828118d, b: 0.9713177611509749d, c: 0.8214674264591668d),
new NpgsqlTypes.NpgsqlLine(a: 0.348911897184759d, b: 0.643590808825706d, c: 0.657087713363983d),
new NpgsqlTypes.NpgsqlLine(a: 0.07490342054490251d, b: 0.7309484632509625d, c: 0.747659202183291d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6100826750568344d, b: 0.6206317175920397d, c: 0.5889867608247585d),
new NpgsqlTypes.NpgsqlLine(a: 0.27911395582332066d, b: 0.31512061112682177d, c: 0.030970181024543852d),
new NpgsqlTypes.NpgsqlLine(a: 0.6364867622763793d, b: 0.9988518044761872d, c: 0.22915822047220435d),
new NpgsqlTypes.NpgsqlLine(a: 0.32027131527098385d, b: 0.03671994397463174d, c: 0.8289055924894329d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9791903773122469d, b: 0.08472926515247114d, c: 0.6705688443578317d),
new NpgsqlTypes.NpgsqlLine(a: 0.7623979377552574d, b: 0.9294988517663171d, c: 0.5437056455927611d),
new NpgsqlTypes.NpgsqlLine(a: 0.27604111769434436d, b: 0.12422541068254989d, c: 0.14873121740250228d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8397656477811262d, b: 0.9308525238377167d, c: 0.34950215160546316d),
new NpgsqlTypes.NpgsqlLine(a: 0.2635987528798073d, b: 0.4367941736631954d, c: 0.8372577061980068d),
new NpgsqlTypes.NpgsqlLine(a: 0.24695680241538298d, b: 0.5436962269646475d, c: 0.5770219731944022d),
new NpgsqlTypes.NpgsqlLine(a: 0.37241563785311915d, b: 0.7592307315777788d, c: 0.5299506173854375d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7862403349486305d, b: 0.6519448970738518d, c: 0.21388640466228237d),
new NpgsqlTypes.NpgsqlLine(a: 0.9701427142885273d, b: 0.9493547073808039d, c: 0.2284795373263142d),
new NpgsqlTypes.NpgsqlLine(a: 0.6044674516766735d, b: 0.055723309822959144d, c: 0.8317868323443748d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7733496305267913d, b: 0.4367699240139802d, c: 0.294854851332746d),
new NpgsqlTypes.NpgsqlLine(a: 0.02523612339273329d, b: 0.05253776587858883d, c: 0.12218996906958601d),
new NpgsqlTypes.NpgsqlLine(a: 0.4485699479405212d, b: 0.44472698554283596d, c: 0.6317559412626319d),
new NpgsqlTypes.NpgsqlLine(a: 0.8758153153776053d, b: 0.9180005588587202d, c: 0.05053209185260621d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1654294591389871d, b: 0.7667713982902874d, c: 0.7322990384507969d),
new NpgsqlTypes.NpgsqlLine(a: 0.48667150995763186d, b: 0.8003217765608253d, c: 0.8695788307713406d),
new NpgsqlTypes.NpgsqlLine(a: 0.17709286435199156d, b: 0.34666575043743697d, c: 0.938122573841412d),
new NpgsqlTypes.NpgsqlLine(a: 0.6720293655457469d, b: 0.21702314649974763d, c: 0.4981280771523463d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6787705179744081d, b: 0.4397881466521474d, c: 0.6883986856677529d),
new NpgsqlTypes.NpgsqlLine(a: 0.6712558684382633d, b: 0.5808422895163549d, c: 0.6597633814072869d),
new NpgsqlTypes.NpgsqlLine(a: 0.03600231147350963d, b: 0.5505584279051474d, c: 0.5538441833996753d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5416176806572292d, b: 0.994496118772195d, c: 0.08844135902450734d),
new NpgsqlTypes.NpgsqlLine(a: 0.47274887599719007d, b: 0.05167375413826214d, c: 0.347605774536213d),
new NpgsqlTypes.NpgsqlLine(a: 0.46570122654267154d, b: 0.990198475820434d, c: 0.7094492571125748d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7502379515165907d, b: 0.5233837154552374d, c: 0.9270806037908227d),
new NpgsqlTypes.NpgsqlLine(a: 0.6856513465548335d, b: 0.5539299926764047d, c: 0.6552318608788534d),
new NpgsqlTypes.NpgsqlLine(a: 0.3355273783148106d, b: 0.3033218641180181d, c: 0.31475692210303463d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24947768380558688d, b: 0.8500599302690623d, c: 0.4587378302723163d),
new NpgsqlTypes.NpgsqlLine(a: 0.8077545057217052d, b: 0.9880021782445417d, c: 0.3284288457549587d),
new NpgsqlTypes.NpgsqlLine(a: 0.18101189129008488d, b: 0.8272284501173569d, c: 0.3181311657103345d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7625898487747088d, b: 0.7381821477552876d, c: 0.3113459128356887d),
new NpgsqlTypes.NpgsqlLine(a: 0.2695458305008317d, b: 0.7523272065766189d, c: 0.16969068565623913d),
new NpgsqlTypes.NpgsqlLine(a: 0.4602912400880208d, b: 0.670200546252953d, c: 0.011272095710763375d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.42666339144340415d, b: 0.9091902130557928d, c: 0.9753126178306001d),
new NpgsqlTypes.NpgsqlLine(a: 0.7385655131666358d, b: 0.6477670684371357d, c: 0.26375035974986905d),
new NpgsqlTypes.NpgsqlLine(a: 0.29734212189547704d, b: 0.1561299522020374d, c: 0.21747231195464434d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.39073906381769763d, b: 0.6153247283299795d, c: 0.6576503141279192d),
new NpgsqlTypes.NpgsqlLine(a: 0.18489475768436814d, b: 0.7974760848487095d, c: 0.16025142254765024d),
new NpgsqlTypes.NpgsqlLine(a: 0.5947541798048974d, b: 0.909367852168688d, c: 0.2428376895093719d),
new NpgsqlTypes.NpgsqlLine(a: 0.8245427053732761d, b: 0.3074806499720355d, c: 0.15207950138118154d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4860733042239518d, b: 0.7416434386970158d, c: 0.5727620356202734d),
new NpgsqlTypes.NpgsqlLine(a: 0.6789072572505976d, b: 0.8055009029833664d, c: 0.0030547913747995814d),
new NpgsqlTypes.NpgsqlLine(a: 0.0491089524352577d, b: 0.2918191635971935d, c: 0.7204268498655537d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8616363642664943d, b: 0.564787094682358d, c: 0.22931200348851866d),
new NpgsqlTypes.NpgsqlLine(a: 0.8550104732004605d, b: 0.6221362186233604d, c: 0.25142788365842494d),
new NpgsqlTypes.NpgsqlLine(a: 0.6294610012039422d, b: 0.6683515532467882d, c: 0.4151376592342523d),
new NpgsqlTypes.NpgsqlLine(a: 0.8109636025070739d, b: 0.6365775107958013d, c: 0.8598142335079921d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9195508680348227d, b: 0.03119046284455884d, c: 0.7906890163323361d),
new NpgsqlTypes.NpgsqlLine(a: 0.3007364072915303d, b: 0.04500270476711765d, c: 0.09050510515842991d),
new NpgsqlTypes.NpgsqlLine(a: 0.3309785154350803d, b: 0.957618533855341d, c: 0.3245550748567574d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.879102382564159d, b: 0.33973575432706116d, c: 0.1331713732095119d),
new NpgsqlTypes.NpgsqlLine(a: 0.003391080354835263d, b: 0.5298772224415375d, c: 0.965800639615324d),
new NpgsqlTypes.NpgsqlLine(a: 0.7679329644386484d, b: 0.3913351379118535d, c: 0.79270694082927d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2522101889380508d, b: 0.4418262475900596d, c: 0.44553854637958357d),
new NpgsqlTypes.NpgsqlLine(a: 0.533919518933862d, b: 0.812031297798426d, c: 0.464750664577291d),
new NpgsqlTypes.NpgsqlLine(a: 0.3168473678499264d, b: 0.5916575750542049d, c: 0.4148085365800913d),
new NpgsqlTypes.NpgsqlLine(a: 0.9734586274724197d, b: 0.11868944204475607d, c: 0.229715962526724d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.06327424627157763d, b: 0.5760482301089965d, c: 0.6311442820588795d),
new NpgsqlTypes.NpgsqlLine(a: 0.28047732002762316d, b: 0.44774071786186664d, c: 0.7304197375594692d),
new NpgsqlTypes.NpgsqlLine(a: 0.46454483291896387d, b: 0.19772003092717472d, c: 0.23721044401836477d),
new NpgsqlTypes.NpgsqlLine(a: 0.054974582138578976d, b: 0.1404974334474134d, c: 0.7850889280458251d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9447421533670238d, b: 0.5428068756876611d, c: 0.3429675156661869d),
new NpgsqlTypes.NpgsqlLine(a: 0.4988646738437952d, b: 0.4282337827462105d, c: 0.0597634673930415d),
new NpgsqlTypes.NpgsqlLine(a: 0.16476954023753d, b: 0.7772829625343399d, c: 0.6974180286726814d),
new NpgsqlTypes.NpgsqlLine(a: 0.7773917197120002d, b: 0.8260109706205283d, c: 0.30544401796155674d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.713391894086756d, b: 0.8740366303261123d, c: 0.9494193447503283d),
new NpgsqlTypes.NpgsqlLine(a: 0.44080498658082434d, b: 0.06288147917718567d, c: 0.18466887905052787d),
new NpgsqlTypes.NpgsqlLine(a: 0.31517065094627417d, b: 0.08424096293289773d, c: 0.03102935824776487d),
new NpgsqlTypes.NpgsqlLine(a: 0.7019909689265182d, b: 0.8466350303420105d, c: 0.6943546121283016d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7373028515292294d, b: 0.9182299834210578d, c: 0.5398655806190937d),
new NpgsqlTypes.NpgsqlLine(a: 0.3349749818145872d, b: 0.28479955092903875d, c: 0.8477415916249558d),
new NpgsqlTypes.NpgsqlLine(a: 0.9269304469661975d, b: 0.8229651296705394d, c: 0.6505980195939901d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.45597904331376493d, b: 0.2271057975595021d, c: 0.37327088241250905d),
new NpgsqlTypes.NpgsqlLine(a: 0.3847295934825d, b: 0.13800563466527815d, c: 0.5477981916703883d),
new NpgsqlTypes.NpgsqlLine(a: 0.7520709766929757d, b: 0.8980263961538566d, c: 0.44408099439599114d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8115252829093624d, b: 0.14590140004920826d, c: 0.03789994019789d),
new NpgsqlTypes.NpgsqlLine(a: 0.86577075120285d, b: 0.9215486486461724d, c: 0.5517280808863112d),
new NpgsqlTypes.NpgsqlLine(a: 0.8161696284208572d, b: 0.5416932634216142d, c: 0.6135378557033231d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9702601940917315d, b: 0.9522876265915613d, c: 0.08057039136212352d),
new NpgsqlTypes.NpgsqlLine(a: 0.6516838220535394d, b: 0.23077660694411983d, c: 0.8921789074780855d),
new NpgsqlTypes.NpgsqlLine(a: 0.9005124897091177d, b: 0.8647961157425058d, c: 0.023195282974485698d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.46238279809871496d, b: 0.3424128112675796d, c: 0.08124731568682064d),
new NpgsqlTypes.NpgsqlLine(a: 0.3561130553319941d, b: 0.9233039852145579d, c: 0.3988492439671737d),
new NpgsqlTypes.NpgsqlLine(a: 0.3175106173861514d, b: 0.6242697202938706d, c: 0.5615750000164407d),
new NpgsqlTypes.NpgsqlLine(a: 0.04057680316879464d, b: 0.049433676976573415d, c: 0.03541871429899113d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25524909567014986d, b: 0.3999873466304227d, c: 0.505857474957641d),
new NpgsqlTypes.NpgsqlLine(a: 0.9845781365508601d, b: 0.5192380527517994d, c: 0.6397980643107593d),
new NpgsqlTypes.NpgsqlLine(a: 0.7527875055821782d, b: 0.0263521205480578d, c: 0.495573102380782d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0809025649936872d, b: 0.6418735027142708d, c: 0.23717941965841016d),
new NpgsqlTypes.NpgsqlLine(a: 0.4962086005694344d, b: 0.6434501925438505d, c: 0.47625225918497927d),
new NpgsqlTypes.NpgsqlLine(a: 0.6535894950030852d, b: 0.1134012032840298d, c: 0.5583173218287993d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7062541370410741d, b: 0.3624229971749846d, c: 0.7406886864509614d),
new NpgsqlTypes.NpgsqlLine(a: 0.36133798625118196d, b: 0.11196997252317775d, c: 0.2144367310058396d),
new NpgsqlTypes.NpgsqlLine(a: 0.4992865143125891d, b: 0.5264012717653425d, c: 0.34152145599718653d),
new NpgsqlTypes.NpgsqlLine(a: 0.11124055996779436d, b: 0.7253360419310549d, c: 0.8669803949745863d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6874858524266118d, b: 0.0862014063280806d, c: 0.8014484321995194d),
new NpgsqlTypes.NpgsqlLine(a: 0.49638718294304784d, b: 0.3395461777585592d, c: 0.4138137530232475d),
new NpgsqlTypes.NpgsqlLine(a: 0.9304875661546991d, b: 0.030066039978336012d, c: 0.671963585759361d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.940867602689553d, b: 0.04670115422635723d, c: 0.9742359481374228d),
new NpgsqlTypes.NpgsqlLine(a: 0.6488630700159765d, b: 0.5166921147819373d, c: 0.590976521636848d),
new NpgsqlTypes.NpgsqlLine(a: 0.18473175004445785d, b: 0.9021206297782625d, c: 0.34887026291613743d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6032867338567787d, b: 0.6033274850837922d, c: 0.5858724370762184d),
new NpgsqlTypes.NpgsqlLine(a: 0.02986333724428558d, b: 0.2762950138038529d, c: 0.8175894709197227d),
new NpgsqlTypes.NpgsqlLine(a: 0.8780617417979275d, b: 0.5984197642720879d, c: 0.7901973885104252d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.00623217548998467d, b: 0.8602276041098834d, c: 0.3759372243536345d),
new NpgsqlTypes.NpgsqlLine(a: 0.728379832399398d, b: 0.6637801896735074d, c: 0.6101766553208376d),
new NpgsqlTypes.NpgsqlLine(a: 0.21578105061648978d, b: 0.43048450595354415d, c: 0.18647304071649007d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8766823832053343d, b: 0.5817791494832961d, c: 0.22263934451938827d),
new NpgsqlTypes.NpgsqlLine(a: 0.3961385957351071d, b: 0.06907552861785238d, c: 0.5275625054206935d),
new NpgsqlTypes.NpgsqlLine(a: 0.35455917203260956d, b: 0.040879700810148134d, c: 0.027456033312097117d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6623238163732778d, b: 0.534952611018132d, c: 0.9641247798722288d),
new NpgsqlTypes.NpgsqlLine(a: 0.782167154178999d, b: 0.4482901130647938d, c: 0.3250443809707475d),
new NpgsqlTypes.NpgsqlLine(a: 0.5296719695986745d, b: 0.522947342662926d, c: 0.7941788256679404d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2268375223257233d, b: 0.21965310429892515d, c: 0.7335244703784296d),
new NpgsqlTypes.NpgsqlLine(a: 0.5541071937794398d, b: 0.3979149541389062d, c: 0.7042231255531086d),
new NpgsqlTypes.NpgsqlLine(a: 0.8539414323074564d, b: 0.03199837327752564d, c: 0.46917707137236d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.38630996258930894d, b: 0.8026258236834788d, c: 0.18351639237171635d),
new NpgsqlTypes.NpgsqlLine(a: 0.5272843723689596d, b: 0.4440166350407132d, c: 0.17332160139303032d),
new NpgsqlTypes.NpgsqlLine(a: 0.9937308057188906d, b: 0.6582319731065213d, c: 0.526858435269624d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04809749652466666d, b: 0.525667684432469d, c: 0.43623221514319277d),
new NpgsqlTypes.NpgsqlLine(a: 0.4609602328533594d, b: 0.8114068159462108d, c: 0.8494607895731697d),
new NpgsqlTypes.NpgsqlLine(a: 0.8522031190794107d, b: 0.20854517233726455d, c: 0.6963840704735129d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9448130527147188d, b: 0.6001145333045721d, c: 0.697743324934478d),
new NpgsqlTypes.NpgsqlLine(a: 0.1993127348134468d, b: 0.49091258371348034d, c: 0.7820086111001405d),
new NpgsqlTypes.NpgsqlLine(a: 0.6654860270564267d, b: 0.05493110223871389d, c: 0.40400833502576095d),
new NpgsqlTypes.NpgsqlLine(a: 0.6316930950363657d, b: 0.670360688312412d, c: 0.739174344445792d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9759216439714153d, b: 0.3672228486368d, c: 0.4753771378039693d),
new NpgsqlTypes.NpgsqlLine(a: 0.9368560783667759d, b: 0.10403423873742934d, c: 0.519371847986505d),
new NpgsqlTypes.NpgsqlLine(a: 0.8896709479673436d, b: 0.31851923157416895d, c: 0.6260088414588721d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.42575951025951764d, b: 0.9606938962754318d, c: 0.22045210808159355d),
new NpgsqlTypes.NpgsqlLine(a: 0.33902946686245794d, b: 0.8076349498296742d, c: 0.7351349079308614d),
new NpgsqlTypes.NpgsqlLine(a: 0.6901714801951333d, b: 0.4526796319115918d, c: 0.7745585701293766d),
new NpgsqlTypes.NpgsqlLine(a: 0.6243368043879255d, b: 0.45281644321686676d, c: 0.14933949674169678d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8491844580736907d, b: 0.15773400519756564d, c: 0.708899417770524d),
new NpgsqlTypes.NpgsqlLine(a: 0.6508672940613541d, b: 0.1288271390449024d, c: 0.45670134597517675d),
new NpgsqlTypes.NpgsqlLine(a: 0.6929395605546771d, b: 0.7796695875340486d, c: 0.9724128161300574d),
new NpgsqlTypes.NpgsqlLine(a: 0.2972968711028534d, b: 0.2822224585763583d, c: 0.31928631282236086d),
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

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.34609246851187936d, b: 0.39251547551801025d, c: 0.32541761654649637d),
new NpgsqlTypes.NpgsqlLine(a: 0.46765336813743064d, b: 0.5764654867328483d, c: 0.7441488575516071d),
new NpgsqlTypes.NpgsqlLine(a: 0.10428831399683436d, b: 0.29698994425051417d, c: 0.6992844267686388d),
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6871587090124631d, b: 0.047620746155580984d, c: 0.33065840347811537d),
new NpgsqlTypes.NpgsqlLine(a: 0.7211969901831852d, b: 0.3547360158613555d, c: 0.972709095693869d),
new NpgsqlTypes.NpgsqlLine(a: 0.14922846566141412d, b: 0.493370056651957d, c: 0.905906456466475d),
new NpgsqlTypes.NpgsqlLine(a: 0.7978088508917298d, b: 0.1908495283086381d, c: 0.21746717439986052d),
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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5822899220495753d, b: 0.5644281410954355d, c: 0.022370957359178933d),
new NpgsqlTypes.NpgsqlLine(a: 0.15170626802229092d, b: 0.563397059225121d, c: 0.0782048173331178d),
new NpgsqlTypes.NpgsqlLine(a: 0.23401171764707263d, b: 0.40327015353015117d, c: 0.13504609814644486d),
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
new NpgsqlTypes.NpgsqlLine(a: 0.6853614677601814d, b: 0.8908196416107838d, c: 0.8599819918896275d),
new NpgsqlTypes.NpgsqlLine(a: 0.05469363946492567d, b: 0.7172640733055512d, c: 0.5325030300633132d),
new NpgsqlTypes.NpgsqlLine(a: 0.8256858920073677d, b: 0.2002048109308039d, c: 0.6054752339011817d),
new NpgsqlTypes.NpgsqlLine(a: 0.8280635775350932d, b: 0.7657101490588539d, c: 0.16891623526923705d),
}));
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8304188445108406d, b: 0.4594583067037301d, c: 0.9869090560578612d),
new NpgsqlTypes.NpgsqlLine(a: 0.3379747210128896d, b: 0.14302520575885502d, c: 0.8000206188804473d),
new NpgsqlTypes.NpgsqlLine(a: 0.027058565689371816d, b: 0.3489930202226845d, c: 0.6262450835750689d),
new NpgsqlTypes.NpgsqlLine(a: 0.7547556927953766d, b: 0.9083165498677327d, c: 0.5187234841309054d),
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
new NpgsqlTypes.NpgsqlLine(a: 0.4892841183612068d, b: 0.6628023162529851d, c: 0.23775100645940184d),
new NpgsqlTypes.NpgsqlLine(a: 0.16682606002246392d, b: 0.17682439574717734d, c: 0.1739215310500043d),
new NpgsqlTypes.NpgsqlLine(a: 0.41627066665955836d, b: 0.7416508675807767d, c: 0.3709931460184902d),
new NpgsqlTypes.NpgsqlLine(a: 0.028661154443934134d, b: 0.6226255872111796d, c: 0.736573418619408d),
}));
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9803942885281275d, b: 0.2368289416078091d, c: 0.9931753815897602d),
new NpgsqlTypes.NpgsqlLine(a: 0.7403775866829669d, b: 0.7131650196438692d, c: 3.578821540528576E-05d),
new NpgsqlTypes.NpgsqlLine(a: 0.5551941869960522d, b: 0.008679912363629194d, c: 0.8682684375769252d),
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
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
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
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
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
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 128, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 49, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 5, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
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
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
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
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 28, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 67, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[34], false);
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
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 97, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 54, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[34], false);
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
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 87, query1, 50, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
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
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 49, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 49, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[34], false);
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
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[32], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[33], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[29], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[30], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[31], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[32], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[33], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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

        [Test, Order(13)]
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
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI), typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                await ((INpgsqlLineArraylineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                ((INpgsqlLineArraylineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

