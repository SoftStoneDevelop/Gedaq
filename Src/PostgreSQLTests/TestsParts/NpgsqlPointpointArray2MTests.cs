

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
    internal partial interface INpgsqlPointListpointArray
    {
    }
    
    internal partial class NpgsqlPointListpointArray : INpgsqlPointListpointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray2M[] _testData = new NpgsqlPointpointArray2M[]
        {
            new NpgsqlPointpointArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7895130955663652d, y: 0.885202450967274d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4622392968254625d, y: 0.05364691475997774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17017571689302868d, y: 0.3903482592228973d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19038088944180598d, y: 0.4902777852478014d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2682611746142841d, y: 0.6615290329826551d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3864091129821d, y: 0.723423253707768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3591933397081678d, y: 0.17080153706681755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5778494449682012d, y: 0.10130028639671318d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9514819819686444d, y: 0.11225170772592419d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8079841137413974d, y: 0.8656552828521478d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9623161796127297d, y: 0.4103309331655348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6299857288097269d, y: 0.6207953992347361d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7512544161735322d, y: 0.8060010936970002d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10937566882474159d, y: 0.857054004747216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4090744533409545d, y: 0.39702052896232454d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8499986447329172d, y: 0.968077486210921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22964293088445176d, y: 0.7252449949712851d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19343751908217632d, y: 0.511182867901403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24552388954855464d, y: 0.9949211490805248d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6249323922310175d, y: 0.3883970817264707d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3445060812649421d, y: 0.8410911476599489d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4573503710414616d, y: 0.39653304041003723d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7888409347329203d, y: 0.17606720850161273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9470512782472009d, y: 0.4492936303030921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8868909578134012d, y: 0.6575928688949846d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.540007046398287d, y: 0.9681695691593837d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4632525958780733d, y: 0.7666352942601447d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5479478060879985d, y: 0.47542691553767913d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02413177777401787d, y: 0.9888723361838508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8037013472835652d, y: 0.2659295020557704d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9876615982991648d, y: 0.9370501447383798d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7666542929369549d, y: 0.740975121576412d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46520698746659916d, y: 0.26379438507387876d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48100663963187584d, y: 0.03895834827461442d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3394674942982724d, y: 0.6779374959687392d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08475536557009689d, y: 0.21203910849716412d),

new NpgsqlTypes.NpgsqlPoint(x: 0.719722416227187d, y: 0.44947004670504365d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35523071744630896d, y: 0.6085459457424691d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03418611784773873d, y: 0.9157362329765614d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.133907453366929d, y: 0.6757092043295143d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4225331107853706d, y: 0.5812196232329919d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8752899637103554d, y: 0.5259942790025638d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.227513293351157d, y: 0.6044680406581318d),

new NpgsqlTypes.NpgsqlPoint(x: 0.911844334412147d, y: 0.4386846176201953d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6654015535549025d, y: 0.1638791390550599d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7829672288087677d, y: 0.7576996781044308d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2614681379606406d, y: 0.9258768631380498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8396513587719874d, y: 0.9332266029230307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.037963509152348696d, y: 0.7561688733168991d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8630440534730254d, y: 0.028034937330476573d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7071871190620641d, y: 0.38473894860411195d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04611531670074931d, y: 0.547082924432644d),

new NpgsqlTypes.NpgsqlPoint(x: 0.443691759990413d, y: 0.6254651122840216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5562593953389351d, y: 0.2726184663060479d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5729003431347056d, y: 0.49410637187277695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9272644000254722d, y: 0.220021016330463d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6575390585482564d, y: 0.6970017449956669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.794002733184432d, y: 0.09955343581488352d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09193835525616656d, y: 0.10984110475295394d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10723375480616859d, y: 0.9393537449535797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8752632550409528d, y: 0.4323525846329991d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5359523739540425d, y: 0.6543179617483927d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8473587284742548d, y: 0.28039839177752457d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7617607643391662d, y: 0.769863933696467d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31223510479220573d, y: 0.4108603131648534d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8878478729297855d, y: 0.09122227567524599d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9266922295682859d, y: 0.12729651691950716d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7813096890443315d, y: 0.6438649101196334d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4342456862787224d, y: 0.5214318531473382d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1840610432901989d, y: 0.7124735765666937d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07875951949686155d, y: 0.3637254618549721d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9555299135523319d, y: 0.35494209356088624d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3447170833556644d, y: 0.3376070278482204d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9421362054058458d, y: 0.40130401947768324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3289651647989128d, y: 0.32518921112872157d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9703317573697863d, y: 0.450123697688532d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9065656848404079d, y: 0.04341078139431598d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9537107462282218d, y: 0.8426193818581736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8027509516754403d, y: 0.9653558673728353d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47218585317202144d, y: 0.1870309326201206d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6673533116308642d, y: 0.501689847111073d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2251763063612714d, y: 0.8116621030089041d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4439061567065118d, y: 0.14324014493532333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18167067708194184d, y: 0.40795405104440585d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7110426331577611d, y: 0.8663975581208391d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5116073122504734d, y: 0.687622278028963d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5770150636528695d, y: 0.26357146510778773d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4579811175880969d, y: 0.9096625129179218d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1084476630498884d, y: 0.22156475489062755d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6401125759729033d, y: 0.6157515209494014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.571728373489414d, y: 0.43086947142980736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6784470125994342d, y: 0.7840717895774519d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9031678194468854d, y: 0.6307213202890286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44365972159285527d, y: 0.07523657498476788d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7911275143299118d, y: 0.025002204110451176d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22779079182446116d, y: 0.8661942158568645d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11981458609900941d, y: 0.6169763601054251d),

new NpgsqlTypes.NpgsqlPoint(x: 0.895509209251377d, y: 0.40908992396309474d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8637009753087465d, y: 0.7369529346609386d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5500602737011743d, y: 0.12308818592018311d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11759513433330637d, y: 0.7960085407024514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49494126980316466d, y: 0.6256027033841808d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.33410914778883216d, y: 0.14346887408986786d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9637619856233749d, y: 0.20686515999053046d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8040998780391644d, y: 0.37378988381759226d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9558686952102788d, y: 0.6688648419381351d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3845814722598875d, y: 0.03468987388227607d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9646768615492614d, y: 0.9812809671272474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7097493585548746d, y: 0.8051323722689367d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16087121678922323d, y: 0.26141801157976385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6716206097652706d, y: 0.7621835468686593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1846994833726996d, y: 0.3664389014291557d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9647510574201364d, y: 0.9295979669176692d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7498609002869635d, y: 0.818658255060112d),

new NpgsqlTypes.NpgsqlPoint(x: 0.033441008798358984d, y: 0.4637083565709411d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4534338650958656d, y: 0.38629361540063867d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8150158086883776d, y: 0.12172378556185726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21498960005448398d, y: 0.22181579482394964d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9527362012310516d, y: 0.5783457086371347d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6861582983579632d, y: 0.8102404623992578d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06625712834390762d, y: 0.48890713134202046d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9386556545428538d, y: 0.3876047137521228d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1451435178842756d, y: 0.4372621954905913d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.017170853387643792d, y: 0.5219881442764963d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5578966933004524d, y: 0.8912688516108321d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34357193056387336d, y: 0.2400426654340453d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9737002473739498d, y: 0.45809636293881306d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8818838912372267d, y: 0.493116877775601d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6692188964141235d, y: 0.5284029781469639d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44101739743194723d, y: 0.06188374861392132d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5606351997101985d, y: 0.3484632938933092d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6048405565219365d, y: 0.6107919978440436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8935256875538372d, y: 0.8732860499103972d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7321435268614604d, y: 0.3355008420624581d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4270353530168167d, y: 0.5808642426241749d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03192519142142525d, y: 0.5562604982421585d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5789689069812414d, y: 0.5702614051680952d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7097275931384469d, y: 0.9782579911758285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13821805778653096d, y: 0.3087712918728912d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6426295981150936d, y: 0.8807784554982235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6576097664607937d, y: 0.8183745559188267d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16550909364724742d, y: 0.43112817767913103d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5288588080614528d, y: 0.10756476903288015d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7669812760234296d, y: 0.1820061183484889d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20159689340845754d, y: 0.7136456362966829d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9136049545119121d, y: 0.30109815597349254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46645831464893295d, y: 0.8537938954685662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4406415633941355d, y: 0.7107437722430999d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5961319273920216d, y: 0.07430481831654989d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9620552868727319d, y: 0.5003491506611287d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6574351444685013d, y: 0.07376934759081766d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29737683766675016d, y: 0.4496903554313796d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03282275047104599d, y: 0.6222539590172815d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5820177855553664d, y: 0.8133376636706318d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6378063886638852d, y: 0.976736537112064d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3383031073440481d, y: 0.34754373791321513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9784529628293697d, y: 0.3577094197077578d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40901098798063806d, y: 0.573391448823019d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.019779996421758317d, y: 0.39753542650610507d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8030717397973554d, y: 0.3445499406910393d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5658492900588159d, y: 0.462805600411502d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2913001205863387d, y: 0.7639011821430131d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8046548723197584d, y: 0.9921893384698889d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6989995751563716d, y: 0.8554699450320635d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48714517564477267d, y: 0.26827982078354007d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9094444593721351d, y: 0.5021271728753338d),

new NpgsqlTypes.NpgsqlPoint(x: 0.017951027934306252d, y: 0.39731587593657414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9378792694077825d, y: 0.8698864246545225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28835445254738146d, y: 0.7342521385338295d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7142106913570022d, y: 0.7045521535564062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2567578934400966d, y: 0.9329693837078098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5314082848459976d, y: 0.2565294303669222d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9626468956064861d, y: 0.7742861833458895d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07085400612521942d, y: 0.10868113862274931d),

new NpgsqlTypes.NpgsqlPoint(x: 0.045325767445155485d, y: 0.038118491810425925d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7537960544051386d, y: 0.4969723556803469d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5118720525595548d, y: 0.8000993679316705d),

new NpgsqlTypes.NpgsqlPoint(x: 0.581907747542446d, y: 0.5910198506400165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18211454930006965d, y: 0.19389994607089667d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9722669247292206d, y: 0.4219991370792261d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7741589535932034d, y: 0.6040237340953851d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6837903677124105d, y: 0.08616846347295903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17738987550477447d, y: 0.5169889536821355d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8849937949498098d, y: 0.17296531399529558d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4791639303439196d, y: 0.5235612467471586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21811230663765702d, y: 0.22039483205633037d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6058476902785607d, y: 0.14265882469785152d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45200552340874356d, y: 0.8379336834440076d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6824889670866565d, y: 0.8309381932954318d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7562471493985679d, y: 0.9406427152090656d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24028338497999824d, y: 0.35075980234031134d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3813160160773561d, y: 0.2541534982095228d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.554837923487347d, y: 0.3969552353127245d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9888680551875129d, y: 0.09744893246092756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7726083642602236d, y: 0.8442338440862039d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4057524899717264d, y: 0.05466051272964434d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6940620124469798d, y: 0.8893377539474233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15214800850450405d, y: 0.6600908933850752d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5224045433471447d, y: 0.31589619718949347d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9421959802903624d, y: 0.3691081772554543d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08522130123894811d, y: 0.5466199153211401d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5627538891732442d, y: 0.0914634522949408d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4399597418048701d, y: 0.13253124856483944d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9185309030185261d, y: 0.0037181425301789917d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5265988896369335d, y: 0.3637099203184465d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43709632612762495d, y: 0.01986435455007618d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7777963952624249d, y: 0.1785705679492645d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8476656186814043d, y: 0.08877996041501934d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7840358841485849d, y: 0.4874069003774031d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2681491649060056d, y: 0.7463013108508241d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12090583319829873d, y: 0.0811259348379676d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5280224181865448d, y: 0.027998382070517525d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7944375693002645d, y: 0.8904855763988406d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3210916113841159d, y: 0.9776485014806315d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35981483856985375d, y: 0.5306941629239628d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5370276375692885d, y: 0.07931302511352412d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9522256662096822d, y: 0.10353260167549594d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10998378039198442d, y: 0.2683106437312164d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4220376525553683d, y: 0.19440596976825797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.853111861679968d, y: 0.8722229763870077d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6785238819456303d, y: 0.9420953442234785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17078578461985205d, y: 0.5018283978488715d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11049971623562482d, y: 0.9830406389225476d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46487321622819955d, y: 0.1034818971466801d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8444207319402327d, y: 0.35631352894880974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3076003516008332d, y: 0.7071194632761819d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3751778671816953d, y: 0.16725793447238135d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3479259725922882d, y: 0.8656621352552344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17935040823252202d, y: 0.13729646080875357d),

new NpgsqlTypes.NpgsqlPoint(x: 0.020974671685689894d, y: 0.39746917670360904d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9699345079748455d, y: 0.5358230186071805d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9251272997481566d, y: 0.2682547581327859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6302292177226064d, y: 0.5476328411698611d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05805255340347881d, y: 0.2606270494145638d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4606825558437224d, y: 0.8528405710262419d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6800769519560862d, y: 0.08160286482653212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3569782017632901d, y: 0.8140783273512772d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23524193829858675d, y: 0.7044025960142324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.005445911184291385d, y: 0.6345968985478337d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05355111729522666d, y: 0.057687258857571755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27874272331629957d, y: 0.9787738055328905d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 184,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9485229428149272d, y: 0.5647650900727154d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4713559165586251d, y: 0.5531163326853505d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21341991172509356d, y: 0.7381713470384751d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.013713446482305325d, y: 0.4058382005809239d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5762573607625048d, y: 0.46575176318259603d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4053025021438783d, y: 0.9124662858265274d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4918977872079401d, y: 0.5008965793056256d),

new NpgsqlTypes.NpgsqlPoint(x: 0.96276564765921d, y: 0.7246544328153687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2662147216772238d, y: 0.6573398637246078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8515219454896847d, y: 0.29390764241378253d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9445813728858735d, y: 0.9582672522087274d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6643475359251326d, y: 0.012047261202374204d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7672470072445918d, y: 0.2843969295885408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4689778943167051d, y: 0.2336158731316723d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 192,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5166225581689237d, y: 0.7941301066503119d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5877327588941943d, y: 0.4098127932472746d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8486203697624396d, y: 0.7943685175343532d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02592890750512522d, y: 0.0725799579502614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0941415943497772d, y: 0.6738350890255854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33628961368157606d, y: 0.3566133249518678d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 199,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36980152908120867d, y: 0.9729767306788248d),

new NpgsqlTypes.NpgsqlPoint(x: 0.89453861158363d, y: 0.8685230236037204d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1468983983713188d, y: 0.9460183975070356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1637398755759487d, y: 0.462197994034655d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44883970773981396d, y: 0.24600058864952912d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8465171168721914d, y: 0.08450679560053997d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8047144810511345d, y: 0.12587042417096705d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6739723355293629d, y: 0.9822785191569436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4687592064765995d, y: 0.8641617215036661d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3668581305407951d, y: 0.05312973069199467d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3543910325579843d, y: 0.7850124585642265d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 205,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7902459693357085d, y: 0.36642318911168337d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7774034589259954d, y: 0.9118716984490415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8605752873668506d, y: 0.9901445481405194d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
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

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                List<NpgsqlPointpointArray2M> models = null;

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray2M> models = null;

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 118;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 150;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 190;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 154, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 190, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 35, query1, 174, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 190, query1, 159, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 140, query1, 118, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 159, query1, 140, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 151, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 172, query1, 85, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 63, 177))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 150, 172))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[29], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[30], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[31], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[32], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[33], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[29], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[30], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[31], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[32], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[33], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[34], false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MI),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray2M),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
FROM public.binary_npgsqlpointpointarray2m m
LEFT JOIN public.binary_npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointListpointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI), typeof(NpgsqlPointpointArray2MI)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                await ((INpgsqlPointListpointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                ((INpgsqlPointListpointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

