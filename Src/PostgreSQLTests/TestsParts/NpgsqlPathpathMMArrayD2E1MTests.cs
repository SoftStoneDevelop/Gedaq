

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
    internal partial interface INpgsqlPathMArraypathMMArrayD2
    {
    }
    
    internal partial class NpgsqlPathMArraypathMMArrayD2 : INpgsqlPathMArraypathMMArrayD2
    {


#region TestData

        private readonly NpgsqlPathpathMMArrayD2E1M[] _testData = new NpgsqlPathpathMMArrayD2E1M[]
        {
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4984137673680141d, y: 0.5431184676768298d), new NpgsqlTypes.NpgsqlPoint(x: 0.1625765099195544d, y: 0.5707422070204251d), new NpgsqlTypes.NpgsqlPoint(x: 0.7406799018069743d, y: 0.11674393826717333d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4049015205187153d, y: 0.561221822924405d), new NpgsqlTypes.NpgsqlPoint(x: 0.04576824650787925d, y: 0.12479472434920946d), new NpgsqlTypes.NpgsqlPoint(x: 0.21550282102306595d, y: 0.36134528940343d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22427190181722456d, y: 0.3150356600095676d), new NpgsqlTypes.NpgsqlPoint(x: 0.3317016470535833d, y: 0.428733816793597d), new NpgsqlTypes.NpgsqlPoint(x: 0.07526838964071347d, y: 0.31542219709349506d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3399310733235327d, y: 0.46733484203671527d), new NpgsqlTypes.NpgsqlPoint(x: 0.49392569949127296d, y: 0.8202726673502374d), new NpgsqlTypes.NpgsqlPoint(x: 0.6310067919708431d, y: 0.004818927944508999d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5777352502470917d, y: 0.036793625674516495d), new NpgsqlTypes.NpgsqlPoint(x: 0.12815987522505135d, y: 0.5045161328878293d), new NpgsqlTypes.NpgsqlPoint(x: 0.03547853890772601d, y: 0.30773838075243976d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.432192689757813d, y: 0.24550427028553357d), new NpgsqlTypes.NpgsqlPoint(x: 0.25751378288320215d, y: 0.1783734895434771d), new NpgsqlTypes.NpgsqlPoint(x: 0.31113985689228707d, y: 0.9408324879575459d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2893778110210661d, y: 0.6848014524741695d), new NpgsqlTypes.NpgsqlPoint(x: 0.2312952343125798d, y: 0.6648357658371218d), new NpgsqlTypes.NpgsqlPoint(x: 0.014203006341375946d, y: 0.23084168713648034d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6135101398259855d, y: 0.8981327218015606d), new NpgsqlTypes.NpgsqlPoint(x: 0.44160756266937795d, y: 0.3917921901985466d), new NpgsqlTypes.NpgsqlPoint(x: 0.9140776784276576d, y: 0.2637915974273223d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.723266675240621d, y: 0.03886308893679469d), new NpgsqlTypes.NpgsqlPoint(x: 0.45864555966425347d, y: 0.42893782276546755d), new NpgsqlTypes.NpgsqlPoint(x: 0.2547662301299546d, y: 0.7136889807214042d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7073714225759158d, y: 0.6406063567002759d), new NpgsqlTypes.NpgsqlPoint(x: 0.8445770748329194d, y: 0.46751533884027296d), new NpgsqlTypes.NpgsqlPoint(x: 0.2795096062237008d, y: 0.7297412958003344d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5214659754221873d, y: 0.06215507140437715d), new NpgsqlTypes.NpgsqlPoint(x: 0.2868357671127665d, y: 0.3767043774572171d), new NpgsqlTypes.NpgsqlPoint(x: 0.38108133859989735d, y: 0.2398461412414764d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9192644740649917d, y: 0.27574781844273044d), new NpgsqlTypes.NpgsqlPoint(x: 0.9082820971222269d, y: 0.16028218927798277d), new NpgsqlTypes.NpgsqlPoint(x: 0.6960669748452367d, y: 0.5100815282677914d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7571673533369575d, y: 0.8669008090139577d), new NpgsqlTypes.NpgsqlPoint(x: 0.8830938127868296d, y: 0.7762407000769949d), new NpgsqlTypes.NpgsqlPoint(x: 0.3213020056504199d, y: 0.5986632013299146d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10120631128204649d, y: 0.7259632109041741d), new NpgsqlTypes.NpgsqlPoint(x: 0.8385624408443061d, y: 0.7538107086855935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9122305834537906d, y: 0.22514068982288493d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1294993657700626d, y: 0.24329237827099104d), new NpgsqlTypes.NpgsqlPoint(x: 0.09722525462150988d, y: 0.40963244427951595d), new NpgsqlTypes.NpgsqlPoint(x: 0.8782309370418506d, y: 0.6784405918866846d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9543052670576516d, y: 0.1774425192831922d), new NpgsqlTypes.NpgsqlPoint(x: 0.13181197721371174d, y: 0.9451620753549768d), new NpgsqlTypes.NpgsqlPoint(x: 0.8423779176751592d, y: 0.11451564050562824d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5224703426649346d, y: 0.21288652942534292d), new NpgsqlTypes.NpgsqlPoint(x: 0.5060392308142907d, y: 0.3664828391085677d), new NpgsqlTypes.NpgsqlPoint(x: 0.15001328052215335d, y: 0.6738425808848966d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.033154782443177044d, y: 0.8365262706647284d), new NpgsqlTypes.NpgsqlPoint(x: 0.3183277438346508d, y: 0.4161208000324942d), new NpgsqlTypes.NpgsqlPoint(x: 0.5529049464641883d, y: 0.5497854136102243d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17304465581936646d, y: 0.20759419857572203d), new NpgsqlTypes.NpgsqlPoint(x: 0.389414296735328d, y: 0.33092397134928575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9945993899178802d, y: 0.493497913146435d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8757652720431442d, y: 0.424885102100627d), new NpgsqlTypes.NpgsqlPoint(x: 0.585763004528847d, y: 0.27804181857803756d), new NpgsqlTypes.NpgsqlPoint(x: 0.835779623927418d, y: 0.2544793282908243d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.253689821539826d, y: 0.39861192174230065d), new NpgsqlTypes.NpgsqlPoint(x: 0.844220555854554d, y: 0.11770724964139112d), new NpgsqlTypes.NpgsqlPoint(x: 0.5162947956447634d, y: 0.0761480529894919d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0358260255916949d, y: 0.678924838633993d), new NpgsqlTypes.NpgsqlPoint(x: 0.7496498774778289d, y: 0.7464121628896446d), new NpgsqlTypes.NpgsqlPoint(x: 0.28204397220379374d, y: 0.6479573953786478d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5271246263174282d, y: 0.4233081849050102d), new NpgsqlTypes.NpgsqlPoint(x: 0.28203052303813503d, y: 0.5619272937256282d), new NpgsqlTypes.NpgsqlPoint(x: 0.0032903819405661894d, y: 0.23850296479526878d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.675525137254819d, y: 0.1259151453507188d), new NpgsqlTypes.NpgsqlPoint(x: 0.20626913837840966d, y: 0.1453233735521008d), new NpgsqlTypes.NpgsqlPoint(x: 0.6023473248985685d, y: 0.3297801477421477d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005755774433229832d, y: 0.18387752545666114d), new NpgsqlTypes.NpgsqlPoint(x: 0.8955630784931632d, y: 0.8349611039878897d), new NpgsqlTypes.NpgsqlPoint(x: 0.6640461508833094d, y: 0.9847574097734684d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9519244694284434d, y: 0.3626444644899032d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752646417478305d, y: 0.06906850315739865d), new NpgsqlTypes.NpgsqlPoint(x: 0.5094228356089092d, y: 0.1376918978553595d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9861609831072452d, y: 0.6148993149207672d), new NpgsqlTypes.NpgsqlPoint(x: 0.19481945435459436d, y: 0.2567039788040878d), new NpgsqlTypes.NpgsqlPoint(x: 0.43817620136329016d, y: 0.29577555203526584d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3821843393894775d, y: 0.2487734704931167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7012760516564992d, y: 0.37950368378491683d), new NpgsqlTypes.NpgsqlPoint(x: 0.7600552474165297d, y: 0.5594244172526712d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.949534791793372d, y: 0.45481205864210505d), new NpgsqlTypes.NpgsqlPoint(x: 0.5694330259761448d, y: 0.2632474077799878d), new NpgsqlTypes.NpgsqlPoint(x: 0.9599244313047763d, y: 0.5974028949844944d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27769348937737093d, y: 0.47876030816642734d), new NpgsqlTypes.NpgsqlPoint(x: 0.21795176443474262d, y: 0.19211702497350636d), new NpgsqlTypes.NpgsqlPoint(x: 0.730732690821686d, y: 0.9802312991693752d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9938235768005345d, y: 0.15044195838996144d), new NpgsqlTypes.NpgsqlPoint(x: 0.02354666274751216d, y: 0.5337812646799985d), new NpgsqlTypes.NpgsqlPoint(x: 0.9640017002093566d, y: 0.6911948976671098d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0935595034242599d, y: 0.4855523378532379d), new NpgsqlTypes.NpgsqlPoint(x: 0.8202985953908988d, y: 0.5782712572071776d), new NpgsqlTypes.NpgsqlPoint(x: 0.06775254153786925d, y: 0.6219129779316265d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3016129821780734d, y: 0.5718521575247538d), new NpgsqlTypes.NpgsqlPoint(x: 0.26823656126922635d, y: 0.02518492307802711d), new NpgsqlTypes.NpgsqlPoint(x: 0.9355481395370898d, y: 0.7678389814113017d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.339168517465559d, y: 0.8088160987536437d), new NpgsqlTypes.NpgsqlPoint(x: 0.7506499523318905d, y: 0.48800841310537d), new NpgsqlTypes.NpgsqlPoint(x: 0.5711278744209183d, y: 0.2649124603935108d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6653737957161798d, y: 0.06265641445896986d), new NpgsqlTypes.NpgsqlPoint(x: 0.7613850185582038d, y: 0.5263225720542363d), new NpgsqlTypes.NpgsqlPoint(x: 0.23545015564572658d, y: 0.5924016672128668d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6451327724546082d, y: 0.10841183130483079d), new NpgsqlTypes.NpgsqlPoint(x: 0.24269314087499838d, y: 0.5776424242438872d), new NpgsqlTypes.NpgsqlPoint(x: 0.46449776984703384d, y: 0.37490914763619065d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3084902027076336d, y: 0.4333269727825053d), new NpgsqlTypes.NpgsqlPoint(x: 0.9315674765742905d, y: 0.40013934289929587d), new NpgsqlTypes.NpgsqlPoint(x: 0.926095506171225d, y: 0.6837845793293408d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40308700179487766d, y: 0.040344073176387996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861156875333488d, y: 0.485575689003078d), new NpgsqlTypes.NpgsqlPoint(x: 0.541956342265183d, y: 0.08490538318390828d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09419131984102813d, y: 0.8325902581154264d), new NpgsqlTypes.NpgsqlPoint(x: 0.8082593312245824d, y: 0.20083013742212763d), new NpgsqlTypes.NpgsqlPoint(x: 0.9289547357812631d, y: 0.2818530890628185d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34575289639766693d, y: 0.10856834120147796d), new NpgsqlTypes.NpgsqlPoint(x: 0.6425999461793861d, y: 0.09674190568062613d), new NpgsqlTypes.NpgsqlPoint(x: 0.792957286961153d, y: 0.43020272660045134d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11101463179236726d, y: 0.7661040486844657d), new NpgsqlTypes.NpgsqlPoint(x: 0.4924959373376594d, y: 0.827161100478228d), new NpgsqlTypes.NpgsqlPoint(x: 0.5455227268930872d, y: 0.8552731770037215d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05076188829518302d, y: 0.3385291142685133d), new NpgsqlTypes.NpgsqlPoint(x: 0.9086208889668043d, y: 0.5504757305111961d), new NpgsqlTypes.NpgsqlPoint(x: 0.7279920882471043d, y: 0.90442476581645d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.539342276500853d, y: 0.13748265565778928d), new NpgsqlTypes.NpgsqlPoint(x: 0.4709538925407871d, y: 0.9260039054900975d), new NpgsqlTypes.NpgsqlPoint(x: 0.4666937244883499d, y: 0.3573924026235753d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6541798298535726d, y: 0.9886907646104806d), new NpgsqlTypes.NpgsqlPoint(x: 0.053397892963814475d, y: 0.5914491695029628d), new NpgsqlTypes.NpgsqlPoint(x: 0.11526118379185324d, y: 0.8298141244348736d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6485815195424723d, y: 0.8553368883585248d), new NpgsqlTypes.NpgsqlPoint(x: 0.27447851602774254d, y: 0.9519356744659787d), new NpgsqlTypes.NpgsqlPoint(x: 0.12843846293560945d, y: 0.3347161247489332d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1794719380375921d, y: 0.6657329452435371d), new NpgsqlTypes.NpgsqlPoint(x: 0.10105340958194975d, y: 0.15903774030828322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971446468157276d, y: 0.40628721830677816d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.521564915797511d, y: 0.5570974740180044d), new NpgsqlTypes.NpgsqlPoint(x: 0.15898927194632384d, y: 0.7452727451883566d), new NpgsqlTypes.NpgsqlPoint(x: 0.1570040737113788d, y: 0.9009446240972832d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13547305820132483d, y: 0.19710239170122523d), new NpgsqlTypes.NpgsqlPoint(x: 0.1615706528441394d, y: 0.36519273794207896d), new NpgsqlTypes.NpgsqlPoint(x: 0.1968629993851716d, y: 0.6063884715144408d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14524275661681318d, y: 0.03072748562957217d), new NpgsqlTypes.NpgsqlPoint(x: 0.4952800431186437d, y: 0.09560064567814708d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728131384653277d, y: 0.3667712409220014d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17720519414427283d, y: 0.7143134813564781d), new NpgsqlTypes.NpgsqlPoint(x: 0.45032017691653914d, y: 0.09791586540071884d), new NpgsqlTypes.NpgsqlPoint(x: 0.5622570909876808d, y: 0.495058294543011d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22587822635395505d, y: 0.9558336036322689d), new NpgsqlTypes.NpgsqlPoint(x: 0.9544904165178296d, y: 0.9839572346702865d), new NpgsqlTypes.NpgsqlPoint(x: 0.4783865801127267d, y: 0.45240471078759303d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9416931911909948d, y: 0.9636570435844605d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016712180197442d, y: 0.5315260063661048d), new NpgsqlTypes.NpgsqlPoint(x: 0.207000729447692d, y: 0.8639124819144666d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1823153718268441d, y: 0.1561879588395193d), new NpgsqlTypes.NpgsqlPoint(x: 0.7334765318272547d, y: 0.7705375078362862d), new NpgsqlTypes.NpgsqlPoint(x: 0.3907360614837918d, y: 0.8156221952134061d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35593964813635415d, y: 0.4865931838063223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5712613466557686d, y: 0.8479986268284818d), new NpgsqlTypes.NpgsqlPoint(x: 0.6037150575611444d, y: 0.7954438922791491d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8938898670816593d, y: 0.7018891085062423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5079071909140063d, y: 0.006079916166921717d), new NpgsqlTypes.NpgsqlPoint(x: 0.3870330602091948d, y: 0.6295262527188225d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4196776279029917d, y: 0.4978856826865494d), new NpgsqlTypes.NpgsqlPoint(x: 0.6275946594642811d, y: 0.01458171558910748d), new NpgsqlTypes.NpgsqlPoint(x: 0.4171628160486567d, y: 0.9880927206762853d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02175190962255913d, y: 0.8792279176982748d), new NpgsqlTypes.NpgsqlPoint(x: 0.6915947606420372d, y: 0.07696593069460589d), new NpgsqlTypes.NpgsqlPoint(x: 0.4126992565931029d, y: 0.693161837367362d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5687480979785206d, y: 0.5887941723353466d), new NpgsqlTypes.NpgsqlPoint(x: 0.4563038960832685d, y: 0.6450017331979935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9631829552890778d, y: 0.9931956855975159d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3983963726464621d, y: 0.7464605333166051d), new NpgsqlTypes.NpgsqlPoint(x: 0.025662434950252777d, y: 0.39584289868523737d), new NpgsqlTypes.NpgsqlPoint(x: 0.02548435258308801d, y: 0.6037661577921792d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4856485264362189d, y: 0.8983878677107666d), new NpgsqlTypes.NpgsqlPoint(x: 0.7543908167431306d, y: 0.4936082722817636d), new NpgsqlTypes.NpgsqlPoint(x: 0.635780711211796d, y: 0.5744890692109368d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8290778274503524d, y: 0.6690930320162202d), new NpgsqlTypes.NpgsqlPoint(x: 0.3339231032485771d, y: 0.8452667631346164d), new NpgsqlTypes.NpgsqlPoint(x: 0.4536074162273651d, y: 0.25003328562457394d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5191939472426109d, y: 0.03663076046262492d), new NpgsqlTypes.NpgsqlPoint(x: 0.35023003909328965d, y: 0.017683417991837036d), new NpgsqlTypes.NpgsqlPoint(x: 0.2741762985523134d, y: 0.05641480931067622d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5427969428623205d, y: 0.765089647134735d), new NpgsqlTypes.NpgsqlPoint(x: 0.43922776256506946d, y: 0.571601818787861d), new NpgsqlTypes.NpgsqlPoint(x: 0.9515976892315999d, y: 0.6041170968560337d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6055918013681795d, y: 0.8762104459086335d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005241384666920812d, y: 0.8579102290927673d), new NpgsqlTypes.NpgsqlPoint(x: 0.44063857975439846d, y: 0.5555330703366044d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6543386198475749d, y: 0.47546864276195544d), new NpgsqlTypes.NpgsqlPoint(x: 0.6008464533873071d, y: 0.9872429218724478d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560641997320834d, y: 0.05399264029663842d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4829105260125952d, y: 0.3347630779507007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9590312067335923d, y: 0.5881050836720535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7488986123963125d, y: 0.3428883019448554d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7109806967501358d, y: 0.13073126283956205d), new NpgsqlTypes.NpgsqlPoint(x: 0.06415937453011122d, y: 0.37640891664434706d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331974072041345d, y: 0.7502872682658365d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22490090552161313d, y: 0.6673884554323669d), new NpgsqlTypes.NpgsqlPoint(x: 0.9074842225527643d, y: 0.27558143621605824d), new NpgsqlTypes.NpgsqlPoint(x: 0.9469201874429581d, y: 0.26161681210930554d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35101249527753187d, y: 0.24398686512311374d), new NpgsqlTypes.NpgsqlPoint(x: 0.7584625818202786d, y: 0.2669606046538142d), new NpgsqlTypes.NpgsqlPoint(x: 0.9477494887474877d, y: 0.37525974912348414d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2707365148973132d, y: 0.29717506331417864d), new NpgsqlTypes.NpgsqlPoint(x: 0.11211684411194545d, y: 0.12079675858510763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5999858557147758d, y: 0.11001868627512235d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32300173295897894d, y: 0.30384082189368766d), new NpgsqlTypes.NpgsqlPoint(x: 0.7105692313456229d, y: 0.9383518330312431d), new NpgsqlTypes.NpgsqlPoint(x: 0.8760997997353229d, y: 0.18891680584731163d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5367971750409123d, y: 0.6188545123987179d), new NpgsqlTypes.NpgsqlPoint(x: 0.31967280487422245d, y: 0.9748402335196162d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961174550129838d, y: 0.4028307218458491d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34455061773794515d, y: 0.9871523884730634d), new NpgsqlTypes.NpgsqlPoint(x: 0.6955430626441351d, y: 0.3916090441555288d), new NpgsqlTypes.NpgsqlPoint(x: 0.162859202495503d, y: 0.7078516898723479d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7243124469880057d, y: 0.8928108282393415d), new NpgsqlTypes.NpgsqlPoint(x: 0.6602824478420362d, y: 0.3294039855171935d), new NpgsqlTypes.NpgsqlPoint(x: 0.262422183558811d, y: 0.48255188753774314d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.669299059533657d, y: 0.34440947205284134d), new NpgsqlTypes.NpgsqlPoint(x: 0.08556635985402705d, y: 0.758406135235702d), new NpgsqlTypes.NpgsqlPoint(x: 0.12860724391617684d, y: 0.03907169522519138d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8247532047454449d, y: 0.7378059797197746d), new NpgsqlTypes.NpgsqlPoint(x: 0.8354532226981136d, y: 0.7454935726258033d), new NpgsqlTypes.NpgsqlPoint(x: 0.34294343879132483d, y: 0.6684508948361378d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7158504586552874d, y: 0.11300118624732136d), new NpgsqlTypes.NpgsqlPoint(x: 0.9438427126569191d, y: 0.8924735223763408d), new NpgsqlTypes.NpgsqlPoint(x: 0.8779135635763692d, y: 0.4532948266814911d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15638915302903744d, y: 0.32684659726808785d), new NpgsqlTypes.NpgsqlPoint(x: 0.18191342429856472d, y: 0.49821996522229606d), new NpgsqlTypes.NpgsqlPoint(x: 0.19372866186788085d, y: 0.33873771563596d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24806711823354355d, y: 0.023474627123385883d), new NpgsqlTypes.NpgsqlPoint(x: 0.543587788347339d, y: 0.8193620567789655d), new NpgsqlTypes.NpgsqlPoint(x: 0.10181139898639313d, y: 0.8441798071007118d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8135030047199338d, y: 0.20592497271287702d), new NpgsqlTypes.NpgsqlPoint(x: 0.912505735115537d, y: 0.04042412667724682d), new NpgsqlTypes.NpgsqlPoint(x: 0.8429860417187388d, y: 0.6217896496225078d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47188726456735786d, y: 0.9976212355249929d), new NpgsqlTypes.NpgsqlPoint(x: 0.6707190444379738d, y: 0.3627922428920608d), new NpgsqlTypes.NpgsqlPoint(x: 0.5103940423047612d, y: 0.2095840066618213d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35765446725717465d, y: 0.18776935424940966d), new NpgsqlTypes.NpgsqlPoint(x: 0.07171396528706209d, y: 0.2900862370221948d), new NpgsqlTypes.NpgsqlPoint(x: 0.7758401230836399d, y: 0.07554247290680227d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7214933323341175d, y: 0.7302380677247915d), new NpgsqlTypes.NpgsqlPoint(x: 0.6862666864732059d, y: 0.5582332510132072d), new NpgsqlTypes.NpgsqlPoint(x: 0.4290868157023263d, y: 0.4956013996241918d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.319490461050838d, y: 0.16101657400563607d), new NpgsqlTypes.NpgsqlPoint(x: 0.06438119453117674d, y: 0.1934901839185016d), new NpgsqlTypes.NpgsqlPoint(x: 0.90418604673293d, y: 0.3148695038110598d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08416422941485657d, y: 0.18539249742399666d), new NpgsqlTypes.NpgsqlPoint(x: 0.9801988131491999d, y: 0.7512786408397232d), new NpgsqlTypes.NpgsqlPoint(x: 0.9769984265693116d, y: 0.3651928187169463d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.017324407960570443d, y: 0.12967369523550343d), new NpgsqlTypes.NpgsqlPoint(x: 0.6788513021298479d, y: 0.6719074512548591d), new NpgsqlTypes.NpgsqlPoint(x: 0.6607654243970267d, y: 0.3934845525390346d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9086846482343292d, y: 0.35611769792035775d), new NpgsqlTypes.NpgsqlPoint(x: 0.5299582735421926d, y: 0.9050298325080733d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334606054779536d, y: 0.8614129962319351d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9014466637648807d, y: 0.7950635117948909d), new NpgsqlTypes.NpgsqlPoint(x: 0.2444005649834321d, y: 0.599535923761446d), new NpgsqlTypes.NpgsqlPoint(x: 0.379767431900099d, y: 0.2881566480080854d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7980507903519356d, y: 0.6560001768101652d), new NpgsqlTypes.NpgsqlPoint(x: 0.016757173332880293d, y: 0.6989471906668467d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280808048228063d, y: 0.12115726545343264d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2784419114340754d, y: 0.5544022990890982d), new NpgsqlTypes.NpgsqlPoint(x: 0.45420408360500963d, y: 0.22579331027627325d), new NpgsqlTypes.NpgsqlPoint(x: 0.09655279717783394d, y: 0.6825924605596317d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11842650645154673d, y: 0.1826517045435868d), new NpgsqlTypes.NpgsqlPoint(x: 0.5841220199455215d, y: 0.9325005831896924d), new NpgsqlTypes.NpgsqlPoint(x: 0.08734330884384478d, y: 0.8993624843874528d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43374020523831347d, y: 0.1600202408863971d), new NpgsqlTypes.NpgsqlPoint(x: 0.4158702143911155d, y: 0.48585571703818164d), new NpgsqlTypes.NpgsqlPoint(x: 0.37639262579776245d, y: 0.5819560503161854d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028384304353398893d, y: 0.09411094578028556d), new NpgsqlTypes.NpgsqlPoint(x: 0.6888400017654996d, y: 0.07107825015173341d), new NpgsqlTypes.NpgsqlPoint(x: 0.44919167827365813d, y: 0.6160435867301652d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8161885344958543d, y: 0.4811268983265946d), new NpgsqlTypes.NpgsqlPoint(x: 0.09832824959304842d, y: 0.7553252753159507d), new NpgsqlTypes.NpgsqlPoint(x: 0.13747427825594016d, y: 0.5617417298272244d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49043984255953255d, y: 0.49610147937776305d), new NpgsqlTypes.NpgsqlPoint(x: 0.6451403328849542d, y: 0.618691071846106d), new NpgsqlTypes.NpgsqlPoint(x: 0.1345703421004969d, y: 0.8361910337760593d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14176475103031527d, y: 0.3593008513484053d), new NpgsqlTypes.NpgsqlPoint(x: 0.49265578006453437d, y: 0.011566307700047962d), new NpgsqlTypes.NpgsqlPoint(x: 0.724299796075211d, y: 0.06349393641499645d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44549995966100076d, y: 0.5653381957944839d), new NpgsqlTypes.NpgsqlPoint(x: 0.771156359133397d, y: 0.07789494907172678d), new NpgsqlTypes.NpgsqlPoint(x: 0.49020440204851723d, y: 0.957458028723481d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15511139094739546d, y: 0.9037089172019324d), new NpgsqlTypes.NpgsqlPoint(x: 0.3386407921327601d, y: 0.6915117611150498d), new NpgsqlTypes.NpgsqlPoint(x: 0.2114422722293272d, y: 0.9177867921331547d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3472190914791259d, y: 0.005153937764216798d), new NpgsqlTypes.NpgsqlPoint(x: 0.37228338867074007d, y: 0.43451711495920664d), new NpgsqlTypes.NpgsqlPoint(x: 0.18003706030416822d, y: 0.1910695219025751d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.907862812810879d, y: 0.2814060507443997d), new NpgsqlTypes.NpgsqlPoint(x: 0.33458897398003107d, y: 0.8847064742875105d), new NpgsqlTypes.NpgsqlPoint(x: 0.4941561389306325d, y: 0.3549629824224355d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6367076096286363d, y: 0.48569595084070805d), new NpgsqlTypes.NpgsqlPoint(x: 0.9812803797113504d, y: 0.26187074370137564d), new NpgsqlTypes.NpgsqlPoint(x: 0.4086261203590481d, y: 0.3979086364356529d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11698896859551111d, y: 0.03959888120452637d), new NpgsqlTypes.NpgsqlPoint(x: 0.4209047009551403d, y: 0.49385851267494185d), new NpgsqlTypes.NpgsqlPoint(x: 0.6813623705530991d, y: 0.23163489943284155d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4471301575756651d, y: 0.6940041007610164d), new NpgsqlTypes.NpgsqlPoint(x: 0.9702833067489932d, y: 0.35946301208222575d), new NpgsqlTypes.NpgsqlPoint(x: 0.6643356473369587d, y: 0.862876781806452d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.632131854015007d, y: 0.30686884912405443d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292240003182661d, y: 0.9245203234493967d), new NpgsqlTypes.NpgsqlPoint(x: 0.36565777233985397d, y: 0.5979757837327518d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027552006600231937d, y: 0.03889356923855691d), new NpgsqlTypes.NpgsqlPoint(x: 0.1696747952503006d, y: 0.6229428913679327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8875703477438275d, y: 0.5525582481314893d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41977208604166605d, y: 0.9640876439422467d), new NpgsqlTypes.NpgsqlPoint(x: 0.030994997601946905d, y: 0.503118069012781d), new NpgsqlTypes.NpgsqlPoint(x: 0.9280541000704016d, y: 0.744684708567914d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.886063921271358d, y: 0.28232142404555005d), new NpgsqlTypes.NpgsqlPoint(x: 0.37475974691059866d, y: 0.9024329548997494d), new NpgsqlTypes.NpgsqlPoint(x: 0.4577458483963721d, y: 0.3435264003655225d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5690235379514564d, y: 0.10105881397990013d), new NpgsqlTypes.NpgsqlPoint(x: 0.354162235498668d, y: 0.899905784766657d), new NpgsqlTypes.NpgsqlPoint(x: 0.993755945391606d, y: 0.84441659706457d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.903826641296254d, y: 0.09538768408352194d), new NpgsqlTypes.NpgsqlPoint(x: 0.9758761028094491d, y: 0.15084475899793293d), new NpgsqlTypes.NpgsqlPoint(x: 0.554970482912936d, y: 0.6708880290429604d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04930352193310927d, y: 0.17005744373693243d), new NpgsqlTypes.NpgsqlPoint(x: 0.705051226157239d, y: 0.04304978503003731d), new NpgsqlTypes.NpgsqlPoint(x: 0.36067547413637824d, y: 0.8414628295115922d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14078819841037638d, y: 0.7828524238177831d), new NpgsqlTypes.NpgsqlPoint(x: 0.33406412837888855d, y: 0.9045527223004188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9771063439938122d, y: 0.7477987647408693d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43153843540789905d, y: 0.2600191590403851d), new NpgsqlTypes.NpgsqlPoint(x: 0.8019148826966405d, y: 0.8968104439870805d), new NpgsqlTypes.NpgsqlPoint(x: 0.6685028176211989d, y: 0.8600029100891405d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6145662808612196d, y: 0.05557536392750406d), new NpgsqlTypes.NpgsqlPoint(x: 0.3346666553456976d, y: 0.6699315068931927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5710537270343046d, y: 0.230461042611259d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2654467011642534d, y: 0.501451845491932d), new NpgsqlTypes.NpgsqlPoint(x: 0.265976857126082d, y: 0.8439509859370328d), new NpgsqlTypes.NpgsqlPoint(x: 0.3992714778826224d, y: 0.2064718596377919d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6679544072495933d, y: 0.49169431643534256d), new NpgsqlTypes.NpgsqlPoint(x: 0.46447079643983036d, y: 0.5380040735051025d), new NpgsqlTypes.NpgsqlPoint(x: 0.07451682158627693d, y: 0.8688887752558523d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9247865579051511d, y: 0.00585998813019839d), new NpgsqlTypes.NpgsqlPoint(x: 0.001460323796586227d, y: 0.5287604928173428d), new NpgsqlTypes.NpgsqlPoint(x: 0.5554991414564925d, y: 0.1744790780198815d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18011494437456388d, y: 0.1817146501827115d), new NpgsqlTypes.NpgsqlPoint(x: 0.25265672749551027d, y: 0.07168237273734335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6404259576188334d, y: 0.16055508561693466d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7600995961302454d, y: 0.8260162691761439d), new NpgsqlTypes.NpgsqlPoint(x: 0.9758767453313935d, y: 0.6785829403530683d), new NpgsqlTypes.NpgsqlPoint(x: 0.11601955183176849d, y: 0.791299168839991d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6184916985368419d, y: 0.7062288911318885d), new NpgsqlTypes.NpgsqlPoint(x: 0.47031595521770353d, y: 0.17072589832953466d), new NpgsqlTypes.NpgsqlPoint(x: 0.3540861143920605d, y: 0.008477397147358623d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6410759783808084d, y: 0.09672897455826268d), new NpgsqlTypes.NpgsqlPoint(x: 0.4973973865917133d, y: 0.5812328563253308d), new NpgsqlTypes.NpgsqlPoint(x: 0.3600728052280179d, y: 0.17093956076753625d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3559509724003166d, y: 0.10065471000963833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8563743525798007d, y: 0.5558082330516664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9746397418492548d, y: 0.9473616742435769d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7438676365248159d, y: 0.37195036485899413d), new NpgsqlTypes.NpgsqlPoint(x: 0.4244287769668583d, y: 0.986813489464395d), new NpgsqlTypes.NpgsqlPoint(x: 0.11552600207203667d, y: 0.5037882334096461d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16258846697210527d, y: 0.2317492647594146d), new NpgsqlTypes.NpgsqlPoint(x: 0.666517343967718d, y: 0.6222158001135683d), new NpgsqlTypes.NpgsqlPoint(x: 0.42919672171052603d, y: 0.08174571442316836d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7521671143103915d, y: 0.76453217959003d), new NpgsqlTypes.NpgsqlPoint(x: 0.06333445963862772d, y: 0.7120908669922235d), new NpgsqlTypes.NpgsqlPoint(x: 0.5048119096793331d, y: 0.4968106243519774d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7147369190358347d, y: 0.14022276168677728d), new NpgsqlTypes.NpgsqlPoint(x: 0.168254308648785d, y: 0.8285882415265393d), new NpgsqlTypes.NpgsqlPoint(x: 0.9575835745423332d, y: 0.02605052106227035d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16789139144016652d, y: 0.5737355800355944d), new NpgsqlTypes.NpgsqlPoint(x: 0.8140852482452171d, y: 0.3978159633451791d), new NpgsqlTypes.NpgsqlPoint(x: 0.8220334519725824d, y: 0.10252894440599825d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7526332672975679d, y: 0.7854297989440416d), new NpgsqlTypes.NpgsqlPoint(x: 0.03496914411062402d, y: 0.4691890894988786d), new NpgsqlTypes.NpgsqlPoint(x: 0.020195658343476364d, y: 0.04280088954611638d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9974590517947983d, y: 0.8934723685796974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7642089772827305d, y: 0.12453368456908653d), new NpgsqlTypes.NpgsqlPoint(x: 0.14461503376497087d, y: 0.21425014999985736d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11780308330787836d, y: 0.013077499416314087d), new NpgsqlTypes.NpgsqlPoint(x: 0.4579353412695071d, y: 0.6601915006878711d), new NpgsqlTypes.NpgsqlPoint(x: 0.07675339031835549d, y: 0.049173149034012376d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9300769892216546d, y: 0.04962655994569054d), new NpgsqlTypes.NpgsqlPoint(x: 0.42588885014359334d, y: 0.74989491557139d), new NpgsqlTypes.NpgsqlPoint(x: 0.2792541021605286d, y: 0.617246327716926d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6578236514772479d, y: 0.9200086832295963d), new NpgsqlTypes.NpgsqlPoint(x: 0.022082857663504707d, y: 0.2228405245714089d), new NpgsqlTypes.NpgsqlPoint(x: 0.5052307678118544d, y: 0.2940063343587631d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7157580153288794d, y: 0.8654068516330231d), new NpgsqlTypes.NpgsqlPoint(x: 0.06391426544718426d, y: 0.693410077010699d), new NpgsqlTypes.NpgsqlPoint(x: 0.24241594079285556d, y: 0.7826826964449964d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17049251080429373d, y: 0.6904140050503718d), new NpgsqlTypes.NpgsqlPoint(x: 0.47447593490321427d, y: 0.4868913507158964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4020163663856582d, y: 0.04107497444206021d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43463166006844367d, y: 0.09513476678938759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7795094197922019d, y: 0.22528768070595606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5628702638520431d, y: 0.23442118382194488d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21756506505733797d, y: 0.4959461588049735d), new NpgsqlTypes.NpgsqlPoint(x: 0.2892238711246924d, y: 0.3453926752658506d), new NpgsqlTypes.NpgsqlPoint(x: 0.260739673411603d, y: 0.47783444976091916d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19561895558404285d, y: 0.201496041189272d), new NpgsqlTypes.NpgsqlPoint(x: 0.43850520266520787d, y: 0.34263940978011964d), new NpgsqlTypes.NpgsqlPoint(x: 0.1354845949549749d, y: 0.6687906945901327d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9446459713417724d, y: 0.26434192134662104d), new NpgsqlTypes.NpgsqlPoint(x: 0.40034483325329306d, y: 0.4095930751224883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7828260977836887d, y: 0.21639449274026912d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9082108887058846d, y: 0.5275683586589374d), new NpgsqlTypes.NpgsqlPoint(x: 0.27876534003857334d, y: 0.851234784904241d), new NpgsqlTypes.NpgsqlPoint(x: 0.2745229797655758d, y: 0.0692136321435437d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5873862007648804d, y: 0.1980072017416321d), new NpgsqlTypes.NpgsqlPoint(x: 0.31376644110718255d, y: 0.06247778744837196d), new NpgsqlTypes.NpgsqlPoint(x: 0.32059663828561635d, y: 0.6575917396203239d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5220755844570405d, y: 0.021297351966919842d), new NpgsqlTypes.NpgsqlPoint(x: 0.33892525296797804d, y: 0.4586157357315346d), new NpgsqlTypes.NpgsqlPoint(x: 0.724977981738922d, y: 0.6011337245643249d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5650915393796663d, y: 0.19420468865725826d), new NpgsqlTypes.NpgsqlPoint(x: 0.8219810631695113d, y: 0.9998600778388043d), new NpgsqlTypes.NpgsqlPoint(x: 0.2947298457052595d, y: 0.13864958650378656d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17295257983397128d, y: 0.0832949749719869d), new NpgsqlTypes.NpgsqlPoint(x: 0.530482247146664d, y: 0.9744971238736017d), new NpgsqlTypes.NpgsqlPoint(x: 0.5118336790877881d, y: 0.7336218998246843d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7658211732742505d, y: 0.9011381746819112d), new NpgsqlTypes.NpgsqlPoint(x: 0.012939246363720014d, y: 0.6192040401544621d), new NpgsqlTypes.NpgsqlPoint(x: 0.3625993675991994d, y: 0.18043647548139974d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7021791284032827d, y: 0.3818451411356266d), new NpgsqlTypes.NpgsqlPoint(x: 0.6613556626101951d, y: 0.937674848690868d), new NpgsqlTypes.NpgsqlPoint(x: 0.20220440280491625d, y: 0.9960301872828533d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7376846758492729d, y: 0.3292354408841305d), new NpgsqlTypes.NpgsqlPoint(x: 0.2464737902035109d, y: 0.2236836451973595d), new NpgsqlTypes.NpgsqlPoint(x: 0.5991185799630571d, y: 0.4627672990156513d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13914183632070787d, y: 0.7524753268996772d), new NpgsqlTypes.NpgsqlPoint(x: 0.03859185428944145d, y: 0.3125299840264021d), new NpgsqlTypes.NpgsqlPoint(x: 0.02548849027909561d, y: 0.1756111430926265d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8995148037347961d, y: 0.44659037418732883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7879156873961299d, y: 0.3066966143584402d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495705827457553d, y: 0.4023359317098769d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7562275428963942d, y: 0.9854989575348888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9545845118108409d, y: 0.3162054581996244d), new NpgsqlTypes.NpgsqlPoint(x: 0.8886548222288401d, y: 0.28067022292648547d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18255156820651097d, y: 0.2544259492998002d), new NpgsqlTypes.NpgsqlPoint(x: 0.6230922092435838d, y: 0.9284447252894538d), new NpgsqlTypes.NpgsqlPoint(x: 0.6847048000816077d, y: 0.9216974917895872d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14938096461366013d, y: 0.2901365070468336d), new NpgsqlTypes.NpgsqlPoint(x: 0.26841046194898266d, y: 0.5240325887247348d), new NpgsqlTypes.NpgsqlPoint(x: 0.8981928425692804d, y: 0.4232989883423818d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6734893603897553d, y: 0.41510773118084654d), new NpgsqlTypes.NpgsqlPoint(x: 0.884286178197302d, y: 0.8276189864588448d), new NpgsqlTypes.NpgsqlPoint(x: 0.578583531714785d, y: 0.9646717607090658d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8336437657617825d, y: 0.05394341017696247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8138494116111408d, y: 0.7231363671873221d), new NpgsqlTypes.NpgsqlPoint(x: 0.21526986979611396d, y: 0.9966121492075773d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9902502535169867d, y: 0.010218189380246212d), new NpgsqlTypes.NpgsqlPoint(x: 0.7534197056285321d, y: 0.14773550022108928d), new NpgsqlTypes.NpgsqlPoint(x: 0.7791649319824058d, y: 0.8104067261385229d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2976138076417042d, y: 0.9200919740043059d), new NpgsqlTypes.NpgsqlPoint(x: 0.6413457452052939d, y: 0.4933198833709427d), new NpgsqlTypes.NpgsqlPoint(x: 0.492487456220449d, y: 0.16860669986082077d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7450610203535816d, y: 0.5648688938877737d), new NpgsqlTypes.NpgsqlPoint(x: 0.22647046568474982d, y: 0.7720701649742147d), new NpgsqlTypes.NpgsqlPoint(x: 0.17819973861841454d, y: 0.5681601820466424d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0987669486054027d, y: 0.12921192970346496d), new NpgsqlTypes.NpgsqlPoint(x: 0.3079650218751847d, y: 0.4919257942654697d), new NpgsqlTypes.NpgsqlPoint(x: 0.8431448437102752d, y: 0.1521446268053942d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9068258916903897d, y: 0.41864343339389676d), new NpgsqlTypes.NpgsqlPoint(x: 0.17859093375462898d, y: 0.7046160702450133d), new NpgsqlTypes.NpgsqlPoint(x: 0.7541170224173124d, y: 0.29221405786668087d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5706949383159803d, y: 0.8992805989952011d), new NpgsqlTypes.NpgsqlPoint(x: 0.5681920551376145d, y: 0.11253271086056738d), new NpgsqlTypes.NpgsqlPoint(x: 0.5182461256932717d, y: 0.4753693556531736d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4164689355470911d, y: 0.6794010554629099d), new NpgsqlTypes.NpgsqlPoint(x: 0.11937026285205032d, y: 0.8375183276893745d), new NpgsqlTypes.NpgsqlPoint(x: 0.921391750452506d, y: 0.16648948899527427d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1645518538643771d, y: 0.5837649104633638d), new NpgsqlTypes.NpgsqlPoint(x: 0.494720167694204d, y: 0.9053423788068106d), new NpgsqlTypes.NpgsqlPoint(x: 0.30381706321128654d, y: 0.8712695227175208d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1286540439680245d, y: 0.172228007811709d), new NpgsqlTypes.NpgsqlPoint(x: 0.2794962053817581d, y: 0.4097347974306321d), new NpgsqlTypes.NpgsqlPoint(x: 0.9082828941468389d, y: 0.188551300088736d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43150644128603144d, y: 0.51803170068576d), new NpgsqlTypes.NpgsqlPoint(x: 0.37163990461268925d, y: 0.4915454145228221d), new NpgsqlTypes.NpgsqlPoint(x: 0.24881140565500215d, y: 0.17179426979513301d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8278838334108946d, y: 0.6031550495475911d), new NpgsqlTypes.NpgsqlPoint(x: 0.7979589192687369d, y: 0.5173326425550702d), new NpgsqlTypes.NpgsqlPoint(x: 0.2969909488787099d, y: 0.8911622803098771d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5680131489319075d, y: 0.5571848713158156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8016311785174187d, y: 0.21901498136412578d), new NpgsqlTypes.NpgsqlPoint(x: 0.8091918391845413d, y: 0.4506316011753899d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7380427289970163d, y: 0.48701720549689653d), new NpgsqlTypes.NpgsqlPoint(x: 0.24705532127938246d, y: 0.9609950725972285d), new NpgsqlTypes.NpgsqlPoint(x: 0.011285770798808548d, y: 0.7034008211741322d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8877640418205199d, y: 0.3230740304187486d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567647145445643d, y: 0.8805622529795042d), new NpgsqlTypes.NpgsqlPoint(x: 0.49374864842009514d, y: 0.4236892860730691d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9249322969141747d, y: 0.3413407265712499d), new NpgsqlTypes.NpgsqlPoint(x: 0.5500454415455884d, y: 0.21247379426342583d), new NpgsqlTypes.NpgsqlPoint(x: 0.2551282617510302d, y: 0.32760572056848614d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8412990074969607d, y: 0.6586269831164342d), new NpgsqlTypes.NpgsqlPoint(x: 0.2641613759206367d, y: 0.12492893740940603d), new NpgsqlTypes.NpgsqlPoint(x: 0.12837256069532954d, y: 0.08313865078983862d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11254110032439357d, y: 0.44009574022782527d), new NpgsqlTypes.NpgsqlPoint(x: 0.7418923802952395d, y: 0.46811414462375334d), new NpgsqlTypes.NpgsqlPoint(x: 0.418471798051794d, y: 0.5749709838856675d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6099094178392349d, y: 0.40049872960279d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859923836735687d, y: 0.9763559627728521d), new NpgsqlTypes.NpgsqlPoint(x: 0.6565257710000033d, y: 0.10254596135637883d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.501771084877014d, y: 0.1072623466468553d), new NpgsqlTypes.NpgsqlPoint(x: 0.8649726173962976d, y: 0.7476965583349426d), new NpgsqlTypes.NpgsqlPoint(x: 0.014955774617757212d, y: 0.5755213411190636d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26791723719709004d, y: 0.8456540129332436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5468560907943902d, y: 0.24015498297221693d), new NpgsqlTypes.NpgsqlPoint(x: 0.5979375491936652d, y: 0.5426288383143167d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8584823305640272d, y: 0.8879540915891515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5466491501057861d, y: 0.7971704359414183d), new NpgsqlTypes.NpgsqlPoint(x: 0.20647614880863974d, y: 0.34627744304950014d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7035834510033754d, y: 0.619779784722904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8207947120719793d, y: 0.2939438661507773d), new NpgsqlTypes.NpgsqlPoint(x: 0.9467207436590441d, y: 0.15557172402584107d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2823296556479815d, y: 0.9378861395035198d), new NpgsqlTypes.NpgsqlPoint(x: 0.4448180525233594d, y: 0.93021990528763d), new NpgsqlTypes.NpgsqlPoint(x: 0.4417524438151881d, y: 0.5676937432527099d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2712734609177647d, y: 0.326604102183085d), new NpgsqlTypes.NpgsqlPoint(x: 0.04035743142116499d, y: 0.24857045354165141d), new NpgsqlTypes.NpgsqlPoint(x: 0.5660414446395325d, y: 0.9636016213564504d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8469307356006058d, y: 0.18262199706906268d), new NpgsqlTypes.NpgsqlPoint(x: 0.6039202644808539d, y: 0.8169596030754773d), new NpgsqlTypes.NpgsqlPoint(x: 0.3833713280545975d, y: 0.948951637909555d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16336474163628467d, y: 0.0802532857734568d), new NpgsqlTypes.NpgsqlPoint(x: 0.48635425727016823d, y: 0.4467448468429499d), new NpgsqlTypes.NpgsqlPoint(x: 0.5065497649022797d, y: 0.08490154102043623d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20463240804052607d, y: 0.2157239559654528d), new NpgsqlTypes.NpgsqlPoint(x: 0.7677765876839522d, y: 0.8120752892455347d), new NpgsqlTypes.NpgsqlPoint(x: 0.07372536658361695d, y: 0.7937145904855013d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24619472185636437d, y: 0.7002614851458191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7313676868881178d, y: 0.6466363417959123d), new NpgsqlTypes.NpgsqlPoint(x: 0.5027868575575398d, y: 0.746599665113068d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07335030656546404d, y: 0.7150966419236134d), new NpgsqlTypes.NpgsqlPoint(x: 0.2187494030785493d, y: 0.13404140712411472d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515441476961537d, y: 0.6453363284070951d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3925184281463595d, y: 0.7259994542042773d), new NpgsqlTypes.NpgsqlPoint(x: 0.6158025579073506d, y: 0.9484812390666953d), new NpgsqlTypes.NpgsqlPoint(x: 0.8722728606712862d, y: 0.36510750638132927d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9714411142551787d, y: 0.9626940197466194d), new NpgsqlTypes.NpgsqlPoint(x: 0.0840914085331873d, y: 0.7249600213602456d), new NpgsqlTypes.NpgsqlPoint(x: 0.3790148971684937d, y: 0.21793488720843635d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9612381216901927d, y: 0.7584234866587728d), new NpgsqlTypes.NpgsqlPoint(x: 0.8977158361940228d, y: 0.5063571919783632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7447004136882097d, y: 0.267036398957354d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12475281214092893d, y: 0.9925266888243547d), new NpgsqlTypes.NpgsqlPoint(x: 0.8570574049900087d, y: 0.16018955627454612d), new NpgsqlTypes.NpgsqlPoint(x: 0.48145288423439103d, y: 0.6488596825503311d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9176132767314671d, y: 0.588753281580675d), new NpgsqlTypes.NpgsqlPoint(x: 0.5880117234863342d, y: 0.4924828228006074d), new NpgsqlTypes.NpgsqlPoint(x: 0.45436166067282746d, y: 0.07379856766702042d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4610121203480876d, y: 0.7352161011489354d), new NpgsqlTypes.NpgsqlPoint(x: 0.2538471231800792d, y: 0.4310513237503574d), new NpgsqlTypes.NpgsqlPoint(x: 0.48897954426848167d, y: 0.8138146801675533d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27555692200011894d, y: 0.9580501107948517d), new NpgsqlTypes.NpgsqlPoint(x: 0.30329300650397917d, y: 0.10308101969756134d), new NpgsqlTypes.NpgsqlPoint(x: 0.3074326966084884d, y: 0.47652411787416915d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6078792621997947d, y: 0.5025991880132271d), new NpgsqlTypes.NpgsqlPoint(x: 0.5935351758062111d, y: 0.32930049708155174d), new NpgsqlTypes.NpgsqlPoint(x: 0.6744697417457137d, y: 0.6239014981472585d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9038878548235606d, y: 0.7598870469024184d), new NpgsqlTypes.NpgsqlPoint(x: 0.20984577715546449d, y: 0.02459638233909689d), new NpgsqlTypes.NpgsqlPoint(x: 0.44456846110726744d, y: 0.5925115275661137d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4620368913158116d, y: 0.1543486224681503d), new NpgsqlTypes.NpgsqlPoint(x: 0.25857864571831257d, y: 0.42966357087316787d), new NpgsqlTypes.NpgsqlPoint(x: 0.66599660281557d, y: 0.5253107687627768d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31968877642990867d, y: 0.6213773770890324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7617154928120271d, y: 0.005599270232501952d), new NpgsqlTypes.NpgsqlPoint(x: 0.8478478655257118d, y: 0.3963706411064155d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2080776701944529d, y: 0.046529377229901026d), new NpgsqlTypes.NpgsqlPoint(x: 0.3437329772001614d, y: 0.32023798114287483d), new NpgsqlTypes.NpgsqlPoint(x: 0.7458725824568649d, y: 0.8125965353827589d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44027210877121936d, y: 0.29504414482606656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6936497536946059d, y: 0.6018959461163154d), new NpgsqlTypes.NpgsqlPoint(x: 0.8147472408675868d, y: 0.697145384994774d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2733586430163961d, y: 0.551604549110533d), new NpgsqlTypes.NpgsqlPoint(x: 0.5363086181234287d, y: 0.8338225483308311d), new NpgsqlTypes.NpgsqlPoint(x: 0.7563137793981818d, y: 0.4700021976679374d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8435420743249907d, y: 0.32630132960432556d), new NpgsqlTypes.NpgsqlPoint(x: 0.6218305844823572d, y: 0.4641543393529003d), new NpgsqlTypes.NpgsqlPoint(x: 0.7281269691403148d, y: 0.6748093375674253d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5676898419823049d, y: 0.07163633683583914d), new NpgsqlTypes.NpgsqlPoint(x: 0.02563779036735092d, y: 0.6689128368280595d), new NpgsqlTypes.NpgsqlPoint(x: 0.4305243047734487d, y: 0.42974393760946616d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35218822666588834d, y: 0.17127118355220317d), new NpgsqlTypes.NpgsqlPoint(x: 0.22991226578865054d, y: 0.9865325924176419d), new NpgsqlTypes.NpgsqlPoint(x: 0.7389144128599796d, y: 0.4922330456453974d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7453553443672734d, y: 0.6047224727768601d), new NpgsqlTypes.NpgsqlPoint(x: 0.3255489836358124d, y: 0.45408657138790876d), new NpgsqlTypes.NpgsqlPoint(x: 0.6137217686699382d, y: 0.03307398368117509d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.666207617292892d, y: 0.5787345585248124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8674237554914461d, y: 0.46803318401452987d), new NpgsqlTypes.NpgsqlPoint(x: 0.22334259158885028d, y: 0.8883647720840018d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2579646248841908d, y: 0.8439454765904166d), new NpgsqlTypes.NpgsqlPoint(x: 0.23110512312990206d, y: 0.7306176253205966d), new NpgsqlTypes.NpgsqlPoint(x: 0.4707444393506356d, y: 0.6686763470646938d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.592346660738749d, y: 0.8085816452792624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5813481455536685d, y: 0.8326559538834971d), new NpgsqlTypes.NpgsqlPoint(x: 0.9247558146342305d, y: 0.6819446815367922d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5185301589990035d, y: 0.9395104485346325d), new NpgsqlTypes.NpgsqlPoint(x: 0.39527678862453675d, y: 0.831741659382947d), new NpgsqlTypes.NpgsqlPoint(x: 0.5845703973514887d, y: 0.36246740075627526d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.040127471187810015d, y: 0.1866288259727148d), new NpgsqlTypes.NpgsqlPoint(x: 0.204170527662364d, y: 0.8531256228882531d), new NpgsqlTypes.NpgsqlPoint(x: 0.09963265531440024d, y: 0.23117758373278974d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09275777021205045d, y: 0.5154657617166137d), new NpgsqlTypes.NpgsqlPoint(x: 0.37145897850740617d, y: 0.2877462383376429d), new NpgsqlTypes.NpgsqlPoint(x: 0.23314727219732634d, y: 0.6938567196731825d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17842476065675483d, y: 0.14660917435897014d), new NpgsqlTypes.NpgsqlPoint(x: 0.07583292399802266d, y: 0.10984958348047547d), new NpgsqlTypes.NpgsqlPoint(x: 0.22322523847498643d, y: 0.9713801649585172d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.568310237517728d, y: 0.8226854658640924d), new NpgsqlTypes.NpgsqlPoint(x: 0.1837910971359087d, y: 0.4058543772689307d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445459425659551d, y: 0.7052205896906981d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8980325062651627d, y: 0.20131122783833955d), new NpgsqlTypes.NpgsqlPoint(x: 0.07196454850478928d, y: 0.5637289099100473d), new NpgsqlTypes.NpgsqlPoint(x: 0.7311301389373668d, y: 0.3657436745655278d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.916287508161913d, y: 0.6052329955112852d), new NpgsqlTypes.NpgsqlPoint(x: 0.9921742768618474d, y: 0.9693021277543118d), new NpgsqlTypes.NpgsqlPoint(x: 0.6988565828848209d, y: 0.8802048641082612d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34965991176854117d, y: 0.973199986462693d), new NpgsqlTypes.NpgsqlPoint(x: 0.8188307639201157d, y: 0.19556332716643976d), new NpgsqlTypes.NpgsqlPoint(x: 0.40892665244048976d, y: 0.9414587274189786d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7493500707763108d, y: 0.016981447298341834d), new NpgsqlTypes.NpgsqlPoint(x: 0.5196080067891847d, y: 0.05549319368107042d), new NpgsqlTypes.NpgsqlPoint(x: 0.730071345539689d, y: 0.1129131613569807d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2673934886648375d, y: 0.6730752392064681d), new NpgsqlTypes.NpgsqlPoint(x: 0.3556467404584709d, y: 0.9185746927443904d), new NpgsqlTypes.NpgsqlPoint(x: 0.05145632969023972d, y: 0.8104022644457216d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3571619774430167d, y: 0.6489286742982666d), new NpgsqlTypes.NpgsqlPoint(x: 0.8021154943005863d, y: 0.14431170630498913d), new NpgsqlTypes.NpgsqlPoint(x: 0.36489716238755876d, y: 0.17903018801051562d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07410122658392782d, y: 0.1633043868795987d), new NpgsqlTypes.NpgsqlPoint(x: 0.9565612417920657d, y: 0.3403439422277802d), new NpgsqlTypes.NpgsqlPoint(x: 0.23126997580615216d, y: 0.9869913564462942d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7519269140993856d, y: 0.477030447148429d), new NpgsqlTypes.NpgsqlPoint(x: 0.09241279966516591d, y: 0.6291831022071956d), new NpgsqlTypes.NpgsqlPoint(x: 0.2689541665102926d, y: 0.7715315348798152d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31960680016369813d, y: 0.643678353274965d), new NpgsqlTypes.NpgsqlPoint(x: 0.18584432069976586d, y: 0.03391205110366069d), new NpgsqlTypes.NpgsqlPoint(x: 0.3671791627050609d, y: 0.27243530587427467d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04313462701288606d, y: 0.8893779894955252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6613052933799148d, y: 0.9332532630584759d), new NpgsqlTypes.NpgsqlPoint(x: 0.8870291417262821d, y: 0.6515148927307696d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7816925396999973d, y: 0.5869946972125949d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836494340019106d, y: 0.253756925469772d), new NpgsqlTypes.NpgsqlPoint(x: 0.2610830988571081d, y: 0.6586518499842581d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06591472555799704d, y: 0.016188010659629826d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769854986039314d, y: 0.11598229038810826d), new NpgsqlTypes.NpgsqlPoint(x: 0.1646909175846698d, y: 0.8454140846897231d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16350168098870366d, y: 0.8411321043946788d), new NpgsqlTypes.NpgsqlPoint(x: 0.22642165719375273d, y: 0.9845408998681896d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158538483554859d, y: 0.5787699408877136d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8816302866477627d, y: 0.5421400249446768d), new NpgsqlTypes.NpgsqlPoint(x: 0.10232210123043706d, y: 0.11180651211553716d), new NpgsqlTypes.NpgsqlPoint(x: 0.09834346342981015d, y: 0.30788014661767427d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06646543058528054d, y: 0.2586642425707598d), new NpgsqlTypes.NpgsqlPoint(x: 0.45639582235862997d, y: 0.5895926002703628d), new NpgsqlTypes.NpgsqlPoint(x: 0.4125878779527721d, y: 0.26032334476955954d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5696979582979883d, y: 0.3522409419974931d), new NpgsqlTypes.NpgsqlPoint(x: 0.6388352329666723d, y: 0.9700116917864924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7415532694060606d, y: 0.5150570457511656d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3320774277413807d, y: 0.14341416127486017d), new NpgsqlTypes.NpgsqlPoint(x: 0.8892136946616247d, y: 0.010098074696363257d), new NpgsqlTypes.NpgsqlPoint(x: 0.6430347225563062d, y: 0.3912086927832483d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2536135436833251d, y: 0.8146345418566616d), new NpgsqlTypes.NpgsqlPoint(x: 0.8682029306886314d, y: 0.7581725549536444d), new NpgsqlTypes.NpgsqlPoint(x: 0.7469672716714769d, y: 0.9320344218073002d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8508347226007771d, y: 0.6378896705665348d), new NpgsqlTypes.NpgsqlPoint(x: 0.9925618280038819d, y: 0.1858092775936967d), new NpgsqlTypes.NpgsqlPoint(x: 0.15541510302190387d, y: 0.18495655338608719d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36113714631902705d, y: 0.666808493653649d), new NpgsqlTypes.NpgsqlPoint(x: 0.3292584369689636d, y: 0.7366232258736405d), new NpgsqlTypes.NpgsqlPoint(x: 0.6177853426439074d, y: 0.5825648522454779d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.026117783348069024d, y: 0.1881593345750019d), new NpgsqlTypes.NpgsqlPoint(x: 0.8232910193823584d, y: 0.9477958070473242d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903245759857511d, y: 0.627940963998178d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8687659812013728d, y: 0.844654182579344d), new NpgsqlTypes.NpgsqlPoint(x: 0.28135177372535525d, y: 0.017248798372599516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8561748113005303d, y: 0.4153651853818453d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0729129473217619d, y: 0.17637006089629836d), new NpgsqlTypes.NpgsqlPoint(x: 0.027039500217543866d, y: 0.14075757023276736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5722935541777396d, y: 0.5837500358548932d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.682010923827304d, y: 0.6490701409164271d), new NpgsqlTypes.NpgsqlPoint(x: 0.21431935881399444d, y: 0.28296277432406225d), new NpgsqlTypes.NpgsqlPoint(x: 0.3657152580449009d, y: 0.45994654767888554d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16434851842127463d, y: 0.7931922344664354d), new NpgsqlTypes.NpgsqlPoint(x: 0.24284201326320132d, y: 0.3280023704798294d), new NpgsqlTypes.NpgsqlPoint(x: 0.14263168571018492d, y: 0.5322397969856144d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2921224440578065d, y: 0.21683363883002116d), new NpgsqlTypes.NpgsqlPoint(x: 0.23494309509487354d, y: 0.9081868788595227d), new NpgsqlTypes.NpgsqlPoint(x: 0.45936477893695926d, y: 0.8176885199075998d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2635160447644692d, y: 0.3469374345109236d), new NpgsqlTypes.NpgsqlPoint(x: 0.2682058129094598d, y: 0.46387302825876997d), new NpgsqlTypes.NpgsqlPoint(x: 0.06524584179152382d, y: 0.4088484154928673d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7974557345822292d, y: 0.3090702649725714d), new NpgsqlTypes.NpgsqlPoint(x: 0.5710667398001057d, y: 0.9213041710990723d), new NpgsqlTypes.NpgsqlPoint(x: 0.3296161431681218d, y: 0.9753717948094424d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5461379455208123d, y: 0.236770252361457d), new NpgsqlTypes.NpgsqlPoint(x: 0.06902559912495243d, y: 0.1157335547523961d), new NpgsqlTypes.NpgsqlPoint(x: 0.043472461128153395d, y: 0.6478176071068491d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05948935032021874d, y: 0.7274846171128191d), new NpgsqlTypes.NpgsqlPoint(x: 0.00651180264792095d, y: 0.6537037674995521d), new NpgsqlTypes.NpgsqlPoint(x: 0.11698169895627919d, y: 0.2984822747765782d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7637018261418516d, y: 0.2099330114764858d), new NpgsqlTypes.NpgsqlPoint(x: 0.4354286473023784d, y: 0.8263460784075974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7567675364958357d, y: 0.8185369171423076d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4505968951920639d, y: 0.3736528986191898d), new NpgsqlTypes.NpgsqlPoint(x: 0.4823182559854412d, y: 0.3590352436727231d), new NpgsqlTypes.NpgsqlPoint(x: 0.24971316593245718d, y: 0.43884246242438585d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5947519615625282d, y: 0.1607642248851322d), new NpgsqlTypes.NpgsqlPoint(x: 0.6518807551143446d, y: 0.16018113058734618d), new NpgsqlTypes.NpgsqlPoint(x: 0.3254200815489823d, y: 0.3813568837970176d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3694952453630356d, y: 0.7929126175100669d), new NpgsqlTypes.NpgsqlPoint(x: 0.06259022359459221d, y: 0.9968100100306285d), new NpgsqlTypes.NpgsqlPoint(x: 0.3203932704383292d, y: 0.21066713233936152d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3022297548675462d, y: 0.43769144019567063d), new NpgsqlTypes.NpgsqlPoint(x: 0.9731183747994707d, y: 0.8531972940422355d), new NpgsqlTypes.NpgsqlPoint(x: 0.30299977694251146d, y: 0.802295574504527d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.993694647811149d, y: 0.9180217853446169d), new NpgsqlTypes.NpgsqlPoint(x: 0.01173061147321064d, y: 0.7759744398448812d), new NpgsqlTypes.NpgsqlPoint(x: 0.2078164103343949d, y: 0.3195065368844331d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.190706300520195d, y: 0.31438655850005115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8813626351471366d, y: 0.41695156471884154d), new NpgsqlTypes.NpgsqlPoint(x: 0.5023482469318412d, y: 0.09458383661443015d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.354416034754347d, y: 0.07434697471417917d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474049827970227d, y: 0.6323739088056807d), new NpgsqlTypes.NpgsqlPoint(x: 0.9426653117520961d, y: 0.06316795853695656d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.920393178596569d, y: 0.6254486674171553d), new NpgsqlTypes.NpgsqlPoint(x: 0.021372925623543093d, y: 0.6578132591729131d), new NpgsqlTypes.NpgsqlPoint(x: 0.7152234128531768d, y: 0.8977080275101079d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7204349483689414d, y: 0.3697181246783102d), new NpgsqlTypes.NpgsqlPoint(x: 0.5854414302398584d, y: 0.721177534282933d), new NpgsqlTypes.NpgsqlPoint(x: 0.2524358956204804d, y: 0.501067276009915d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42434218417806d, y: 0.25590301816466443d), new NpgsqlTypes.NpgsqlPoint(x: 0.007828264646809968d, y: 0.8907110110370738d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471926022089358d, y: 0.3543078327288145d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7042444079734459d, y: 0.12219336594322283d), new NpgsqlTypes.NpgsqlPoint(x: 0.4417286852765465d, y: 0.9931675542233488d), new NpgsqlTypes.NpgsqlPoint(x: 0.39393028229943516d, y: 0.698695968324706d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7029631112163572d, y: 0.6788041860016819d), new NpgsqlTypes.NpgsqlPoint(x: 0.8507447056361989d, y: 0.4060659000122737d), new NpgsqlTypes.NpgsqlPoint(x: 0.602081013746337d, y: 0.2176561870749637d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9566558670528759d, y: 0.6150547292098477d), new NpgsqlTypes.NpgsqlPoint(x: 0.1275792898246696d, y: 0.41132535601598197d), new NpgsqlTypes.NpgsqlPoint(x: 0.2862807212657493d, y: 0.8124700713605905d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.918368377280109d, y: 0.10233629585910509d), new NpgsqlTypes.NpgsqlPoint(x: 0.2513768484808684d, y: 0.45557216752362806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5734448468688902d, y: 0.5675600398005937d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8733107795293332d, y: 0.5379583828428939d), new NpgsqlTypes.NpgsqlPoint(x: 0.008234781695709792d, y: 0.29963978601568686d), new NpgsqlTypes.NpgsqlPoint(x: 0.35778336779957964d, y: 0.2826537357190285d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9973638407572919d, y: 0.007932231327107742d), new NpgsqlTypes.NpgsqlPoint(x: 0.40759832426280673d, y: 0.7103220474759924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861380400263118d, y: 0.35675819885226145d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34527120140091505d, y: 0.14781452783341686d), new NpgsqlTypes.NpgsqlPoint(x: 0.4188723318513471d, y: 0.015797630019668163d), new NpgsqlTypes.NpgsqlPoint(x: 0.6702070830952823d, y: 0.13622601845520177d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8334358921863033d, y: 0.4059784600204047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5152370359368154d, y: 0.8013475414627236d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371125609399984d, y: 0.3075835163032403d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9331075429261143d, y: 0.3623047381045511d), new NpgsqlTypes.NpgsqlPoint(x: 0.43799893939171264d, y: 0.561380362881601d), new NpgsqlTypes.NpgsqlPoint(x: 0.7325908152463535d, y: 0.7996790504254676d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4401231180383117d, y: 0.5908376663383302d), new NpgsqlTypes.NpgsqlPoint(x: 0.8450506067589966d, y: 0.7772415405224804d), new NpgsqlTypes.NpgsqlPoint(x: 0.23814106224820397d, y: 0.023225290761801687d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8036691016757802d, y: 0.24017159934243937d), new NpgsqlTypes.NpgsqlPoint(x: 0.6716726312569259d, y: 0.7487774334356901d), new NpgsqlTypes.NpgsqlPoint(x: 0.6908857209453959d, y: 0.1843135683149988d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6154175008532705d, y: 0.3968940459435989d), new NpgsqlTypes.NpgsqlPoint(x: 0.020536343578631766d, y: 0.4055051241658265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5118708568612235d, y: 0.7192174048710789d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7265960681017849d, y: 0.6998730446016095d), new NpgsqlTypes.NpgsqlPoint(x: 0.8433383794548072d, y: 0.15415864923516542d), new NpgsqlTypes.NpgsqlPoint(x: 0.01937122296783722d, y: 0.3043362359826587d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3903683408058999d, y: 0.9390993079625543d), new NpgsqlTypes.NpgsqlPoint(x: 0.08455963237576936d, y: 0.1995881818972728d), new NpgsqlTypes.NpgsqlPoint(x: 0.39478132256542386d, y: 0.16256680558152659d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0940172058868799d, y: 0.844703028325158d), new NpgsqlTypes.NpgsqlPoint(x: 0.31156406026485195d, y: 0.6747850197942264d), new NpgsqlTypes.NpgsqlPoint(x: 0.8198625451058915d, y: 0.10414768402729035d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006487636975021083d, y: 0.4516846191262629d), new NpgsqlTypes.NpgsqlPoint(x: 0.9964762426015842d, y: 0.011947198699016615d), new NpgsqlTypes.NpgsqlPoint(x: 0.049276876405380476d, y: 0.4059885481979678d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39918848373770643d, y: 0.21424062984338d), new NpgsqlTypes.NpgsqlPoint(x: 0.31414171022689363d, y: 0.9587847190242366d), new NpgsqlTypes.NpgsqlPoint(x: 0.34067545620456574d, y: 0.8856594210707169d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3249411890729357d, y: 0.2666365898277946d), new NpgsqlTypes.NpgsqlPoint(x: 0.36180960500626613d, y: 0.42677283228047524d), new NpgsqlTypes.NpgsqlPoint(x: 0.012275748094656036d, y: 0.9956414437536495d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9012548704165085d, y: 0.6784421081335484d), new NpgsqlTypes.NpgsqlPoint(x: 0.8214779016848843d, y: 0.7714325281594822d), new NpgsqlTypes.NpgsqlPoint(x: 0.3669920270150968d, y: 0.6523519001166246d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7957597296845631d, y: 0.5747262688906879d), new NpgsqlTypes.NpgsqlPoint(x: 0.37577460915089955d, y: 0.7416146782465268d), new NpgsqlTypes.NpgsqlPoint(x: 0.006008899459603256d, y: 0.8124363670616707d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9582140782683236d, y: 0.6519304391553429d), new NpgsqlTypes.NpgsqlPoint(x: 0.6374674534363057d, y: 0.4491936918464857d), new NpgsqlTypes.NpgsqlPoint(x: 0.8639211621278015d, y: 0.030698909457669732d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003563836666925835d, y: 0.7924077908577158d), new NpgsqlTypes.NpgsqlPoint(x: 0.4790900056185331d, y: 0.13742942147439963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088459742539289d, y: 0.11955979498301628d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12919749628503474d, y: 0.8929112145970663d), new NpgsqlTypes.NpgsqlPoint(x: 0.7769958566637012d, y: 0.3630409433699937d), new NpgsqlTypes.NpgsqlPoint(x: 0.33706918047172807d, y: 0.11852221899129056d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4232326308359333d, y: 0.16615061594941438d), new NpgsqlTypes.NpgsqlPoint(x: 0.53747506107763d, y: 0.7240754099860679d), new NpgsqlTypes.NpgsqlPoint(x: 0.09174509683863652d, y: 0.8558921143412725d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7525098577881061d, y: 0.29390863083562924d), new NpgsqlTypes.NpgsqlPoint(x: 0.49778145094237636d, y: 0.06612414137258327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914011610125488d, y: 0.10422027820538793d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6577078372610757d, y: 0.5122412903041951d), new NpgsqlTypes.NpgsqlPoint(x: 0.9849229991568583d, y: 0.9227611238236353d), new NpgsqlTypes.NpgsqlPoint(x: 0.10176907243685396d, y: 0.7199846459395984d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4630092325429783d, y: 0.16490751941292425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9144894555592669d, y: 0.3299663545742545d), new NpgsqlTypes.NpgsqlPoint(x: 0.3306609066622195d, y: 0.9000675391685677d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9352158870599402d, y: 0.009782731793369082d), new NpgsqlTypes.NpgsqlPoint(x: 0.3324037276916113d, y: 0.4561242191339776d), new NpgsqlTypes.NpgsqlPoint(x: 0.02535507495293765d, y: 0.09797630581597994d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0638108780094343d, y: 0.9533326228722429d), new NpgsqlTypes.NpgsqlPoint(x: 0.16630082992038298d, y: 0.42399109469854657d), new NpgsqlTypes.NpgsqlPoint(x: 0.8133503518825606d, y: 0.7785398456220312d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5859457961968335d, y: 0.8740964581223978d), new NpgsqlTypes.NpgsqlPoint(x: 0.28768596208438646d, y: 0.4274530241778228d), new NpgsqlTypes.NpgsqlPoint(x: 0.17316932760672554d, y: 0.8601682526623482d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7485094160352904d, y: 0.3570360046712753d), new NpgsqlTypes.NpgsqlPoint(x: 0.4682409501569734d, y: 0.9089677272361524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9220481824930828d, y: 0.9134457122758625d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6734007113491872d, y: 0.906799175549959d), new NpgsqlTypes.NpgsqlPoint(x: 0.9945938246159879d, y: 0.23020620532454739d), new NpgsqlTypes.NpgsqlPoint(x: 0.573657902526113d, y: 0.3603364107782687d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8422149367571312d, y: 0.5560588792814333d), new NpgsqlTypes.NpgsqlPoint(x: 0.12104100695321063d, y: 0.2649419177931841d), new NpgsqlTypes.NpgsqlPoint(x: 0.32061240664949897d, y: 0.7183248185677539d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28689319070774655d, y: 0.8759113332424062d), new NpgsqlTypes.NpgsqlPoint(x: 0.6929406189303084d, y: 0.44408453313728435d), new NpgsqlTypes.NpgsqlPoint(x: 0.3725305126210491d, y: 0.3866522141719113d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7096392145503693d, y: 0.06861846779368086d), new NpgsqlTypes.NpgsqlPoint(x: 0.842443162663974d, y: 0.05205354937881668d), new NpgsqlTypes.NpgsqlPoint(x: 0.7143747964481338d, y: 0.5908907218974486d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7676991745508712d, y: 0.5642041299096815d), new NpgsqlTypes.NpgsqlPoint(x: 0.992836262557326d, y: 0.7708434989887851d), new NpgsqlTypes.NpgsqlPoint(x: 0.8540597828530365d, y: 0.5687889672207461d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9454589184473523d, y: 0.7818083550256335d), new NpgsqlTypes.NpgsqlPoint(x: 0.9324321953981876d, y: 0.4698631676301198d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522468551580616d, y: 0.05411269690424292d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20188335852562067d, y: 0.6708129906962874d), new NpgsqlTypes.NpgsqlPoint(x: 0.733879003061079d, y: 0.4901582370593338d), new NpgsqlTypes.NpgsqlPoint(x: 0.010656517581299041d, y: 0.6428776112853171d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10584340049753904d, y: 0.0930994526578196d), new NpgsqlTypes.NpgsqlPoint(x: 0.2456938334211859d, y: 0.9945475410372898d), new NpgsqlTypes.NpgsqlPoint(x: 0.4172563058758679d, y: 0.07150650045408735d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42359131905783154d, y: 0.051937311700285926d), new NpgsqlTypes.NpgsqlPoint(x: 0.029685614351477763d, y: 0.9335111959912867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7051805556305232d, y: 0.5215998024068079d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014383366970453837d, y: 0.5011198296256644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7183679719105213d, y: 0.7566361445589979d), new NpgsqlTypes.NpgsqlPoint(x: 0.6990387000370538d, y: 0.32417530538033734d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31805669677395554d, y: 0.09463314523527144d), new NpgsqlTypes.NpgsqlPoint(x: 0.8964286857438053d, y: 0.3127641511572695d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846134723327937d, y: 0.231157152280702d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14084909885315522d, y: 0.3873748388267221d), new NpgsqlTypes.NpgsqlPoint(x: 0.058165540646783254d, y: 0.8116027603342408d), new NpgsqlTypes.NpgsqlPoint(x: 0.7353376378044575d, y: 0.9220045612794489d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7308963776255859d, y: 0.4673370608633366d), new NpgsqlTypes.NpgsqlPoint(x: 0.17959710714081167d, y: 0.8779285488812959d), new NpgsqlTypes.NpgsqlPoint(x: 0.3641783655618429d, y: 0.6457093369283167d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2927944030659321d, y: 0.2653275641369741d), new NpgsqlTypes.NpgsqlPoint(x: 0.6268058976440083d, y: 0.1416690721188527d), new NpgsqlTypes.NpgsqlPoint(x: 0.1811650218093298d, y: 0.7987620707360474d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5097051300438858d, y: 0.5373725187830899d), new NpgsqlTypes.NpgsqlPoint(x: 0.12888225256247043d, y: 0.7325614615797506d), new NpgsqlTypes.NpgsqlPoint(x: 0.9205337487687837d, y: 0.20058268193659712d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3546300248368882d, y: 0.8461524156377864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183108080975543d, y: 0.1918957201985736d), new NpgsqlTypes.NpgsqlPoint(x: 0.8207101351389368d, y: 0.13751222101328608d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9554033034387508d, y: 0.18863799693034566d), new NpgsqlTypes.NpgsqlPoint(x: 0.6357350074263449d, y: 0.5201440339527885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9721501393645802d, y: 0.023161448241591276d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8516801185873438d, y: 0.0036104925178112035d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155375406628465d, y: 0.9688357708549622d), new NpgsqlTypes.NpgsqlPoint(x: 0.7278513623279163d, y: 0.8927774327897292d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8554062239293062d, y: 0.04261625557519533d), new NpgsqlTypes.NpgsqlPoint(x: 0.7808070291631337d, y: 0.5093144829369978d), new NpgsqlTypes.NpgsqlPoint(x: 0.15585813850082453d, y: 0.8511242980513076d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33985880714101324d, y: 0.434383923322331d), new NpgsqlTypes.NpgsqlPoint(x: 0.6008587426379263d, y: 0.7443388061923689d), new NpgsqlTypes.NpgsqlPoint(x: 0.6802714450113977d, y: 0.7795472975513834d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7869522369128582d, y: 0.6501973543844749d), new NpgsqlTypes.NpgsqlPoint(x: 0.8759556140218949d, y: 0.5683289499452946d), new NpgsqlTypes.NpgsqlPoint(x: 0.22570236611796557d, y: 0.44112550863529465d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4218983933670193d, y: 0.8901160300726126d), new NpgsqlTypes.NpgsqlPoint(x: 0.01519809390714466d, y: 0.46649181819431407d), new NpgsqlTypes.NpgsqlPoint(x: 0.7022086723756686d, y: 0.006490420394715035d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8230040600683309d, y: 0.24282414843531674d), new NpgsqlTypes.NpgsqlPoint(x: 0.04625340774855091d, y: 0.28025287213366834d), new NpgsqlTypes.NpgsqlPoint(x: 0.015714114661810497d, y: 0.8718174314172292d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02735969925734949d, y: 0.6868337834795566d), new NpgsqlTypes.NpgsqlPoint(x: 0.363733496326915d, y: 0.7256423244109623d), new NpgsqlTypes.NpgsqlPoint(x: 0.37429638378548413d, y: 0.0771724523047631d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46485255173016826d, y: 0.4191155719708669d), new NpgsqlTypes.NpgsqlPoint(x: 0.9047733773310467d, y: 0.2958178798870186d), new NpgsqlTypes.NpgsqlPoint(x: 0.2824424172633081d, y: 0.8428525050638627d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5467937485872614d, y: 0.41198471134719006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8375780911387567d, y: 0.4332222885184418d), new NpgsqlTypes.NpgsqlPoint(x: 0.872638301003819d, y: 0.7321136491557289d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7724461442001309d, y: 0.9771329174527263d), new NpgsqlTypes.NpgsqlPoint(x: 0.8176755686117587d, y: 0.5837196021852051d), new NpgsqlTypes.NpgsqlPoint(x: 0.42942942963653863d, y: 0.2162199424553689d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5900939312130218d, y: 0.5662784210835604d), new NpgsqlTypes.NpgsqlPoint(x: 0.9948969756892548d, y: 0.4736259780760773d), new NpgsqlTypes.NpgsqlPoint(x: 0.68949125659809d, y: 0.5806394538015258d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4746629840220623d, y: 0.8946828777288434d), new NpgsqlTypes.NpgsqlPoint(x: 0.8365997422142704d, y: 0.5973589906628173d), new NpgsqlTypes.NpgsqlPoint(x: 0.6396544897585598d, y: 0.7895302426506633d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.60144330890718d, y: 0.15651313459584437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6504001113267611d, y: 0.6334383793990119d), new NpgsqlTypes.NpgsqlPoint(x: 0.07437731448339213d, y: 0.3964640968712443d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20458192635027517d, y: 0.3621113355494341d), new NpgsqlTypes.NpgsqlPoint(x: 0.048324693235544d, y: 0.29516479185225997d), new NpgsqlTypes.NpgsqlPoint(x: 0.3265447942225548d, y: 0.16537238034842294d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14900332558139928d, y: 0.7493253949432714d), new NpgsqlTypes.NpgsqlPoint(x: 0.7559150195149242d, y: 0.02124407127530703d), new NpgsqlTypes.NpgsqlPoint(x: 0.20737494615408347d, y: 0.5042906557275355d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.054858657671721156d, y: 0.35492227869569826d), new NpgsqlTypes.NpgsqlPoint(x: 0.17061972309526685d, y: 0.24309972517176337d), new NpgsqlTypes.NpgsqlPoint(x: 0.14345370110806022d, y: 0.45462368618018256d)), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
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

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14524275661681318d, y: 0.03072748562957217d), new NpgsqlTypes.NpgsqlPoint(x: 0.4952800431186437d, y: 0.09560064567814708d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728131384653277d, y: 0.3667712409220014d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17720519414427283d, y: 0.7143134813564781d), new NpgsqlTypes.NpgsqlPoint(x: 0.45032017691653914d, y: 0.09791586540071884d), new NpgsqlTypes.NpgsqlPoint(x: 0.5622570909876808d, y: 0.495058294543011d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22587822635395505d, y: 0.9558336036322689d), new NpgsqlTypes.NpgsqlPoint(x: 0.9544904165178296d, y: 0.9839572346702865d), new NpgsqlTypes.NpgsqlPoint(x: 0.4783865801127267d, y: 0.45240471078759303d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9416931911909948d, y: 0.9636570435844605d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016712180197442d, y: 0.5315260063661048d), new NpgsqlTypes.NpgsqlPoint(x: 0.207000729447692d, y: 0.8639124819144666d)), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08416422941485657d, y: 0.18539249742399666d), new NpgsqlTypes.NpgsqlPoint(x: 0.9801988131491999d, y: 0.7512786408397232d), new NpgsqlTypes.NpgsqlPoint(x: 0.9769984265693116d, y: 0.3651928187169463d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.017324407960570443d, y: 0.12967369523550343d), new NpgsqlTypes.NpgsqlPoint(x: 0.6788513021298479d, y: 0.6719074512548591d), new NpgsqlTypes.NpgsqlPoint(x: 0.6607654243970267d, y: 0.3934845525390346d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9086846482343292d, y: 0.35611769792035775d), new NpgsqlTypes.NpgsqlPoint(x: 0.5299582735421926d, y: 0.9050298325080733d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334606054779536d, y: 0.8614129962319351d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9014466637648807d, y: 0.7950635117948909d), new NpgsqlTypes.NpgsqlPoint(x: 0.2444005649834321d, y: 0.599535923761446d), new NpgsqlTypes.NpgsqlPoint(x: 0.379767431900099d, y: 0.2881566480080854d)), }, }));
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44549995966100076d, y: 0.5653381957944839d), new NpgsqlTypes.NpgsqlPoint(x: 0.771156359133397d, y: 0.07789494907172678d), new NpgsqlTypes.NpgsqlPoint(x: 0.49020440204851723d, y: 0.957458028723481d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15511139094739546d, y: 0.9037089172019324d), new NpgsqlTypes.NpgsqlPoint(x: 0.3386407921327601d, y: 0.6915117611150498d), new NpgsqlTypes.NpgsqlPoint(x: 0.2114422722293272d, y: 0.9177867921331547d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3472190914791259d, y: 0.005153937764216798d), new NpgsqlTypes.NpgsqlPoint(x: 0.37228338867074007d, y: 0.43451711495920664d), new NpgsqlTypes.NpgsqlPoint(x: 0.18003706030416822d, y: 0.1910695219025751d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.907862812810879d, y: 0.2814060507443997d), new NpgsqlTypes.NpgsqlPoint(x: 0.33458897398003107d, y: 0.8847064742875105d), new NpgsqlTypes.NpgsqlPoint(x: 0.4941561389306325d, y: 0.3549629824224355d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6145662808612196d, y: 0.05557536392750406d), new NpgsqlTypes.NpgsqlPoint(x: 0.3346666553456976d, y: 0.6699315068931927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5710537270343046d, y: 0.230461042611259d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2654467011642534d, y: 0.501451845491932d), new NpgsqlTypes.NpgsqlPoint(x: 0.265976857126082d, y: 0.8439509859370328d), new NpgsqlTypes.NpgsqlPoint(x: 0.3992714778826224d, y: 0.2064718596377919d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6679544072495933d, y: 0.49169431643534256d), new NpgsqlTypes.NpgsqlPoint(x: 0.46447079643983036d, y: 0.5380040735051025d), new NpgsqlTypes.NpgsqlPoint(x: 0.07451682158627693d, y: 0.8688887752558523d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9247865579051511d, y: 0.00585998813019839d), new NpgsqlTypes.NpgsqlPoint(x: 0.001460323796586227d, y: 0.5287604928173428d), new NpgsqlTypes.NpgsqlPoint(x: 0.5554991414564925d, y: 0.1744790780198815d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 13, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 51, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 10, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 125, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 147, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 103, query1, 3, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 103, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 38, query1, 3, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 131, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 72, 66))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 147);
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
FROM public.binary_npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI), typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

