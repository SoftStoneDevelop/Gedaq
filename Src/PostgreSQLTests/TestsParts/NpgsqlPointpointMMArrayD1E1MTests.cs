

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
    internal partial interface INpgsqlPointMArraypointMMArrayD1
    {
    }
    
    internal partial class NpgsqlPointMArraypointMMArrayD1 : INpgsqlPointMArraypointMMArrayD1
    {


#region TestData

        private readonly NpgsqlPointpointMMArrayD1E1M[] _testData = new NpgsqlPointpointMMArrayD1E1M[]
        {
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2049359553349095d, y: 0.507887911602506d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4850196454873721d, y: 0.7783030725017231d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07355594704259882d, y: 0.5134662953176469d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31367537738547424d, y: 0.498674393892905d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8371955355871641d, y: 0.7560246582062998d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26897170615387134d, y: 0.5286598103334028d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9099523631378302d, y: 0.5782115506932247d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4348617844591103d, y: 0.5225492962435473d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.304047747031693d, y: 0.23389329998322306d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5778234770399017d, y: 0.868610976395063d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8841948197928872d, y: 0.9773916480824351d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4739515887738618d, y: 0.2682547260231627d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41611239055660776d, y: 0.22006252669059456d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4693634674989928d, y: 0.3213860528900687d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6343427942967533d, y: 0.5702588796819954d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7714635854244358d, y: 0.7896876687855111d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3416827012528386d, y: 0.870031149881773d),
new NpgsqlTypes.NpgsqlPoint(x: 0.93860953720312d, y: 0.5799369565682051d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2538078975035809d, y: 0.32278211777803356d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9290875971083034d, y: 0.9451175038658881d),
new NpgsqlTypes.NpgsqlPoint(x: 0.384392984950796d, y: 0.816968856314431d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3101765670538237d, y: 0.0014149837316430602d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3375231685985326d, y: 0.16310715508578233d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.214408012932637d, y: 0.7855497846691488d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8798064125058276d, y: 0.38866413867622873d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5493899545789241d, y: 0.31615525136262734d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22322630515364283d, y: 0.7581022162183257d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9922790329669673d, y: 0.6099780076849288d),
new NpgsqlTypes.NpgsqlPoint(x: 0.788933297955036d, y: 0.34756880459823314d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05768270811734899d, y: 0.5931873038659031d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4512358451851822d, y: 0.11170217274105332d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25467277280509926d, y: 0.38919799768536667d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7702085988997666d, y: 0.20244467995803916d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2763266418428165d, y: 0.2005905267646566d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45204688534485216d, y: 0.17947150285807179d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8678180418938176d, y: 0.6928724381750404d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6139828306864944d, y: 0.9324059393203162d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24985870984656366d, y: 0.2905731620132953d),
new NpgsqlTypes.NpgsqlPoint(x: 0.037385875593428985d, y: 0.2761658411110759d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1652951742271569d, y: 0.17686430977654766d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5992518467244338d, y: 0.5252105509702217d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06566006399644198d, y: 0.30073934438420313d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7383535209493278d, y: 0.15681598165041055d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4995378052120185d, y: 0.926836166892841d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9089445907049425d, y: 0.15382902828192047d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07625375469614426d, y: 0.7253434558870198d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5223153032809233d, y: 0.6416786396507662d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5872077171977239d, y: 0.05945170995449045d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5674613430858685d, y: 0.41172256779787164d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17669667207065853d, y: 0.5748573867341356d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37839548120576083d, y: 0.5280906196822966d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3348109974120197d, y: 0.3667151423714744d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5509469196784994d, y: 0.5889065662330832d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39740276441877076d, y: 0.08048188864214934d),
new NpgsqlTypes.NpgsqlPoint(x: 0.992945200007936d, y: 0.07263579806401188d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7627829737187588d, y: 0.03208164773825661d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9113756229373817d, y: 0.10274715780923105d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7795630116059525d, y: 0.029830048897743544d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7453134230044716d, y: 0.5250995570966194d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5391298569976957d, y: 0.1991049942284262d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3072885666161268d, y: 0.038155491979648515d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6388810332527364d, y: 0.5973680629069579d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6269151952784828d, y: 0.517400145033035d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8850903832806124d, y: 0.8239379000066664d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40284526713020985d, y: 0.8035817664159336d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9359808612582161d, y: 0.8264531916291438d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6385122023264002d, y: 0.2598113920047491d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25285899460693473d, y: 0.8018900929010779d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8388812796915193d, y: 0.5369307745363913d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7515800596630142d, y: 0.9493657198599585d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3021352762618975d, y: 0.011830426732256538d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4433904111528849d, y: 0.5918057267485107d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6977525759825574d, y: 0.2610411274421034d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45328817859626513d, y: 0.6875410722623577d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8763080300181608d, y: 0.6934893560217176d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26661148857296557d, y: 0.9074875862691895d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47987288173971177d, y: 0.4085187255489362d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6507096746229325d, y: 0.27949712439614516d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06403321338066248d, y: 0.6930146854283783d),
new NpgsqlTypes.NpgsqlPoint(x: 0.567226985298847d, y: 0.6278529964875709d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063045308225312d, y: 0.8223435632900721d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2406517904670128d, y: 0.11865823536326892d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10183406739739442d, y: 0.6503495448964444d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24119095608965213d, y: 0.27057864423726785d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30282959834612133d, y: 0.26541704096088703d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3560008516128471d, y: 0.9828421363392117d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12183777492473491d, y: 0.6782978615264885d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3912792552543307d, y: 0.8044778201083416d),
new NpgsqlTypes.NpgsqlPoint(x: 0.030138369226667572d, y: 0.6710580680737562d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9736740029455424d, y: 0.11763625327979221d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34846597057993434d, y: 0.6191932707818668d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22910000256537666d, y: 0.07391128242252709d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15112969329784975d, y: 0.4448189943198516d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8226468750438272d, y: 0.7057164821108535d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7817192608812837d, y: 0.29716918637263856d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13430949601462516d, y: 0.7554226575615456d),
new NpgsqlTypes.NpgsqlPoint(x: 0.054806220021824004d, y: 0.5795005493612445d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3775186988751913d, y: 0.5910094256019625d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2797499250376051d, y: 0.3529008263828972d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25942875492392903d, y: 0.19454686298130963d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23749565456063604d, y: 0.9437324150871204d),
new NpgsqlTypes.NpgsqlPoint(x: 0.034626791709209126d, y: 0.5952557175333058d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7631073116085353d, y: 0.9659270254544498d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7960138889892884d, y: 0.20207008007034144d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5433156464532486d, y: 0.02790398646636283d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1486823798204211d, y: 0.3183741261110341d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35428168471917754d, y: 0.8503942240269189d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7349174326630559d, y: 0.9422606082617914d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10936458888262945d, y: 0.1877438771578792d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2995422911513079d, y: 0.49963078429332775d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1368998411608079d, y: 0.04701275710210495d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4390721075651568d, y: 0.2815054162982522d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5615883882924362d, y: 0.5619261244390833d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5354229403212085d, y: 0.526897094966874d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5121585041385911d, y: 0.44689449395729564d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2849456551415446d, y: 0.17309402607500357d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49960826181271634d, y: 0.7084621523049802d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19800308038639436d, y: 0.07132410852428483d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6113672504421996d, y: 0.08565500941484572d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3435107403266445d, y: 0.97717042884052d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08274030665352672d, y: 0.43417516647855614d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3592613502571861d, y: 0.28348341009978084d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9986662563074804d, y: 0.5822042771173465d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04517155719140176d, y: 0.614402667191907d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3496519464746066d, y: 0.5011132935866677d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8439057902054294d, y: 0.5021185419664181d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08123283153989136d, y: 0.2033735432169086d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4538671149775263d, y: 0.4080612258439017d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32071715533886025d, y: 0.1326128711190967d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08671828180252639d, y: 0.5844672938299822d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26706572122606675d, y: 0.5479686816213645d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3233280599984901d, y: 0.7224032040250395d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17148256008639995d, y: 0.5114483382806128d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8058700426144937d, y: 0.6291721919440131d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4835732848505945d, y: 0.09670999686571202d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7511359759605207d, y: 0.9836952772020711d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8084357923861271d, y: 0.7991381885858148d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03093876097189774d, y: 0.126661280266532d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6379833127844217d, y: 0.1183893972906549d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6344924707164186d, y: 0.8310676078424845d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9601885949252055d, y: 0.15433130253994387d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25686472038010266d, y: 0.9397872600806264d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7238504453413018d, y: 0.29898082392546876d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09257020989324227d, y: 0.9696007085328489d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24379771641105097d, y: 0.8392718774511505d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6009828943129103d, y: 0.9628969766750529d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5419661892293228d, y: 0.8290918255299383d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13414725182759168d, y: 0.7130932897320513d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8786836961055938d, y: 0.9601244783220438d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9564666731142893d, y: 0.7805571643493486d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11154751144253183d, y: 0.71602372639059d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7793888878360912d, y: 0.9976402618081308d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7232567223618716d, y: 0.9632517499920338d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13883943095161244d, y: 0.22243989398390218d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32903648980478173d, y: 0.8946575412543483d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8414875788195862d, y: 0.6604162446688023d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38641971203754255d, y: 0.896914379841211d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47613163276110404d, y: 0.1257206693851609d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7554254546686789d, y: 0.8998829676284882d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40167421273996207d, y: 0.29298290865734355d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8628158175041929d, y: 0.45236221256639453d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3340819640441851d, y: 0.2765139892002145d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2618817021181563d, y: 0.45410391416260054d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3742020838556338d, y: 0.5365568523172474d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30916059087723324d, y: 0.1918160151971856d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6733715887996368d, y: 0.7101350089247553d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3204931016659647d, y: 0.7580414559746769d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6593239933996622d, y: 0.6631063519287538d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7141219391183028d, y: 0.27848767564052357d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6152443821059813d, y: 0.7430551412279475d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32537555029543574d, y: 0.3928656395149921d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6297617348239628d, y: 0.7489320739060071d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8352895468867214d, y: 0.14154847148980587d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17182933971267467d, y: 0.9406162093173717d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9495270056328142d, y: 0.7326004508812946d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11630436826068113d, y: 0.22973501563816057d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1573698770097257d, y: 0.6490992101060734d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5446749565436955d, y: 0.952199088878937d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7145050233227949d, y: 0.03841016052349833d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9077211807488782d, y: 0.08717112577487884d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9253321973150616d, y: 0.04008636657566644d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5548357683418532d, y: 0.3329176496352584d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9181318586921625d, y: 0.7248882066833158d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0994703201414775d, y: 0.03566476396818685d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8860779401043903d, y: 0.6051512863240083d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5660826702591947d, y: 0.9689903869758056d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8257045218517616d, y: 0.17218390093778102d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1464758691404605d, y: 0.45836724649549754d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0076151959168631045d, y: 0.8835492212503692d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20105230598907542d, y: 0.9322759491276188d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5460665828413733d, y: 0.11455416825446019d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5525345272194525d, y: 0.6249244890653657d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4920956246590589d, y: 0.297707688425755d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34391408709761795d, y: 0.39076113049968986d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29333657555396087d, y: 0.7533890997565446d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22605779738523024d, y: 0.7967574974094823d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08464581401685156d, y: 0.08762073009229066d),
new NpgsqlTypes.NpgsqlPoint(x: 0.406288649614017d, y: 0.9780546821052168d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8147021902025374d, y: 0.5786768122355623d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43841042387469986d, y: 0.85979228226057d),
new NpgsqlTypes.NpgsqlPoint(x: 0.015391217051078487d, y: 0.5014163509688214d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4568462586509364d, y: 0.16400715610249939d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6656542412167124d, y: 0.8708898634565334d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10860698409928826d, y: 0.712341388884782d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6151731863614395d, y: 0.2111656341151249d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5524186880616015d, y: 0.9274959199970004d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9443624214673484d, y: 0.690847134511968d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4713123473495383d, y: 0.34564320092586864d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1845029829719017d, y: 0.4155033644908235d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11565837638188992d, y: 0.8287867181205726d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3200099066428225d, y: 0.4106058683768733d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7143921533256277d, y: 0.48458378826749027d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9420274266881651d, y: 0.448980345955046d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7905503578874545d, y: 0.13856653456692103d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8637865194252194d, y: 0.466869727905596d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12868879048876014d, y: 0.18511584280517335d),
new NpgsqlTypes.NpgsqlPoint(x: 0.003575172260588899d, y: 0.16404195228635654d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05987388337939603d, y: 0.6779407633089478d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6365272834924147d, y: 0.9745385490078599d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31547268210952084d, y: 0.15986379960354347d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4532150710464148d, y: 0.15042113919529376d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8033540660358468d, y: 0.2887175029084196d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4158790472839886d, y: 0.45383517187019706d),
new NpgsqlTypes.NpgsqlPoint(x: 0.59510401030605d, y: 0.3118957007522627d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14466939872215878d, y: 0.22535807701629385d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8960155998904128d, y: 0.3916266676675024d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07690913424751555d, y: 0.38702456646336547d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3311654191374289d, y: 0.8562199677183283d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7110076413770392d, y: 0.27821855260074224d),
new NpgsqlTypes.NpgsqlPoint(x: 0.771883122340238d, y: 0.13946163432668368d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4236493617750965d, y: 0.16906000124250053d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6989777337122438d, y: 0.3892153635701945d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5444511194172716d, y: 0.01998349778872688d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5690300384065159d, y: 0.5312966426625222d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4517902995253732d, y: 0.8119160045677578d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2860499410678756d, y: 0.7496579104202148d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9018855961219604d, y: 0.9961656700400493d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5636102667217148d, y: 0.628573785101447d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08163107698772698d, y: 0.955685855537378d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9700970262753174d, y: 0.5937250045885308d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8979664961100983d, y: 0.3142956857992487d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05043635116956213d, y: 0.7069850771071842d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28749052565632705d, y: 0.6036768104593576d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5059661667303244d, y: 0.24547372589800742d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6703698778971002d, y: 0.09564909074056327d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7709203485627371d, y: 0.334325700318699d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14530374559986292d, y: 0.7909078309338609d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9554693114908888d, y: 0.2895465372566033d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0505456870710973d, y: 0.5948547042615413d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4738353438538373d, y: 0.7006321782113061d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26328630998353986d, y: 0.9402413212680379d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6242510222783193d, y: 0.20727282539035186d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10776421321984575d, y: 0.6027461613733682d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6469799898827612d, y: 0.7460303448427488d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7434442348967164d, y: 0.04792391123875617d),
new NpgsqlTypes.NpgsqlPoint(x: 0.662926514655941d, y: 0.6623132649120946d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5003277161267061d, y: 0.15968589517949827d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14507488830866344d, y: 0.5252305342096518d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7513607702295236d, y: 0.08023096518093542d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2864236673863576d, y: 0.11198156355930611d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5536637941090036d, y: 0.9440855551846344d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9859967843800492d, y: 0.3121391403402556d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4927976054744727d, y: 0.8366574184711867d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3006103951532949d, y: 0.852194219830803d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4595392097745141d, y: 0.7703005730869045d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8720710165375619d, y: 0.9511363916832097d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9840298515389356d, y: 0.10607862653895883d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5184020595690195d, y: 0.47555140001533536d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5961589857494094d, y: 0.7833125704197356d),
new NpgsqlTypes.NpgsqlPoint(x: 0.473037657794d, y: 0.4370425059800186d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5461543959590145d, y: 0.879099979527178d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7768961912008656d, y: 0.8785438846709118d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6004864676949873d, y: 0.16547098915676262d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6823507862300515d, y: 0.27186532834434773d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4223259738656219d, y: 0.6161870250478846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40919876162753266d, y: 0.8675973566400512d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2586253010737307d, y: 0.8722624072348539d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2843525406070304d, y: 0.6781702089635938d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8177174314921013d, y: 0.7364214041731726d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08686641028138542d, y: 0.5756589659339252d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37197917814917747d, y: 0.9996487600040876d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8753648746591658d, y: 0.40339601594663754d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8713533866997708d, y: 0.5873574649999657d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2256808931866222d, y: 0.17949797322853667d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07132363531565111d, y: 0.9141529746056144d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5770733633798595d, y: 0.8297793624233297d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.924495992864266d, y: 0.20348349250358555d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24031928132077918d, y: 0.8037320681791243d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8921221852983752d, y: 0.3118099527242175d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3878186655367907d, y: 0.412573228234423d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41481182251617854d, y: 0.7000212396358572d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15376542526872805d, y: 0.7798275206951132d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6882838277376973d, y: 0.767129666679413d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7699881700990648d, y: 0.7525245435925915d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1356768753298796d, y: 0.4648160605190922d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08930639461948153d, y: 0.7571616908325679d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7805345899908968d, y: 0.7067904174817685d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9039046253642421d, y: 0.46302346448208076d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18255332083394693d, y: 0.3295387230985649d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
INSERT INTO public.npgsqlpointpointmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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

                changedRows =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)), 
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
                methodParametrName: "npgsqlpointpointmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd1e1mi_id
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
    npgsqlpointpointmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2763266418428165d, y: 0.2005905267646566d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45204688534485216d, y: 0.17947150285807179d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8678180418938176d, y: 0.6928724381750404d),
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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5223153032809233d, y: 0.6416786396507662d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5872077171977239d, y: 0.05945170995449045d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5674613430858685d, y: 0.41172256779787164d),
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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6269151952784828d, y: 0.517400145033035d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8850903832806124d, y: 0.8239379000066664d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40284526713020985d, y: 0.8035817664159336d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd1e1mi_id
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
    npgsqlpointpointmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                methodParametrName: "npgsqlpointpointmmarrayd1e1mi_id", 
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
                nullable =  ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7515800596630142d, y: 0.9493657198599585d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3021352762618975d, y: 0.011830426732256538d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4433904111528849d, y: 0.5918057267485107d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6977525759825574d, y: 0.2610411274421034d),
}));
                nullable =  ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6063045308225312d, y: 0.8223435632900721d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2406517904670128d, y: 0.11865823536326892d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10183406739739442d, y: 0.6503495448964444d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24119095608965213d, y: 0.27057864423726785d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable = await ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3912792552543307d, y: 0.8044778201083416d),
new NpgsqlTypes.NpgsqlPoint(x: 0.030138369226667572d, y: 0.6710580680737562d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9736740029455424d, y: 0.11763625327979221d),
}));
                nullable = await ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3775186988751913d, y: 0.5910094256019625d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2797499250376051d, y: 0.3529008263828972d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25942875492392903d, y: 0.19454686298130963d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD1E1M> models = null;

                models =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD1E1M> models = null;

                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M), typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M), typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M), typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 148;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 170;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M), typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 148, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 154, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 128, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 74, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 37, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 141, query1, 163, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 37, query1, 141, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 28, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 128, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 98, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointMArraypointMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointMArraypointMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 129);
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointMArraypointMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointMArraypointMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models =  ((INpgsqlPointMArraypointMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
FROM public.binary_npgsqlpointpointmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
FROM public.binary_npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models =  ((INpgsqlPointMArraypointMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA), typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
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
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
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
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA), typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
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
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
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
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MI), typeof(NpgsqlPointpointMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MI>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MI>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA), typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

