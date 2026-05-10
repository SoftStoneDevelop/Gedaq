

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
    internal partial interface INpgsqlPolygonSingleTypepolygon
    {
    }
    
    internal partial class NpgsqlPolygonSingleTypepolygon : INpgsqlPolygonSingleTypepolygon
    {


#region TestData

        private readonly NpgsqlPolygonpolygon0M[] _testData = new NpgsqlPolygonpolygon0M[]
        {
            new NpgsqlPolygonpolygon0M
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07723680438365821d, y: 0.19412275221630115d), new NpgsqlTypes.NpgsqlPoint(x: 0.09463158344919842d, y: 0.47958517637300524d), new NpgsqlTypes.NpgsqlPoint(x: 0.49757643917567074d, y: 0.7590829833656306d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4467778866794727d, y: 0.5275497923379555d), new NpgsqlTypes.NpgsqlPoint(x: 0.08597793082770355d, y: 0.7922609466732978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194743612468459d, y: 0.9915177859592793d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9415808985245905d, y: 0.41201367330911254d), new NpgsqlTypes.NpgsqlPoint(x: 0.6878278160847102d, y: 0.813061370032777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7293684541216d, y: 0.36085248743986686d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4954932669777632d, y: 0.9010310262848793d), new NpgsqlTypes.NpgsqlPoint(x: 0.8061650373884471d, y: 0.7406074361351522d), new NpgsqlTypes.NpgsqlPoint(x: 0.35583906394232967d, y: 0.4327263736431842d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9430289047463589d, y: 0.4212144465359644d), new NpgsqlTypes.NpgsqlPoint(x: 0.19226573609509423d, y: 0.21014355118036332d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192188333038053d, y: 0.8519458214936273d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.681830035275096d, y: 0.2797986956419204d), new NpgsqlTypes.NpgsqlPoint(x: 0.35848221297594984d, y: 0.5460354828845584d), new NpgsqlTypes.NpgsqlPoint(x: 0.3080625547461536d, y: 0.8048270829416994d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24569632547439224d, y: 0.3412571208659917d), new NpgsqlTypes.NpgsqlPoint(x: 0.8367718155876226d, y: 0.8872515688517333d), new NpgsqlTypes.NpgsqlPoint(x: 0.5996694640962077d, y: 0.9397768522409867d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006348764037024779d, y: 0.4310276295588946d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856533965640494d, y: 0.2251585760551723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6483355932962087d, y: 0.6300785106409178d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8712208248691173d, y: 0.39721677150338963d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236229745061835d, y: 0.6884339747660182d), new NpgsqlTypes.NpgsqlPoint(x: 0.2051340685725821d, y: 0.2821134528353255d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1276816178843707d, y: 0.22372224594687218d), new NpgsqlTypes.NpgsqlPoint(x: 0.24013057083730394d, y: 0.87565761504102d), new NpgsqlTypes.NpgsqlPoint(x: 0.8114992999086507d, y: 0.7391682907729954d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4990211951036152d, y: 0.6165989641743783d), new NpgsqlTypes.NpgsqlPoint(x: 0.533389763036298d, y: 0.5827343557111898d), new NpgsqlTypes.NpgsqlPoint(x: 0.06068197922682306d, y: 0.007140417474505001d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9478283769223386d, y: 0.6070810908322117d), new NpgsqlTypes.NpgsqlPoint(x: 0.3386249735254967d, y: 0.4981837795323366d), new NpgsqlTypes.NpgsqlPoint(x: 0.1948835618332554d, y: 0.2071516445536732d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4924587301164691d, y: 0.5345288837343241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412543623449388d, y: 0.19485543661552396d), new NpgsqlTypes.NpgsqlPoint(x: 0.40137251565019416d, y: 0.004500216612572494d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9867805949590258d, y: 0.968741750879758d), new NpgsqlTypes.NpgsqlPoint(x: 0.43349515977046493d, y: 0.39542280161441246d), new NpgsqlTypes.NpgsqlPoint(x: 0.5054056418690736d, y: 0.6117112139322257d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7493198364651344d, y: 0.993558648055594d), new NpgsqlTypes.NpgsqlPoint(x: 0.026873704570960832d, y: 0.15698277719556908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9487282550291074d, y: 0.9783961951928806d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7602762808355282d, y: 0.9397283339953704d), new NpgsqlTypes.NpgsqlPoint(x: 0.35780295859417166d, y: 0.2856904401666881d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851391851067593d, y: 0.039469369136903576d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5734179873871643d, y: 0.7871704011182797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8867105062865611d, y: 0.0184938878287354d), new NpgsqlTypes.NpgsqlPoint(x: 0.07753134396909367d, y: 0.21577741911248205d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5742136995527953d, y: 0.9777063630975231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440423646857237d, y: 0.33663068640888305d), new NpgsqlTypes.NpgsqlPoint(x: 0.2255348679271526d, y: 0.12096331069416377d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5105545294579896d, y: 0.5423010393157877d), new NpgsqlTypes.NpgsqlPoint(x: 0.7399929706903641d, y: 0.2153901374163375d), new NpgsqlTypes.NpgsqlPoint(x: 0.4708811073694953d, y: 0.42082182620661746d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07845335898545813d, y: 0.1486412855068755d), new NpgsqlTypes.NpgsqlPoint(x: 0.09068643698020229d, y: 0.5653533531958327d), new NpgsqlTypes.NpgsqlPoint(x: 0.17645742748216608d, y: 0.10265378232327871d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07309045323810393d, y: 0.25753743692271347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8844711386138092d, y: 0.4638552686003947d), new NpgsqlTypes.NpgsqlPoint(x: 0.9175990066455342d, y: 0.1985483751174799d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7917945739654565d, y: 0.7780182050842142d), new NpgsqlTypes.NpgsqlPoint(x: 0.017577862850656767d, y: 0.8188562208381974d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096497683337922d, y: 0.5658622557599692d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9114061933822705d, y: 0.9948592780487483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9429537795942224d, y: 0.19946569018102922d), new NpgsqlTypes.NpgsqlPoint(x: 0.6921994272565709d, y: 0.5506854086637782d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41613919761854357d, y: 0.8920376756247623d), new NpgsqlTypes.NpgsqlPoint(x: 0.37882527347110917d, y: 0.7255692158496257d), new NpgsqlTypes.NpgsqlPoint(x: 0.07520612378943181d, y: 0.44026586099926457d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27256547163001177d, y: 0.8609543156612416d), new NpgsqlTypes.NpgsqlPoint(x: 0.9878352682970014d, y: 0.7771811202546531d), new NpgsqlTypes.NpgsqlPoint(x: 0.7848510302853363d, y: 0.9443068925618259d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9841291517335776d, y: 0.21986984412222077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6568133494686599d, y: 0.6903564512347252d), new NpgsqlTypes.NpgsqlPoint(x: 0.002636584038089862d, y: 0.8832325771437274d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8653794128208815d, y: 0.12503059440247954d), new NpgsqlTypes.NpgsqlPoint(x: 0.061048339497027704d, y: 0.6889432076001077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994102589108969d, y: 0.1839262505370981d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5754722931362528d, y: 0.7241587488099376d), new NpgsqlTypes.NpgsqlPoint(x: 0.4588428630647151d, y: 0.5143986224844598d), new NpgsqlTypes.NpgsqlPoint(x: 0.9148599112305609d, y: 0.5013086649002022d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4510204023547999d, y: 0.8378516356927233d), new NpgsqlTypes.NpgsqlPoint(x: 0.07649493345904912d, y: 0.17594295732589305d), new NpgsqlTypes.NpgsqlPoint(x: 0.28574300411429265d, y: 0.2514983696398534d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9165041731710948d, y: 0.7481528528688036d), new NpgsqlTypes.NpgsqlPoint(x: 0.15945692613131612d, y: 0.10209868683491718d), new NpgsqlTypes.NpgsqlPoint(x: 0.7465270214017974d, y: 0.9310520603251811d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9606641735798155d, y: 0.8673985019340875d), new NpgsqlTypes.NpgsqlPoint(x: 0.9151515062925657d, y: 0.4845489040363916d), new NpgsqlTypes.NpgsqlPoint(x: 0.5159434526391316d, y: 0.11705117934160036d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9019499784011583d, y: 0.15518081342033319d), new NpgsqlTypes.NpgsqlPoint(x: 0.6979359539053731d, y: 0.5756521582717166d), new NpgsqlTypes.NpgsqlPoint(x: 0.8052545407703953d, y: 0.08917751359339021d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429319103867429d, y: 0.4512415511184229d), new NpgsqlTypes.NpgsqlPoint(x: 0.22089394867939205d, y: 0.7975317065229061d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418982498501284d, y: 0.7340351802529462d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6090820573278335d, y: 0.3485038843595941d), new NpgsqlTypes.NpgsqlPoint(x: 0.04793722038062753d, y: 0.5764295900704189d), new NpgsqlTypes.NpgsqlPoint(x: 0.3184632682217281d, y: 0.6644424527523188d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47450920729159685d, y: 0.28324556976784365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9437242803165198d, y: 0.9965370984875012d), new NpgsqlTypes.NpgsqlPoint(x: 0.9411256322065535d, y: 0.7319938007778924d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7977589948011891d, y: 0.08780390912452285d), new NpgsqlTypes.NpgsqlPoint(x: 0.7652638066307963d, y: 0.920065002261888d), new NpgsqlTypes.NpgsqlPoint(x: 0.24661096500186974d, y: 0.9969655136391309d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6075553288022528d, y: 0.8188605946494936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9432881682578016d, y: 0.9853178389344142d), new NpgsqlTypes.NpgsqlPoint(x: 0.8844737667055307d, y: 0.4695248818322858d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12622347713064563d, y: 0.03236195552232091d), new NpgsqlTypes.NpgsqlPoint(x: 0.23083468237893057d, y: 0.07789780816251823d), new NpgsqlTypes.NpgsqlPoint(x: 0.3095886742879367d, y: 0.16202969991846172d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3494184115358486d, y: 0.7839818768318174d), new NpgsqlTypes.NpgsqlPoint(x: 0.5850737590130891d, y: 0.13400167459578127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040969289721312d, y: 0.7261037103555835d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32487398120537003d, y: 0.687197140630098d), new NpgsqlTypes.NpgsqlPoint(x: 0.8616692696088532d, y: 0.41528956937654726d), new NpgsqlTypes.NpgsqlPoint(x: 0.3359062810593748d, y: 0.6247493803661783d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49485881491744876d, y: 0.21534355567131558d), new NpgsqlTypes.NpgsqlPoint(x: 0.31045956802584906d, y: 0.6076409154259372d), new NpgsqlTypes.NpgsqlPoint(x: 0.006837067387978069d, y: 0.20640215566808295d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5985286374399241d, y: 0.7112168937819667d), new NpgsqlTypes.NpgsqlPoint(x: 0.08584560690802046d, y: 0.12721795325517793d), new NpgsqlTypes.NpgsqlPoint(x: 0.768132108330214d, y: 0.349057350820302d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42091395456090086d, y: 0.9618686055654728d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111467304699096d, y: 0.5415626913025148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6891253612116826d, y: 0.4482114382595206d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6156484861180535d, y: 0.736420353559385d), new NpgsqlTypes.NpgsqlPoint(x: 0.6207013820949597d, y: 0.8974748288421611d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138922753585318d, y: 0.018675951670182434d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6278114789604075d, y: 0.14150608006851517d), new NpgsqlTypes.NpgsqlPoint(x: 0.18741357180619123d, y: 0.5653975844957007d), new NpgsqlTypes.NpgsqlPoint(x: 0.20179635387730543d, y: 0.3616539297068928d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.913211108584691d, y: 0.9774100019889209d), new NpgsqlTypes.NpgsqlPoint(x: 0.2544875772586819d, y: 0.8073625130697794d), new NpgsqlTypes.NpgsqlPoint(x: 0.21305246708982772d, y: 0.5492491164773211d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4208249614010622d, y: 0.6571713454613011d), new NpgsqlTypes.NpgsqlPoint(x: 0.44596913450853704d, y: 0.2559147650298371d), new NpgsqlTypes.NpgsqlPoint(x: 0.9127859848899278d, y: 0.6147096141925049d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.91839278220715d, y: 0.550870408307094d), new NpgsqlTypes.NpgsqlPoint(x: 0.33109004986568447d, y: 0.0044385996956792795d), new NpgsqlTypes.NpgsqlPoint(x: 0.5434900890247862d, y: 0.973518387544629d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13654490189338253d, y: 0.5342357701601504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5179934249493056d, y: 0.9145992609223922d), new NpgsqlTypes.NpgsqlPoint(x: 0.9374073505661349d, y: 0.8611709385875553d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8048028896318936d, y: 0.6207637527090558d), new NpgsqlTypes.NpgsqlPoint(x: 0.4794957258510154d, y: 0.6822616010372661d), new NpgsqlTypes.NpgsqlPoint(x: 0.5359409284997051d, y: 0.45543564127576797d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6639749312172155d, y: 0.3101840746119435d), new NpgsqlTypes.NpgsqlPoint(x: 0.30897034581463d, y: 0.5366226778954619d), new NpgsqlTypes.NpgsqlPoint(x: 0.0006561955458498359d, y: 0.7269435879810499d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5052386414152347d, y: 0.15675500828988786d), new NpgsqlTypes.NpgsqlPoint(x: 0.874485830005185d, y: 0.607351998129797d), new NpgsqlTypes.NpgsqlPoint(x: 0.5341792937776833d, y: 0.25644956586916967d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6769241721704446d, y: 0.5657501027054893d), new NpgsqlTypes.NpgsqlPoint(x: 0.5507359709640733d, y: 0.7955767966361883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7702806135620746d, y: 0.35000737559797523d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07207543532561256d, y: 0.583485912837788d), new NpgsqlTypes.NpgsqlPoint(x: 0.13746439070274807d, y: 0.08102824713801393d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296538616394946d, y: 0.6918719276696275d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.009530619487962966d, y: 0.6261049942629516d), new NpgsqlTypes.NpgsqlPoint(x: 0.4005848709757269d, y: 0.8538781597777162d), new NpgsqlTypes.NpgsqlPoint(x: 0.6087113753223348d, y: 0.4485761993396433d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2719654398991448d, y: 0.31534492346857323d), new NpgsqlTypes.NpgsqlPoint(x: 0.18718976191598613d, y: 0.7027596580400032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6417821443223064d, y: 0.3141444124760494d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04660638052198085d, y: 0.07988602601804162d), new NpgsqlTypes.NpgsqlPoint(x: 0.026646629851136194d, y: 0.2353511911223779d), new NpgsqlTypes.NpgsqlPoint(x: 0.5855251294249244d, y: 0.2722359501099544d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5684311013990891d, y: 0.7887914556344491d), new NpgsqlTypes.NpgsqlPoint(x: 0.6888968839713415d, y: 0.6077187958770517d), new NpgsqlTypes.NpgsqlPoint(x: 0.9113972328943457d, y: 0.4255083805278984d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5224624567902484d, y: 0.6315800055288602d), new NpgsqlTypes.NpgsqlPoint(x: 0.2583879428080853d, y: 0.20212659597216853d), new NpgsqlTypes.NpgsqlPoint(x: 0.9442160042339418d, y: 0.8054522713810881d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5195948088569305d, y: 0.3131143668639763d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083418115467156d, y: 0.9506473348030424d), new NpgsqlTypes.NpgsqlPoint(x: 0.9570308727623642d, y: 0.9829544447848211d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9640049433835463d, y: 0.7699434380761929d), new NpgsqlTypes.NpgsqlPoint(x: 0.27044728709495325d, y: 0.3472869222681405d), new NpgsqlTypes.NpgsqlPoint(x: 0.18310966414961882d, y: 0.09707182638177592d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.009042235836101087d, y: 0.06257878609624423d), new NpgsqlTypes.NpgsqlPoint(x: 0.44084380437833026d, y: 0.611830959041127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6866992172449632d, y: 0.7361361503502726d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.577308529755552d, y: 0.9721281994554859d), new NpgsqlTypes.NpgsqlPoint(x: 0.22696479887088195d, y: 0.004458088442149677d), new NpgsqlTypes.NpgsqlPoint(x: 0.047812616615836245d, y: 0.2683299751719287d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30214059727771925d, y: 0.9391843077691626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8947674527435746d, y: 0.30476447233863013d), new NpgsqlTypes.NpgsqlPoint(x: 0.1328411768290113d, y: 0.24763292237991452d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03179060652157606d, y: 0.34274893886557434d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491637217727862d, y: 0.5859346317746953d), new NpgsqlTypes.NpgsqlPoint(x: 0.00753749963963779d, y: 0.9073818493205933d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.646570217557216d, y: 0.9174877791694706d), new NpgsqlTypes.NpgsqlPoint(x: 0.036140978707626115d, y: 0.9622910878503356d), new NpgsqlTypes.NpgsqlPoint(x: 0.007964241551364548d, y: 0.5334676682558709d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07993220795101719d, y: 0.8771200483144106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6871654854259208d, y: 0.621350330157007d), new NpgsqlTypes.NpgsqlPoint(x: 0.4756334476493892d, y: 0.42393576412307576d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9949923028891655d, y: 0.6017156415495409d), new NpgsqlTypes.NpgsqlPoint(x: 0.9340731910947369d, y: 0.3884133108571366d), new NpgsqlTypes.NpgsqlPoint(x: 0.3928014970963124d, y: 0.5800242852145707d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5040649810270929d, y: 0.9788652125393151d), new NpgsqlTypes.NpgsqlPoint(x: 0.5522565805274671d, y: 0.2813458878462435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6476978427344255d, y: 0.9916214948962144d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4839619871928653d, y: 0.9379439489091167d), new NpgsqlTypes.NpgsqlPoint(x: 0.17808775956384626d, y: 0.482907163555058d), new NpgsqlTypes.NpgsqlPoint(x: 0.3868410099322368d, y: 0.9925476446300683d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37386366555343753d, y: 0.04640117106181241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712125754122155d, y: 0.27271710554319184d), new NpgsqlTypes.NpgsqlPoint(x: 0.6070955701377547d, y: 0.44548924912820376d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8816221788659575d, y: 0.833865344896626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298340095706493d, y: 0.06643436944741143d), new NpgsqlTypes.NpgsqlPoint(x: 0.529756522731776d, y: 0.05179500908188184d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3333077031090882d, y: 0.18805348802650912d), new NpgsqlTypes.NpgsqlPoint(x: 0.6933698933078768d, y: 0.5452974621347005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5714749245642702d, y: 0.8474126979708624d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3889683210081687d, y: 0.89381920429338d), new NpgsqlTypes.NpgsqlPoint(x: 0.11747349688693043d, y: 0.5903864836917365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5932875878796859d, y: 0.25830519154328935d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4511000869885873d, y: 0.09462780610147925d), new NpgsqlTypes.NpgsqlPoint(x: 0.4055290788041269d, y: 0.24122881661136797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8034548952073033d, y: 0.4471833247879273d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6375681374324155d, y: 0.4974256904342287d), new NpgsqlTypes.NpgsqlPoint(x: 0.1402537146606011d, y: 0.17522049201051537d), new NpgsqlTypes.NpgsqlPoint(x: 0.1370477227460436d, y: 0.7209375346034844d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01905234170174619d, y: 0.14295910382609045d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040491834808407d, y: 0.20183261651843298d), new NpgsqlTypes.NpgsqlPoint(x: 0.3413688043579448d, y: 0.9404352049753929d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7253308279643402d, y: 0.2897359775723617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079680742844703d, y: 0.1512618715463031d), new NpgsqlTypes.NpgsqlPoint(x: 0.9207350652621826d, y: 0.720248501499192d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9233025489022999d, y: 0.7422955909895558d), new NpgsqlTypes.NpgsqlPoint(x: 0.4876993761785756d, y: 0.2636861339962322d), new NpgsqlTypes.NpgsqlPoint(x: 0.03571194474748651d, y: 0.6318849005325331d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8737244052283121d, y: 0.32835432223023164d), new NpgsqlTypes.NpgsqlPoint(x: 0.9244100074326214d, y: 0.4011734847741276d), new NpgsqlTypes.NpgsqlPoint(x: 0.305234931524633d, y: 0.6323503011628062d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 171,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2695843430452073d, y: 0.3490445981464855d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494765326589441d, y: 0.5928814158094478d), new NpgsqlTypes.NpgsqlPoint(x: 0.4560652257247799d, y: 0.08935855492785683d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8652071224015441d, y: 0.6199440164865732d), new NpgsqlTypes.NpgsqlPoint(x: 0.4501396252675053d, y: 0.5616702044751612d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180093151867222d, y: 0.010624196403108854d)),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7602762808355282d, y: 0.9397283339953704d), new NpgsqlTypes.NpgsqlPoint(x: 0.35780295859417166d, y: 0.2856904401666881d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851391851067593d, y: 0.039469369136903576d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5742136995527953d, y: 0.9777063630975231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440423646857237d, y: 0.33663068640888305d), new NpgsqlTypes.NpgsqlPoint(x: 0.2255348679271526d, y: 0.12096331069416377d))));
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9114061933822705d, y: 0.9948592780487483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9429537795942224d, y: 0.19946569018102922d), new NpgsqlTypes.NpgsqlPoint(x: 0.6921994272565709d, y: 0.5506854086637782d))));
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9841291517335776d, y: 0.21986984412222077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6568133494686599d, y: 0.6903564512347252d), new NpgsqlTypes.NpgsqlPoint(x: 0.002636584038089862d, y: 0.8832325771437274d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpolygonpolygon0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpolygonpolygon0mi_id", 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 58;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 76;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 140, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 143, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 110, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 143, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 48, query1, 135, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 140, query1, 154, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 28, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 118, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 3, 158))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 110, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[29], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[30], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[31], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[32], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[33], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[29], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[30], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[31], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[32], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[33], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07723680438365821d, y: 0.19412275221630115d), new NpgsqlTypes.NpgsqlPoint(x: 0.09463158344919842d, y: 0.47958517637300524d), new NpgsqlTypes.NpgsqlPoint(x: 0.49757643917567074d, y: 0.7590829833656306d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4467778866794727d, y: 0.5275497923379555d), new NpgsqlTypes.NpgsqlPoint(x: 0.08597793082770355d, y: 0.7922609466732978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194743612468459d, y: 0.9915177859592793d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9415808985245905d, y: 0.41201367330911254d), new NpgsqlTypes.NpgsqlPoint(x: 0.6878278160847102d, y: 0.813061370032777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7293684541216d, y: 0.36085248743986686d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4954932669777632d, y: 0.9010310262848793d), new NpgsqlTypes.NpgsqlPoint(x: 0.8061650373884471d, y: 0.7406074361351522d), new NpgsqlTypes.NpgsqlPoint(x: 0.35583906394232967d, y: 0.4327263736431842d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9430289047463589d, y: 0.4212144465359644d), new NpgsqlTypes.NpgsqlPoint(x: 0.19226573609509423d, y: 0.21014355118036332d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192188333038053d, y: 0.8519458214936273d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.681830035275096d, y: 0.2797986956419204d), new NpgsqlTypes.NpgsqlPoint(x: 0.35848221297594984d, y: 0.5460354828845584d), new NpgsqlTypes.NpgsqlPoint(x: 0.3080625547461536d, y: 0.8048270829416994d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24569632547439224d, y: 0.3412571208659917d), new NpgsqlTypes.NpgsqlPoint(x: 0.8367718155876226d, y: 0.8872515688517333d), new NpgsqlTypes.NpgsqlPoint(x: 0.5996694640962077d, y: 0.9397768522409867d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006348764037024779d, y: 0.4310276295588946d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856533965640494d, y: 0.2251585760551723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6483355932962087d, y: 0.6300785106409178d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8712208248691173d, y: 0.39721677150338963d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236229745061835d, y: 0.6884339747660182d), new NpgsqlTypes.NpgsqlPoint(x: 0.2051340685725821d, y: 0.2821134528353255d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1276816178843707d, y: 0.22372224594687218d), new NpgsqlTypes.NpgsqlPoint(x: 0.24013057083730394d, y: 0.87565761504102d), new NpgsqlTypes.NpgsqlPoint(x: 0.8114992999086507d, y: 0.7391682907729954d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4990211951036152d, y: 0.6165989641743783d), new NpgsqlTypes.NpgsqlPoint(x: 0.533389763036298d, y: 0.5827343557111898d), new NpgsqlTypes.NpgsqlPoint(x: 0.06068197922682306d, y: 0.007140417474505001d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9478283769223386d, y: 0.6070810908322117d), new NpgsqlTypes.NpgsqlPoint(x: 0.3386249735254967d, y: 0.4981837795323366d), new NpgsqlTypes.NpgsqlPoint(x: 0.1948835618332554d, y: 0.2071516445536732d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4924587301164691d, y: 0.5345288837343241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412543623449388d, y: 0.19485543661552396d), new NpgsqlTypes.NpgsqlPoint(x: 0.40137251565019416d, y: 0.004500216612572494d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9867805949590258d, y: 0.968741750879758d), new NpgsqlTypes.NpgsqlPoint(x: 0.43349515977046493d, y: 0.39542280161441246d), new NpgsqlTypes.NpgsqlPoint(x: 0.5054056418690736d, y: 0.6117112139322257d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7493198364651344d, y: 0.993558648055594d), new NpgsqlTypes.NpgsqlPoint(x: 0.026873704570960832d, y: 0.15698277719556908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9487282550291074d, y: 0.9783961951928806d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7602762808355282d, y: 0.9397283339953704d), new NpgsqlTypes.NpgsqlPoint(x: 0.35780295859417166d, y: 0.2856904401666881d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851391851067593d, y: 0.039469369136903576d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5734179873871643d, y: 0.7871704011182797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8867105062865611d, y: 0.0184938878287354d), new NpgsqlTypes.NpgsqlPoint(x: 0.07753134396909367d, y: 0.21577741911248205d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5742136995527953d, y: 0.9777063630975231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440423646857237d, y: 0.33663068640888305d), new NpgsqlTypes.NpgsqlPoint(x: 0.2255348679271526d, y: 0.12096331069416377d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5105545294579896d, y: 0.5423010393157877d), new NpgsqlTypes.NpgsqlPoint(x: 0.7399929706903641d, y: 0.2153901374163375d), new NpgsqlTypes.NpgsqlPoint(x: 0.4708811073694953d, y: 0.42082182620661746d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07845335898545813d, y: 0.1486412855068755d), new NpgsqlTypes.NpgsqlPoint(x: 0.09068643698020229d, y: 0.5653533531958327d), new NpgsqlTypes.NpgsqlPoint(x: 0.17645742748216608d, y: 0.10265378232327871d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07309045323810393d, y: 0.25753743692271347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8844711386138092d, y: 0.4638552686003947d), new NpgsqlTypes.NpgsqlPoint(x: 0.9175990066455342d, y: 0.1985483751174799d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7917945739654565d, y: 0.7780182050842142d), new NpgsqlTypes.NpgsqlPoint(x: 0.017577862850656767d, y: 0.8188562208381974d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096497683337922d, y: 0.5658622557599692d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9114061933822705d, y: 0.9948592780487483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9429537795942224d, y: 0.19946569018102922d), new NpgsqlTypes.NpgsqlPoint(x: 0.6921994272565709d, y: 0.5506854086637782d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41613919761854357d, y: 0.8920376756247623d), new NpgsqlTypes.NpgsqlPoint(x: 0.37882527347110917d, y: 0.7255692158496257d), new NpgsqlTypes.NpgsqlPoint(x: 0.07520612378943181d, y: 0.44026586099926457d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27256547163001177d, y: 0.8609543156612416d), new NpgsqlTypes.NpgsqlPoint(x: 0.9878352682970014d, y: 0.7771811202546531d), new NpgsqlTypes.NpgsqlPoint(x: 0.7848510302853363d, y: 0.9443068925618259d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9841291517335776d, y: 0.21986984412222077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6568133494686599d, y: 0.6903564512347252d), new NpgsqlTypes.NpgsqlPoint(x: 0.002636584038089862d, y: 0.8832325771437274d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8653794128208815d, y: 0.12503059440247954d), new NpgsqlTypes.NpgsqlPoint(x: 0.061048339497027704d, y: 0.6889432076001077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994102589108969d, y: 0.1839262505370981d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5754722931362528d, y: 0.7241587488099376d), new NpgsqlTypes.NpgsqlPoint(x: 0.4588428630647151d, y: 0.5143986224844598d), new NpgsqlTypes.NpgsqlPoint(x: 0.9148599112305609d, y: 0.5013086649002022d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4510204023547999d, y: 0.8378516356927233d), new NpgsqlTypes.NpgsqlPoint(x: 0.07649493345904912d, y: 0.17594295732589305d), new NpgsqlTypes.NpgsqlPoint(x: 0.28574300411429265d, y: 0.2514983696398534d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9165041731710948d, y: 0.7481528528688036d), new NpgsqlTypes.NpgsqlPoint(x: 0.15945692613131612d, y: 0.10209868683491718d), new NpgsqlTypes.NpgsqlPoint(x: 0.7465270214017974d, y: 0.9310520603251811d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9606641735798155d, y: 0.8673985019340875d), new NpgsqlTypes.NpgsqlPoint(x: 0.9151515062925657d, y: 0.4845489040363916d), new NpgsqlTypes.NpgsqlPoint(x: 0.5159434526391316d, y: 0.11705117934160036d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9019499784011583d, y: 0.15518081342033319d), new NpgsqlTypes.NpgsqlPoint(x: 0.6979359539053731d, y: 0.5756521582717166d), new NpgsqlTypes.NpgsqlPoint(x: 0.8052545407703953d, y: 0.08917751359339021d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429319103867429d, y: 0.4512415511184229d), new NpgsqlTypes.NpgsqlPoint(x: 0.22089394867939205d, y: 0.7975317065229061d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418982498501284d, y: 0.7340351802529462d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6090820573278335d, y: 0.3485038843595941d), new NpgsqlTypes.NpgsqlPoint(x: 0.04793722038062753d, y: 0.5764295900704189d), new NpgsqlTypes.NpgsqlPoint(x: 0.3184632682217281d, y: 0.6644424527523188d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47450920729159685d, y: 0.28324556976784365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9437242803165198d, y: 0.9965370984875012d), new NpgsqlTypes.NpgsqlPoint(x: 0.9411256322065535d, y: 0.7319938007778924d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7977589948011891d, y: 0.08780390912452285d), new NpgsqlTypes.NpgsqlPoint(x: 0.7652638066307963d, y: 0.920065002261888d), new NpgsqlTypes.NpgsqlPoint(x: 0.24661096500186974d, y: 0.9969655136391309d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6075553288022528d, y: 0.8188605946494936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9432881682578016d, y: 0.9853178389344142d), new NpgsqlTypes.NpgsqlPoint(x: 0.8844737667055307d, y: 0.4695248818322858d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12622347713064563d, y: 0.03236195552232091d), new NpgsqlTypes.NpgsqlPoint(x: 0.23083468237893057d, y: 0.07789780816251823d), new NpgsqlTypes.NpgsqlPoint(x: 0.3095886742879367d, y: 0.16202969991846172d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3494184115358486d, y: 0.7839818768318174d), new NpgsqlTypes.NpgsqlPoint(x: 0.5850737590130891d, y: 0.13400167459578127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040969289721312d, y: 0.7261037103555835d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32487398120537003d, y: 0.687197140630098d), new NpgsqlTypes.NpgsqlPoint(x: 0.8616692696088532d, y: 0.41528956937654726d), new NpgsqlTypes.NpgsqlPoint(x: 0.3359062810593748d, y: 0.6247493803661783d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49485881491744876d, y: 0.21534355567131558d), new NpgsqlTypes.NpgsqlPoint(x: 0.31045956802584906d, y: 0.6076409154259372d), new NpgsqlTypes.NpgsqlPoint(x: 0.006837067387978069d, y: 0.20640215566808295d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5985286374399241d, y: 0.7112168937819667d), new NpgsqlTypes.NpgsqlPoint(x: 0.08584560690802046d, y: 0.12721795325517793d), new NpgsqlTypes.NpgsqlPoint(x: 0.768132108330214d, y: 0.349057350820302d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42091395456090086d, y: 0.9618686055654728d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111467304699096d, y: 0.5415626913025148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6891253612116826d, y: 0.4482114382595206d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6156484861180535d, y: 0.736420353559385d), new NpgsqlTypes.NpgsqlPoint(x: 0.6207013820949597d, y: 0.8974748288421611d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138922753585318d, y: 0.018675951670182434d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6278114789604075d, y: 0.14150608006851517d), new NpgsqlTypes.NpgsqlPoint(x: 0.18741357180619123d, y: 0.5653975844957007d), new NpgsqlTypes.NpgsqlPoint(x: 0.20179635387730543d, y: 0.3616539297068928d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.913211108584691d, y: 0.9774100019889209d), new NpgsqlTypes.NpgsqlPoint(x: 0.2544875772586819d, y: 0.8073625130697794d), new NpgsqlTypes.NpgsqlPoint(x: 0.21305246708982772d, y: 0.5492491164773211d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4208249614010622d, y: 0.6571713454613011d), new NpgsqlTypes.NpgsqlPoint(x: 0.44596913450853704d, y: 0.2559147650298371d), new NpgsqlTypes.NpgsqlPoint(x: 0.9127859848899278d, y: 0.6147096141925049d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.91839278220715d, y: 0.550870408307094d), new NpgsqlTypes.NpgsqlPoint(x: 0.33109004986568447d, y: 0.0044385996956792795d), new NpgsqlTypes.NpgsqlPoint(x: 0.5434900890247862d, y: 0.973518387544629d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13654490189338253d, y: 0.5342357701601504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5179934249493056d, y: 0.9145992609223922d), new NpgsqlTypes.NpgsqlPoint(x: 0.9374073505661349d, y: 0.8611709385875553d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8048028896318936d, y: 0.6207637527090558d), new NpgsqlTypes.NpgsqlPoint(x: 0.4794957258510154d, y: 0.6822616010372661d), new NpgsqlTypes.NpgsqlPoint(x: 0.5359409284997051d, y: 0.45543564127576797d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6639749312172155d, y: 0.3101840746119435d), new NpgsqlTypes.NpgsqlPoint(x: 0.30897034581463d, y: 0.5366226778954619d), new NpgsqlTypes.NpgsqlPoint(x: 0.0006561955458498359d, y: 0.7269435879810499d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5052386414152347d, y: 0.15675500828988786d), new NpgsqlTypes.NpgsqlPoint(x: 0.874485830005185d, y: 0.607351998129797d), new NpgsqlTypes.NpgsqlPoint(x: 0.5341792937776833d, y: 0.25644956586916967d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6769241721704446d, y: 0.5657501027054893d), new NpgsqlTypes.NpgsqlPoint(x: 0.5507359709640733d, y: 0.7955767966361883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7702806135620746d, y: 0.35000737559797523d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07207543532561256d, y: 0.583485912837788d), new NpgsqlTypes.NpgsqlPoint(x: 0.13746439070274807d, y: 0.08102824713801393d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296538616394946d, y: 0.6918719276696275d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.009530619487962966d, y: 0.6261049942629516d), new NpgsqlTypes.NpgsqlPoint(x: 0.4005848709757269d, y: 0.8538781597777162d), new NpgsqlTypes.NpgsqlPoint(x: 0.6087113753223348d, y: 0.4485761993396433d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2719654398991448d, y: 0.31534492346857323d), new NpgsqlTypes.NpgsqlPoint(x: 0.18718976191598613d, y: 0.7027596580400032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6417821443223064d, y: 0.3141444124760494d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04660638052198085d, y: 0.07988602601804162d), new NpgsqlTypes.NpgsqlPoint(x: 0.026646629851136194d, y: 0.2353511911223779d), new NpgsqlTypes.NpgsqlPoint(x: 0.5855251294249244d, y: 0.2722359501099544d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5684311013990891d, y: 0.7887914556344491d), new NpgsqlTypes.NpgsqlPoint(x: 0.6888968839713415d, y: 0.6077187958770517d), new NpgsqlTypes.NpgsqlPoint(x: 0.9113972328943457d, y: 0.4255083805278984d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5224624567902484d, y: 0.6315800055288602d), new NpgsqlTypes.NpgsqlPoint(x: 0.2583879428080853d, y: 0.20212659597216853d), new NpgsqlTypes.NpgsqlPoint(x: 0.9442160042339418d, y: 0.8054522713810881d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5195948088569305d, y: 0.3131143668639763d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083418115467156d, y: 0.9506473348030424d), new NpgsqlTypes.NpgsqlPoint(x: 0.9570308727623642d, y: 0.9829544447848211d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9640049433835463d, y: 0.7699434380761929d), new NpgsqlTypes.NpgsqlPoint(x: 0.27044728709495325d, y: 0.3472869222681405d), new NpgsqlTypes.NpgsqlPoint(x: 0.18310966414961882d, y: 0.09707182638177592d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.009042235836101087d, y: 0.06257878609624423d), new NpgsqlTypes.NpgsqlPoint(x: 0.44084380437833026d, y: 0.611830959041127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6866992172449632d, y: 0.7361361503502726d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.577308529755552d, y: 0.9721281994554859d), new NpgsqlTypes.NpgsqlPoint(x: 0.22696479887088195d, y: 0.004458088442149677d), new NpgsqlTypes.NpgsqlPoint(x: 0.047812616615836245d, y: 0.2683299751719287d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30214059727771925d, y: 0.9391843077691626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8947674527435746d, y: 0.30476447233863013d), new NpgsqlTypes.NpgsqlPoint(x: 0.1328411768290113d, y: 0.24763292237991452d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03179060652157606d, y: 0.34274893886557434d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491637217727862d, y: 0.5859346317746953d), new NpgsqlTypes.NpgsqlPoint(x: 0.00753749963963779d, y: 0.9073818493205933d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.646570217557216d, y: 0.9174877791694706d), new NpgsqlTypes.NpgsqlPoint(x: 0.036140978707626115d, y: 0.9622910878503356d), new NpgsqlTypes.NpgsqlPoint(x: 0.007964241551364548d, y: 0.5334676682558709d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07993220795101719d, y: 0.8771200483144106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6871654854259208d, y: 0.621350330157007d), new NpgsqlTypes.NpgsqlPoint(x: 0.4756334476493892d, y: 0.42393576412307576d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9949923028891655d, y: 0.6017156415495409d), new NpgsqlTypes.NpgsqlPoint(x: 0.9340731910947369d, y: 0.3884133108571366d), new NpgsqlTypes.NpgsqlPoint(x: 0.3928014970963124d, y: 0.5800242852145707d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5040649810270929d, y: 0.9788652125393151d), new NpgsqlTypes.NpgsqlPoint(x: 0.5522565805274671d, y: 0.2813458878462435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6476978427344255d, y: 0.9916214948962144d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4839619871928653d, y: 0.9379439489091167d), new NpgsqlTypes.NpgsqlPoint(x: 0.17808775956384626d, y: 0.482907163555058d), new NpgsqlTypes.NpgsqlPoint(x: 0.3868410099322368d, y: 0.9925476446300683d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37386366555343753d, y: 0.04640117106181241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712125754122155d, y: 0.27271710554319184d), new NpgsqlTypes.NpgsqlPoint(x: 0.6070955701377547d, y: 0.44548924912820376d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8816221788659575d, y: 0.833865344896626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298340095706493d, y: 0.06643436944741143d), new NpgsqlTypes.NpgsqlPoint(x: 0.529756522731776d, y: 0.05179500908188184d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3333077031090882d, y: 0.18805348802650912d), new NpgsqlTypes.NpgsqlPoint(x: 0.6933698933078768d, y: 0.5452974621347005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5714749245642702d, y: 0.8474126979708624d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3889683210081687d, y: 0.89381920429338d), new NpgsqlTypes.NpgsqlPoint(x: 0.11747349688693043d, y: 0.5903864836917365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5932875878796859d, y: 0.25830519154328935d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4511000869885873d, y: 0.09462780610147925d), new NpgsqlTypes.NpgsqlPoint(x: 0.4055290788041269d, y: 0.24122881661136797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8034548952073033d, y: 0.4471833247879273d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6375681374324155d, y: 0.4974256904342287d), new NpgsqlTypes.NpgsqlPoint(x: 0.1402537146606011d, y: 0.17522049201051537d), new NpgsqlTypes.NpgsqlPoint(x: 0.1370477227460436d, y: 0.7209375346034844d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01905234170174619d, y: 0.14295910382609045d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040491834808407d, y: 0.20183261651843298d), new NpgsqlTypes.NpgsqlPoint(x: 0.3413688043579448d, y: 0.9404352049753929d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7253308279643402d, y: 0.2897359775723617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079680742844703d, y: 0.1512618715463031d), new NpgsqlTypes.NpgsqlPoint(x: 0.9207350652621826d, y: 0.720248501499192d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9233025489022999d, y: 0.7422955909895558d), new NpgsqlTypes.NpgsqlPoint(x: 0.4876993761785756d, y: 0.2636861339962322d), new NpgsqlTypes.NpgsqlPoint(x: 0.03571194474748651d, y: 0.6318849005325331d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8737244052283121d, y: 0.32835432223023164d), new NpgsqlTypes.NpgsqlPoint(x: 0.9244100074326214d, y: 0.4011734847741276d), new NpgsqlTypes.NpgsqlPoint(x: 0.305234931524633d, y: 0.6323503011628062d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2695843430452073d, y: 0.3490445981464855d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494765326589441d, y: 0.5928814158094478d), new NpgsqlTypes.NpgsqlPoint(x: 0.4560652257247799d, y: 0.08935855492785683d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8652071224015441d, y: 0.6199440164865732d), new NpgsqlTypes.NpgsqlPoint(x: 0.4501396252675053d, y: 0.5616702044751612d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180093151867222d, y: 0.010624196403108854d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07723680438365821d, y: 0.19412275221630115d), new NpgsqlTypes.NpgsqlPoint(x: 0.09463158344919842d, y: 0.47958517637300524d), new NpgsqlTypes.NpgsqlPoint(x: 0.49757643917567074d, y: 0.7590829833656306d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4467778866794727d, y: 0.5275497923379555d), new NpgsqlTypes.NpgsqlPoint(x: 0.08597793082770355d, y: 0.7922609466732978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194743612468459d, y: 0.9915177859592793d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9415808985245905d, y: 0.41201367330911254d), new NpgsqlTypes.NpgsqlPoint(x: 0.6878278160847102d, y: 0.813061370032777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7293684541216d, y: 0.36085248743986686d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4954932669777632d, y: 0.9010310262848793d), new NpgsqlTypes.NpgsqlPoint(x: 0.8061650373884471d, y: 0.7406074361351522d), new NpgsqlTypes.NpgsqlPoint(x: 0.35583906394232967d, y: 0.4327263736431842d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9430289047463589d, y: 0.4212144465359644d), new NpgsqlTypes.NpgsqlPoint(x: 0.19226573609509423d, y: 0.21014355118036332d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192188333038053d, y: 0.8519458214936273d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.681830035275096d, y: 0.2797986956419204d), new NpgsqlTypes.NpgsqlPoint(x: 0.35848221297594984d, y: 0.5460354828845584d), new NpgsqlTypes.NpgsqlPoint(x: 0.3080625547461536d, y: 0.8048270829416994d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24569632547439224d, y: 0.3412571208659917d), new NpgsqlTypes.NpgsqlPoint(x: 0.8367718155876226d, y: 0.8872515688517333d), new NpgsqlTypes.NpgsqlPoint(x: 0.5996694640962077d, y: 0.9397768522409867d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006348764037024779d, y: 0.4310276295588946d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856533965640494d, y: 0.2251585760551723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6483355932962087d, y: 0.6300785106409178d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8712208248691173d, y: 0.39721677150338963d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236229745061835d, y: 0.6884339747660182d), new NpgsqlTypes.NpgsqlPoint(x: 0.2051340685725821d, y: 0.2821134528353255d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1276816178843707d, y: 0.22372224594687218d), new NpgsqlTypes.NpgsqlPoint(x: 0.24013057083730394d, y: 0.87565761504102d), new NpgsqlTypes.NpgsqlPoint(x: 0.8114992999086507d, y: 0.7391682907729954d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4990211951036152d, y: 0.6165989641743783d), new NpgsqlTypes.NpgsqlPoint(x: 0.533389763036298d, y: 0.5827343557111898d), new NpgsqlTypes.NpgsqlPoint(x: 0.06068197922682306d, y: 0.007140417474505001d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9478283769223386d, y: 0.6070810908322117d), new NpgsqlTypes.NpgsqlPoint(x: 0.3386249735254967d, y: 0.4981837795323366d), new NpgsqlTypes.NpgsqlPoint(x: 0.1948835618332554d, y: 0.2071516445536732d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4924587301164691d, y: 0.5345288837343241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412543623449388d, y: 0.19485543661552396d), new NpgsqlTypes.NpgsqlPoint(x: 0.40137251565019416d, y: 0.004500216612572494d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9867805949590258d, y: 0.968741750879758d), new NpgsqlTypes.NpgsqlPoint(x: 0.43349515977046493d, y: 0.39542280161441246d), new NpgsqlTypes.NpgsqlPoint(x: 0.5054056418690736d, y: 0.6117112139322257d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7493198364651344d, y: 0.993558648055594d), new NpgsqlTypes.NpgsqlPoint(x: 0.026873704570960832d, y: 0.15698277719556908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9487282550291074d, y: 0.9783961951928806d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7602762808355282d, y: 0.9397283339953704d), new NpgsqlTypes.NpgsqlPoint(x: 0.35780295859417166d, y: 0.2856904401666881d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851391851067593d, y: 0.039469369136903576d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5734179873871643d, y: 0.7871704011182797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8867105062865611d, y: 0.0184938878287354d), new NpgsqlTypes.NpgsqlPoint(x: 0.07753134396909367d, y: 0.21577741911248205d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5742136995527953d, y: 0.9777063630975231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440423646857237d, y: 0.33663068640888305d), new NpgsqlTypes.NpgsqlPoint(x: 0.2255348679271526d, y: 0.12096331069416377d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5105545294579896d, y: 0.5423010393157877d), new NpgsqlTypes.NpgsqlPoint(x: 0.7399929706903641d, y: 0.2153901374163375d), new NpgsqlTypes.NpgsqlPoint(x: 0.4708811073694953d, y: 0.42082182620661746d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07845335898545813d, y: 0.1486412855068755d), new NpgsqlTypes.NpgsqlPoint(x: 0.09068643698020229d, y: 0.5653533531958327d), new NpgsqlTypes.NpgsqlPoint(x: 0.17645742748216608d, y: 0.10265378232327871d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07309045323810393d, y: 0.25753743692271347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8844711386138092d, y: 0.4638552686003947d), new NpgsqlTypes.NpgsqlPoint(x: 0.9175990066455342d, y: 0.1985483751174799d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7917945739654565d, y: 0.7780182050842142d), new NpgsqlTypes.NpgsqlPoint(x: 0.017577862850656767d, y: 0.8188562208381974d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096497683337922d, y: 0.5658622557599692d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9114061933822705d, y: 0.9948592780487483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9429537795942224d, y: 0.19946569018102922d), new NpgsqlTypes.NpgsqlPoint(x: 0.6921994272565709d, y: 0.5506854086637782d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41613919761854357d, y: 0.8920376756247623d), new NpgsqlTypes.NpgsqlPoint(x: 0.37882527347110917d, y: 0.7255692158496257d), new NpgsqlTypes.NpgsqlPoint(x: 0.07520612378943181d, y: 0.44026586099926457d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27256547163001177d, y: 0.8609543156612416d), new NpgsqlTypes.NpgsqlPoint(x: 0.9878352682970014d, y: 0.7771811202546531d), new NpgsqlTypes.NpgsqlPoint(x: 0.7848510302853363d, y: 0.9443068925618259d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9841291517335776d, y: 0.21986984412222077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6568133494686599d, y: 0.6903564512347252d), new NpgsqlTypes.NpgsqlPoint(x: 0.002636584038089862d, y: 0.8832325771437274d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8653794128208815d, y: 0.12503059440247954d), new NpgsqlTypes.NpgsqlPoint(x: 0.061048339497027704d, y: 0.6889432076001077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994102589108969d, y: 0.1839262505370981d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5754722931362528d, y: 0.7241587488099376d), new NpgsqlTypes.NpgsqlPoint(x: 0.4588428630647151d, y: 0.5143986224844598d), new NpgsqlTypes.NpgsqlPoint(x: 0.9148599112305609d, y: 0.5013086649002022d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4510204023547999d, y: 0.8378516356927233d), new NpgsqlTypes.NpgsqlPoint(x: 0.07649493345904912d, y: 0.17594295732589305d), new NpgsqlTypes.NpgsqlPoint(x: 0.28574300411429265d, y: 0.2514983696398534d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9165041731710948d, y: 0.7481528528688036d), new NpgsqlTypes.NpgsqlPoint(x: 0.15945692613131612d, y: 0.10209868683491718d), new NpgsqlTypes.NpgsqlPoint(x: 0.7465270214017974d, y: 0.9310520603251811d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9606641735798155d, y: 0.8673985019340875d), new NpgsqlTypes.NpgsqlPoint(x: 0.9151515062925657d, y: 0.4845489040363916d), new NpgsqlTypes.NpgsqlPoint(x: 0.5159434526391316d, y: 0.11705117934160036d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9019499784011583d, y: 0.15518081342033319d), new NpgsqlTypes.NpgsqlPoint(x: 0.6979359539053731d, y: 0.5756521582717166d), new NpgsqlTypes.NpgsqlPoint(x: 0.8052545407703953d, y: 0.08917751359339021d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429319103867429d, y: 0.4512415511184229d), new NpgsqlTypes.NpgsqlPoint(x: 0.22089394867939205d, y: 0.7975317065229061d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418982498501284d, y: 0.7340351802529462d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6090820573278335d, y: 0.3485038843595941d), new NpgsqlTypes.NpgsqlPoint(x: 0.04793722038062753d, y: 0.5764295900704189d), new NpgsqlTypes.NpgsqlPoint(x: 0.3184632682217281d, y: 0.6644424527523188d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47450920729159685d, y: 0.28324556976784365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9437242803165198d, y: 0.9965370984875012d), new NpgsqlTypes.NpgsqlPoint(x: 0.9411256322065535d, y: 0.7319938007778924d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7977589948011891d, y: 0.08780390912452285d), new NpgsqlTypes.NpgsqlPoint(x: 0.7652638066307963d, y: 0.920065002261888d), new NpgsqlTypes.NpgsqlPoint(x: 0.24661096500186974d, y: 0.9969655136391309d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6075553288022528d, y: 0.8188605946494936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9432881682578016d, y: 0.9853178389344142d), new NpgsqlTypes.NpgsqlPoint(x: 0.8844737667055307d, y: 0.4695248818322858d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12622347713064563d, y: 0.03236195552232091d), new NpgsqlTypes.NpgsqlPoint(x: 0.23083468237893057d, y: 0.07789780816251823d), new NpgsqlTypes.NpgsqlPoint(x: 0.3095886742879367d, y: 0.16202969991846172d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3494184115358486d, y: 0.7839818768318174d), new NpgsqlTypes.NpgsqlPoint(x: 0.5850737590130891d, y: 0.13400167459578127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040969289721312d, y: 0.7261037103555835d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32487398120537003d, y: 0.687197140630098d), new NpgsqlTypes.NpgsqlPoint(x: 0.8616692696088532d, y: 0.41528956937654726d), new NpgsqlTypes.NpgsqlPoint(x: 0.3359062810593748d, y: 0.6247493803661783d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49485881491744876d, y: 0.21534355567131558d), new NpgsqlTypes.NpgsqlPoint(x: 0.31045956802584906d, y: 0.6076409154259372d), new NpgsqlTypes.NpgsqlPoint(x: 0.006837067387978069d, y: 0.20640215566808295d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5985286374399241d, y: 0.7112168937819667d), new NpgsqlTypes.NpgsqlPoint(x: 0.08584560690802046d, y: 0.12721795325517793d), new NpgsqlTypes.NpgsqlPoint(x: 0.768132108330214d, y: 0.349057350820302d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42091395456090086d, y: 0.9618686055654728d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111467304699096d, y: 0.5415626913025148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6891253612116826d, y: 0.4482114382595206d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6156484861180535d, y: 0.736420353559385d), new NpgsqlTypes.NpgsqlPoint(x: 0.6207013820949597d, y: 0.8974748288421611d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138922753585318d, y: 0.018675951670182434d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6278114789604075d, y: 0.14150608006851517d), new NpgsqlTypes.NpgsqlPoint(x: 0.18741357180619123d, y: 0.5653975844957007d), new NpgsqlTypes.NpgsqlPoint(x: 0.20179635387730543d, y: 0.3616539297068928d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.913211108584691d, y: 0.9774100019889209d), new NpgsqlTypes.NpgsqlPoint(x: 0.2544875772586819d, y: 0.8073625130697794d), new NpgsqlTypes.NpgsqlPoint(x: 0.21305246708982772d, y: 0.5492491164773211d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4208249614010622d, y: 0.6571713454613011d), new NpgsqlTypes.NpgsqlPoint(x: 0.44596913450853704d, y: 0.2559147650298371d), new NpgsqlTypes.NpgsqlPoint(x: 0.9127859848899278d, y: 0.6147096141925049d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.91839278220715d, y: 0.550870408307094d), new NpgsqlTypes.NpgsqlPoint(x: 0.33109004986568447d, y: 0.0044385996956792795d), new NpgsqlTypes.NpgsqlPoint(x: 0.5434900890247862d, y: 0.973518387544629d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13654490189338253d, y: 0.5342357701601504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5179934249493056d, y: 0.9145992609223922d), new NpgsqlTypes.NpgsqlPoint(x: 0.9374073505661349d, y: 0.8611709385875553d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8048028896318936d, y: 0.6207637527090558d), new NpgsqlTypes.NpgsqlPoint(x: 0.4794957258510154d, y: 0.6822616010372661d), new NpgsqlTypes.NpgsqlPoint(x: 0.5359409284997051d, y: 0.45543564127576797d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6639749312172155d, y: 0.3101840746119435d), new NpgsqlTypes.NpgsqlPoint(x: 0.30897034581463d, y: 0.5366226778954619d), new NpgsqlTypes.NpgsqlPoint(x: 0.0006561955458498359d, y: 0.7269435879810499d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5052386414152347d, y: 0.15675500828988786d), new NpgsqlTypes.NpgsqlPoint(x: 0.874485830005185d, y: 0.607351998129797d), new NpgsqlTypes.NpgsqlPoint(x: 0.5341792937776833d, y: 0.25644956586916967d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6769241721704446d, y: 0.5657501027054893d), new NpgsqlTypes.NpgsqlPoint(x: 0.5507359709640733d, y: 0.7955767966361883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7702806135620746d, y: 0.35000737559797523d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07207543532561256d, y: 0.583485912837788d), new NpgsqlTypes.NpgsqlPoint(x: 0.13746439070274807d, y: 0.08102824713801393d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296538616394946d, y: 0.6918719276696275d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.009530619487962966d, y: 0.6261049942629516d), new NpgsqlTypes.NpgsqlPoint(x: 0.4005848709757269d, y: 0.8538781597777162d), new NpgsqlTypes.NpgsqlPoint(x: 0.6087113753223348d, y: 0.4485761993396433d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2719654398991448d, y: 0.31534492346857323d), new NpgsqlTypes.NpgsqlPoint(x: 0.18718976191598613d, y: 0.7027596580400032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6417821443223064d, y: 0.3141444124760494d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04660638052198085d, y: 0.07988602601804162d), new NpgsqlTypes.NpgsqlPoint(x: 0.026646629851136194d, y: 0.2353511911223779d), new NpgsqlTypes.NpgsqlPoint(x: 0.5855251294249244d, y: 0.2722359501099544d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5684311013990891d, y: 0.7887914556344491d), new NpgsqlTypes.NpgsqlPoint(x: 0.6888968839713415d, y: 0.6077187958770517d), new NpgsqlTypes.NpgsqlPoint(x: 0.9113972328943457d, y: 0.4255083805278984d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5224624567902484d, y: 0.6315800055288602d), new NpgsqlTypes.NpgsqlPoint(x: 0.2583879428080853d, y: 0.20212659597216853d), new NpgsqlTypes.NpgsqlPoint(x: 0.9442160042339418d, y: 0.8054522713810881d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5195948088569305d, y: 0.3131143668639763d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083418115467156d, y: 0.9506473348030424d), new NpgsqlTypes.NpgsqlPoint(x: 0.9570308727623642d, y: 0.9829544447848211d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9640049433835463d, y: 0.7699434380761929d), new NpgsqlTypes.NpgsqlPoint(x: 0.27044728709495325d, y: 0.3472869222681405d), new NpgsqlTypes.NpgsqlPoint(x: 0.18310966414961882d, y: 0.09707182638177592d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.009042235836101087d, y: 0.06257878609624423d), new NpgsqlTypes.NpgsqlPoint(x: 0.44084380437833026d, y: 0.611830959041127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6866992172449632d, y: 0.7361361503502726d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.577308529755552d, y: 0.9721281994554859d), new NpgsqlTypes.NpgsqlPoint(x: 0.22696479887088195d, y: 0.004458088442149677d), new NpgsqlTypes.NpgsqlPoint(x: 0.047812616615836245d, y: 0.2683299751719287d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30214059727771925d, y: 0.9391843077691626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8947674527435746d, y: 0.30476447233863013d), new NpgsqlTypes.NpgsqlPoint(x: 0.1328411768290113d, y: 0.24763292237991452d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03179060652157606d, y: 0.34274893886557434d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491637217727862d, y: 0.5859346317746953d), new NpgsqlTypes.NpgsqlPoint(x: 0.00753749963963779d, y: 0.9073818493205933d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.646570217557216d, y: 0.9174877791694706d), new NpgsqlTypes.NpgsqlPoint(x: 0.036140978707626115d, y: 0.9622910878503356d), new NpgsqlTypes.NpgsqlPoint(x: 0.007964241551364548d, y: 0.5334676682558709d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07993220795101719d, y: 0.8771200483144106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6871654854259208d, y: 0.621350330157007d), new NpgsqlTypes.NpgsqlPoint(x: 0.4756334476493892d, y: 0.42393576412307576d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9949923028891655d, y: 0.6017156415495409d), new NpgsqlTypes.NpgsqlPoint(x: 0.9340731910947369d, y: 0.3884133108571366d), new NpgsqlTypes.NpgsqlPoint(x: 0.3928014970963124d, y: 0.5800242852145707d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5040649810270929d, y: 0.9788652125393151d), new NpgsqlTypes.NpgsqlPoint(x: 0.5522565805274671d, y: 0.2813458878462435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6476978427344255d, y: 0.9916214948962144d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4839619871928653d, y: 0.9379439489091167d), new NpgsqlTypes.NpgsqlPoint(x: 0.17808775956384626d, y: 0.482907163555058d), new NpgsqlTypes.NpgsqlPoint(x: 0.3868410099322368d, y: 0.9925476446300683d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37386366555343753d, y: 0.04640117106181241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712125754122155d, y: 0.27271710554319184d), new NpgsqlTypes.NpgsqlPoint(x: 0.6070955701377547d, y: 0.44548924912820376d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8816221788659575d, y: 0.833865344896626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298340095706493d, y: 0.06643436944741143d), new NpgsqlTypes.NpgsqlPoint(x: 0.529756522731776d, y: 0.05179500908188184d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3333077031090882d, y: 0.18805348802650912d), new NpgsqlTypes.NpgsqlPoint(x: 0.6933698933078768d, y: 0.5452974621347005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5714749245642702d, y: 0.8474126979708624d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3889683210081687d, y: 0.89381920429338d), new NpgsqlTypes.NpgsqlPoint(x: 0.11747349688693043d, y: 0.5903864836917365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5932875878796859d, y: 0.25830519154328935d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4511000869885873d, y: 0.09462780610147925d), new NpgsqlTypes.NpgsqlPoint(x: 0.4055290788041269d, y: 0.24122881661136797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8034548952073033d, y: 0.4471833247879273d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6375681374324155d, y: 0.4974256904342287d), new NpgsqlTypes.NpgsqlPoint(x: 0.1402537146606011d, y: 0.17522049201051537d), new NpgsqlTypes.NpgsqlPoint(x: 0.1370477227460436d, y: 0.7209375346034844d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01905234170174619d, y: 0.14295910382609045d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040491834808407d, y: 0.20183261651843298d), new NpgsqlTypes.NpgsqlPoint(x: 0.3413688043579448d, y: 0.9404352049753929d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7253308279643402d, y: 0.2897359775723617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079680742844703d, y: 0.1512618715463031d), new NpgsqlTypes.NpgsqlPoint(x: 0.9207350652621826d, y: 0.720248501499192d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9233025489022999d, y: 0.7422955909895558d), new NpgsqlTypes.NpgsqlPoint(x: 0.4876993761785756d, y: 0.2636861339962322d), new NpgsqlTypes.NpgsqlPoint(x: 0.03571194474748651d, y: 0.6318849005325331d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8737244052283121d, y: 0.32835432223023164d), new NpgsqlTypes.NpgsqlPoint(x: 0.9244100074326214d, y: 0.4011734847741276d), new NpgsqlTypes.NpgsqlPoint(x: 0.305234931524633d, y: 0.6323503011628062d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2695843430452073d, y: 0.3490445981464855d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494765326589441d, y: 0.5928814158094478d), new NpgsqlTypes.NpgsqlPoint(x: 0.4560652257247799d, y: 0.08935855492785683d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8652071224015441d, y: 0.6199440164865732d), new NpgsqlTypes.NpgsqlPoint(x: 0.4501396252675053d, y: 0.5616702044751612d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180093151867222d, y: 0.010624196403108854d)))));

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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygon0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
FROM public.binary_npgsqlpolygonpolygon0m m
LEFT JOIN public.binary_npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI), typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

