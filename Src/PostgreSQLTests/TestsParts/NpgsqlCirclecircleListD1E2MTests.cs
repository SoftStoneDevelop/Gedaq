

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
    internal partial interface INpgsqlCircleListcircleListD1
    {
    }
    
    internal partial class NpgsqlCircleListcircleListD1 : INpgsqlCircleListcircleListD1
    {


#region TestData

        private readonly NpgsqlCirclecircleListD1E2M[] _testData = new NpgsqlCirclecircleListD1E2M[]
        {
            new NpgsqlCirclecircleListD1E2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8067247876431615d, y: 0.6719619100902094d), radius: 0.07242741969619793d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08322075804596163d, y: 0.02312071608880817d), radius: 0.23663371273860756d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8747105622991664d, y: 0.5275088353708081d), radius: 0.6054743341242064d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0725267852101158d, y: 0.5409895293557693d), radius: 0.8015059519438615d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9818977550758988d, y: 0.9360441579913485d), radius: 0.35865829152867845d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9106748336466056d, y: 0.897884601687097d), radius: 0.3646862274951519d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4840172845310814d, y: 0.10237026340411182d), radius: 0.37274820575730105d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9464879973069351d, y: 0.7650760348738844d), radius: 0.30003673568036593d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14880458484578474d, y: 0.5677770333757385d), radius: 0.07221389991879246d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4377489144325494d, y: 0.3648091093379434d), radius: 0.5020806862546656d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26152472284277695d, y: 0.4087578704540411d), radius: 0.1375440596791827d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9771163321016638d, y: 0.11733382367259915d), radius: 0.47677630118998926d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35086559148206375d, y: 0.409915562941356d), radius: 0.5006877665742033d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5546533768751389d, y: 0.3828162628412862d), radius: 0.9598324715554559d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8876598093905684d, y: 0.2898181058390311d), radius: 0.5253661547629096d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09457443733832749d, y: 0.09510468932974447d), radius: 0.06187714927674004d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.621617871037914d, y: 0.6194743779757315d), radius: 0.9095515845363976d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03605640978513691d, y: 0.7924612972996783d), radius: 0.917112592400904d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17418559198688d, y: 0.3950454877897739d), radius: 0.40046744724331984d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34589293489630535d, y: 0.32631222691601214d), radius: 0.41319716440566134d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13616211156695412d, y: 0.6751847708037668d), radius: 0.6729520826600492d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32512934847064756d, y: 0.5110313794391811d), radius: 0.5258050983308804d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4107014504076254d, y: 0.046916786177049086d), radius: 0.8517618656427666d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11042637191536075d, y: 0.8183845234498031d), radius: 0.210270955266872d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4876657400213287d, y: 0.28172666950527325d), radius: 0.7045347666735666d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5664941853113103d, y: 0.03965949391690249d), radius: 0.8895402306651989d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3902053251143832d, y: 0.9267419643312947d), radius: 0.4830223896286704d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1260702129005472d, y: 0.1604620349954493d), radius: 0.9630973218130899d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49261595826019366d, y: 0.46724677254137637d), radius: 0.4140302860080731d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08752322831141435d, y: 0.9799263293179736d), radius: 0.5506925566335844d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1560458886976378d, y: 0.43087838786784016d), radius: 0.9145286055523096d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.294875707841861d, y: 0.5104071687826854d), radius: 0.5818639224073693d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06265111542401991d, y: 0.42335655447001763d), radius: 0.6946439545363311d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7652603161429248d, y: 0.1209954482922938d), radius: 0.9499089865992347d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37778680189461933d, y: 0.33731435599375825d), radius: 0.5473810615392061d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2691676155476249d, y: 0.14184060326380954d), radius: 0.0758920360733204d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.396150408529947d, y: 0.754811563503713d), radius: 0.07467238358630746d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7213064845614122d, y: 0.017850820969881775d), radius: 0.6584620724108793d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6703585602198814d, y: 0.06336874425387706d), radius: 0.9125210029021436d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6205878712598103d, y: 0.10811782802507586d), radius: 0.5481512833170413d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9138827986558197d, y: 0.6808377068914072d), radius: 0.765671595447183d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8092359379125652d, y: 0.1193604506652528d), radius: 0.9897772535227624d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8000082460253601d, y: 0.6373107262729308d), radius: 0.2816479545075863d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6873501283567106d, y: 0.4035662826070894d), radius: 0.9410111258353763d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8113258357863201d, y: 0.4855122798711423d), radius: 0.9970343144399603d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02334737387656638d, y: 0.38792599391010985d), radius: 0.9191930238751561d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5425864852093816d, y: 0.5968295661263132d), radius: 0.5253940314917176d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12933524784664285d, y: 0.8774739529333693d), radius: 0.2921800004678573d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9651283364766523d, y: 0.7801205335581984d), radius: 0.3986285844468095d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9660178977001258d, y: 0.3292881133501937d), radius: 0.5376603328545397d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7191902868107162d, y: 0.690863065673038d), radius: 0.07599031352520769d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47248075990512584d, y: 0.23422693526711869d), radius: 0.46122781250879397d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5172481870432277d, y: 0.5515731605149335d), radius: 0.786026816827509d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08259704212813446d, y: 0.2718593678141631d), radius: 0.028179891620946473d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6915010934327989d, y: 0.1431168409010093d), radius: 0.8006733728115809d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7578017510632999d, y: 0.5203458429234137d), radius: 0.4575378751279052d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07520849607840652d, y: 0.3634661017052898d), radius: 0.37994941131601134d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8649058010369984d, y: 0.606781679033241d), radius: 0.05346393438909047d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27768173352639114d, y: 0.7428074109777828d), radius: 0.9559512622773638d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18916056405557813d, y: 0.5540288743742678d), radius: 0.16276458502966373d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7499168781879539d, y: 0.6424616663087538d), radius: 0.09018759838547752d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9936097202927846d, y: 0.2208229425530407d), radius: 0.9183778362464243d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3859087422470806d, y: 0.5962929461730064d), radius: 0.6582610185343265d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9649131057858696d, y: 0.13768605424551172d), radius: 0.39337420618848895d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8305393225104309d, y: 0.48290291287035536d), radius: 0.7705244182103433d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9272271749685648d, y: 0.5778952580753225d), radius: 0.20456811562439614d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07819579142593869d, y: 0.2167184939807557d), radius: 0.9252725509337976d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7954983306294108d, y: 0.6516636944421377d), radius: 0.6330202541857715d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41186356510129296d, y: 0.33668965717745847d), radius: 0.7155291954965597d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5756531832192963d, y: 0.004631423444868332d), radius: 0.6640854078005954d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9541320603641803d, y: 0.1892445409901059d), radius: 0.8100871875440543d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7439833449769454d, y: 0.5198205794557332d), radius: 0.37789572325590726d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3408507191606869d, y: 0.6936362650969005d), radius: 0.7991450813671805d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1586790627230611d, y: 0.8768389493881806d), radius: 0.6899448925250483d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3888400311255594d, y: 0.9143310280196468d), radius: 0.4196463428358784d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8166672129526864d, y: 0.24651152853720248d), radius: 0.7143490991215288d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.055073874763998276d, y: 0.6852533639177059d), radius: 0.6913315668830671d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5909694641142035d, y: 0.22545057387187228d), radius: 0.7574487903396201d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9789962961585432d, y: 0.21152941793293445d), radius: 0.8340713209140805d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9476627654858523d, y: 0.3433382288160226d), radius: 0.5978439819940577d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11789571405017318d, y: 0.677106430178263d), radius: 0.18003020114202262d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7823195480213133d, y: 0.7070440805215803d), radius: 0.6001330853729544d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6741084080368223d, y: 0.275696854478656d), radius: 0.2949770646330231d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5451960943878613d, y: 0.07056480869687187d), radius: 0.09448058898161238d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12151166874564445d, y: 0.7193108967153393d), radius: 0.02751673319516068d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27998963129182264d, y: 0.9198147767720353d), radius: 0.08939686981267592d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27412602803887387d, y: 0.24399180285086797d), radius: 0.562346583395555d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.319577917781363d, y: 0.8287367860819725d), radius: 0.9788535521890555d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2421607952697058d, y: 0.09856138766548728d), radius: 0.04967671746951485d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6315100324315313d, y: 0.3453452494414445d), radius: 0.4530478861678957d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3276736280791481d, y: 0.17111232078610983d), radius: 0.3551462925203396d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.268756067765357d, y: 0.7214467182894216d), radius: 0.11457493714358458d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016219224050001424d, y: 0.3696323702123855d), radius: 0.9635566591731973d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9629560552895283d, y: 0.44687376423418523d), radius: 0.7008488199153341d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0378947935555185d, y: 0.32428466153446944d), radius: 0.03947690126233705d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5998324985242776d, y: 0.6924125121341933d), radius: 0.1794974779877444d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49189522052432455d, y: 0.9343020421913686d), radius: 0.8677137605872587d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8812673412354407d, y: 0.9275796614798677d), radius: 0.9192883076377724d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3115042787207297d, y: 0.8066486718395706d), radius: 0.7129000161767202d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.005006431929034605d, y: 0.8772184177068328d), radius: 0.5282112982765841d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45340073509806644d, y: 0.048975887608116d), radius: 0.9197932697864856d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8936665276721957d, y: 0.7034454635478345d), radius: 0.9180394178394407d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.040209431584458666d, y: 0.3346575886942311d), radius: 0.5738727768471453d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3356410155909103d, y: 0.3619600554010276d), radius: 0.1958319261149879d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8382479351613283d, y: 0.4535112924400919d), radius: 0.7361235662081965d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7059540697204534d, y: 0.5223394947596207d), radius: 0.14929444400791647d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1324154259379311d, y: 0.42027589986732916d), radius: 0.499649032911886d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2497720950331126d, y: 0.7461182327402831d), radius: 0.9499068652660612d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4620175952332175d, y: 0.37472892765392496d), radius: 0.2288863972356333d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4751907584558559d, y: 0.5488801047497344d), radius: 0.3936652141116195d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9058594252155563d, y: 0.9259531943543323d), radius: 0.16633779651522806d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8456595131785886d, y: 0.07627341332877835d), radius: 0.7000767636302635d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4568706118324586d, y: 0.9378099499167918d), radius: 0.04547640823873267d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5824327417097512d, y: 0.17380884619297365d), radius: 0.8787377541411411d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45615347527509653d, y: 0.9428198943439686d), radius: 0.06495991078663876d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.826395297634223d, y: 0.3003196222275817d), radius: 0.48087137058666196d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.036528142105698436d, y: 0.3530687735767236d), radius: 0.297485938790471d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4416843089174213d, y: 0.8537698286090166d), radius: 0.7895972180310621d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08858215015680193d, y: 0.09047170133082916d), radius: 0.007425256403073122d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35787563101762176d, y: 0.5305486554502258d), radius: 0.011244435653595564d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3997607543784002d, y: 0.4634322359935341d), radius: 0.4300833062898348d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.84825293481915d, y: 0.8175637166863619d), radius: 0.5410341455226694d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3019840458963703d, y: 0.8158214863452713d), radius: 0.2236616690077745d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.062420430173938835d, y: 0.5783669323415784d), radius: 0.1648611772352805d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.021347823258937138d, y: 0.8353217571835762d), radius: 0.9726089856190255d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8957688869981878d, y: 0.6210980844713799d), radius: 0.04457144207719499d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02535184399826651d, y: 0.2647688053498597d), radius: 0.4317129589612585d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.955693329655016d, y: 0.24408423756918274d), radius: 0.05798262002512822d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5590601308290862d, y: 0.5653162252170454d), radius: 0.6806025890242771d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08413539109826829d, y: 0.7521151137350772d), radius: 0.8828565931760491d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6809574919331497d, y: 0.5976889885502384d), radius: 0.7882334098930761d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2952441726098134d, y: 0.9718127278323455d), radius: 0.48719071364317634d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6811199934756321d, y: 0.8550283058195328d), radius: 0.4477465226912192d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14544661297065686d, y: 0.1867853783853779d), radius: 0.6435136682715327d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7774262563932968d, y: 0.6823329827746321d), radius: 0.4684914580359053d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35477412929191643d, y: 0.6170572548631287d), radius: 0.4262648217073618d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02709297172066716d, y: 0.6733040631508654d), radius: 0.7276981943435179d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48666479316935984d, y: 0.31267484706124016d), radius: 0.15168666519826435d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08934075650885309d, y: 0.9915528035820543d), radius: 0.6735080023578075d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02568333402692391d, y: 0.6683488901292891d), radius: 0.4553956909022612d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34205316147023035d, y: 0.8137473824398436d), radius: 0.6061167359474181d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40538945778384494d, y: 0.7172313419574106d), radius: 0.21631140328975496d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1639874125467179d, y: 0.9580922323845784d), radius: 0.19002443164931393d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9330516312004619d, y: 0.37700929043315545d), radius: 0.08284914621474904d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.817617156870085d, y: 0.4348855978982421d), radius: 0.27036032709333946d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06757895047791485d, y: 0.39830141941886676d), radius: 0.7940153647330765d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9307871277237777d, y: 0.2664355559440157d), radius: 0.14051790614275905d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9171311621507376d, y: 0.5975432217708937d), radius: 0.29294176353182566d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09934995997526641d, y: 0.8677022923017286d), radius: 0.32939944283006806d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13456819672341325d, y: 0.877178952578716d), radius: 0.7199563602487681d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8206256219481485d, y: 0.11565681142686246d), radius: 0.567925699845857d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023998827159349867d, y: 0.2712499240522783d), radius: 0.3071683683089883d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.878776450511329d, y: 0.8779088354399143d), radius: 0.5684271143342099d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9017710013787096d, y: 0.8539133072756067d), radius: 0.48045587626346176d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8770076683329416d, y: 0.39406816653094356d), radius: 0.7650663075600213d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5710309365822904d, y: 0.5688215735970322d), radius: 0.700324072039719d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.014389552239223224d, y: 0.34917842415503364d), radius: 0.7517020312394793d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5813822909997967d, y: 0.34558779616654145d), radius: 0.8331410723600794d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38270145004659417d, y: 0.774494765398381d), radius: 0.5832145031783995d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3823635112673567d, y: 0.9305742277450735d), radius: 0.7377928759695971d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3600381954092441d, y: 0.8570154739874144d), radius: 0.4180392343952155d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37316510520817514d, y: 0.7021716851992119d), radius: 0.9290054876220052d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11713407495563088d, y: 0.11731724574163072d), radius: 0.7617930385243461d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7999371492459222d, y: 0.091932504938951d), radius: 0.34693520964174385d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6837689475790056d, y: 0.2499736821820404d), radius: 0.9605085583142716d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9160437919589112d, y: 0.621728988127457d), radius: 0.5507637413690839d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39646417962496383d, y: 0.6853896081468093d), radius: 0.678449194745466d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23919707854916206d, y: 0.35819399419538744d), radius: 0.8742872219958742d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4186364577631251d, y: 0.8383450375480012d), radius: 0.6915174906643783d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46209783836737883d, y: 0.43215390788262d), radius: 0.47750111301542064d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7593722611261172d, y: 0.14551213967439192d), radius: 0.20929356372103025d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6863332936924085d, y: 0.535720255268675d), radius: 0.969037135453182d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11595173606255449d, y: 0.9524017403101789d), radius: 0.3214849581288842d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24843364285404512d, y: 0.4688565720172636d), radius: 0.6546416467236275d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6317794081896229d, y: 0.060313093837278564d), radius: 0.8695144705507656d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8297814446326871d, y: 0.47807851260997847d), radius: 0.10158165217038906d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.238604113192473d, y: 0.32208884161729323d), radius: 0.624211458424507d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11720166925940156d, y: 0.4220915923466916d), radius: 0.2870713754523033d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7822999505079723d, y: 0.9260447842829883d), radius: 0.03022587927654219d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33000401062750695d, y: 0.29110507399986096d), radius: 0.9686841989474395d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33072337464208d, y: 0.2437653555770991d), radius: 0.5628808627701206d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027282904459422053d, y: 0.8826992135433173d), radius: 0.899064374252038d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46815517523126293d, y: 0.531968365873441d), radius: 0.3857895803119592d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5817040405621441d, y: 0.3220593028898212d), radius: 0.8045414802320262d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48948220887714833d, y: 0.7910336509275537d), radius: 0.9244487945444954d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2261696845200406d, y: 0.8115466276359116d), radius: 0.3452093768409281d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13170309128446478d, y: 0.857982548479585d), radius: 0.551874937447608d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8852845510425601d, y: 0.9787029284338133d), radius: 0.28879651540370344d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1043651493962815d, y: 0.7183429225944291d), radius: 0.8062849970945588d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8422882728731115d, y: 0.09353207873278435d), radius: 0.6220016340194752d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9861567452138715d, y: 0.79739701791474d), radius: 0.5304466046494563d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.711540316559992d, y: 0.2913325849490681d), radius: 0.6571600079533851d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7992155557942898d, y: 0.029380170193362587d), radius: 0.7173924925399288d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9409051144572934d, y: 0.22425544777090345d), radius: 0.14823164608443862d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6454716104060809d, y: 0.16515072288938992d), radius: 0.8332557170776892d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4371959071980295d, y: 0.6078919597398167d), radius: 0.3376651568735328d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9526122384536525d, y: 0.6710786568489794d), radius: 0.7150940897285424d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9920455298485107d, y: 0.43841012390502654d), radius: 0.10036955688485283d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27102714013666396d, y: 0.25320951238343425d), radius: 0.5584635666352836d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7748466831894959d, y: 0.6404789475396953d), radius: 0.4376985598256353d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38492797323220307d, y: 0.07124083872851084d), radius: 0.3114897160041503d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05057424423421086d, y: 0.3657595903862274d), radius: 0.5186541994042208d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13312998090385353d, y: 0.3462596281387219d), radius: 0.8080384154938441d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30289389801926636d, y: 0.2444007698975016d), radius: 0.17820421394426222d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43470711006507157d, y: 0.27136151130781905d), radius: 0.6444361004426146d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3955305669762591d, y: 0.7049950533584274d), radius: 0.5636603728434265d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4455728807030295d, y: 0.8805963070082434d), radius: 0.916068310760872d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5463183423444545d, y: 0.062106919698101226d), radius: 0.4996453624741748d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6815501802323762d, y: 0.2892013091482827d), radius: 0.43824941064061185d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4285905759948987d, y: 0.6334835205021908d), radius: 0.029772833368488794d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6836108539619706d, y: 0.18157270839644513d), radius: 0.16596006086462467d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6435043989578041d, y: 0.5155628953332075d), radius: 0.330903552197633d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8005256726003821d, y: 0.2477833901430554d), radius: 0.17433382597465685d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4600399720265601d, y: 0.33504565494596006d), radius: 0.9621939056243558d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8924656402933423d, y: 0.8352334733524247d), radius: 0.8000289216949306d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43650996914649787d, y: 0.7847249482440505d), radius: 0.843245167885539d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10760816520978456d, y: 0.2115320159954036d), radius: 0.7808748314572652d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7727164196416291d, y: 0.665199337452034d), radius: 0.17139341854560675d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9667433470445136d, y: 0.9930725926522393d), radius: 0.8553921330497719d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7146076603030381d, y: 0.6550683969193357d), radius: 0.7752181782235317d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9509350213846148d, y: 0.5671546496832413d), radius: 0.2982712382776972d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22969642570516746d, y: 0.045853064773996643d), radius: 0.7213485469820808d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.048078211468866594d, y: 0.9716192671823731d), radius: 0.9675674244659324d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5386263964435913d, y: 0.2105461870728924d), radius: 0.13684626439261205d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.546652013918181d, y: 0.42072379259627046d), radius: 0.4189884666512329d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.680098290663701d, y: 0.7029890324202197d), radius: 0.08631505264612616d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0647403597784817d, y: 0.10970440600560538d), radius: 0.4604828591209028d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48734024082514593d, y: 0.05981419376690855d), radius: 0.34292005699980077d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6049712271780493d, y: 0.7418755024617981d), radius: 0.36714836617749347d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7558705710990645d, y: 0.6117860060621428d), radius: 0.6369397907458922d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7726543540091522d, y: 0.31192668942484036d), radius: 0.5277564870891379d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7971927475065004d, y: 0.8821021937352387d), radius: 0.6706561162275824d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5666473233337681d, y: 0.7787012490163889d), radius: 0.804786931493304d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5235694826785006d, y: 0.8046335681241126d), radius: 0.7696924064155031d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1309113961027325d, y: 0.26063297847290556d), radius: 0.05485107115549226d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6343599543880869d, y: 0.41810709750689967d), radius: 0.6491821475440714d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6400265205720314d, y: 0.9366795050907881d), radius: 0.8579473513704811d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2584116321568356d, y: 0.12958064502368138d), radius: 0.5594517818466218d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6158917877736405d, y: 0.609294587137474d), radius: 0.02347949969434937d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0409218524218683d, y: 0.5503281211645836d), radius: 0.20548256812914678d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19987453987640935d, y: 0.9714491947838328d), radius: 0.2249394996958458d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1808651726388154d, y: 0.22609428186568603d), radius: 0.7161964838815801d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9521760283296737d, y: 0.6859162680262105d), radius: 0.2863301074851009d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8403551015483873d, y: 0.20802732636934884d), radius: 0.7125458935057621d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9510406932224139d, y: 0.10840555233336191d), radius: 0.19189536416872843d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6384435047133619d, y: 0.8055415864755914d), radius: 0.5537258728479831d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0009103822727150046d, y: 0.11903782156627163d), radius: 0.7930149776241557d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2756173617609594d, y: 0.9752080307940683d), radius: 0.4474733552448593d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40466808232549256d, y: 0.2561862661624972d), radius: 0.17229258589911123d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8862606787661479d, y: 0.5662556663336266d), radius: 0.5498106620915664d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24297463974963862d, y: 0.11438734563078634d), radius: 0.5715880379866017d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6582332067369735d, y: 0.121876227170721d), radius: 0.6644135598472232d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4426558013146531d, y: 0.9067540852565757d), radius: 0.15336110035496275d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6917847972372664d, y: 0.3123113481455634d), radius: 0.1586311596241773d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5492640949713269d, y: 0.45283975770893325d), radius: 0.26497609802853317d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19423816564076013d, y: 0.35862990768618574d), radius: 0.25820661616304275d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22724621353673635d, y: 0.758361567900096d), radius: 0.33205427092590745d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15911679299988524d, y: 0.15412852614442796d), radius: 0.20661273758798882d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7970176758499888d, y: 0.913321815948348d), radius: 0.8035032775162547d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7973001551052576d, y: 0.4428221106088981d), radius: 0.8517215206849263d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12407293104785388d, y: 0.23332600224338973d), radius: 0.6867338088867659d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06587680997742129d, y: 0.8746698227660148d), radius: 0.8346721427757521d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6195653787139337d, y: 0.35338611660071173d), radius: 0.1421262211667076d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3975525191006398d, y: 0.27225429962590497d), radius: 0.8468101737437853d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8213250331098869d, y: 0.20006589591985646d), radius: 0.4649423167913592d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6550227200850721d, y: 0.9955045363456299d), radius: 0.8921942295368516d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7099899071346669d, y: 0.6027229655357134d), radius: 0.370738873552113d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2969241530319009d, y: 0.8920103799777228d), radius: 0.7046167329383017d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8862598027641204d, y: 0.08822470220882161d), radius: 0.1829232578025477d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7943751836399195d, y: 0.2118003477293433d), radius: 0.8156642701491916d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3331620160857114d, y: 0.9720819026456526d), radius: 0.09482000378535871d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09564099128137704d, y: 0.4859951645120275d), radius: 0.06101352109369773d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.034130607634792365d, y: 0.25210809417561797d), radius: 0.7653768902698637d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5273230178859735d, y: 0.6813514422271694d), radius: 0.8865746052639112d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12460031665977145d, y: 0.9777262806418504d), radius: 0.14324943060309958d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9235570843608671d, y: 0.2875486094529941d), radius: 0.31848453565266666d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8006124175586645d, y: 0.23835899273924455d), radius: 0.9201011773666071d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18138806702607346d, y: 0.950883202484527d), radius: 0.3635329731060094d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2mi(
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
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

                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclelistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclelistd1e2mi_id", 
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
                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclelistd1e2mi_id
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
    npgsqlcirclecirclelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclelistd1e2mi_id
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
    npgsqlcirclecirclelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclelistd1e2mi_id", 
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
                List<NpgsqlCirclecircleListD1E2M> models = null;

                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleListD1E2M> models = null;

                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleListcircleListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 51;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 83, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 85, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 78, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 38, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 135, query1, 135, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 151, query1, 113, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 80, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 3, query1, 135, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 137, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelBatch(connection, 13, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleListcircleListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleListcircleListD1)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models = await ((INpgsqlCircleListcircleListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[15], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[16], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[17], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[18], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[19], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[20], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[21], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[22], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[23], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[24], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[25], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[26], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[27], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[28], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[29], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[30], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[31], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[32], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[33], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleListD1)this).SetDbConnectionSelectModelParametrs(cmd, 83);
                var models =  ((INpgsqlCircleListcircleListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[17], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[18], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[19], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[20], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[21], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[22], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[23], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[24], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[25], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[26], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[27], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[28], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[29], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[30], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[31], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[32], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[33], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MI),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclelistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2M),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
FROM public.binary_npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.binary_npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclelistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models =  ((INpgsqlCircleListcircleListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA), typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA), typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI), typeof(NpgsqlCirclecircleListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MI>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MI>();
                await ((INpgsqlCircleListcircleListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MI>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MI>();
                ((INpgsqlCircleListcircleListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA), typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                await ((INpgsqlCircleListcircleListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                ((INpgsqlCircleListcircleListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models = await ((INpgsqlCircleListcircleListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

