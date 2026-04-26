

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
new NpgsqlTypes.NpgsqlLine(a: 0.545852386792688d, b: 0.2797227225920307d, c: 0.7840490748234987d),
new NpgsqlTypes.NpgsqlLine(a: 0.27034550241895106d, b: 0.7517528876877466d, c: 0.5672271761801989d),
new NpgsqlTypes.NpgsqlLine(a: 0.8956959707566623d, b: 0.3612241935032796d, c: 0.680609008701588d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6191276907640871d, b: 0.06940572702643444d, c: 0.7582280435754742d),
new NpgsqlTypes.NpgsqlLine(a: 0.13699109174849622d, b: 0.0021082653314964395d, c: 0.6303261674728727d),
new NpgsqlTypes.NpgsqlLine(a: 0.5855880551591452d, b: 0.4612812495198122d, c: 0.4922682955499721d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8290292222020401d, b: 0.329432222532831d, c: 0.522679996576427d),
new NpgsqlTypes.NpgsqlLine(a: 0.6732750350587192d, b: 0.4614014675890741d, c: 0.11201203209762789d),
new NpgsqlTypes.NpgsqlLine(a: 0.31417416636987716d, b: 0.8878451778317197d, c: 0.8904819222722685d),
new NpgsqlTypes.NpgsqlLine(a: 0.5869948535189659d, b: 0.691582221241478d, c: 0.7227445604801984d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7550040833093649d, b: 0.1855499824292579d, c: 0.08733374250629522d),
new NpgsqlTypes.NpgsqlLine(a: 0.8394265631538236d, b: 0.10227454089309906d, c: 0.4687927981488874d),
new NpgsqlTypes.NpgsqlLine(a: 0.20981663461473443d, b: 0.7537821616861422d, c: 0.8546694982435434d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04016649868890365d, b: 0.7181793237485706d, c: 0.4440558589304391d),
new NpgsqlTypes.NpgsqlLine(a: 0.6107300402469464d, b: 0.8766620611229541d, c: 0.3720698741944346d),
new NpgsqlTypes.NpgsqlLine(a: 0.9147893781143626d, b: 0.6584999895050536d, c: 0.6524183875375371d),
new NpgsqlTypes.NpgsqlLine(a: 0.0883651085917666d, b: 0.736394092106881d, c: 0.34364742963780104d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9195349002494371d, b: 0.8304575518031196d, c: 0.11502915008848635d),
new NpgsqlTypes.NpgsqlLine(a: 0.7845904576951158d, b: 0.3900103495643027d, c: 0.9128770789082497d),
new NpgsqlTypes.NpgsqlLine(a: 0.31666749363717217d, b: 0.033075627906477556d, c: 0.4499959524546586d),
new NpgsqlTypes.NpgsqlLine(a: 0.580986246133345d, b: 0.6055276208167839d, c: 0.956337997299678d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3549478073014325d, b: 0.2721084734359681d, c: 0.6101273825754957d),
new NpgsqlTypes.NpgsqlLine(a: 0.3733413475825855d, b: 0.09889918347521132d, c: 0.8046129721366936d),
new NpgsqlTypes.NpgsqlLine(a: 0.24001248182725254d, b: 0.7424898776846477d, c: 0.0893447006819621d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.997432325972822d, b: 0.6769234372370924d, c: 0.7760215425805155d),
new NpgsqlTypes.NpgsqlLine(a: 0.37167485636326447d, b: 0.4490678367789479d, c: 0.06276063481273875d),
new NpgsqlTypes.NpgsqlLine(a: 0.4044237830742341d, b: 0.16113639964201998d, c: 0.40657046910190786d),
new NpgsqlTypes.NpgsqlLine(a: 0.5567137367507611d, b: 0.4103335987710893d, c: 0.24285684670615937d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7970874233065316d, b: 0.7869835509095054d, c: 0.4633880312102634d),
new NpgsqlTypes.NpgsqlLine(a: 0.6535307877307887d, b: 0.06778527808544621d, c: 0.5324923653311956d),
new NpgsqlTypes.NpgsqlLine(a: 0.6767701459465397d, b: 0.757439328575128d, c: 0.13262220787063872d),
new NpgsqlTypes.NpgsqlLine(a: 0.7925646238348634d, b: 0.854891371668945d, c: 0.5680938393764643d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4351346066611683d, b: 0.7022646948934573d, c: 0.022116470434292212d),
new NpgsqlTypes.NpgsqlLine(a: 0.40233549436302374d, b: 0.2277621894784969d, c: 0.44859279325420176d),
new NpgsqlTypes.NpgsqlLine(a: 0.1129894990418806d, b: 0.6583838055893074d, c: 0.8184243168936701d),
new NpgsqlTypes.NpgsqlLine(a: 0.7322518006954702d, b: 0.8560269015722015d, c: 0.09878629609257716d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43915677156112465d, b: 0.7799282665136356d, c: 0.9742642701384893d),
new NpgsqlTypes.NpgsqlLine(a: 0.98365861984609d, b: 0.5715597050115645d, c: 0.7028671260669972d),
new NpgsqlTypes.NpgsqlLine(a: 0.626116260052116d, b: 0.7858041527267805d, c: 0.8417622886766026d),
new NpgsqlTypes.NpgsqlLine(a: 0.01211733727918518d, b: 0.03794899773281757d, c: 0.16773410450278547d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08762572806460467d, b: 0.2693329165722885d, c: 0.8610926140752668d),
new NpgsqlTypes.NpgsqlLine(a: 0.185146202442804d, b: 0.2935352055188363d, c: 0.11886160650706179d),
new NpgsqlTypes.NpgsqlLine(a: 0.6213328319471964d, b: 0.4646145355482356d, c: 0.25479518629630005d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.983049202534315d, b: 0.5361285154697061d, c: 0.19871271473608254d),
new NpgsqlTypes.NpgsqlLine(a: 0.5049219582703102d, b: 0.34081569079934204d, c: 0.8576844421793958d),
new NpgsqlTypes.NpgsqlLine(a: 0.8103080962132525d, b: 0.22388083539911197d, c: 0.4650133192057646d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.353006804265372d, b: 0.5288470470411414d, c: 0.003711000633956907d),
new NpgsqlTypes.NpgsqlLine(a: 0.003556899193295826d, b: 0.5182388019273365d, c: 0.6893987543191848d),
new NpgsqlTypes.NpgsqlLine(a: 0.9606018982284571d, b: 0.25028229278787395d, c: 0.4535745739496856d),
new NpgsqlTypes.NpgsqlLine(a: 0.33184789606607024d, b: 0.5929857800370832d, c: 0.09658562285185657d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2933646872048695d, b: 0.8213528794478999d, c: 0.16144286294167098d),
new NpgsqlTypes.NpgsqlLine(a: 0.12734542807760096d, b: 0.4652645107625416d, c: 0.13706146854670487d),
new NpgsqlTypes.NpgsqlLine(a: 0.6195806414074427d, b: 0.754935701011626d, c: 0.16219739686537604d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2044928727494889d, b: 0.444043604484203d, c: 0.9180593426127833d),
new NpgsqlTypes.NpgsqlLine(a: 0.4600505853886667d, b: 0.9915595866839853d, c: 0.27125424373390605d),
new NpgsqlTypes.NpgsqlLine(a: 0.6346678601805319d, b: 0.10176568494846217d, c: 0.9481837799757266d),
new NpgsqlTypes.NpgsqlLine(a: 0.11806818480946268d, b: 0.017219526140809238d, c: 0.8491331490578823d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9701647523073526d, b: 0.5035851937311939d, c: 0.09801477887991938d),
new NpgsqlTypes.NpgsqlLine(a: 0.46905450113397906d, b: 0.45249331691409367d, c: 0.571848702862225d),
new NpgsqlTypes.NpgsqlLine(a: 0.9391945053848348d, b: 0.14312494718762714d, c: 0.3461189294403175d),
new NpgsqlTypes.NpgsqlLine(a: 0.2870474950602079d, b: 0.539415781773023d, c: 0.8786208069556296d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1256483530684237d, b: 0.6062237608944316d, c: 0.9421387060391745d),
new NpgsqlTypes.NpgsqlLine(a: 0.5496660884795377d, b: 0.369621144055319d, c: 0.49514732668949324d),
new NpgsqlTypes.NpgsqlLine(a: 0.07814497286011513d, b: 0.3872255908191726d, c: 0.3477931324513558d),
new NpgsqlTypes.NpgsqlLine(a: 0.3007188229140447d, b: 0.10691629486885401d, c: 0.3077415673158125d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4643954538107232d, b: 0.23649448979301024d, c: 0.932514311918332d),
new NpgsqlTypes.NpgsqlLine(a: 0.9608584497715058d, b: 0.03856757863472915d, c: 0.3306261169469463d),
new NpgsqlTypes.NpgsqlLine(a: 0.19407151628906427d, b: 0.535581673957276d, c: 0.6597625987902807d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04356136882228301d, b: 0.8301686108599573d, c: 0.1730665993653423d),
new NpgsqlTypes.NpgsqlLine(a: 0.10645800625485824d, b: 0.9201384256894121d, c: 0.3605406266701442d),
new NpgsqlTypes.NpgsqlLine(a: 0.3568949291904562d, b: 0.3144596552240063d, c: 0.24626211464699022d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.33842811300840026d, b: 0.598702223869042d, c: 0.41111617680474555d),
new NpgsqlTypes.NpgsqlLine(a: 0.4619801375578497d, b: 0.2363248930335491d, c: 0.3465262774158264d),
new NpgsqlTypes.NpgsqlLine(a: 0.005094768987942366d, b: 0.890711993236365d, c: 0.7151977399263099d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5920534320857385d, b: 0.9600124465215915d, c: 0.5553463853231193d),
new NpgsqlTypes.NpgsqlLine(a: 0.6507292533129737d, b: 0.33596614283295967d, c: 0.38166488246121444d),
new NpgsqlTypes.NpgsqlLine(a: 0.5734548541626089d, b: 0.987084383042829d, c: 0.9497730483854266d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.576790768068071d, b: 0.9753307498729779d, c: 0.4286388876755546d),
new NpgsqlTypes.NpgsqlLine(a: 0.4889402801178365d, b: 0.6569066204756426d, c: 0.6819606209065061d),
new NpgsqlTypes.NpgsqlLine(a: 0.7483233181350131d, b: 0.5302738919534661d, c: 0.34291332095473004d),
new NpgsqlTypes.NpgsqlLine(a: 0.8670708435277613d, b: 0.2962417865410839d, c: 0.680437520789489d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11187490470277273d, b: 0.5326060235903286d, c: 0.22629407627656883d),
new NpgsqlTypes.NpgsqlLine(a: 0.6270624655855588d, b: 0.7313196741126788d, c: 0.08980358578264958d),
new NpgsqlTypes.NpgsqlLine(a: 0.5165539442560798d, b: 0.5149335072553373d, c: 0.8807703650252189d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6189641696586488d, b: 0.022163906619385276d, c: 0.6540690167671809d),
new NpgsqlTypes.NpgsqlLine(a: 0.7296339402695019d, b: 0.1590400201800709d, c: 0.597241939046476d),
new NpgsqlTypes.NpgsqlLine(a: 0.47847528925858185d, b: 0.6943946567629541d, c: 0.3153442650106917d),
new NpgsqlTypes.NpgsqlLine(a: 0.774987903194798d, b: 0.561160690909337d, c: 0.03074285152594536d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.904417747971749d, b: 0.2324750153997176d, c: 0.8234216709391163d),
new NpgsqlTypes.NpgsqlLine(a: 0.1887361181372611d, b: 0.566079333196146d, c: 0.7366258846011824d),
new NpgsqlTypes.NpgsqlLine(a: 0.9262925155024994d, b: 0.6490980116819223d, c: 0.9047864963367368d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23833386768204012d, b: 0.37020141124407757d, c: 0.08233361829122199d),
new NpgsqlTypes.NpgsqlLine(a: 0.28178885390364994d, b: 0.28233314789832975d, c: 0.6123487264612619d),
new NpgsqlTypes.NpgsqlLine(a: 0.6830573925272246d, b: 0.5560347401882367d, c: 0.39818356937186905d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7173461240789274d, b: 0.24156116356179314d, c: 0.5107576925526297d),
new NpgsqlTypes.NpgsqlLine(a: 0.4333434451590418d, b: 0.7566436794152285d, c: 0.6665767759707732d),
new NpgsqlTypes.NpgsqlLine(a: 0.5368081155269908d, b: 0.2750726561249035d, c: 0.3222289834011237d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10645849606453539d, b: 0.972752458779941d, c: 0.9634258335596769d),
new NpgsqlTypes.NpgsqlLine(a: 0.7679747473525611d, b: 0.3695660386901839d, c: 0.2736296484240265d),
new NpgsqlTypes.NpgsqlLine(a: 0.538942920628706d, b: 0.4006133667655979d, c: 0.4393481652212773d),
new NpgsqlTypes.NpgsqlLine(a: 0.9382325721550133d, b: 0.18977569388953752d, c: 0.07105792151879053d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.46101185594613814d, b: 0.5236257033665215d, c: 0.2883274148772298d),
new NpgsqlTypes.NpgsqlLine(a: 0.11911178299489789d, b: 0.7928716308221454d, c: 0.8136500434275968d),
new NpgsqlTypes.NpgsqlLine(a: 0.5793859581295892d, b: 0.38001552594875043d, c: 0.3618346575137674d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7473192145864284d, b: 0.33264024687819826d, c: 0.17923040590095574d),
new NpgsqlTypes.NpgsqlLine(a: 0.4193341829703201d, b: 0.009877624935504148d, c: 0.918082095367848d),
new NpgsqlTypes.NpgsqlLine(a: 0.6095336993583768d, b: 0.5195734554940978d, c: 0.17676679060997935d),
new NpgsqlTypes.NpgsqlLine(a: 0.24270108642725852d, b: 0.001814398369607173d, c: 0.013701154560494588d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3394995106933839d, b: 0.9797678037792487d, c: 0.5241203425745723d),
new NpgsqlTypes.NpgsqlLine(a: 0.5626900253316582d, b: 0.0634738452113528d, c: 0.5154359237797266d),
new NpgsqlTypes.NpgsqlLine(a: 0.018568190903690662d, b: 0.761278272479281d, c: 0.5323937314309016d),
new NpgsqlTypes.NpgsqlLine(a: 0.11010311840005238d, b: 0.06302395796387927d, c: 0.4258261486120696d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9598395332735696d, b: 0.8223610015840128d, c: 0.06802232532834007d),
new NpgsqlTypes.NpgsqlLine(a: 0.12830270719927628d, b: 0.7863067210231013d, c: 0.5322449442005339d),
new NpgsqlTypes.NpgsqlLine(a: 0.8188359266030499d, b: 0.6651682729019605d, c: 0.7183419472373989d),
new NpgsqlTypes.NpgsqlLine(a: 0.016478207561757885d, b: 0.35087903748575666d, c: 0.7127816698695846d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2415322928261162d, b: 0.24396594676676342d, c: 0.33029314455147085d),
new NpgsqlTypes.NpgsqlLine(a: 0.8861790317430864d, b: 0.9560903231123574d, c: 0.07319230706429702d),
new NpgsqlTypes.NpgsqlLine(a: 0.9056678933606814d, b: 0.13563807749486012d, c: 0.32285910737758117d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7392070621254255d, b: 0.08514784182153112d, c: 0.25230347776213446d),
new NpgsqlTypes.NpgsqlLine(a: 0.8474465838101137d, b: 0.5319932271073219d, c: 0.4074407365466295d),
new NpgsqlTypes.NpgsqlLine(a: 0.8494315689195733d, b: 0.6946313808073095d, c: 0.6539878501699565d),
new NpgsqlTypes.NpgsqlLine(a: 0.034390099837136257d, b: 0.17444280711741966d, c: 0.39762540071649266d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.910939405024259d, b: 0.8503480473630441d, c: 0.5455476508827267d),
new NpgsqlTypes.NpgsqlLine(a: 0.4080603488253022d, b: 0.23005877372140493d, c: 0.6558356150155602d),
new NpgsqlTypes.NpgsqlLine(a: 0.2662749404206176d, b: 0.43835539845202154d, c: 0.8328676497825674d),
new NpgsqlTypes.NpgsqlLine(a: 0.27028442190606694d, b: 0.8779154984634012d, c: 0.2838432737785602d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23269841862554252d, b: 0.4409120759701646d, c: 0.5925387642172576d),
new NpgsqlTypes.NpgsqlLine(a: 0.5650178563321977d, b: 0.25887503530621436d, c: 0.8788406494035338d),
new NpgsqlTypes.NpgsqlLine(a: 0.8075142447178142d, b: 0.9130032937231113d, c: 0.6099950150054924d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4472001676146127d, b: 0.7438378105640603d, c: 0.655310296601477d),
new NpgsqlTypes.NpgsqlLine(a: 0.38735029382263453d, b: 0.913748317591077d, c: 0.7088513480302607d),
new NpgsqlTypes.NpgsqlLine(a: 0.6005125264509314d, b: 0.5359259289245484d, c: 0.05614173177496329d),
new NpgsqlTypes.NpgsqlLine(a: 0.6459856745410179d, b: 0.5486328007977976d, c: 0.32642930287210603d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8399281594750982d, b: 0.9138219309152058d, c: 0.1854447203456593d),
new NpgsqlTypes.NpgsqlLine(a: 0.5169315852312625d, b: 0.35586046517746206d, c: 0.54367132509006d),
new NpgsqlTypes.NpgsqlLine(a: 0.17146934805585934d, b: 0.9597136210353977d, c: 0.44510244855936876d),
new NpgsqlTypes.NpgsqlLine(a: 0.4222675052163112d, b: 0.04789830902041359d, c: 0.045292544153369474d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11088169040559914d, b: 0.7034341892164061d, c: 0.7022645558650498d),
new NpgsqlTypes.NpgsqlLine(a: 0.06536962409434222d, b: 0.6872381568655912d, c: 0.6947402622020376d),
new NpgsqlTypes.NpgsqlLine(a: 0.06092786311605991d, b: 0.44830610117264147d, c: 0.11763856557311181d),
new NpgsqlTypes.NpgsqlLine(a: 0.9920677999243943d, b: 0.9920097896997716d, c: 0.5807660064585064d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5396894491231056d, b: 0.288761969799444d, c: 0.786015297881979d),
new NpgsqlTypes.NpgsqlLine(a: 0.7786121364918481d, b: 0.4653096139041315d, c: 0.7188556490392914d),
new NpgsqlTypes.NpgsqlLine(a: 0.10961783248630608d, b: 0.6479435146374951d, c: 0.17872204727211338d),
new NpgsqlTypes.NpgsqlLine(a: 0.7432527612939801d, b: 0.7141468279099863d, c: 0.668152713712314d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17965988317765313d, b: 0.011839694049724847d, c: 0.3216105644880942d),
new NpgsqlTypes.NpgsqlLine(a: 0.7363108779661915d, b: 0.4073255651361457d, c: 0.39201806856198373d),
new NpgsqlTypes.NpgsqlLine(a: 0.040560077478887346d, b: 0.8482443116871536d, c: 0.13749969448053634d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9214706456581485d, b: 0.7639956931398001d, c: 0.2856513419082566d),
new NpgsqlTypes.NpgsqlLine(a: 0.43355068258029916d, b: 0.04466305996438924d, c: 0.017500303078834212d),
new NpgsqlTypes.NpgsqlLine(a: 0.8330266502027551d, b: 0.6889830976170953d, c: 0.5046065904704751d),
new NpgsqlTypes.NpgsqlLine(a: 0.22698701197410776d, b: 0.18560759657922465d, c: 0.6006105430970615d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.46794335397509224d, b: 0.44138119344250504d, c: 0.6028233745237942d),
new NpgsqlTypes.NpgsqlLine(a: 0.17110581000275216d, b: 0.8546405196310065d, c: 0.13825348881462207d),
new NpgsqlTypes.NpgsqlLine(a: 0.1817739600842021d, b: 0.37808352830214054d, c: 0.1598724591316475d),
new NpgsqlTypes.NpgsqlLine(a: 0.755582971729305d, b: 0.5241342277993838d, c: 0.5920062418277521d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2483594767930798d, b: 0.04246222043739467d, c: 0.9485759572237508d),
new NpgsqlTypes.NpgsqlLine(a: 0.9529363146623583d, b: 0.339738643125581d, c: 0.5835566478393872d),
new NpgsqlTypes.NpgsqlLine(a: 0.8318000291998224d, b: 0.6819040721418667d, c: 0.7122906649227216d),
new NpgsqlTypes.NpgsqlLine(a: 0.9517176620824557d, b: 0.004189593167267747d, c: 0.27390128682230397d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8454992566046708d, b: 0.0898483113860078d, c: 0.46067213707831656d),
new NpgsqlTypes.NpgsqlLine(a: 0.9249529581770296d, b: 0.544624037419762d, c: 0.31130612984076556d),
new NpgsqlTypes.NpgsqlLine(a: 0.6588406019898624d, b: 0.677086131721045d, c: 0.20517551465565997d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9827328874176315d, b: 0.0008010425907269969d, c: 0.759822553934579d),
new NpgsqlTypes.NpgsqlLine(a: 0.3459558743418233d, b: 0.12380377462835235d, c: 0.5641996111663459d),
new NpgsqlTypes.NpgsqlLine(a: 0.9389425559442431d, b: 0.3833238179309131d, c: 0.3929264283664108d),
new NpgsqlTypes.NpgsqlLine(a: 0.7297591968843339d, b: 0.6133940677230294d, c: 0.47313458947884934d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.02719727221324031d, b: 0.09640559497351076d, c: 0.38241821120043784d),
new NpgsqlTypes.NpgsqlLine(a: 0.40440320157622534d, b: 0.31090764202905097d, c: 0.2116811962211731d),
new NpgsqlTypes.NpgsqlLine(a: 0.5336875968761744d, b: 0.7885247262437236d, c: 0.9390391583661659d),
new NpgsqlTypes.NpgsqlLine(a: 0.919122254849809d, b: 0.6667791637261866d, c: 0.8268660715101787d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4364193956365221d, b: 0.6712659533477032d, c: 0.5271571974049988d),
new NpgsqlTypes.NpgsqlLine(a: 0.27809325038500043d, b: 0.2697286533732647d, c: 0.2779765497788367d),
new NpgsqlTypes.NpgsqlLine(a: 0.25062214526352d, b: 0.47709135953021886d, c: 0.8935214123776102d),
new NpgsqlTypes.NpgsqlLine(a: 0.31999949601244826d, b: 0.5541255403564673d, c: 0.50982404641773d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5670288729195169d, b: 0.46550214223875597d, c: 0.14335380611488902d),
new NpgsqlTypes.NpgsqlLine(a: 0.711734257375294d, b: 0.06066478239864603d, c: 0.9052374819502954d),
new NpgsqlTypes.NpgsqlLine(a: 0.08241308569660555d, b: 0.894549671907945d, c: 0.5929479198178172d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9642355230531159d, b: 0.48106129083527016d, c: 0.7616120667458639d),
new NpgsqlTypes.NpgsqlLine(a: 0.28255139943904495d, b: 0.16429212074215904d, c: 0.5511540825106924d),
new NpgsqlTypes.NpgsqlLine(a: 0.18089492534080576d, b: 0.035140650969410214d, c: 0.8126176540334441d),
new NpgsqlTypes.NpgsqlLine(a: 0.8725110863358299d, b: 0.6969617326374523d, c: 0.8370567159480973d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9682624737346482d, b: 0.812174203719524d, c: 0.2467040615569719d),
new NpgsqlTypes.NpgsqlLine(a: 0.07442005382734851d, b: 0.4005909062864468d, c: 0.0793011394570684d),
new NpgsqlTypes.NpgsqlLine(a: 0.610385705864634d, b: 0.2122274249847469d, c: 0.9739650656360509d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7175060227938672d, b: 0.8515183043439335d, c: 0.6255976748900768d),
new NpgsqlTypes.NpgsqlLine(a: 0.7346411881270064d, b: 0.8641106667354187d, c: 0.41698990725270135d),
new NpgsqlTypes.NpgsqlLine(a: 0.06575369132486075d, b: 0.2873950285121063d, c: 0.7861460596591114d),
new NpgsqlTypes.NpgsqlLine(a: 0.2600957974026826d, b: 0.21304028847715184d, c: 0.39033084327441436d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30941147233035804d, b: 0.8588963102959805d, c: 0.4872785095124714d),
new NpgsqlTypes.NpgsqlLine(a: 0.5040324995121587d, b: 0.7553884573488464d, c: 0.5586812373148542d),
new NpgsqlTypes.NpgsqlLine(a: 0.3732623841951146d, b: 0.8495812936630456d, c: 0.5437518128951385d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6540055297200417d, b: 0.27201297949348224d, c: 0.26200780463375606d),
new NpgsqlTypes.NpgsqlLine(a: 0.17417180353635642d, b: 0.5551620559441894d, c: 0.009845162533531293d),
new NpgsqlTypes.NpgsqlLine(a: 0.27277282044781004d, b: 0.7593947510053266d, c: 0.39352270060829475d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7561657685725661d, b: 0.39519901342297037d, c: 0.5373806707207625d),
new NpgsqlTypes.NpgsqlLine(a: 0.9654864614782618d, b: 0.08594808744092919d, c: 0.7169539542628809d),
new NpgsqlTypes.NpgsqlLine(a: 0.3795412169138609d, b: 0.1413807855992546d, c: 0.6066062663430598d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.415346275206922d, b: 0.9346013580444518d, c: 0.5933128730379132d),
new NpgsqlTypes.NpgsqlLine(a: 0.5774064236163784d, b: 0.5643360858126755d, c: 0.613285606601471d),
new NpgsqlTypes.NpgsqlLine(a: 0.04227380923341839d, b: 0.9453787195441979d, c: 0.7700707723961496d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8669665759226045d, b: 0.1284351902891685d, c: 0.5150308941415239d),
new NpgsqlTypes.NpgsqlLine(a: 0.9575571984218734d, b: 0.4420569893852393d, c: 0.04008188945451452d),
new NpgsqlTypes.NpgsqlLine(a: 0.9829518371629768d, b: 0.05652197820727012d, c: 0.23473309557174238d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7116508036527852d, b: 0.8975490992586191d, c: 0.5004799933162913d),
new NpgsqlTypes.NpgsqlLine(a: 0.09008018940488005d, b: 0.6182754355409882d, c: 0.17410554314000026d),
new NpgsqlTypes.NpgsqlLine(a: 0.20818962843425604d, b: 0.40262536529795845d, c: 0.2684567850419687d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.022775204990137632d, b: 0.47252975554903587d, c: 0.5590122209349456d),
new NpgsqlTypes.NpgsqlLine(a: 0.7275814740748243d, b: 0.3371801211330445d, c: 0.9063604498035879d),
new NpgsqlTypes.NpgsqlLine(a: 0.5518413615108586d, b: 0.3878903346860191d, c: 0.656836207710925d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9148384748106044d, b: 0.5474084080528964d, c: 0.25160260142909874d),
new NpgsqlTypes.NpgsqlLine(a: 0.3197027457441345d, b: 0.9591225858385324d, c: 0.667782971303624d),
new NpgsqlTypes.NpgsqlLine(a: 0.8187146237628845d, b: 0.6612765569755d, c: 0.1440135449596771d),
new NpgsqlTypes.NpgsqlLine(a: 0.7889465527884458d, b: 0.0068847043164567134d, c: 0.480831883847899d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.06807320903409175d, b: 0.34290395537763785d, c: 0.9124823819701655d),
new NpgsqlTypes.NpgsqlLine(a: 0.7441218511330832d, b: 0.4792238974034463d, c: 0.4308804863814405d),
new NpgsqlTypes.NpgsqlLine(a: 0.03848317216799124d, b: 0.7750514907849687d, c: 0.341084125507763d),
new NpgsqlTypes.NpgsqlLine(a: 0.3505804426567509d, b: 0.944572098185963d, c: 0.537874652545338d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17015291407161015d, b: 0.42938586791520916d, c: 0.36494902669106055d),
new NpgsqlTypes.NpgsqlLine(a: 0.1391590378600105d, b: 0.2391763467840734d, c: 0.8014143380443572d),
new NpgsqlTypes.NpgsqlLine(a: 0.9927990059505936d, b: 0.6707927966927265d, c: 0.5991873245073748d),
new NpgsqlTypes.NpgsqlLine(a: 0.349525258631617d, b: 0.7058193420442924d, c: 0.24807618735672232d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9578379807906027d, b: 0.06765036821865655d, c: 0.01455694372027394d),
new NpgsqlTypes.NpgsqlLine(a: 0.2148400150490678d, b: 0.5849298830474224d, c: 0.19247023955692755d),
new NpgsqlTypes.NpgsqlLine(a: 0.7906882864888175d, b: 0.876413650657427d, c: 0.37325558047816465d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8588508977989625d, b: 0.650733683526847d, c: 0.6441483273379074d),
new NpgsqlTypes.NpgsqlLine(a: 0.2517741958806604d, b: 0.1831612419516d, c: 0.10742175755714045d),
new NpgsqlTypes.NpgsqlLine(a: 0.38653771022166994d, b: 0.3905067482247653d, c: 0.036081085984526085d),
new NpgsqlTypes.NpgsqlLine(a: 0.7443778029789723d, b: 0.2921836851266463d, c: 0.7463943632171632d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9099423392735837d, b: 0.09398975834158207d, c: 0.8406835035328212d),
new NpgsqlTypes.NpgsqlLine(a: 0.1375137498299226d, b: 0.19448430775601622d, c: 0.8977857852357363d),
new NpgsqlTypes.NpgsqlLine(a: 0.7401746633515903d, b: 0.31716661004575164d, c: 0.1717490610386181d),
new NpgsqlTypes.NpgsqlLine(a: 0.7653077794024618d, b: 0.07553835828616395d, c: 0.7885641658457322d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.13234008414536835d, b: 0.5973367968774957d, c: 0.049113903988625696d),
new NpgsqlTypes.NpgsqlLine(a: 0.7494178655593631d, b: 0.6990121698591225d, c: 0.046510534541349347d),
new NpgsqlTypes.NpgsqlLine(a: 0.887155422716831d, b: 0.8000945817603192d, c: 0.6264635156228668d),
new NpgsqlTypes.NpgsqlLine(a: 0.23613073073747448d, b: 0.1351430201964926d, c: 0.8858546792573133d),
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.983049202534315d, b: 0.5361285154697061d, c: 0.19871271473608254d),
new NpgsqlTypes.NpgsqlLine(a: 0.5049219582703102d, b: 0.34081569079934204d, c: 0.8576844421793958d),
new NpgsqlTypes.NpgsqlLine(a: 0.8103080962132525d, b: 0.22388083539911197d, c: 0.4650133192057646d),
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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9701647523073526d, b: 0.5035851937311939d, c: 0.09801477887991938d),
new NpgsqlTypes.NpgsqlLine(a: 0.46905450113397906d, b: 0.45249331691409367d, c: 0.571848702862225d),
new NpgsqlTypes.NpgsqlLine(a: 0.9391945053848348d, b: 0.14312494718762714d, c: 0.3461189294403175d),
new NpgsqlTypes.NpgsqlLine(a: 0.2870474950602079d, b: 0.539415781773023d, c: 0.8786208069556296d),
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.576790768068071d, b: 0.9753307498729779d, c: 0.4286388876755546d),
new NpgsqlTypes.NpgsqlLine(a: 0.4889402801178365d, b: 0.6569066204756426d, c: 0.6819606209065061d),
new NpgsqlTypes.NpgsqlLine(a: 0.7483233181350131d, b: 0.5302738919534661d, c: 0.34291332095473004d),
new NpgsqlTypes.NpgsqlLine(a: 0.8670708435277613d, b: 0.2962417865410839d, c: 0.680437520789489d),
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                        Assert.That(models, Has.Count.EqualTo(12));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 133, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 133, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatchAsync(connection, 72, 40))
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
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatch(connection, 91, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
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
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[29], false);
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

