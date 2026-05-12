

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
    internal partial interface INpgsqlLineListlineListD1
    {
    }
    
    internal partial class NpgsqlLineListlineListD1 : INpgsqlLineListlineListD1
    {


#region TestData

        private readonly NpgsqlLinelineListD1E2M[] _testData = new NpgsqlLinelineListD1E2M[]
        {
            new NpgsqlLinelineListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7410202312731787d, b: 0.7044451197885355d, c: 0.7337438263602013d),

new NpgsqlTypes.NpgsqlLine(a: 0.8027440504293696d, b: 0.3726387486157322d, c: 0.0016149304350104865d),

new NpgsqlTypes.NpgsqlLine(a: 0.20100967655128077d, b: 0.9333148794633392d, c: 0.03591640530788265d),

new NpgsqlTypes.NpgsqlLine(a: 0.36599586896767267d, b: 0.2723861824697207d, c: 0.46282993594205113d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8492723973983877d, b: 0.8984605755007495d, c: 0.0024137719871575314d),

new NpgsqlTypes.NpgsqlLine(a: 0.5974357465200474d, b: 0.4434964130032746d, c: 0.6703426391713005d),

new NpgsqlTypes.NpgsqlLine(a: 0.36592634451282446d, b: 0.1596007633699731d, c: 0.9035458985080368d),

new NpgsqlTypes.NpgsqlLine(a: 0.8724161956200609d, b: 0.1328894922682926d, c: 0.8180399420405131d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.30536003472787165d, b: 0.5510525993166197d, c: 0.15655345789459196d),

new NpgsqlTypes.NpgsqlLine(a: 0.3242352628712769d, b: 0.5010595133746495d, c: 0.5638290964553482d),

new NpgsqlTypes.NpgsqlLine(a: 0.40165906915945293d, b: 0.6434706379187243d, c: 0.817253176401383d),

new NpgsqlTypes.NpgsqlLine(a: 0.8277835275771902d, b: 0.06969011586704932d, c: 0.5579971651154845d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9772523691408677d, b: 0.558086987350034d, c: 0.3539375824966895d),

new NpgsqlTypes.NpgsqlLine(a: 0.031068437314239694d, b: 0.5997951959339617d, c: 0.3011954143940567d),

new NpgsqlTypes.NpgsqlLine(a: 0.6751857272398043d, b: 0.1926364488522302d, c: 0.7471726044610687d),

new NpgsqlTypes.NpgsqlLine(a: 0.9435140395050402d, b: 0.7914122465041589d, c: 0.16059277383901915d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3034333465463045d, b: 0.5748139662412679d, c: 0.46311084556429294d),

new NpgsqlTypes.NpgsqlLine(a: 0.6402386226204148d, b: 0.28967575126957634d, c: 0.2247916219027548d),

new NpgsqlTypes.NpgsqlLine(a: 0.750868088198975d, b: 0.5808160989097684d, c: 0.4607532340811089d),

new NpgsqlTypes.NpgsqlLine(a: 0.2348872855950287d, b: 0.3322113756702466d, c: 0.140079455680027d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43472406495474025d, b: 0.8662124528997516d, c: 0.8876745742789979d),

new NpgsqlTypes.NpgsqlLine(a: 0.9445405548001278d, b: 0.21717236972818144d, c: 0.4084094065548133d),

new NpgsqlTypes.NpgsqlLine(a: 0.3446602006178159d, b: 0.43080280360877277d, c: 0.2923490729796768d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8372110682278047d, b: 0.6393366680069037d, c: 0.13871949165884379d),

new NpgsqlTypes.NpgsqlLine(a: 0.8547649523226717d, b: 0.5630635281773405d, c: 0.883890472947869d),

new NpgsqlTypes.NpgsqlLine(a: 0.5479792031279952d, b: 0.7914658168999135d, c: 0.37265215746544766d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5009958935796284d, b: 0.951726103533952d, c: 0.02079704603199506d),

new NpgsqlTypes.NpgsqlLine(a: 0.20648995907941137d, b: 0.296776643259683d, c: 0.4055729776765489d),

new NpgsqlTypes.NpgsqlLine(a: 0.9438573243262994d, b: 0.12195149984720999d, c: 0.6713890641781272d),

new NpgsqlTypes.NpgsqlLine(a: 0.310079397102473d, b: 0.6896687021416533d, c: 0.6857522220453098d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4994559279657157d, b: 0.5809087080441231d, c: 0.9960507801654467d),

new NpgsqlTypes.NpgsqlLine(a: 0.8119342234482528d, b: 0.08911142569009178d, c: 0.31597984484519936d),

new NpgsqlTypes.NpgsqlLine(a: 0.7975927560650428d, b: 0.899492605599248d, c: 0.29780789234573013d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1978530584038758d, b: 0.4668410459977461d, c: 0.05895730082825579d),

new NpgsqlTypes.NpgsqlLine(a: 0.1906188000538015d, b: 0.3387594876946851d, c: 0.9118603190181847d),

new NpgsqlTypes.NpgsqlLine(a: 0.02647464229557328d, b: 0.11925152886131885d, c: 0.32920820931582073d),

new NpgsqlTypes.NpgsqlLine(a: 0.6951710966052081d, b: 0.08838778073166731d, c: 0.944875351440368d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.851398219816708d, b: 0.5512907335639196d, c: 0.5340270518932759d),

new NpgsqlTypes.NpgsqlLine(a: 0.7177106603036523d, b: 0.8672315819804978d, c: 0.3343085321590401d),

new NpgsqlTypes.NpgsqlLine(a: 0.40008775315071854d, b: 0.9613437044149462d, c: 0.4431926830557723d),

new NpgsqlTypes.NpgsqlLine(a: 0.26299014697801437d, b: 0.9498186262733598d, c: 0.14480127800239806d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5569596797670253d, b: 0.916341952720349d, c: 0.009529455970535672d),

new NpgsqlTypes.NpgsqlLine(a: 0.4155934276330714d, b: 0.301998487876743d, c: 0.718658037144367d),

new NpgsqlTypes.NpgsqlLine(a: 0.498560035523394d, b: 0.6241876765248614d, c: 0.9217917097278396d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6075940735024422d, b: 0.6960205809310066d, c: 0.003331329481395917d),

new NpgsqlTypes.NpgsqlLine(a: 0.763310316784249d, b: 0.03826659076409211d, c: 0.9075233267558738d),

new NpgsqlTypes.NpgsqlLine(a: 0.4576848828319541d, b: 0.5775864749707611d, c: 0.12367287779235714d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.105611526893993d, b: 0.5003493402430961d, c: 0.09980002533998023d),

new NpgsqlTypes.NpgsqlLine(a: 0.7102521454868386d, b: 0.20211106908987053d, c: 0.24022451050875138d),

new NpgsqlTypes.NpgsqlLine(a: 0.5994774731992624d, b: 0.37214994238804766d, c: 0.7897731142525122d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7914577259654886d, b: 0.24325844257794615d, c: 0.012700348343021473d),

new NpgsqlTypes.NpgsqlLine(a: 0.980686449269707d, b: 0.8206661557248898d, c: 0.9877861003911945d),

new NpgsqlTypes.NpgsqlLine(a: 0.9093135218861831d, b: 0.5358339766232754d, c: 0.033752453665390925d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.40479559876733306d, b: 0.08708441315592585d, c: 0.21895555042617698d),

new NpgsqlTypes.NpgsqlLine(a: 0.5743650162629907d, b: 0.3545506047287491d, c: 0.1938486711872489d),

new NpgsqlTypes.NpgsqlLine(a: 0.7102720108119526d, b: 0.9017462535413024d, c: 0.838237424575939d),

new NpgsqlTypes.NpgsqlLine(a: 0.7184715090544663d, b: 0.7299968381347856d, c: 0.7591208604475717d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8035238098946876d, b: 0.5787346477551107d, c: 0.3880287220502211d),

new NpgsqlTypes.NpgsqlLine(a: 0.665349664387135d, b: 0.9685667579069551d, c: 0.8786173596861377d),

new NpgsqlTypes.NpgsqlLine(a: 0.36393223850598533d, b: 0.5532960879932233d, c: 0.8892067489862269d),

new NpgsqlTypes.NpgsqlLine(a: 0.443868754715924d, b: 0.6863093324015606d, c: 0.849451865745449d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36094674381378855d, b: 0.6524174789341692d, c: 0.8278606445045441d),

new NpgsqlTypes.NpgsqlLine(a: 0.7162608765524161d, b: 0.7457933597190534d, c: 0.7689197485577408d),

new NpgsqlTypes.NpgsqlLine(a: 0.14352615898763488d, b: 0.9787679958387048d, c: 0.15718336455598947d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8011776367392394d, b: 0.13556049927698655d, c: 0.9284992729994098d),

new NpgsqlTypes.NpgsqlLine(a: 0.5666735795379534d, b: 0.8311937861336934d, c: 0.18380539883643043d),

new NpgsqlTypes.NpgsqlLine(a: 0.1400590984290987d, b: 0.1226554248496271d, c: 0.08687719514770298d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.46309761058806576d, b: 0.5197279469216521d, c: 0.770980684819518d),

new NpgsqlTypes.NpgsqlLine(a: 0.26857477398780993d, b: 0.33187419567381693d, c: 0.5049608640999224d),

new NpgsqlTypes.NpgsqlLine(a: 0.43406699308053365d, b: 0.8338255660725965d, c: 0.5268839545403935d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5656919793993881d, b: 0.8130198435710065d, c: 0.20994622846710698d),

new NpgsqlTypes.NpgsqlLine(a: 0.8694968306932106d, b: 0.25065172933302715d, c: 0.32462006687388134d),

new NpgsqlTypes.NpgsqlLine(a: 0.49135868538618976d, b: 0.237375599000907d, c: 0.5204883035684699d),

new NpgsqlTypes.NpgsqlLine(a: 0.9171354689624761d, b: 0.060830986703392265d, c: 0.4100859891146248d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20667026790282939d, b: 0.7387889793532965d, c: 0.9970291730129637d),

new NpgsqlTypes.NpgsqlLine(a: 0.5486057399939546d, b: 0.3843973694693129d, c: 0.5129032632086423d),

new NpgsqlTypes.NpgsqlLine(a: 0.4612345539355084d, b: 0.4235016635163782d, c: 0.3318491018825611d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7899744220555903d, b: 0.48847159500858395d, c: 0.8683051760920715d),

new NpgsqlTypes.NpgsqlLine(a: 0.6986586902891436d, b: 0.37251092570558186d, c: 0.962833428038675d),

new NpgsqlTypes.NpgsqlLine(a: 0.39951668483188496d, b: 0.036741572441278736d, c: 0.7222145011492462d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5942423156077249d, b: 0.9437131458185218d, c: 0.8448611641655474d),

new NpgsqlTypes.NpgsqlLine(a: 0.15279850562507136d, b: 0.7128238503495065d, c: 0.39317591879706204d),

new NpgsqlTypes.NpgsqlLine(a: 0.6097829950702459d, b: 0.273618842479704d, c: 0.3292139746000028d),

new NpgsqlTypes.NpgsqlLine(a: 0.013580738069107978d, b: 0.1099863867834514d, c: 0.9637614651570738d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4600623194326886d, b: 0.20190884148641652d, c: 0.14437818644610256d),

new NpgsqlTypes.NpgsqlLine(a: 0.5750922523414118d, b: 0.4755628719806303d, c: 0.40345585836147313d),

new NpgsqlTypes.NpgsqlLine(a: 0.6766637206462368d, b: 0.6788174132490501d, c: 0.8610136020311988d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2483545825728085d, b: 0.027435415906179483d, c: 0.5793618706960649d),

new NpgsqlTypes.NpgsqlLine(a: 0.8574206448954942d, b: 0.2378301741901241d, c: 0.6717671872140857d),

new NpgsqlTypes.NpgsqlLine(a: 0.39194545169235673d, b: 0.1289695028143194d, c: 0.44525275752039273d),

new NpgsqlTypes.NpgsqlLine(a: 0.4206244118973742d, b: 0.8223816531940816d, c: 0.5045956183918384d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14781349695738788d, b: 0.5826520186101017d, c: 0.2731176888482578d),

new NpgsqlTypes.NpgsqlLine(a: 0.12475524921598002d, b: 0.2720795105624365d, c: 0.02782911776068353d),

new NpgsqlTypes.NpgsqlLine(a: 0.971908448327364d, b: 0.8605032733044925d, c: 0.5196819242985219d),

new NpgsqlTypes.NpgsqlLine(a: 0.21641253637524382d, b: 0.6459693357716796d, c: 0.7094912292937839d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12865064449817665d, b: 0.33862686344202175d, c: 0.3559017983812275d),

new NpgsqlTypes.NpgsqlLine(a: 0.725624160108142d, b: 0.19445157911691557d, c: 0.8201605695581977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5879870188426631d, b: 0.6534655850651955d, c: 0.8209029614194494d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6028234409438156d, b: 0.8808981399016192d, c: 0.03352741376047286d),

new NpgsqlTypes.NpgsqlLine(a: 0.9828206936304861d, b: 0.4296926887446473d, c: 0.2232119751815308d),

new NpgsqlTypes.NpgsqlLine(a: 0.8244383106259017d, b: 0.0232347942386959d, c: 0.14260550375352998d),

new NpgsqlTypes.NpgsqlLine(a: 0.5845615794785031d, b: 0.7734159041117687d, c: 0.2073195661241659d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6392719541828537d, b: 0.6784035374289343d, c: 0.09794630180792918d),

new NpgsqlTypes.NpgsqlLine(a: 0.6977464509079315d, b: 0.34715355204579534d, c: 0.3586071343021302d),

new NpgsqlTypes.NpgsqlLine(a: 0.8345205835323422d, b: 0.39898483626068815d, c: 0.6740131665992517d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9074013182907119d, b: 0.332820842173599d, c: 0.9226326630391088d),

new NpgsqlTypes.NpgsqlLine(a: 0.6105870069943344d, b: 0.11679552437802043d, c: 0.06989942632183477d),

new NpgsqlTypes.NpgsqlLine(a: 0.7277390495899831d, b: 0.23150138219457528d, c: 0.5767906307357901d),

new NpgsqlTypes.NpgsqlLine(a: 0.23434687770761164d, b: 0.3534671132198778d, c: 0.554313879044766d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.945370898071807d, b: 0.4071194589786342d, c: 0.7355677320522235d),

new NpgsqlTypes.NpgsqlLine(a: 0.8313650494765803d, b: 0.22808729624751234d, c: 0.37000283709136284d),

new NpgsqlTypes.NpgsqlLine(a: 0.49817895543254853d, b: 0.02164010899690838d, c: 0.49550719115480135d),

new NpgsqlTypes.NpgsqlLine(a: 0.04808797441994339d, b: 0.3280334900055063d, c: 0.46431634761897544d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9419355048154049d, b: 0.8966299035560744d, c: 0.2311601191120125d),

new NpgsqlTypes.NpgsqlLine(a: 0.118211579417695d, b: 0.08144906786315675d, c: 0.18905022610316435d),

new NpgsqlTypes.NpgsqlLine(a: 0.40829038474944346d, b: 0.21921435630727004d, c: 0.5056587637388882d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04343602224136223d, b: 0.19371521196102193d, c: 0.4615481686946674d),

new NpgsqlTypes.NpgsqlLine(a: 0.056334943268494864d, b: 0.6641519595811239d, c: 0.26787570379948167d),

new NpgsqlTypes.NpgsqlLine(a: 0.0847989994936843d, b: 0.7632528569173455d, c: 0.4059906821780179d),

new NpgsqlTypes.NpgsqlLine(a: 0.9010385706912925d, b: 0.9896547724403046d, c: 0.40370540501208296d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42155507451179397d, b: 0.5363364544886859d, c: 0.10255318717294004d),

new NpgsqlTypes.NpgsqlLine(a: 0.35911189149962475d, b: 0.4715290188382806d, c: 0.5729564148402904d),

new NpgsqlTypes.NpgsqlLine(a: 0.4029822472386927d, b: 0.5925697169409813d, c: 0.9227339750466317d),

new NpgsqlTypes.NpgsqlLine(a: 0.5136223183365672d, b: 0.35117323766202646d, c: 0.5431776014321448d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28669233401038574d, b: 0.6734973362105526d, c: 0.7747324439188955d),

new NpgsqlTypes.NpgsqlLine(a: 0.7120442675879433d, b: 0.26440279887738727d, c: 0.34241560194865617d),

new NpgsqlTypes.NpgsqlLine(a: 0.187794255039064d, b: 0.8645904750196208d, c: 0.4247558715495874d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8038362957631148d, b: 0.8723607424813838d, c: 0.5662316918904878d),

new NpgsqlTypes.NpgsqlLine(a: 0.3971628511699502d, b: 0.3066012813266391d, c: 0.2567853940658923d),

new NpgsqlTypes.NpgsqlLine(a: 0.09017158065121489d, b: 0.1796803056977333d, c: 0.8828129188540311d),

new NpgsqlTypes.NpgsqlLine(a: 0.11488560370263856d, b: 0.4308361016439971d, c: 0.9719730619641463d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6504925826105264d, b: 0.9222422001221963d, c: 0.508542300942923d),

new NpgsqlTypes.NpgsqlLine(a: 0.840064825514572d, b: 0.07244686990320348d, c: 0.3424325686923385d),

new NpgsqlTypes.NpgsqlLine(a: 0.46450486799956203d, b: 0.8690778384700795d, c: 0.8019847608971833d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12344360791816666d, b: 0.15199610056094148d, c: 0.40438526545514575d),

new NpgsqlTypes.NpgsqlLine(a: 0.28077313238567025d, b: 0.5809384141440587d, c: 0.5033443886129163d),

new NpgsqlTypes.NpgsqlLine(a: 0.2491093597712023d, b: 0.732939242857247d, c: 0.1688428386592945d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7739373952767173d, b: 0.9435704256892529d, c: 0.6944390453386757d),

new NpgsqlTypes.NpgsqlLine(a: 0.8012151523252596d, b: 0.3904479925239124d, c: 0.2806249910618632d),

new NpgsqlTypes.NpgsqlLine(a: 0.8604662338556918d, b: 0.04069971575345299d, c: 0.6716522801962822d),

new NpgsqlTypes.NpgsqlLine(a: 0.9689503169556548d, b: 0.6200925740475984d, c: 0.26238073559176023d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5889431028565333d, b: 0.46957269352660036d, c: 0.34427938525148327d),

new NpgsqlTypes.NpgsqlLine(a: 0.3787110152896689d, b: 0.2913577594519655d, c: 0.9526213128440196d),

new NpgsqlTypes.NpgsqlLine(a: 0.9698755635925053d, b: 0.5696620548382251d, c: 0.7596673954777144d),

new NpgsqlTypes.NpgsqlLine(a: 0.915002239663223d, b: 0.00173629206383219d, c: 0.30496358182010463d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9895964503439109d, b: 0.6208428000528279d, c: 0.43493502956928976d),

new NpgsqlTypes.NpgsqlLine(a: 0.28394749485240145d, b: 0.5569731974184332d, c: 0.7623445968335306d),

new NpgsqlTypes.NpgsqlLine(a: 0.43697541013402874d, b: 0.6957941087989243d, c: 0.44495722983031805d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5676322501073772d, b: 0.3070949259276703d, c: 0.07229977307343693d),

new NpgsqlTypes.NpgsqlLine(a: 0.5415584650194054d, b: 0.7162273440158482d, c: 0.5128559212402788d),

new NpgsqlTypes.NpgsqlLine(a: 0.02076424185207726d, b: 0.04439981461021014d, c: 0.04999642957399364d),

new NpgsqlTypes.NpgsqlLine(a: 0.2125310121615226d, b: 0.9986333995724709d, c: 0.3606328801045259d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7766312726017168d, b: 0.29440734446059824d, c: 0.8393633360797209d),

new NpgsqlTypes.NpgsqlLine(a: 0.4385690849896d, b: 0.38846054800276875d, c: 0.9844099911196743d),

new NpgsqlTypes.NpgsqlLine(a: 0.9926059284191598d, b: 0.42301178056805067d, c: 0.39576122195275154d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5960801497169419d, b: 0.957386623147411d, c: 0.9741054168406684d),

new NpgsqlTypes.NpgsqlLine(a: 0.1355873102643873d, b: 0.8653330857886262d, c: 0.8460782129686027d),

new NpgsqlTypes.NpgsqlLine(a: 0.0527340325385639d, b: 0.854810011106109d, c: 0.3593717139328494d),

new NpgsqlTypes.NpgsqlLine(a: 0.1939031124063999d, b: 0.43471077060596486d, c: 0.8861832413832109d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16965450104383994d, b: 0.3638522713500296d, c: 0.09058435535269171d),

new NpgsqlTypes.NpgsqlLine(a: 0.6408990965621677d, b: 0.8143778932807096d, c: 0.09479540999166958d),

new NpgsqlTypes.NpgsqlLine(a: 0.6542332863029833d, b: 0.37848606022838904d, c: 0.38511468258742576d),

new NpgsqlTypes.NpgsqlLine(a: 0.20720756296246712d, b: 0.20932199075814462d, c: 0.7446993839337118d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8012784214501738d, b: 0.966675404233677d, c: 0.6334140691969278d),

new NpgsqlTypes.NpgsqlLine(a: 0.20066873937426566d, b: 0.4830398126194676d, c: 0.3611937946571566d),

new NpgsqlTypes.NpgsqlLine(a: 0.9753444746800674d, b: 0.8240163014654646d, c: 0.34064528716603304d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17958029500849948d, b: 0.25782768269869905d, c: 0.8931287455525908d),

new NpgsqlTypes.NpgsqlLine(a: 0.6360867925541966d, b: 0.28951407382114625d, c: 0.3862841313689006d),

new NpgsqlTypes.NpgsqlLine(a: 0.04637388267262976d, b: 0.7464555515106234d, c: 0.25201931673513245d),

new NpgsqlTypes.NpgsqlLine(a: 0.23729104411008295d, b: 0.1353073663045289d, c: 0.8655187833903402d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1913854418879265d, b: 0.4074217692143066d, c: 0.5798295814829172d),

new NpgsqlTypes.NpgsqlLine(a: 0.7450587158788831d, b: 0.8530931167990322d, c: 0.1308443917925527d),

new NpgsqlTypes.NpgsqlLine(a: 0.6908110776128423d, b: 0.21290214136071628d, c: 0.6085349368906213d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2602001919425603d, b: 0.10024037087367554d, c: 0.11044422214165661d),

new NpgsqlTypes.NpgsqlLine(a: 0.7922414945395344d, b: 0.38107477646279d, c: 0.2705022650290143d),

new NpgsqlTypes.NpgsqlLine(a: 0.7593610495513826d, b: 0.6800966619746618d, c: 0.3233021835843062d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6599324237237634d, b: 0.5626849423177366d, c: 0.9236361443348984d),

new NpgsqlTypes.NpgsqlLine(a: 0.6492231870331006d, b: 0.6324806975352871d, c: 0.8129636623116466d),

new NpgsqlTypes.NpgsqlLine(a: 0.542129871764687d, b: 0.665228178419943d, c: 0.25624238656055287d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3494611476710736d, b: 0.819212684028159d, c: 0.9037006780682666d),

new NpgsqlTypes.NpgsqlLine(a: 0.16656623973631068d, b: 0.1004092611431805d, c: 0.09862151545800912d),

new NpgsqlTypes.NpgsqlLine(a: 0.8030659158642843d, b: 0.02590477074615638d, c: 0.634148851166289d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07481825724767488d, b: 0.1142528486633041d, c: 0.3781543352354173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6582265913753587d, b: 0.35584615082349147d, c: 0.3248811523049183d),

new NpgsqlTypes.NpgsqlLine(a: 0.542858035047718d, b: 0.641098487785164d, c: 0.5770028268475969d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7448912161011543d, b: 0.5935049256805883d, c: 0.5169499475047125d),

new NpgsqlTypes.NpgsqlLine(a: 0.0057393645833273554d, b: 0.32138439147385267d, c: 0.2873481522517992d),

new NpgsqlTypes.NpgsqlLine(a: 0.689932190243266d, b: 0.13135379985616547d, c: 0.12408694743566506d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1142927932558171d, b: 0.5648460750445113d, c: 0.663268692684593d),

new NpgsqlTypes.NpgsqlLine(a: 0.13965446266059856d, b: 0.4638196060125237d, c: 0.13506035778859649d),

new NpgsqlTypes.NpgsqlLine(a: 0.6821411290426065d, b: 0.8209312339634163d, c: 0.22116178785246443d),

new NpgsqlTypes.NpgsqlLine(a: 0.5791281885930669d, b: 0.15472609998433162d, c: 0.24574338442381138d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22847898850012283d, b: 0.11072963318093687d, c: 0.5537074597680697d),

new NpgsqlTypes.NpgsqlLine(a: 0.4407284358949919d, b: 0.32944683042366907d, c: 0.4512074601506011d),

new NpgsqlTypes.NpgsqlLine(a: 0.785284163933307d, b: 0.5582833499289028d, c: 0.8241487318242369d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6497054548402968d, b: 0.12435135849594925d, c: 0.8324980564416508d),

new NpgsqlTypes.NpgsqlLine(a: 0.9360475140074417d, b: 0.37698751081358384d, c: 0.9978070539219055d),

new NpgsqlTypes.NpgsqlLine(a: 0.49180850745933524d, b: 0.2586060108419612d, c: 0.15489752350848907d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7437068833493965d, b: 0.7322061437698634d, c: 0.6334892342978417d),

new NpgsqlTypes.NpgsqlLine(a: 0.9444417812597432d, b: 0.26524831352707046d, c: 0.366713365429884d),

new NpgsqlTypes.NpgsqlLine(a: 0.5918781747991609d, b: 0.21003224268488974d, c: 0.6763118002648699d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2334347343008918d, b: 0.8636389301258467d, c: 0.26962111526562116d),

new NpgsqlTypes.NpgsqlLine(a: 0.27958961366850077d, b: 0.8013150199367441d, c: 0.222758588956546d),

new NpgsqlTypes.NpgsqlLine(a: 0.43218643479187935d, b: 0.11898772117114143d, c: 0.15421295141684743d),

new NpgsqlTypes.NpgsqlLine(a: 0.10249756134643029d, b: 0.7706043771850004d, c: 0.9189979942685381d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20316520686118222d, b: 0.6110340091526938d, c: 0.5903480996439614d),

new NpgsqlTypes.NpgsqlLine(a: 0.6190097847089888d, b: 0.4114034736789097d, c: 0.3490544290543608d),

new NpgsqlTypes.NpgsqlLine(a: 0.7439301460404488d, b: 0.8579333556399598d, c: 0.8713493034949755d),

new NpgsqlTypes.NpgsqlLine(a: 0.9269361841113899d, b: 0.7005753862428149d, c: 0.504821118640193d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.015399029547561227d, b: 0.6998369577693564d, c: 0.16641225832354878d),

new NpgsqlTypes.NpgsqlLine(a: 0.2196467302348193d, b: 0.49397225413940926d, c: 0.9447672028105785d),

new NpgsqlTypes.NpgsqlLine(a: 0.7894404212740765d, b: 0.3142378017509626d, c: 0.15860353481168388d),

new NpgsqlTypes.NpgsqlLine(a: 0.5833172473786119d, b: 0.06900555494972871d, c: 0.24046717164639086d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9181814820677153d, b: 0.08830350537690312d, c: 0.8329647533540147d),

new NpgsqlTypes.NpgsqlLine(a: 0.06834861143933246d, b: 0.4685905134523054d, c: 0.7907084406680617d),

new NpgsqlTypes.NpgsqlLine(a: 0.9558695092729469d, b: 0.015202096743110904d, c: 0.6111434169897284d),

new NpgsqlTypes.NpgsqlLine(a: 0.20870959684123258d, b: 0.3392201864558756d, c: 0.02233522842868807d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18897870294185415d, b: 0.820675443703548d, c: 0.42082429324126014d),

new NpgsqlTypes.NpgsqlLine(a: 0.1831878263132336d, b: 0.25679223541450147d, c: 0.4193187989426138d),

new NpgsqlTypes.NpgsqlLine(a: 0.4063781195253803d, b: 0.3296464303431742d, c: 0.5839517415628283d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10091898147896272d, b: 0.22582687375325805d, c: 0.02049813748667284d),

new NpgsqlTypes.NpgsqlLine(a: 0.8792618917489604d, b: 0.8559041117625228d, c: 0.20554552911260837d),

new NpgsqlTypes.NpgsqlLine(a: 0.11706898544080446d, b: 0.8556685845922439d, c: 0.6821330496629148d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5651265549727242d, b: 0.3662869126131487d, c: 0.11297905850560341d),

new NpgsqlTypes.NpgsqlLine(a: 0.541733370203672d, b: 0.37055945475240115d, c: 0.8733457737785258d),

new NpgsqlTypes.NpgsqlLine(a: 0.760317655217296d, b: 0.7526290357904536d, c: 0.9824619677733981d),

new NpgsqlTypes.NpgsqlLine(a: 0.7170769242265763d, b: 0.15173372043811628d, c: 0.5851336001102144d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1923269390657737d, b: 0.8905182710508532d, c: 0.8187411519750911d),

new NpgsqlTypes.NpgsqlLine(a: 0.22576301028097157d, b: 0.23483883154799168d, c: 0.5032313254503566d),

new NpgsqlTypes.NpgsqlLine(a: 0.34977532012974133d, b: 0.4924399849866219d, c: 0.46250748685770604d),

new NpgsqlTypes.NpgsqlLine(a: 0.11956260801954577d, b: 0.5510616789184901d, c: 0.9166985436884405d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 188,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04449329073858688d, b: 0.7093671150556483d, c: 0.6587336232283978d),

new NpgsqlTypes.NpgsqlLine(a: 0.3639243260683305d, b: 0.20909063859236465d, c: 0.8266303954301699d),

new NpgsqlTypes.NpgsqlLine(a: 0.5303569973418963d, b: 0.13507448062683458d, c: 0.33409234451281733d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 193,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5801179500791698d, b: 0.15168472408746936d, c: 0.11425164089891804d),

new NpgsqlTypes.NpgsqlLine(a: 0.5144265453293559d, b: 0.943237065150955d, c: 0.004047763172776664d),

new NpgsqlTypes.NpgsqlLine(a: 0.7567386504949344d, b: 0.8821092819847814d, c: 0.14586910589548097d),

new NpgsqlTypes.NpgsqlLine(a: 0.26583478580209985d, b: 0.23867260255716793d, c: 0.9020375675915181d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.48995520503963874d, b: 0.7738794728419423d, c: 0.1862780733711462d),

new NpgsqlTypes.NpgsqlLine(a: 0.49282850524885935d, b: 0.5807269312294508d, c: 0.762055517179343d),

new NpgsqlTypes.NpgsqlLine(a: 0.41694841035834507d, b: 0.7383547451090203d, c: 0.09270321323977604d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5345631499409893d, b: 0.04869841626296845d, c: 0.9291123812571492d),

new NpgsqlTypes.NpgsqlLine(a: 0.9864153706609704d, b: 0.3544993964703611d, c: 0.4689581249770016d),

new NpgsqlTypes.NpgsqlLine(a: 0.2905014095919122d, b: 0.10647946725898572d, c: 0.6313784372808948d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 200,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8706017607116286d, b: 0.944627690665597d, c: 0.4068029316646046d),

new NpgsqlTypes.NpgsqlLine(a: 0.16833633408221704d, b: 0.940679949080237d, c: 0.6121696313359195d),

new NpgsqlTypes.NpgsqlLine(a: 0.6628625390757004d, b: 0.05818909557502461d, c: 0.15728699757925768d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.29457268559358407d, b: 0.03232938792995366d, c: 0.10819993731839184d),

new NpgsqlTypes.NpgsqlLine(a: 0.24175181358690778d, b: 0.806635649179064d, c: 0.6521362174032889d),

new NpgsqlTypes.NpgsqlLine(a: 0.9277888192142721d, b: 0.3747811737201916d, c: 0.3641122969914249d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)), 
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
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                List<NpgsqlLinelineListD1E2M> models = null;

                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineListD1E2M> models = null;

                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 173;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 188;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 112, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 112, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 31, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 55, query1, 173, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 8, query1, 157, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 55, query1, 55, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 108, query1, 155, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 188, query1, 157, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 11, 157))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatch(connection, 15, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 168);
                var models = await ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models =  ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[2], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[3], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[4], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[5], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[6], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[7], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[8], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[9], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[10], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[11], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[12], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[13], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[14], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[15], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[16], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[17], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[18], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[19], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[20], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[21], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[22], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[23], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[24], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[25], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[26], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[27], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[28], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[29], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[32],_testData[34], false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MI),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineListD1E2M),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
FROM public.binary_npgsqllinelinelistd1e2m m
LEFT JOIN public.binary_npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models =  ((INpgsqlLineListlineListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI), typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                await ((INpgsqlLineListlineListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                ((INpgsqlLineListlineListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

