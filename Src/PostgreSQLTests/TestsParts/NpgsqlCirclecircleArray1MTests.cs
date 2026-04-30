

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
    internal partial interface INpgsqlCircleArraycircleArray
    {
    }
    
    internal partial class NpgsqlCircleArraycircleArray : INpgsqlCircleArraycircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray1M[] _testData = new NpgsqlCirclecircleArray1M[]
        {
            new NpgsqlCirclecircleArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4986371068618526d, y: 0.5580012100998312d), radius: 0.829940763887871d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7752570664240414d, y: 0.2657903327124158d), radius: 0.27638718404131357d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7311293808780657d, y: 0.7883971957755618d), radius: 0.99651319111292d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39993603114602183d, y: 0.12844401903168357d), radius: 0.05044363955506914d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34861946825939194d, y: 0.5029194305086967d), radius: 0.9527070584584136d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7847516944726224d, y: 0.26158392750259574d), radius: 0.32150421230833015d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11641441739583624d, y: 0.9445644053689766d), radius: 0.24507234071183792d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.051662372196977d, y: 0.45647527222635065d), radius: 0.36703984355008734d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8675588423407404d, y: 0.5680780985826654d), radius: 0.6540474943446548d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29536009367532123d, y: 0.9411537425351567d), radius: 0.2515313534841278d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.288669460100461d, y: 0.27481336567161896d), radius: 0.1589445919924225d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.021604315505638683d, y: 0.9607155284500455d), radius: 0.8860260826904812d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5480344178484691d, y: 0.3027729867902875d), radius: 0.7982113320501917d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8154449054149417d, y: 0.10324242507715153d), radius: 0.6586622598088157d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4943373107838488d, y: 0.27936553153031807d), radius: 0.16396925402382279d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7685140708484524d, y: 0.19475656679332964d), radius: 0.3331314940582363d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4227824283099221d, y: 0.41275666446341297d), radius: 0.9773205850905026d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15578179284687088d, y: 0.9806332257963162d), radius: 0.07090860500288165d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3400209930472292d, y: 0.6142641069007845d), radius: 0.4526044932973716d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08228343715131337d, y: 0.6570958519427691d), radius: 0.5713934145681574d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5584583341814123d, y: 0.4670535519121364d), radius: 0.5240034601792292d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3129655600990163d, y: 0.1803227519381938d), radius: 0.32809271546046626d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5312328270820208d, y: 0.7870383803848852d), radius: 0.7402037050967794d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3691355449960896d, y: 0.2290468348287108d), radius: 0.8854609612190194d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.953517326592749d, y: 0.37778036567823436d), radius: 0.4285246716987985d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32640475912525424d, y: 0.5229250087296275d), radius: 0.9992381423331392d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32235881830346924d, y: 0.2730220550547411d), radius: 0.4220084685070764d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7309541439805393d, y: 0.740460709012273d), radius: 0.3961758407939029d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25458362129314094d, y: 0.4269890176253993d), radius: 0.9681862903276686d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27082272019368614d, y: 0.24794779524515176d), radius: 0.38154917575979386d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7879934826306358d, y: 0.07953756086612573d), radius: 0.9236401528916679d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21255772079172497d, y: 0.5313836343823867d), radius: 0.575103937622873d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26406288884412465d, y: 0.7750846286004622d), radius: 0.05291401508254823d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5020659104601445d, y: 0.01783949543958696d), radius: 0.047771735041191254d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28640202393775205d, y: 0.10004104910655676d), radius: 0.4177594124381928d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49481562646351573d, y: 0.3175413223560545d), radius: 0.3430359682124856d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1434968647722078d, y: 0.3242281786099187d), radius: 0.23652709354945034d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.021623194728493278d, y: 0.800720109954917d), radius: 0.3758267001002782d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.057994192547379586d, y: 0.8734997473388407d), radius: 0.8241020809960627d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9799915421307518d, y: 0.414788160325833d), radius: 0.3931036763586051d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08855580975570321d, y: 0.9542417776200401d), radius: 0.4034660155692139d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6475977877752046d, y: 0.01622015813980482d), radius: 0.8224139358006751d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7973193489792311d, y: 0.1549337660232608d), radius: 0.06207003979564507d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22733202793532337d, y: 0.3862334881836428d), radius: 0.10580762521942122d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5221054893798278d, y: 0.23705781366149792d), radius: 0.2890818600014835d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02742112807226904d, y: 0.018027140515456286d), radius: 0.9513695708393611d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9272556749846128d, y: 0.44489944930994485d), radius: 0.5512549556239508d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2693596870259697d, y: 0.9561189256888084d), radius: 0.6556021781549582d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6310295959908631d, y: 0.9499060363564071d), radius: 0.929268053279864d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6354980202626512d, y: 0.6197395186535849d), radius: 0.859644528151377d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16909752266894051d, y: 0.9981190113997049d), radius: 0.4259207256675933d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09677910575265147d, y: 0.8042341286803358d), radius: 0.1266267987492946d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5159015559805469d, y: 0.43420323242062153d), radius: 0.10494056211062819d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01689442748010872d, y: 0.5379650864244988d), radius: 0.2086895595878625d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2062039813567137d, y: 0.5967666121250655d), radius: 0.49949905340914924d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5989430370572819d, y: 0.03444676617364251d), radius: 0.7034019830331794d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7215046721065312d, y: 0.6500293031526404d), radius: 0.5418348706129031d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22673616807819807d, y: 0.5624156676603141d), radius: 0.8885040260301659d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12349419355794333d, y: 0.5389249164807144d), radius: 0.2314585312711961d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1404086977075969d, y: 0.5423217927041865d), radius: 0.4874046687024278d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8014155323922134d, y: 0.257972625794771d), radius: 0.9043470001504268d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11941691481468208d, y: 0.3046888725731365d), radius: 0.09477590151041515d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4573580309988651d, y: 0.05296938899357573d), radius: 0.41006910510660244d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21684743695952025d, y: 0.933812915748828d), radius: 0.16450546996373905d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6981436297192247d, y: 0.4436505993682879d), radius: 0.010668833106327491d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3925443480732156d, y: 0.8186287076859141d), radius: 0.3142327127225809d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8048933837955801d, y: 0.8946325707231079d), radius: 0.868342929967282d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22661511607509044d, y: 0.7589615080516982d), radius: 0.11619431875688202d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20558411567720591d, y: 0.8107533109586722d), radius: 0.16397056955919964d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.140722203587476d, y: 0.1938919926946171d), radius: 0.4854700811527315d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9556544492128634d, y: 0.35998330858565375d), radius: 0.8191944183777438d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8578208316338836d, y: 0.8377135363657449d), radius: 0.47495182684350157d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7170214419196311d, y: 0.9010056352798679d), radius: 0.1794510317065917d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7437252671170167d, y: 0.31705820653507577d), radius: 0.5437957747223116d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8112467689947096d, y: 0.9870923464478539d), radius: 0.06683523104135214d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07473250084124294d, y: 0.9532539741241707d), radius: 0.0029776918109147843d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4835421742561984d, y: 0.0769767385517639d), radius: 0.11927341238455624d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.018471579456182385d, y: 0.5734140169883347d), radius: 0.25690925383514795d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3408981787988772d, y: 0.0221992978583192d), radius: 0.3335259080606099d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8729034342270685d, y: 0.08415297917881692d), radius: 0.6398139649826851d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18307553786742026d, y: 0.843665493166875d), radius: 0.712965085434483d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9944680515279207d, y: 0.3416000870766769d), radius: 0.6760856364236334d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6497677094575544d, y: 0.07594202460222155d), radius: 0.7767539643665387d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6555071047464268d, y: 0.7214555086893656d), radius: 0.9107935714066202d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.266628215821601d, y: 0.6383866165663269d), radius: 0.013789018036752143d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06480910821195551d, y: 0.5432782485069843d), radius: 0.727769754336248d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.006391325083801802d, y: 0.9914721766276571d), radius: 0.5243577651727459d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37983518051509757d, y: 0.383281758013966d), radius: 0.24351582520830162d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4609477112112653d, y: 0.46184171952303776d), radius: 0.03032292204906928d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4361399229713592d, y: 0.3062237633218401d), radius: 0.3262000043533385d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4586374975642947d, y: 0.2524123379068033d), radius: 0.766261958852628d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6511105536747616d, y: 0.803358216353398d), radius: 0.044240108993846006d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3045140729136919d, y: 0.6137466822753626d), radius: 0.7596487893814449d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29453139867631906d, y: 0.5349561828061927d), radius: 0.03147219794140099d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5077510320341578d, y: 0.43220489469477186d), radius: 0.2892527907226924d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17508025537548455d, y: 0.5807037582300041d), radius: 0.3829995503318856d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9635440434275798d, y: 0.4824521778295848d), radius: 0.31321685295429424d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.802662187822945d, y: 0.1851407569293665d), radius: 0.7520084204609849d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7406225442294706d, y: 0.544033472008304d), radius: 0.9335661351080033d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8819564484771912d, y: 0.5594235436390229d), radius: 0.2594559522756593d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4382652165937575d, y: 0.1241084302801736d), radius: 0.5394697811340129d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47043474929978524d, y: 0.252108398553774d), radius: 0.4501585642062109d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6900144272546106d, y: 0.5911919531281733d), radius: 0.024630807773082575d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.006860438432870208d, y: 0.028028889389474454d), radius: 0.4995183088246147d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47706054871541403d, y: 0.747033580431315d), radius: 0.05545005951731696d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09273599468262161d, y: 0.564624951281326d), radius: 0.9180578372376006d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49722253999642574d, y: 0.15395077863209716d), radius: 0.16152654009630596d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7980138261008658d, y: 0.6652478879000625d), radius: 0.4412453712220943d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7218033100413647d, y: 0.3833536150926896d), radius: 0.23685292355588639d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7933364692604865d, y: 0.9806248036227018d), radius: 0.4115031366247084d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9507248395729682d, y: 0.41059590687286807d), radius: 0.3304205582465052d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8024431846181957d, y: 0.8058799412383537d), radius: 0.7474714768838914d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5187492527378643d, y: 0.6077575079661516d), radius: 0.8669167717035311d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6592629085492999d, y: 0.5487447227728625d), radius: 0.9130425442035741d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30081769249511214d, y: 0.8617680578312907d), radius: 0.16053245942146877d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3322488942253473d, y: 0.13946952730643092d), radius: 0.9648673837530035d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6707050506260113d, y: 0.3961151496856844d), radius: 0.2791328186318719d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.606965167919056d, y: 0.4461201168718655d), radius: 0.6745420712218978d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1518970629092986d, y: 0.4547729620840095d), radius: 0.572796897044648d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0052097397523520605d, y: 0.6677060559198977d), radius: 0.18785495703993882d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9792902706856793d, y: 0.4526437315148034d), radius: 0.24582948492692192d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18840451538494918d, y: 0.21663174667307628d), radius: 0.7044455727868891d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9048231306816834d, y: 0.7128125692034555d), radius: 0.6296520651222378d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7065444690541107d, y: 0.7689489848546289d), radius: 0.5537065376211765d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20955326285527087d, y: 0.49114299960302865d), radius: 0.6580344177439967d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43103331769045705d, y: 0.9209321341309566d), radius: 0.3254677139993992d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9759967395754039d, y: 0.4526659120466874d), radius: 0.994624980503982d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8124595859522168d, y: 0.44366227329030605d), radius: 0.8457787524247097d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.63611210473635d, y: 0.3478031755977107d), radius: 0.0587380012047779d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7038269597255999d, y: 0.6052380918769621d), radius: 0.16382528602876356d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26648293554717195d, y: 0.23111532556297443d), radius: 0.5892881438687577d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9214661126062647d, y: 0.8303791067532816d), radius: 0.5609030863215351d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.698597471830441d, y: 0.3601378769450142d), radius: 0.4921043712026639d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10684718793605541d, y: 0.472711620676854d), radius: 0.47564204841861646d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22706887298719913d, y: 0.3139716152021984d), radius: 0.3868911617420341d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5664172168138986d, y: 0.28317122620277013d), radius: 0.02609802702867625d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16380578748611552d, y: 0.6030079517648196d), radius: 0.354154872359118d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31577933404494385d, y: 0.6566626630374113d), radius: 0.9802574594586758d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15453344693191062d, y: 0.3606403547198267d), radius: 0.3689521624701211d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6497882287970592d, y: 0.6496998911081419d), radius: 0.42771833160231065d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5231856893699061d, y: 0.8749119741629402d), radius: 0.5110490404825093d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9726630179755894d, y: 0.989626967116093d), radius: 0.15509987160904104d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6775773647787664d, y: 0.011379669486399457d), radius: 0.9253758237063373d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8073026984173266d, y: 0.15176307590204108d), radius: 0.5807730331772555d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2563596031991976d, y: 0.0011850203957748384d), radius: 0.5403370791077892d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24717681644735512d, y: 0.4763866774779686d), radius: 0.24711833440459308d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7553008935555008d, y: 0.003544882074719702d), radius: 0.26250796125047193d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6522889584652144d, y: 0.042098204796180205d), radius: 0.14622773196117822d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.618768580178774d, y: 0.6541627038751392d), radius: 0.22590140661657987d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.688575717196812d, y: 0.23831708387803396d), radius: 0.3035912311652169d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8697002353234842d, y: 0.6188542756852558d), radius: 0.24283041638726788d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8224505171213615d, y: 0.45533272955160187d), radius: 0.719029431183321d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6208861267732463d, y: 0.3961494215939486d), radius: 0.4192626730582658d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7454219818845399d, y: 0.8354362842337614d), radius: 0.8233185123453166d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12348996345650631d, y: 0.4954423912310272d), radius: 0.3402023121509947d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19991513291030294d, y: 0.05589474723775889d), radius: 0.9290861272850196d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9125373301262417d, y: 0.36679007710174016d), radius: 0.4292622904778268d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12888308073132715d, y: 0.7666884565651458d), radius: 0.5608403277508351d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6603676111166343d, y: 0.15987077253220572d), radius: 0.4642005927713748d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4579216902574541d, y: 0.8130798151226072d), radius: 0.2131811471797601d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7891996905285331d, y: 0.28615469759552414d), radius: 0.6062188206230735d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7733301698163413d, y: 0.7701561597760643d), radius: 0.3547946170871318d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8499826028259224d, y: 0.24657941817546924d), radius: 0.1242780401186061d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15075947947661572d, y: 0.7656713133217367d), radius: 0.17624493233297844d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8491021960408385d, y: 0.848352690688846d), radius: 0.548235273571794d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3275535186245634d, y: 0.504140326922435d), radius: 0.7020444291247064d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39442083091979263d, y: 0.2612009498508837d), radius: 0.24077140371056727d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5233149785278414d, y: 0.47044913431246593d), radius: 0.8342877485379465d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8737955702207689d, y: 0.8171108501339797d), radius: 0.6788697496475253d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04085763438270573d, y: 0.6368214598717119d), radius: 0.09136504178536797d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7615935491637806d, y: 0.7897785979484293d), radius: 0.8763060825981267d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22115348065325846d, y: 0.25771349518451403d), radius: 0.9180862668782942d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9298411109965976d, y: 0.32811391835494985d), radius: 0.8742568389487632d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04151094576403125d, y: 0.902594280622463d), radius: 0.12636541156531866d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47696608601069224d, y: 0.3046360178043581d), radius: 0.11277822734456178d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5169940609815996d, y: 0.47375999026991d), radius: 0.30702909363178366d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9992946730660699d, y: 0.794836887837419d), radius: 0.3012795118681343d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02463963212278908d, y: 0.9222521832682774d), radius: 0.42360270182965676d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29381274084644005d, y: 0.5475869271284786d), radius: 0.2322492018419713d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.150767477690677d, y: 0.8546574608784704d), radius: 0.41394273834621753d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5049339490688707d, y: 0.9575858332654982d), radius: 0.12611599573129695d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19059016189437705d, y: 0.7831451639518393d), radius: 0.7115819316005155d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6149143346846477d, y: 0.707674674128882d), radius: 0.3180959748058356d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007918754479449341d, y: 0.14815773416064715d), radius: 0.7642354659364868d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2288799328754636d, y: 0.7693613174643619d), radius: 0.49492490728269767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46316368468705515d, y: 0.4367033499028068d), radius: 0.3384579894210413d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7205490861192957d, y: 0.696608777512147d), radius: 0.8601036007935826d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3588244123200828d, y: 0.7015963072901886d), radius: 0.060016612533552505d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41368580677071365d, y: 0.794102159698889d), radius: 0.6018099997625045d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1452919659652374d, y: 0.972946082009635d), radius: 0.39730676308852264d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6089897748949628d, y: 0.06741115515002094d), radius: 0.0913302497420041d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37116630166939124d, y: 0.3145730254794793d), radius: 0.31470236056794043d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46514065154628814d, y: 0.8942467820597227d), radius: 0.35925268764124607d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8173173163581449d, y: 0.6143232596202403d), radius: 0.705484883790167d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06475880379938426d, y: 0.012653444776804745d), radius: 0.9309783500792254d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33067643007051284d, y: 0.474312442793269d), radius: 0.2979313074475588d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7015920161542145d, y: 0.567165512653081d), radius: 0.5206160930277094d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3107476083651045d, y: 0.1969461040673024d), radius: 0.31289653710590126d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9983781332935264d, y: 0.6842481795677045d), radius: 0.9503945860758536d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2072511849901849d, y: 0.41603938500950377d), radius: 0.34010313006204984d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1183146209436261d, y: 0.5973072204482198d), radius: 0.363636293069862d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6594687574489873d, y: 0.5478712776509427d), radius: 0.39381543399757324d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9583541443071383d, y: 0.12439664323942023d), radius: 0.345709064318358d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.741883402120166d, y: 0.9872970396500516d), radius: 0.1500916786263875d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40651144206025225d, y: 0.31812233908460985d), radius: 0.6957382056429294d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2974787948451688d, y: 0.7588808375483902d), radius: 0.12926406701651116d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40703008193634926d, y: 0.9696669241731163d), radius: 0.9835101624892881d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9852359536990805d, y: 0.13927386104518136d), radius: 0.8403300193403246d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8970172282798784d, y: 0.8685008556370164d), radius: 0.6743718612946027d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19326740909681672d, y: 0.2041296003362013d), radius: 0.7295186566218135d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.645385772004229d, y: 0.8679482822312364d), radius: 0.49632374419918346d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12676369053286762d, y: 0.5175112326736514d), radius: 0.7625258829743575d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4894065852059615d, y: 0.5954558264342875d), radius: 0.6601784561620108d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.997706666122944d, y: 0.8183911761013063d), radius: 0.6141055800699581d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5683713647189044d, y: 0.41466279287594554d), radius: 0.26516558784904853d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4822426597655308d, y: 0.2525883984344025d), radius: 0.9856456433193037d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6536547341826825d, y: 0.064943064438851d), radius: 0.775316227717603d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5496874947684846d, y: 0.5586274522889688d), radius: 0.7649219396276011d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5132025699997528d, y: 0.5431903158564734d), radius: 0.7212394675343388d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15798979046759487d, y: 0.2054495594945932d), radius: 0.629930037738555d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8240309054253285d, y: 0.33163539671550923d), radius: 0.9017743161726841d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15473491591474509d, y: 0.2625843849499655d), radius: 0.7062033148207991d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4730447595196664d, y: 0.35855535694305807d), radius: 0.4090098946531584d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33434104637313045d, y: 0.10400725152619117d), radius: 0.8806656536602098d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6027166624932587d, y: 0.2070341503579579d), radius: 0.049887085601920234d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7067306211913548d, y: 0.18704452881654932d), radius: 0.016578579480126643d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5830564421919601d, y: 0.011700824525307407d), radius: 0.5599281923726274d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7298353181912609d, y: 0.7383377658853965d), radius: 0.11531140911863391d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32425860560865793d, y: 0.19123289944147437d), radius: 0.25285712010172745d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24607102937226666d, y: 0.13089690407699128d), radius: 0.460936879548023d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7007430228277035d, y: 0.6881385135563222d), radius: 0.25636728335033665d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03876382550234825d, y: 0.3610740737769472d), radius: 0.3195721070984866d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9301047496051783d, y: 0.3203036530151422d), radius: 0.31321838346038966d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7559504933356953d, y: 0.6703131571121805d), radius: 0.2802801609516202d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6660217669075295d, y: 0.3227850928384738d), radius: 0.7087453669525111d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7273108786301463d, y: 0.4928595083211563d), radius: 0.2299387568965242d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8761240730253684d, y: 0.709588878232575d), radius: 0.5575292317305083d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9241755556408742d, y: 0.30968858317712433d), radius: 0.9699498758105107d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.646101324323469d, y: 0.35751941065004367d), radius: 0.13305392438174435d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28552155694001646d, y: 0.552370013373512d), radius: 0.06013312960262618d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25278396241222223d, y: 0.432016895238888d), radius: 0.6753412006818496d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9731414342802114d, y: 0.1952007405049424d), radius: 0.30233036383353284d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38601302412511973d, y: 0.12379181192980959d), radius: 0.8074001761284806d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13517550888713925d, y: 0.07302608970541868d), radius: 0.5972720383021491d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5412925254560194d, y: 0.7803083053637917d), radius: 0.6085833143528481d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.999161117491914d, y: 0.6740492564313323d), radius: 0.39227109169898d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6000014024714597d, y: 0.7447311781012891d), radius: 0.2033084603271793d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30293431204205135d, y: 0.522529185518201d), radius: 0.3061135299652995d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0901875949369999d, y: 0.29391081817229137d), radius: 0.1486273249932647d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8452622250784206d, y: 0.17715533773609038d), radius: 0.7382846775305552d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8343836119319689d, y: 0.39748456764087503d), radius: 0.19938835674798394d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9541291125109199d, y: 0.507424827124204d), radius: 0.4383095079265561d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2751709393969781d, y: 0.6216994959394727d), radius: 0.14644946226852362d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6663218805565944d, y: 0.8947773785102189d), radius: 0.5190732648448866d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5020078864924566d, y: 0.28606428233210335d), radius: 0.112558381127988d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2911525179521268d, y: 0.03862389404140609d), radius: 0.878703579758888d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35557262415966495d, y: 0.6542101021062134d), radius: 0.8319061118816942d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9369165098072637d, y: 0.020344833429934983d), radius: 0.8219861607271928d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38007212845613003d, y: 0.7525140980178325d), radius: 0.4312186252935629d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16725585031575063d, y: 0.5669877528059281d), radius: 0.6434922275093109d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7230603346671319d, y: 0.5838473701883519d), radius: 0.5850702317196211d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7935728412379918d, y: 0.3382812661291429d), radius: 0.013698889058572972d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09830760834485808d, y: 0.46259637652645735d), radius: 0.16603004336158855d),
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
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22733202793532337d, y: 0.3862334881836428d), radius: 0.10580762521942122d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5221054893798278d, y: 0.23705781366149792d), radius: 0.2890818600014835d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02742112807226904d, y: 0.018027140515456286d), radius: 0.9513695708393611d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9272556749846128d, y: 0.44489944930994485d), radius: 0.5512549556239508d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22673616807819807d, y: 0.5624156676603141d), radius: 0.8885040260301659d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12349419355794333d, y: 0.5389249164807144d), radius: 0.2314585312711961d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1404086977075969d, y: 0.5423217927041865d), radius: 0.4874046687024278d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.140722203587476d, y: 0.1938919926946171d), radius: 0.4854700811527315d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9556544492128634d, y: 0.35998330858565375d), radius: 0.8191944183777438d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8578208316338836d, y: 0.8377135363657449d), radius: 0.47495182684350157d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7170214419196311d, y: 0.9010056352798679d), radius: 0.1794510317065917d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4609477112112653d, y: 0.46184171952303776d), radius: 0.03032292204906928d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4361399229713592d, y: 0.3062237633218401d), radius: 0.3262000043533385d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4586374975642947d, y: 0.2524123379068033d), radius: 0.766261958852628d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6511105536747616d, y: 0.803358216353398d), radius: 0.044240108993846006d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9635440434275798d, y: 0.4824521778295848d), radius: 0.31321685295429424d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.802662187822945d, y: 0.1851407569293665d), radius: 0.7520084204609849d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7406225442294706d, y: 0.544033472008304d), radius: 0.9335661351080033d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8819564484771912d, y: 0.5594235436390229d), radius: 0.2594559522756593d),
}));
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8024431846181957d, y: 0.8058799412383537d), radius: 0.7474714768838914d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5187492527378643d, y: 0.6077575079661516d), radius: 0.8669167717035311d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6592629085492999d, y: 0.5487447227728625d), radius: 0.9130425442035741d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30081769249511214d, y: 0.8617680578312907d), radius: 0.16053245942146877d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 59;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[29], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 73, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 83, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 111, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 71, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 87, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 3, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 77, query1, 78, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 77, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 20, 78))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[29], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 22, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[29], false);
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
                await using var cmd = await ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[29], false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray1m m
LEFT JOIN public.binary_npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray1M>(15);

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
                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

