

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
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3778951494849443d, y: 0.3546898223356527d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4733330778177304d, y: 0.7119054270262061d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8245058945981343d, y: 0.6462961971376987d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5253889550434777d, y: 0.06305535366146486d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5764460571590202d, y: 0.9584456892691824d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45633383681810824d, y: 0.7121547039797405d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45400515510807093d, y: 0.407887443175591d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1263015978144043d, y: 0.3885576023075984d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0037384400894999725d, y: 0.4212973364320449d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5200186729121793d, y: 0.024317981843501868d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24005100978013993d, y: 0.6368953438492412d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6479522954519409d, y: 0.16377687437531274d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5751459697918802d, y: 0.9902483759417524d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1577130192337184d, y: 0.3735875705961642d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9557106980195877d, y: 0.10265642863689695d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5653011265951069d, y: 0.7177863928950811d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5913389633425725d, y: 0.3950127487492002d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6050462022054351d, y: 0.6087986190010037d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8318516907167505d, y: 0.14490718288864446d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27601219382619946d, y: 0.7001933559247252d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16737818926293224d, y: 0.8299390335511286d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7343909415993368d, y: 0.16571338225526278d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21285352024171744d, y: 0.8383368687058947d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4328776252223874d, y: 0.6568204157953065d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8628822614550418d, y: 0.17646941106935388d),
new NpgsqlTypes.NpgsqlPoint(x: 0.011442310144821555d, y: 0.4167768160637637d),
new NpgsqlTypes.NpgsqlPoint(x: 0.528472246330051d, y: 0.12992920793258744d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4846257705847752d, y: 0.731246965673054d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2970359333168532d, y: 0.6510693354063755d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5909989061263866d, y: 0.24379007604001068d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9335664911374354d, y: 0.43501397997523517d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5572637338279162d, y: 0.495383287537713d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5822690749611363d, y: 0.49080375830575085d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9248169703719591d, y: 0.7416914226119385d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9449442632958909d, y: 0.03844458608549528d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2894656909864042d, y: 0.1334697115007415d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6706409276492562d, y: 0.15095536678233368d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10711548766873091d, y: 0.8138541691613029d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6420783418996346d, y: 0.2597821330515879d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06565865057060905d, y: 0.5247893026679581d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16470882124761932d, y: 0.1526834469803089d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9839571443817887d, y: 0.4543598281067104d),
new NpgsqlTypes.NpgsqlPoint(x: 0.014101736361802675d, y: 0.471420649614418d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9438174091574022d, y: 0.118881197778402d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25681095889415373d, y: 0.9532090792948461d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8299281980446332d, y: 0.41033412195263275d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7807087854451084d, y: 0.5497224262240961d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6541365269466379d, y: 0.687133025954002d),
new NpgsqlTypes.NpgsqlPoint(x: 0.913884921739355d, y: 0.11555958333651806d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8014850165298181d, y: 0.9924792525831462d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9059702878913778d, y: 0.8725554879031133d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3166499275255469d, y: 0.6694637960246711d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9035896250561503d, y: 0.01092178597736937d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15300407871176636d, y: 0.7996707227028768d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9945747752205488d, y: 0.9227831941714405d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4691386541045399d, y: 0.2734194530703522d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8574288339565435d, y: 0.14594305460180246d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9126426552093555d, y: 0.8887086129972953d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6622716630003085d, y: 0.27054716958176117d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5844981835107799d, y: 0.16371371166955173d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5698894196660954d, y: 0.7245468178871635d),
new NpgsqlTypes.NpgsqlPoint(x: 0.828902863122684d, y: 0.0859650195308933d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.672225470429766d, y: 0.6231676101905432d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6024902582480862d, y: 0.27771679140622263d),
new NpgsqlTypes.NpgsqlPoint(x: 0.002316485763376397d, y: 0.4225741480494367d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9415111554115076d, y: 0.4398855574228455d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6535633158603846d, y: 0.30199919847900125d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9283363502034032d, y: 0.5754723106851826d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5616140833342226d, y: 0.46204830817040443d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6712131281997056d, y: 0.4273002808293712d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8209869833603375d, y: 0.8748230300919922d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02404045510095809d, y: 0.06528219549403591d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3284301762847357d, y: 0.4052485322006183d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5858822542435135d, y: 0.7147815684889952d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33912262730401754d, y: 0.8718219810092556d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6818293536150027d, y: 0.7235498128496236d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21904519162043679d, y: 0.36575225136295086d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9944450970382525d, y: 0.988166594517763d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3982420289455191d, y: 0.01021708025577528d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6140298909988734d, y: 0.7489878165899543d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9208676829350371d, y: 0.6006094305457882d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4949954824109597d, y: 0.7983953942557599d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5947179059169083d, y: 0.4693003862682765d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8783904347506252d, y: 0.4929824216818429d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15188595880725853d, y: 0.2946514577012943d),
new NpgsqlTypes.NpgsqlPoint(x: 0.926572887637264d, y: 0.5471315376056727d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5840136748990044d, y: 0.1168843183978654d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8253382254435013d, y: 0.3149080738139518d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4730891592465485d, y: 0.7481060288303224d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4938938358383158d, y: 0.8605008075175838d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17442515159168248d, y: 0.25144805284649807d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39607104599610643d, y: 0.949582549104141d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7465296220356729d, y: 0.5286382103038699d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20387393349269645d, y: 0.11213999494972227d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44920028912516674d, y: 0.9482126881297911d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19776258541311342d, y: 0.18378771779442182d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18036150994693156d, y: 0.8274826159341493d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08984458497051884d, y: 0.591333365531581d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9644808826602504d, y: 0.6345293526679747d),
new NpgsqlTypes.NpgsqlPoint(x: 0.487125781238391d, y: 0.22323308794580898d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5913532379129428d, y: 0.8125367228107871d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8250347613394021d, y: 0.06604151773984102d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09203533148391607d, y: 0.059471599149385046d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.613499330761517d, y: 0.7352664909114792d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8215010143218054d, y: 0.5094976094516621d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8335904497672247d, y: 0.15871150898360398d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27585948090031354d, y: 0.004873951943780153d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02164326029376229d, y: 0.7948608023556659d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05167992290450196d, y: 0.9698636899298287d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2908822492264842d, y: 0.8114042167488338d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6797568581679239d, y: 0.9695994047948991d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9363272838550777d, y: 0.16784553056551055d),
new NpgsqlTypes.NpgsqlPoint(x: 0.039014567882903806d, y: 0.1982612647680183d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27854999874437125d, y: 0.45575439009157914d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8344675746882436d, y: 0.44151791793780926d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8694929646507611d, y: 0.254259187579728d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2369830404643699d, y: 0.7154702433020527d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9471853292650877d, y: 0.5098295240978553d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6468295177866805d, y: 0.2690718364176746d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49973764042417157d, y: 0.6339883885960592d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40996780107310893d, y: 0.17119869994219405d),
new NpgsqlTypes.NpgsqlPoint(x: 0.703932870878232d, y: 0.5015367858109743d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9788124184331068d, y: 0.26342844644738184d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42331833432422594d, y: 0.4251679239308661d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5351501197142421d, y: 0.6692340475989849d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39593454610036594d, y: 0.7406675452568336d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39981508739294347d, y: 0.912242433907296d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26641288755830617d, y: 0.18587684529815662d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7076594946383579d, y: 0.30183873943441375d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38873578151710264d, y: 0.16798893835611695d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27851458050958655d, y: 0.2507314766390183d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2066627125511321d, y: 0.9678416445115436d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2778385689833264d, y: 0.24953104434129714d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35573390257600346d, y: 0.3032568695315847d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6732268308097726d, y: 0.11397139291705671d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2608374318978496d, y: 0.5132711489816105d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10537307000227569d, y: 0.45277821702795307d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15755803870582608d, y: 0.7590687382442964d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08537739585485227d, y: 0.31144159480098466d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45259408146064484d, y: 0.5811782341833199d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3700179005656542d, y: 0.08484726823609023d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9101540118818301d, y: 0.009710608495654194d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12132819034440478d, y: 0.01747847370789868d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7902410583199799d, y: 0.7052949513225722d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0015306399644107183d, y: 0.3401350760662578d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6192777135850525d, y: 0.5152577951917322d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5322695612532575d, y: 0.6232020602351732d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05135406771853768d, y: 0.7347761442230571d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15558348322670656d, y: 0.9204187384012346d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2520874902108272d, y: 0.7340871509177918d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7372236888190368d, y: 0.4446916720632289d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9371141911971863d, y: 0.6598846567970833d),
new NpgsqlTypes.NpgsqlPoint(x: 0.770749948000895d, y: 0.4612656772842212d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06223955783252422d, y: 0.022481558916694677d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5998188831371957d, y: 0.3117095300206194d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30587658547682484d, y: 0.5402576591562888d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9550862280783263d, y: 0.09216213091508851d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9291524109763563d, y: 0.1986300215562683d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6296346403911126d, y: 0.6960692938707788d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9597067848555038d, y: 0.8621234124913391d),
new NpgsqlTypes.NpgsqlPoint(x: 0.019286211068973214d, y: 0.9114161700135796d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.615337125745162d, y: 0.5165322538356316d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0021908622481671136d, y: 0.4123129426549855d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3859912156747789d, y: 0.08146175750644102d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7141170520892153d, y: 0.6793718291969466d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1865845664208886d, y: 0.6704809255487365d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9071019765758347d, y: 0.006703224303070576d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8964402729546926d, y: 0.7514823659507589d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5375317149897044d, y: 0.002397809342900792d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20354698982338904d, y: 0.37735841314814955d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17641463898931675d, y: 0.26313607916552206d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5496444507030469d, y: 0.45329353674559825d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1937560472690475d, y: 0.2730404022593549d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.050416603659588d, y: 0.7404353467306392d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24569532882631884d, y: 0.11542715968875816d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4694211722942141d, y: 0.7955965232592197d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03427467388605998d, y: 0.380677308116675d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21191926334696076d, y: 0.13744506750777286d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2994303618724923d, y: 0.8071599817089551d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7397742910671266d, y: 0.28585455625583056d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4061017126797598d, y: 0.13172029358061688d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6472587414620763d, y: 0.11350183305722683d),
new NpgsqlTypes.NpgsqlPoint(x: 0.910214029492592d, y: 0.7326359369788614d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7254369439573078d, y: 0.8830625755232965d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5829933097004721d, y: 0.19963589856551356d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15440138933846437d, y: 0.19827867756399797d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32112744256993087d, y: 0.476300804121769d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5607304350032721d, y: 0.12386423695082971d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48057648348977566d, y: 0.871633483320832d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1375498632691574d, y: 0.09483992151956211d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2777610948034719d, y: 0.3896340686485835d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1406844165934864d, y: 0.8742613890270017d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0044549776484447134d, y: 0.3313408360129292d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9669769467726288d, y: 0.38044326349611113d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9207816584546581d, y: 0.34432923206358523d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5829162868044644d, y: 0.05622296045901676d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9451820254455938d, y: 0.9727876588105493d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9607171704200838d, y: 0.17920902611940215d),
new NpgsqlTypes.NpgsqlPoint(x: 0.036259809203531224d, y: 0.21108020215480372d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8827829555170821d, y: 0.8599016245291101d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4404003289949542d, y: 0.4590708810082208d),
new NpgsqlTypes.NpgsqlPoint(x: 0.00571241380579357d, y: 0.9636973701169619d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24356807575534567d, y: 0.34604900736259825d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5593391418295148d, y: 0.5858680127691137d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7320017058524436d, y: 0.5360674675646117d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32830028254387833d, y: 0.783557496998666d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6961668408411443d, y: 0.66041850521378d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4778621294367389d, y: 0.539638716620961d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48324441490594616d, y: 0.6177138591238064d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3398443912432152d, y: 0.6526117974296025d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8953419221648113d, y: 0.5176363319771683d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3506814468460733d, y: 0.35238358043913987d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5228693544318603d, y: 0.1350249391478685d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46363419344599244d, y: 0.6144884826257069d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6297275510488072d, y: 0.24196868224482737d),
new NpgsqlTypes.NpgsqlPoint(x: 0.980789335606062d, y: 0.2756342786215247d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4059312667154473d, y: 0.8142146185730749d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5023068250958875d, y: 0.7425218271549188d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6785349541500382d, y: 0.9063176812821392d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7592064939317633d, y: 0.6655670385344357d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22628689495332133d, y: 0.9927440709007732d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5810502998410304d, y: 0.1335800335068421d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7236668151469543d, y: 0.23541658277763566d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7769345157050327d, y: 0.0881774413838764d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0962773976211706d, y: 0.8672945880869447d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07052361267344709d, y: 0.5246206938742382d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4247671986905067d, y: 0.8973916603809134d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5591437897534843d, y: 0.8713557457795583d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2628965905053431d, y: 0.6313792902787833d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14325170024323675d, y: 0.9443683038248302d),
new NpgsqlTypes.NpgsqlPoint(x: 0.571766032674292d, y: 0.6611768713306748d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8185029943261289d, y: 0.36213597812469356d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.925052173899678d, y: 0.11429470164873767d),
new NpgsqlTypes.NpgsqlPoint(x: 0.178043926240525d, y: 0.15604396992053604d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7766346729485138d, y: 0.15626494894171816d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5185178756413374d, y: 0.2025241904656805d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4983245590660007d, y: 0.022964273214130082d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3132373719359547d, y: 0.8615110317097621d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1235856272137058d, y: 0.6317062094771804d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08691274343944999d, y: 0.7065775491679949d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06570420719146641d, y: 0.16204964910083908d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33646130121119244d, y: 0.9205949713349468d),
new NpgsqlTypes.NpgsqlPoint(x: 0.141038955314847d, y: 0.6908140898080632d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.650276773507544d, y: 0.13233899582124153d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7905113165813618d, y: 0.4313052387294046d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7607070396828284d, y: 0.9724221709808064d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4760031639266449d, y: 0.33175297976299134d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37688049905453647d, y: 0.3028432946213575d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6863031972868393d, y: 0.3854713765540737d),
new NpgsqlTypes.NpgsqlPoint(x: 0.241441389883836d, y: 0.4677367779634326d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.416637315910776d, y: 0.3795833037907397d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18704352124433488d, y: 0.7203413140784437d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6322454083952613d, y: 0.18133633364804247d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23084561252922187d, y: 0.2729900643439588d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.740241201907289d, y: 0.0035886851398249098d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13569126280219523d, y: 0.5938160757196791d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9095922734145231d, y: 0.5943873298064268d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8370723412819945d, y: 0.446082756561883d),
},
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
new NpgsqlTypes.NpgsqlPoint(x: 0.9449442632958909d, y: 0.03844458608549528d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2894656909864042d, y: 0.1334697115007415d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6706409276492562d, y: 0.15095536678233368d),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9415111554115076d, y: 0.4398855574228455d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6535633158603846d, y: 0.30199919847900125d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9283363502034032d, y: 0.5754723106851826d),
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
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6140298909988734d, y: 0.7489878165899543d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9208676829350371d, y: 0.6006094305457882d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4949954824109597d, y: 0.7983953942557599d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5947179059169083d, y: 0.4693003862682765d),
}));
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
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 84;
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
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
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 94, query1, 157, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 127, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 132, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 7, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 62, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[34], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 41, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
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
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 110, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[34], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 28, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 112, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 43, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[34], false);
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
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[29], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[30], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[31], false);
                NpgsqlPointpointArray1M.AssertModel(models[29],_testData[32], false);
                NpgsqlPointpointArray1M.AssertModel(models[30],_testData[33], false);
                NpgsqlPointpointArray1M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 128);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[29], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[30], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[31], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[32], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[33], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI), typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                await ((INpgsqlPointArraypointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                ((INpgsqlPointArraypointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

