

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
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6050425614417558d, y: 0.007675379116665715d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4179385636425611d, y: 0.2057257131536261d),
new NpgsqlTypes.NpgsqlPoint(x: 0.558363836408653d, y: 0.6448968915576888d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8399723332187083d, y: 0.35749203905579496d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9881009466845149d, y: 0.19982664470538636d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13083798849915063d, y: 0.2250420726710165d),
new NpgsqlTypes.NpgsqlPoint(x: 0.443047649090731d, y: 0.9251198519221308d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.010820167963692229d, y: 0.7730950857806975d),
new NpgsqlTypes.NpgsqlPoint(x: 0.008450839301516688d, y: 0.8907447494303626d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8840257901626273d, y: 0.4259036099074558d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04602512913360657d, y: 0.5132198783885487d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4064078494787786d, y: 0.7650088571635956d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5818800872984345d, y: 0.40794282939065174d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4071610591322722d, y: 0.8701616976774598d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03592132903587952d, y: 0.9004034168267593d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3485760480446862d, y: 0.3823536518504246d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9440597967291603d, y: 0.5592273238370696d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17451066822259276d, y: 0.6574667453271428d),
new NpgsqlTypes.NpgsqlPoint(x: 0.779210931795114d, y: 0.6528692050355509d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7191642259114664d, y: 0.19259150246945356d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06420910836139282d, y: 0.6806892683832669d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2773054039137771d, y: 0.5388442959951829d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6685035641923899d, y: 0.3453171594196759d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.052556524147482575d, y: 0.07934772975888393d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9078995582151903d, y: 0.08894691082806305d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30141831223179905d, y: 0.09027089057066395d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7860071584193864d, y: 0.6031665819681583d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7957331389827228d, y: 0.663125726343417d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3639517829589637d, y: 0.2339420989301645d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4564184582123496d, y: 0.4456535065454421d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23514647974644776d, y: 0.7875528240067531d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7998503694364476d, y: 0.9799316549529933d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47511089367717685d, y: 0.6459954931958831d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15652660836765242d, y: 0.1630476946850925d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5043566819004238d, y: 0.5638267395125068d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11574112895905253d, y: 0.7358519215896325d),
new NpgsqlTypes.NpgsqlPoint(x: 0.695319579234695d, y: 0.8998001284153921d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21340168146137162d, y: 0.24940707380602845d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8011197534120745d, y: 0.6710082575274815d),
new NpgsqlTypes.NpgsqlPoint(x: 0.053970785191480464d, y: 0.2822796250639703d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7343185084618972d, y: 0.5082893119862699d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07672382600587835d, y: 0.31547548098521283d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5217015772634849d, y: 0.1618412270404056d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7655724126915066d, y: 0.856318158512693d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15796810359425628d, y: 0.9356130838157641d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5186300430659174d, y: 0.6582252746762292d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7303050374732359d, y: 0.38170233553983424d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6067901517971495d, y: 0.5959449904495153d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09814559236547449d, y: 0.3408938495470194d),
new NpgsqlTypes.NpgsqlPoint(x: 0.006164478938455842d, y: 0.5210571855666144d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8106996753795547d, y: 0.3680581738886455d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33782910881080797d, y: 0.36474884290145637d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7589258203966572d, y: 0.0815285013925382d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8915500215114431d, y: 0.7164263989904261d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9051313324609891d, y: 0.46265506614032514d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7626532242289381d, y: 0.044554291704574256d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9825651265057621d, y: 0.6264025532574541d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6818692400346558d, y: 0.32537143974276905d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02040652217097816d, y: 0.9779861176039356d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7034944297200857d, y: 0.7899530007688419d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6601119559308053d, y: 0.8753724106772516d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44288808334590635d, y: 0.32104164469826024d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6473967198481531d, y: 0.46414341752814503d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.433900268759599d, y: 0.38018344758621114d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3016635199396607d, y: 0.201607298699659d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9192226914105232d, y: 0.6011568821632651d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9705844852083599d, y: 0.2940815978959529d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37958878482531944d, y: 0.9665867035779405d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6614792706946568d, y: 0.9091416606315592d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2533705146062436d, y: 0.8245244697914068d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2115950837133298d, y: 0.005274008988781276d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8382392566623356d, y: 0.25995383079352763d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7126283168935799d, y: 0.1916537664889837d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04095410064917637d, y: 0.594444896030763d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6027850560173993d, y: 0.332910733806709d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40474931666744784d, y: 0.9048259835713389d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49102112299187484d, y: 0.47438634592490414d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3018169717958826d, y: 0.8870327006197969d),
new NpgsqlTypes.NpgsqlPoint(x: 0.015578268667485684d, y: 0.4298787769645126d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7982238523721382d, y: 0.9082711802676486d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6773950773318161d, y: 0.6119100697470812d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8962801132502292d, y: 0.644329552127833d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32157134829181344d, y: 0.9915752100886895d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3183961822050285d, y: 0.7441404861181917d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12411369655528515d, y: 0.3968609956123459d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6908225772515404d, y: 0.28156653676049226d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24224733738816695d, y: 0.9665262325487308d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20790142622812657d, y: 0.4235446226113305d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7592796237836652d, y: 0.34108732233242867d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0009354793885328894d, y: 0.5135471843427851d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7520267865341965d, y: 0.6598150228820884d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8284235417566216d, y: 0.9491349213136713d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7583903569202667d, y: 0.2591298991215655d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07268670230738572d, y: 0.820150303241135d),
new NpgsqlTypes.NpgsqlPoint(x: 0.493219655426817d, y: 0.04767147557530316d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8518256028219158d, y: 0.004778746894357977d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3883204364359485d, y: 0.3836500834532306d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1391184758811399d, y: 0.9329963512412226d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.034205824915857774d, y: 0.11854262362369794d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4007622197970345d, y: 0.4976589824747145d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5443131440660296d, y: 0.534119338603074d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4612515785337489d, y: 0.8174764579087725d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5585556621696779d, y: 0.6194040702995586d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11979020646555494d, y: 0.8303186504608396d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2083822174886406d, y: 0.6333801151416546d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2585913409719752d, y: 0.3803636288210853d),
new NpgsqlTypes.NpgsqlPoint(x: 0.005085368014650982d, y: 0.7423140597041518d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15207025615518988d, y: 0.35109178698187393d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6777109692327513d, y: 0.11800383591159647d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9704759726737324d, y: 0.4939460640130964d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8915876403986893d, y: 0.5678927112419564d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9382365288160099d, y: 0.8357131400350764d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3975521669647436d, y: 0.5529176388609843d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9034188666427748d, y: 0.3115769203147549d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43009962720923445d, y: 0.9475085001333498d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6488228262080397d, y: 0.1532479250267258d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6656563043076944d, y: 0.9521293669155515d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7941943070182571d, y: 0.38042334790091037d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6168679091863862d, y: 0.8493838081669349d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48348903771309804d, y: 0.5528118218448729d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4801904751314757d, y: 0.6486445294656048d),
new NpgsqlTypes.NpgsqlPoint(x: 0.691435230929612d, y: 0.5983348636588931d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16333076755535092d, y: 0.8209447828093854d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5560658843504513d, y: 0.6286627651384086d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7549162194685245d, y: 0.4114838318863968d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1533908007448731d, y: 0.7915940622501628d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3201873759304539d, y: 0.2997231158680599d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06085623679792007d, y: 0.3877576239330017d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3060400232072529d, y: 0.11104294212292465d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.025174623289122455d, y: 0.6945694870103472d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7026822913756785d, y: 0.4927624319986512d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8100557872153885d, y: 0.31919356623048356d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7604240658628771d, y: 0.03730807509901357d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2972154141189022d, y: 0.130100093605088d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1824007741612751d, y: 0.2918439683121046d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20854366969454774d, y: 0.31842086556730853d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18744103453573036d, y: 0.1246302041898193d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7188458059313856d, y: 0.7836597107982648d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09649166287428357d, y: 0.20507066684627673d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02423934519758364d, y: 0.5728039172794035d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.687946105879789d, y: 0.6303110744221476d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7601311001163628d, y: 0.5859382152346527d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5263017439543474d, y: 0.8823446083415265d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.000870847008928699d, y: 0.41131775795528214d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0530534927259404d, y: 0.9140365209523027d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5426592695532133d, y: 0.7448780041782547d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13430097123315066d, y: 0.07699081330647961d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4277198600797496d, y: 0.6821311598080408d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9554084013841931d, y: 0.3599292668652403d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5209399919324609d, y: 0.22736667733754168d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3945899305846925d, y: 0.40126466150161577d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3304563973649848d, y: 0.8337083675104098d),
new NpgsqlTypes.NpgsqlPoint(x: 0.735534438255465d, y: 0.46879153790884076d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7689191818064034d, y: 0.4133513121837955d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7319004931768803d, y: 0.1377232208353707d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6900922939692044d, y: 0.33780374948580427d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6403840306768767d, y: 0.3502689592867331d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30400743567529764d, y: 0.08482190077310559d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7089008168336836d, y: 0.3055891336622806d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42464219051998464d, y: 0.6432234807976482d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27615058400575165d, y: 0.3171489947087349d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7099108217273635d, y: 0.022836811573744065d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45984700671673384d, y: 0.40523424939306374d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1256128188547323d, y: 0.01960236057775855d),
new NpgsqlTypes.NpgsqlPoint(x: 0.347073161159016d, y: 0.8391933630257302d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9026971483403848d, y: 0.6608208306689317d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6109288799405067d, y: 0.39258534474739937d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6144352422811238d, y: 0.08518846745859865d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5473998115258463d, y: 0.16888242807355636d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8254429678380674d, y: 0.6152612178734574d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3640007489397755d, y: 0.9970346146959885d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4324986303585725d, y: 0.08944620248987434d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7978208111205896d, y: 0.09326234731833616d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14262201832067023d, y: 0.638481336925208d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47788610732186343d, y: 0.7359515622681911d),
new NpgsqlTypes.NpgsqlPoint(x: 0.308657027234557d, y: 0.5472708503723167d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6880480168128665d, y: 0.5699186124298369d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6216799473060823d, y: 0.32790203861213496d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8979882026501046d, y: 0.7442469368752032d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7606636572712361d, y: 0.28288012175252764d),
new NpgsqlTypes.NpgsqlPoint(x: 0.793890713573267d, y: 0.36466929020564787d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5759103449757618d, y: 0.15905261285339356d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6770964278337919d, y: 0.9665010045099797d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7276683894042838d, y: 0.14924155185377086d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10060190797590562d, y: 0.9235050583161951d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8461984867713727d, y: 0.3322796755746029d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5012745955120788d, y: 0.8175203723436902d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1675831106884238d, y: 0.48807292654149026d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7401898822987281d, y: 0.8065844095994984d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22053588757412546d, y: 0.7411249579509648d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5656017193822582d, y: 0.02762233739060349d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3470167324782891d, y: 0.04458011036604226d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2947532080333455d, y: 0.4548954769811866d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7382611461675243d, y: 0.5952650227794423d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7854669379075192d, y: 0.44679577903809675d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4792729270115127d, y: 0.2433907651376237d),
new NpgsqlTypes.NpgsqlPoint(x: 0.708054130191981d, y: 0.9304715147522931d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6776436309319669d, y: 0.34145317399608777d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.26586736411206335d, y: 0.31220728141475096d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15210425783520898d, y: 0.6192711968273976d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5965488632693686d, y: 0.3217385736574454d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6360903083041181d, y: 0.7498055962037438d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38955331602249565d, y: 0.4013168987532213d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8359920064910109d, y: 0.1534708671055378d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8826741913068122d, y: 0.33181452032196856d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0771871833513299d, y: 0.7086925918760112d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4156035984909393d, y: 0.4579486072396345d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6146136771166858d, y: 0.3196331136540026d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27478451582865415d, y: 0.6667690872674541d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4679551507188435d, y: 0.6708177141615917d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7515525793943103d, y: 0.8534179320758065d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22977659555953978d, y: 0.04898383447053667d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6259424113802233d, y: 0.7823351921820344d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1436412114523059d, y: 0.04080872960985826d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7967878714012575d, y: 0.8615556429630705d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06930200864210834d, y: 0.4637571470235201d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.452144164356707d, y: 0.23636962701031938d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12521477649220847d, y: 0.4287556487679063d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8541241116571543d, y: 0.784044786579324d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18436892681725492d, y: 0.9385803145569201d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23810880977286997d, y: 0.26475306443094015d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02065334183181744d, y: 0.5149728779303012d),
},
},
    NullableValue = null,
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
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7957331389827228d, y: 0.663125726343417d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3639517829589637d, y: 0.2339420989301645d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4564184582123496d, y: 0.4456535065454421d),
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
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7343185084618972d, y: 0.5082893119862699d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07672382600587835d, y: 0.31547548098521283d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5217015772634849d, y: 0.1618412270404056d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7655724126915066d, y: 0.856318158512693d),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 13;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[29], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 94, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[29], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 125, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 125, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 41, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 116, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[29], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 54, query1, 38, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 38, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 19, query1, 91, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 30, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 70, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[29], false);
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
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[29], false);
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
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
        public  void DynQueryImportModelInnerTest()
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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1M>(15);

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
                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

