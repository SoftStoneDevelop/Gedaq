

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
    internal partial interface INpgsqlPathListpathListD1
    {
    }
    
    internal partial class NpgsqlPathListpathListD1 : INpgsqlPathListpathListD1
    {


#region TestData

        private readonly NpgsqlPathpathListD1E2M[] _testData = new NpgsqlPathpathListD1E2M[]
        {
            new NpgsqlPathpathListD1E2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29524585357926125d, y: 0.01761634035841131d), new NpgsqlTypes.NpgsqlPoint(x: 0.0732553958080191d, y: 0.7073264468827518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8017352679648477d, y: 0.9254032861883168d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12197108002143042d, y: 0.3664905323900638d), new NpgsqlTypes.NpgsqlPoint(x: 0.11814064719752126d, y: 0.14769802296320922d), new NpgsqlTypes.NpgsqlPoint(x: 0.8535956809482597d, y: 0.3050541138085512d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19026930613368376d, y: 0.21591220488409535d), new NpgsqlTypes.NpgsqlPoint(x: 0.84817588838841d, y: 0.6444132830196648d), new NpgsqlTypes.NpgsqlPoint(x: 0.15899394707595194d, y: 0.5965817544474198d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9870805558782421d, y: 0.5828242894522125d), new NpgsqlTypes.NpgsqlPoint(x: 0.03572711785556604d, y: 0.9502173838335841d), new NpgsqlTypes.NpgsqlPoint(x: 0.1842398670912102d, y: 0.3916343249713464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13605085367599967d, y: 0.0256180832655708d), new NpgsqlTypes.NpgsqlPoint(x: 0.31336291871351507d, y: 0.09367753415159585d), new NpgsqlTypes.NpgsqlPoint(x: 0.6620040228196574d, y: 0.3822079650573008d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45077668775382473d, y: 0.978989012960504d), new NpgsqlTypes.NpgsqlPoint(x: 0.3882264558296503d, y: 0.07829631102082357d), new NpgsqlTypes.NpgsqlPoint(x: 0.44720475543936866d, y: 0.5114515250046088d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7039244442263615d, y: 0.2570467192555447d), new NpgsqlTypes.NpgsqlPoint(x: 0.8215784226695289d, y: 0.54185514200469d), new NpgsqlTypes.NpgsqlPoint(x: 0.09747019399535561d, y: 0.8660589836567688d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9541093348943213d, y: 0.1696944134150301d), new NpgsqlTypes.NpgsqlPoint(x: 0.7951011881065629d, y: 0.6713603869649102d), new NpgsqlTypes.NpgsqlPoint(x: 0.20143122407656378d, y: 0.7718038012365516d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.497306236835549d, y: 0.24634780048586946d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313033642945904d, y: 0.01735333394840044d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510517734010834d, y: 0.653753238444188d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26777223632031555d, y: 0.8960448772682817d), new NpgsqlTypes.NpgsqlPoint(x: 0.40734266271297137d, y: 0.7697692466629141d), new NpgsqlTypes.NpgsqlPoint(x: 0.39148410463974925d, y: 0.4010282510273111d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1343272662174837d, y: 0.19944050519953638d), new NpgsqlTypes.NpgsqlPoint(x: 0.503419827586885d, y: 0.023790522312956086d), new NpgsqlTypes.NpgsqlPoint(x: 0.32461374916945773d, y: 0.35171381486219233d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48677270894420943d, y: 0.4030065674428819d), new NpgsqlTypes.NpgsqlPoint(x: 0.4014285220669265d, y: 0.5871618191606169d), new NpgsqlTypes.NpgsqlPoint(x: 0.40581648338310194d, y: 0.21060981765258813d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0700317531943142d, y: 0.3433673800522471d), new NpgsqlTypes.NpgsqlPoint(x: 0.4831029916021401d, y: 0.45313741187933787d), new NpgsqlTypes.NpgsqlPoint(x: 0.2465081760506691d, y: 0.6046684045565134d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12445091952866938d, y: 0.34544097186254685d), new NpgsqlTypes.NpgsqlPoint(x: 0.24700454482572476d, y: 0.7159249649024962d), new NpgsqlTypes.NpgsqlPoint(x: 0.5856570659814311d, y: 0.8039891027794436d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13292769380825764d, y: 0.9964784590724298d), new NpgsqlTypes.NpgsqlPoint(x: 0.9348431872731843d, y: 0.7440546510740393d), new NpgsqlTypes.NpgsqlPoint(x: 0.12733925601378004d, y: 0.5006221370409535d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5847221056467719d, y: 0.37202685004143177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366058167545627d, y: 0.8428716052850881d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575679354843226d, y: 0.03373968277943917d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41674105013954765d, y: 0.6874055718337485d), new NpgsqlTypes.NpgsqlPoint(x: 0.12987236586991047d, y: 0.13262189581556783d), new NpgsqlTypes.NpgsqlPoint(x: 0.01748213447090541d, y: 0.5897643351548245d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7067388210222348d, y: 0.2703678548669901d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902871819949519d, y: 0.056027221023808305d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469970788854303d, y: 0.7757839807113213d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33947037405929636d, y: 0.6608410541027423d), new NpgsqlTypes.NpgsqlPoint(x: 0.8714241838939322d, y: 0.5671778506697255d), new NpgsqlTypes.NpgsqlPoint(x: 0.3411562983352666d, y: 0.6404470063635497d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.009711513580707543d, y: 0.6423790602751303d), new NpgsqlTypes.NpgsqlPoint(x: 0.3694633850254969d, y: 0.3822623136393334d), new NpgsqlTypes.NpgsqlPoint(x: 0.3884379870447604d, y: 0.3015179643781313d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7528605813968132d, y: 0.3449663286820768d), new NpgsqlTypes.NpgsqlPoint(x: 0.40221185595618103d, y: 0.7978917851022923d), new NpgsqlTypes.NpgsqlPoint(x: 0.8499759027297777d, y: 0.948840337244264d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5129792104839942d, y: 0.3926211666063353d), new NpgsqlTypes.NpgsqlPoint(x: 0.7109137278244901d, y: 0.9499972855953563d), new NpgsqlTypes.NpgsqlPoint(x: 0.17535737230731263d, y: 0.3800033819472226d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7317311780455337d, y: 0.7420513962007527d), new NpgsqlTypes.NpgsqlPoint(x: 0.44390781105980703d, y: 0.8262635953250246d), new NpgsqlTypes.NpgsqlPoint(x: 0.2570339364377363d, y: 0.2763794237228864d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3216275837302117d, y: 0.8542319623391957d), new NpgsqlTypes.NpgsqlPoint(x: 0.08878576534438454d, y: 0.38457662232580103d), new NpgsqlTypes.NpgsqlPoint(x: 0.27987545168811134d, y: 0.9514627252438029d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33167668043108356d, y: 0.16186437166979528d), new NpgsqlTypes.NpgsqlPoint(x: 0.4531772099871978d, y: 0.20145971687799047d), new NpgsqlTypes.NpgsqlPoint(x: 0.32073528679938357d, y: 0.5258660349748073d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2709491631705061d, y: 0.6418680865242994d), new NpgsqlTypes.NpgsqlPoint(x: 0.31481705251573866d, y: 0.38030640556456197d), new NpgsqlTypes.NpgsqlPoint(x: 0.31560318481435123d, y: 0.5871624021059858d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21299909131835626d, y: 0.9225755421408779d), new NpgsqlTypes.NpgsqlPoint(x: 0.4008190550330467d, y: 0.5647068280340447d), new NpgsqlTypes.NpgsqlPoint(x: 0.03839140087486059d, y: 0.040667999925851905d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7609352466060281d, y: 0.29783889042620526d), new NpgsqlTypes.NpgsqlPoint(x: 0.17379087444083308d, y: 0.3300999556260993d), new NpgsqlTypes.NpgsqlPoint(x: 0.034750994292029214d, y: 0.7515074811134522d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9927125883795684d, y: 0.7947406604393664d), new NpgsqlTypes.NpgsqlPoint(x: 0.08773753060246503d, y: 0.7407619455594748d), new NpgsqlTypes.NpgsqlPoint(x: 0.3224586509073196d, y: 0.0978142422745143d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1770425085409013d, y: 0.6910838270293257d), new NpgsqlTypes.NpgsqlPoint(x: 0.2605471544726663d, y: 0.8060690231557536d), new NpgsqlTypes.NpgsqlPoint(x: 0.3547318373893149d, y: 0.541624359047122d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5792912059361967d, y: 0.1460020417096295d), new NpgsqlTypes.NpgsqlPoint(x: 0.39984252446528035d, y: 0.6158187431521299d), new NpgsqlTypes.NpgsqlPoint(x: 0.9911650390436221d, y: 0.36748361377916183d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7699837751711767d, y: 0.4466995900579275d), new NpgsqlTypes.NpgsqlPoint(x: 0.06039979516400207d, y: 0.6456117609810359d), new NpgsqlTypes.NpgsqlPoint(x: 0.32205153337227377d, y: 0.8606435155366464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22638565517156828d, y: 0.9370136538859507d), new NpgsqlTypes.NpgsqlPoint(x: 0.4073552513516234d, y: 0.7131840762864082d), new NpgsqlTypes.NpgsqlPoint(x: 0.6154117358318116d, y: 0.5186330802939925d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7025816395104636d, y: 0.2865300124010737d), new NpgsqlTypes.NpgsqlPoint(x: 0.7805036985392101d, y: 0.6855718167083014d), new NpgsqlTypes.NpgsqlPoint(x: 0.4649850220837435d, y: 0.09107325237201935d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0005424150524629967d, y: 0.38487311272624003d), new NpgsqlTypes.NpgsqlPoint(x: 0.09028058820181029d, y: 0.4907360798643916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6758830507885103d, y: 0.43001140359664736d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.532412045412703d, y: 0.9650299033495062d), new NpgsqlTypes.NpgsqlPoint(x: 0.16484008254748395d, y: 0.9167502051909474d), new NpgsqlTypes.NpgsqlPoint(x: 0.9723422992168734d, y: 0.35351508020267297d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17633514420298346d, y: 0.5077559475532984d), new NpgsqlTypes.NpgsqlPoint(x: 0.13510980107841863d, y: 0.3847113440553064d), new NpgsqlTypes.NpgsqlPoint(x: 0.19076367243579062d, y: 0.7102681406963052d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.894017155700808d, y: 0.35410554206372435d), new NpgsqlTypes.NpgsqlPoint(x: 0.7862562448017423d, y: 0.4574111863989415d), new NpgsqlTypes.NpgsqlPoint(x: 0.7658003372534582d, y: 0.563604911127957d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6759918466595575d, y: 0.6265175207874533d), new NpgsqlTypes.NpgsqlPoint(x: 0.3675319703282368d, y: 0.07611950300758807d), new NpgsqlTypes.NpgsqlPoint(x: 0.41005848857067695d, y: 0.07937279833911581d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06847820628361256d, y: 0.36920839076008827d), new NpgsqlTypes.NpgsqlPoint(x: 0.9524115651270395d, y: 0.47485047634649624d), new NpgsqlTypes.NpgsqlPoint(x: 0.13791488345648528d, y: 0.29431935177013213d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6674396431809485d, y: 0.366347402215043d), new NpgsqlTypes.NpgsqlPoint(x: 0.07230971725012525d, y: 0.9631408515480069d), new NpgsqlTypes.NpgsqlPoint(x: 0.1254383907553409d, y: 0.6796181198677644d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5736909168629365d, y: 0.6650886983595478d), new NpgsqlTypes.NpgsqlPoint(x: 0.8709436448154189d, y: 0.846112638806967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8484388456513519d, y: 0.22666052103811618d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1254822401251694d, y: 0.7589832450794257d), new NpgsqlTypes.NpgsqlPoint(x: 0.8612441780542351d, y: 0.3783191626801876d), new NpgsqlTypes.NpgsqlPoint(x: 0.2853216859153641d, y: 0.03803856961993868d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8291471407355344d, y: 0.1638823505950474d), new NpgsqlTypes.NpgsqlPoint(x: 0.23747012710568305d, y: 0.9764355687021952d), new NpgsqlTypes.NpgsqlPoint(x: 0.7156937901627364d, y: 0.18235286259869699d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13800053745684582d, y: 0.20850262505965167d), new NpgsqlTypes.NpgsqlPoint(x: 0.26006927447774d, y: 0.9603282880405298d), new NpgsqlTypes.NpgsqlPoint(x: 0.4556315235668035d, y: 0.4687411070175831d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7860644932522916d, y: 0.1113021200560742d), new NpgsqlTypes.NpgsqlPoint(x: 0.34710164470517324d, y: 0.7930952416892105d), new NpgsqlTypes.NpgsqlPoint(x: 0.7716767431313271d, y: 0.8429937175873966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28523143192953604d, y: 0.7943642235452335d), new NpgsqlTypes.NpgsqlPoint(x: 0.23064016286574096d, y: 0.9976338217514653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6261819370600865d, y: 0.038548491757196324d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8616438030278714d, y: 0.6583782273326643d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483828485072507d, y: 0.07289688779559089d), new NpgsqlTypes.NpgsqlPoint(x: 0.9525640117408556d, y: 0.0021545580698979494d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9987274938464058d, y: 0.247224765614664d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738549093584282d, y: 0.997987328485123d), new NpgsqlTypes.NpgsqlPoint(x: 0.33810693221029553d, y: 0.22616142371183323d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1138508522430336d, y: 0.26639009181342144d), new NpgsqlTypes.NpgsqlPoint(x: 0.42991883090588645d, y: 0.9888051204544615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5381897065981182d, y: 0.95237703151704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.766714763875126d, y: 0.16636420235944793d), new NpgsqlTypes.NpgsqlPoint(x: 0.19539668270060417d, y: 0.4814521131723064d), new NpgsqlTypes.NpgsqlPoint(x: 0.6971962071536307d, y: 0.934879341607223d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9317345265264d, y: 0.7117013411664581d), new NpgsqlTypes.NpgsqlPoint(x: 0.022230138715872205d, y: 0.15326889268234822d), new NpgsqlTypes.NpgsqlPoint(x: 0.1890333525518748d, y: 0.6925938230170381d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.800555158060306d, y: 0.3262612923877757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8170801419377005d, y: 0.25694817790423674d), new NpgsqlTypes.NpgsqlPoint(x: 0.3080789414027054d, y: 0.3243093834430646d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.724347740478715d, y: 0.42352293828980303d), new NpgsqlTypes.NpgsqlPoint(x: 0.07147229466373362d, y: 0.3886662893933551d), new NpgsqlTypes.NpgsqlPoint(x: 0.8406492976751125d, y: 0.5396925777512782d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5130143691802341d, y: 0.5074031906020078d), new NpgsqlTypes.NpgsqlPoint(x: 0.3397513405508378d, y: 0.43310992264923776d), new NpgsqlTypes.NpgsqlPoint(x: 0.7459705187811133d, y: 0.7885166582521388d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7070141001222578d, y: 0.13476109865410024d), new NpgsqlTypes.NpgsqlPoint(x: 0.506020868075711d, y: 0.2877376801382414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4848044019028336d, y: 0.14730879797369822d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5115797639137392d, y: 0.45839864882083603d), new NpgsqlTypes.NpgsqlPoint(x: 0.1887501456032067d, y: 0.8189045590876445d), new NpgsqlTypes.NpgsqlPoint(x: 0.6887369517947665d, y: 0.07123893076060472d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1766391166458574d, y: 0.3039003524231785d), new NpgsqlTypes.NpgsqlPoint(x: 0.8384265129948139d, y: 0.4897579472506127d), new NpgsqlTypes.NpgsqlPoint(x: 0.21679410474996486d, y: 0.8908790444655933d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45769476710789625d, y: 0.14145455191347467d), new NpgsqlTypes.NpgsqlPoint(x: 0.6933638161428924d, y: 0.032576604747651006d), new NpgsqlTypes.NpgsqlPoint(x: 0.46417340148360897d, y: 0.7041469409615547d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6929943542800638d, y: 0.1775328629855727d), new NpgsqlTypes.NpgsqlPoint(x: 0.8576327444863464d, y: 0.9378617361726712d), new NpgsqlTypes.NpgsqlPoint(x: 0.41728682243434745d, y: 0.5980776182837007d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6749110296950485d, y: 0.7668622837716763d), new NpgsqlTypes.NpgsqlPoint(x: 0.9776737931055461d, y: 0.18258453481878334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6920104158556587d, y: 0.80959129558435d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13402009207572751d, y: 0.9202710526540538d), new NpgsqlTypes.NpgsqlPoint(x: 0.5181782008876037d, y: 0.2627932096892791d), new NpgsqlTypes.NpgsqlPoint(x: 0.8634055278449881d, y: 0.8074786137910268d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8647888156767887d, y: 0.4554120106996403d), new NpgsqlTypes.NpgsqlPoint(x: 0.3130397124251092d, y: 0.13541668530852824d), new NpgsqlTypes.NpgsqlPoint(x: 0.42820698215800657d, y: 0.5694768048832778d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7156637407440907d, y: 0.9330189158602248d), new NpgsqlTypes.NpgsqlPoint(x: 0.7302460450085503d, y: 0.5455853456431435d), new NpgsqlTypes.NpgsqlPoint(x: 0.9571764231579518d, y: 0.8158236004323943d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9273858153957174d, y: 0.19519759737136166d), new NpgsqlTypes.NpgsqlPoint(x: 0.4705969956931778d, y: 0.5794835074259375d), new NpgsqlTypes.NpgsqlPoint(x: 0.6116253832386215d, y: 0.052291558813181815d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5816096368686634d, y: 0.34578151029229187d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253013495690409d, y: 0.3089587688723451d), new NpgsqlTypes.NpgsqlPoint(x: 0.897102325203767d, y: 0.6910704187091327d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6354114132381833d, y: 0.5781536624819159d), new NpgsqlTypes.NpgsqlPoint(x: 0.8918397707395663d, y: 0.7590423341045351d), new NpgsqlTypes.NpgsqlPoint(x: 0.817249335476168d, y: 0.5508277822493828d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2064927026282667d, y: 0.12562997870763082d), new NpgsqlTypes.NpgsqlPoint(x: 0.13848663543881867d, y: 0.9911694208096798d), new NpgsqlTypes.NpgsqlPoint(x: 0.4042590906095106d, y: 0.24811880344716186d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2299081552363046d, y: 0.6700853881425426d), new NpgsqlTypes.NpgsqlPoint(x: 0.19349977036767285d, y: 0.03055184855083981d), new NpgsqlTypes.NpgsqlPoint(x: 0.9059623924571886d, y: 0.2961729214091291d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.801624343409276d, y: 0.4411341574900042d), new NpgsqlTypes.NpgsqlPoint(x: 0.786364956619863d, y: 0.5963588426131033d), new NpgsqlTypes.NpgsqlPoint(x: 0.26814608195091727d, y: 0.694001631528249d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4003944863838157d, y: 0.03530407738679964d), new NpgsqlTypes.NpgsqlPoint(x: 0.3832657305129781d, y: 0.7301008693385362d), new NpgsqlTypes.NpgsqlPoint(x: 0.2651881447924025d, y: 0.18402243136227203d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08262482868461529d, y: 0.6156183941330682d), new NpgsqlTypes.NpgsqlPoint(x: 0.2407219027665496d, y: 0.23229351301339995d), new NpgsqlTypes.NpgsqlPoint(x: 0.1584426035603912d, y: 0.7448133263064002d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9195464531507787d, y: 0.3016011744894207d), new NpgsqlTypes.NpgsqlPoint(x: 0.9563765015651421d, y: 0.035057089792657314d), new NpgsqlTypes.NpgsqlPoint(x: 0.010292920865918487d, y: 0.5387363567393256d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7586371116257197d, y: 0.38103232233357787d), new NpgsqlTypes.NpgsqlPoint(x: 0.5229179672004096d, y: 0.4111257448128933d), new NpgsqlTypes.NpgsqlPoint(x: 0.051546665373171874d, y: 0.35401487087731687d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8617375932967835d, y: 0.21718400634951385d), new NpgsqlTypes.NpgsqlPoint(x: 0.17043644072847874d, y: 0.33345757359538886d), new NpgsqlTypes.NpgsqlPoint(x: 0.6284989193285452d, y: 0.5144504980760559d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04932624670995234d, y: 0.488578639305266d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919873365802752d, y: 0.37802599697373385d), new NpgsqlTypes.NpgsqlPoint(x: 0.5265215674893663d, y: 0.16582847245907462d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8043793156402009d, y: 0.7720346368610022d), new NpgsqlTypes.NpgsqlPoint(x: 0.3930272330526514d, y: 0.04333253973666962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239104083698235d, y: 0.5058933744372456d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02120761671224136d, y: 0.3446221219884428d), new NpgsqlTypes.NpgsqlPoint(x: 0.3008945560658064d, y: 0.136247545056304d), new NpgsqlTypes.NpgsqlPoint(x: 0.3199292038535412d, y: 0.1397193317627533d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4768952655961076d, y: 0.28059920828078977d), new NpgsqlTypes.NpgsqlPoint(x: 0.8670982516360296d, y: 0.29284352462479246d), new NpgsqlTypes.NpgsqlPoint(x: 0.6630867892903215d, y: 0.04639929833328793d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6707955718814228d, y: 0.27177354111293284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8595492389396072d, y: 0.061308337928760004d), new NpgsqlTypes.NpgsqlPoint(x: 0.40527410960675603d, y: 0.7345215765303902d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6335612274619138d, y: 0.24510600184550013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5522989181242967d, y: 0.31231406383649507d), new NpgsqlTypes.NpgsqlPoint(x: 0.030995163439499707d, y: 0.10918020507914261d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9075266400922226d, y: 0.8644424181766639d), new NpgsqlTypes.NpgsqlPoint(x: 0.6315506207917678d, y: 0.3510230125229483d), new NpgsqlTypes.NpgsqlPoint(x: 0.3281534985211705d, y: 0.9531697479134835d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30805096888706707d, y: 0.8894107774368162d), new NpgsqlTypes.NpgsqlPoint(x: 0.44076087362277505d, y: 0.5963097003990497d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554624727765493d, y: 0.17419320734202015d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6933314118255399d, y: 0.2964173269351743d), new NpgsqlTypes.NpgsqlPoint(x: 0.31416766261807816d, y: 0.8962718059411952d), new NpgsqlTypes.NpgsqlPoint(x: 0.5850697336338376d, y: 0.26678168122683166d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6995279367169183d, y: 0.1874134298450435d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237251149255753d, y: 0.6703134077574543d), new NpgsqlTypes.NpgsqlPoint(x: 0.06551975669382282d, y: 0.4685223911047731d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9691190749524479d, y: 0.43683531236625206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060743172537393d, y: 0.5706889551588403d), new NpgsqlTypes.NpgsqlPoint(x: 0.3206246998560627d, y: 0.28767335452115583d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3970307317823877d, y: 0.6809784743058077d), new NpgsqlTypes.NpgsqlPoint(x: 0.7185672466239498d, y: 0.5097088110647874d), new NpgsqlTypes.NpgsqlPoint(x: 0.24157046917366942d, y: 0.7513530118169442d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07160084757595331d, y: 0.24203714651321062d), new NpgsqlTypes.NpgsqlPoint(x: 0.45524940769601185d, y: 0.1256934033049507d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206531883885905d, y: 0.2745061183174915d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5061139069497446d, y: 0.8919716274267235d), new NpgsqlTypes.NpgsqlPoint(x: 0.09841009021758862d, y: 0.02318449896926289d), new NpgsqlTypes.NpgsqlPoint(x: 0.8639098451425783d, y: 0.5700539553389914d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.849705958690681d, y: 0.7340565673633601d), new NpgsqlTypes.NpgsqlPoint(x: 0.8327685244516084d, y: 0.9075252046963221d), new NpgsqlTypes.NpgsqlPoint(x: 0.6865552537697318d, y: 0.26160721733791104d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6529970592081303d, y: 0.9588496224683012d), new NpgsqlTypes.NpgsqlPoint(x: 0.5143233022109724d, y: 0.635081952552127d), new NpgsqlTypes.NpgsqlPoint(x: 0.7592538510295407d, y: 0.9220635862138938d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7588105527931338d, y: 0.025736257186852463d), new NpgsqlTypes.NpgsqlPoint(x: 0.8008094335888233d, y: 0.7189440033819632d), new NpgsqlTypes.NpgsqlPoint(x: 0.48158544822735827d, y: 0.8231806706501086d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5987269481263461d, y: 0.7784143565358638d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994036351828455d, y: 0.5387894056730052d), new NpgsqlTypes.NpgsqlPoint(x: 0.4126859003968063d, y: 0.201386814473819d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8163873092828361d, y: 0.6963996506433247d), new NpgsqlTypes.NpgsqlPoint(x: 0.959994056075137d, y: 0.7237280935431686d), new NpgsqlTypes.NpgsqlPoint(x: 0.0747883572750746d, y: 0.9557618464029743d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6603783174043838d, y: 0.23277040510995217d), new NpgsqlTypes.NpgsqlPoint(x: 0.11490825954719575d, y: 0.6767376285638225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7018645431029883d, y: 0.4892196000900584d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5707282087884821d, y: 0.6225121427719101d), new NpgsqlTypes.NpgsqlPoint(x: 0.7983415685659034d, y: 0.6856499847789301d), new NpgsqlTypes.NpgsqlPoint(x: 0.06679673520194285d, y: 0.8106864536192843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4243056027588563d, y: 0.24601434543221623d), new NpgsqlTypes.NpgsqlPoint(x: 0.8170573832815726d, y: 0.003422947823417899d), new NpgsqlTypes.NpgsqlPoint(x: 0.5172492184139411d, y: 0.26107732265058714d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3708744277938747d, y: 0.58795716807824d), new NpgsqlTypes.NpgsqlPoint(x: 0.691186196508129d, y: 0.6597552005510939d), new NpgsqlTypes.NpgsqlPoint(x: 0.2558150503099488d, y: 0.8027629273018927d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5458780838957143d, y: 0.2475799003971335d), new NpgsqlTypes.NpgsqlPoint(x: 0.48898970059967717d, y: 0.5488022168864478d), new NpgsqlTypes.NpgsqlPoint(x: 0.8912138163629392d, y: 0.09906312012212004d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8876503915273871d, y: 0.16489222453524977d), new NpgsqlTypes.NpgsqlPoint(x: 0.3538584568863973d, y: 0.8959873351484904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6707407185597776d, y: 0.9158776154685673d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42429648205225423d, y: 0.5706666589364788d), new NpgsqlTypes.NpgsqlPoint(x: 0.6385766205041531d, y: 0.6380524213302915d), new NpgsqlTypes.NpgsqlPoint(x: 0.0036404540107153327d, y: 0.19145100534515525d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5406096872186055d, y: 0.5517102330129995d), new NpgsqlTypes.NpgsqlPoint(x: 0.7139285630808987d, y: 0.32488633483696294d), new NpgsqlTypes.NpgsqlPoint(x: 0.8080561320926261d, y: 0.6742366028212399d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15695440741856626d, y: 0.8805426666008477d), new NpgsqlTypes.NpgsqlPoint(x: 0.9505357643192273d, y: 0.06158191817475145d), new NpgsqlTypes.NpgsqlPoint(x: 0.3988881101554853d, y: 0.405786722597582d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12452598949924143d, y: 0.34783613947620906d), new NpgsqlTypes.NpgsqlPoint(x: 0.029119250230480342d, y: 0.502474685905043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6756625135510238d, y: 0.8560669291652665d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8043265927397895d, y: 0.6774170774526967d), new NpgsqlTypes.NpgsqlPoint(x: 0.9162800172537248d, y: 0.42793586336254197d), new NpgsqlTypes.NpgsqlPoint(x: 0.20999338565871783d, y: 0.4843529999696694d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9809411163220656d, y: 0.7504338633098601d), new NpgsqlTypes.NpgsqlPoint(x: 0.2545517357454916d, y: 0.2927196461809618d), new NpgsqlTypes.NpgsqlPoint(x: 0.38180651834626145d, y: 0.3353538462632768d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7087557524187322d, y: 0.5532526999151152d), new NpgsqlTypes.NpgsqlPoint(x: 0.09886792111030618d, y: 0.8400052275387803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7576012127941993d, y: 0.0008998003838960322d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40415937831233917d, y: 0.07959168823367668d), new NpgsqlTypes.NpgsqlPoint(x: 0.1493532523880604d, y: 0.9206543416351165d), new NpgsqlTypes.NpgsqlPoint(x: 0.8772681037946627d, y: 0.1024874024328779d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7963305852093442d, y: 0.31712141333370925d), new NpgsqlTypes.NpgsqlPoint(x: 0.3767237511865935d, y: 0.7904751700538093d), new NpgsqlTypes.NpgsqlPoint(x: 0.23534007828965042d, y: 0.05837167627580775d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41775092502463285d, y: 0.6991170145750402d), new NpgsqlTypes.NpgsqlPoint(x: 0.7008806014114398d, y: 0.7378870679204711d), new NpgsqlTypes.NpgsqlPoint(x: 0.2301271909123972d, y: 0.45520832396293875d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8019506126934487d, y: 0.20830218783201515d), new NpgsqlTypes.NpgsqlPoint(x: 0.09726542100539148d, y: 0.30671899809096237d), new NpgsqlTypes.NpgsqlPoint(x: 0.80771773948895d, y: 0.7858514683971534d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2958079387152798d, y: 0.49882142529231244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9221788290824491d, y: 0.4601000286010013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9067192793400135d, y: 0.08542359834560764d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.641230676021066d, y: 0.9302876778365505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8046572899875876d, y: 0.10544788049613163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9273163955552607d, y: 0.34366054972572446d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9527301922584578d, y: 0.01792603346925803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5209129585905976d, y: 0.05801321876708998d), new NpgsqlTypes.NpgsqlPoint(x: 0.2731390777967202d, y: 0.3635087551413899d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04473794813737331d, y: 0.9090542108193596d), new NpgsqlTypes.NpgsqlPoint(x: 0.27433676338318014d, y: 0.44578758396970675d), new NpgsqlTypes.NpgsqlPoint(x: 0.20941774276839586d, y: 0.9265529898760085d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2775087870839271d, y: 0.4893790019158225d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712280627221807d, y: 0.42795010192805116d), new NpgsqlTypes.NpgsqlPoint(x: 0.6147236623039621d, y: 0.9072276309387792d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8892348231271927d, y: 0.6003724948767714d), new NpgsqlTypes.NpgsqlPoint(x: 0.237922204832266d, y: 0.6799985045244865d), new NpgsqlTypes.NpgsqlPoint(x: 0.3916546139864071d, y: 0.14299897669093198d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40953053974399733d, y: 0.3875926218906982d), new NpgsqlTypes.NpgsqlPoint(x: 0.3941480927525337d, y: 0.8994405507935483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9664082149905452d, y: 0.25300251213469194d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5511966186273257d, y: 0.5517826856989658d), new NpgsqlTypes.NpgsqlPoint(x: 0.7160862460960765d, y: 0.4059618548963244d), new NpgsqlTypes.NpgsqlPoint(x: 0.5770356295796977d, y: 0.7061793702516621d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03248366492076604d, y: 0.7455065902203035d), new NpgsqlTypes.NpgsqlPoint(x: 0.41679665706663205d, y: 0.8233347808869478d), new NpgsqlTypes.NpgsqlPoint(x: 0.302692263297744d, y: 0.7160007553783968d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.422814009273322d, y: 0.7879926643957303d), new NpgsqlTypes.NpgsqlPoint(x: 0.20256377293493977d, y: 0.5847335541148888d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668815780530844d, y: 0.2769682525272168d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8369584182271057d, y: 0.45433680774539886d), new NpgsqlTypes.NpgsqlPoint(x: 0.5479128242913169d, y: 0.6744042702703622d), new NpgsqlTypes.NpgsqlPoint(x: 0.5733067905802882d, y: 0.7452794280903905d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0973537498661311d, y: 0.09282825957571572d), new NpgsqlTypes.NpgsqlPoint(x: 0.4282600819603555d, y: 0.7743511468318484d), new NpgsqlTypes.NpgsqlPoint(x: 0.36787976239537845d, y: 0.13803526298870394d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12266697975493224d, y: 0.03065749675583762d), new NpgsqlTypes.NpgsqlPoint(x: 0.9315496246848837d, y: 0.7541667450386612d), new NpgsqlTypes.NpgsqlPoint(x: 0.3027665708832773d, y: 0.12257248449597313d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4863471168845349d, y: 0.5031874299519902d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712750631429441d, y: 0.23982302659812593d), new NpgsqlTypes.NpgsqlPoint(x: 0.6234945329516034d, y: 0.17728062484723628d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6104134400708526d, y: 0.7397128894721672d), new NpgsqlTypes.NpgsqlPoint(x: 0.7991032273342713d, y: 0.8399063130276916d), new NpgsqlTypes.NpgsqlPoint(x: 0.12634624329769273d, y: 0.06918004607031558d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4135336111643415d, y: 0.46275529055451803d), new NpgsqlTypes.NpgsqlPoint(x: 0.41882367397816866d, y: 0.10085928782830988d), new NpgsqlTypes.NpgsqlPoint(x: 0.529282497861695d, y: 0.8154582607564783d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18636310882658824d, y: 0.348638481269374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9678836815757564d, y: 0.3333377552734399d), new NpgsqlTypes.NpgsqlPoint(x: 0.3423078302342958d, y: 0.07292637036024419d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.468311713767129d, y: 0.7052410272212509d), new NpgsqlTypes.NpgsqlPoint(x: 0.9969248431507785d, y: 0.4941693090117434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5030059335739193d, y: 0.6516638020810251d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4646333256701868d, y: 0.4597953119604792d), new NpgsqlTypes.NpgsqlPoint(x: 0.005151400851985177d, y: 0.4324781578463799d), new NpgsqlTypes.NpgsqlPoint(x: 0.6587125565119905d, y: 0.07347269261322631d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2102617355531856d, y: 0.4873600434740233d), new NpgsqlTypes.NpgsqlPoint(x: 0.27681669780231744d, y: 0.15452855862437165d), new NpgsqlTypes.NpgsqlPoint(x: 0.5741957735481733d, y: 0.6936991338582515d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.697910611932091d, y: 0.11632035030878796d), new NpgsqlTypes.NpgsqlPoint(x: 0.3408927937615627d, y: 0.10625531000196964d), new NpgsqlTypes.NpgsqlPoint(x: 0.9434024373166874d, y: 0.5294207245339555d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0517122579974163d, y: 0.5592869678248742d), new NpgsqlTypes.NpgsqlPoint(x: 0.30113569695608833d, y: 0.9763246982733059d), new NpgsqlTypes.NpgsqlPoint(x: 0.6399828520338401d, y: 0.34427539930591144d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18137416762523917d, y: 0.2745023416069423d), new NpgsqlTypes.NpgsqlPoint(x: 0.6453435079190545d, y: 0.5594970962229029d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395766735039773d, y: 0.6414598447857663d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1808558402644448d, y: 0.3741644339159703d), new NpgsqlTypes.NpgsqlPoint(x: 0.057389368210273295d, y: 0.1739229061582448d), new NpgsqlTypes.NpgsqlPoint(x: 0.5664065151254989d, y: 0.9141450710042576d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.095540130585407d, y: 0.09327271550114413d), new NpgsqlTypes.NpgsqlPoint(x: 0.4727154597202152d, y: 0.4130103036685102d), new NpgsqlTypes.NpgsqlPoint(x: 0.8915430508837188d, y: 0.33313093140905037d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2372709024329529d, y: 0.9659900905765898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7990711160353027d, y: 0.10848889122934657d), new NpgsqlTypes.NpgsqlPoint(x: 0.4422878423338813d, y: 0.873955815052984d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5319663214198478d, y: 0.1226195752110465d), new NpgsqlTypes.NpgsqlPoint(x: 0.6071584861163783d, y: 0.7750589882876971d), new NpgsqlTypes.NpgsqlPoint(x: 0.1675978745624025d, y: 0.6406678381638622d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7709259198992432d, y: 0.06776817010742953d), new NpgsqlTypes.NpgsqlPoint(x: 0.16254137488091414d, y: 0.15945799135543248d), new NpgsqlTypes.NpgsqlPoint(x: 0.6204400749760457d, y: 0.8653204018981299d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8345265971092393d, y: 0.08255249179819935d), new NpgsqlTypes.NpgsqlPoint(x: 0.1167318568607959d, y: 0.37178092708386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7585956429366713d, y: 0.4127650244601142d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9104335751437921d, y: 0.9723184154233763d), new NpgsqlTypes.NpgsqlPoint(x: 0.6727527094779922d, y: 0.7231766018424547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6222872850807495d, y: 0.7215201597038549d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5494303682151155d, y: 0.9861482032769547d), new NpgsqlTypes.NpgsqlPoint(x: 0.11232010735336273d, y: 0.5907244547394009d), new NpgsqlTypes.NpgsqlPoint(x: 0.8544803601526337d, y: 0.8864989997973729d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4913348907228893d, y: 0.7251554436424537d), new NpgsqlTypes.NpgsqlPoint(x: 0.31057465425875463d, y: 0.060884991139550704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9915525613217187d, y: 0.019862532589060233d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7000591603429631d, y: 0.7619769195118473d), new NpgsqlTypes.NpgsqlPoint(x: 0.3720257261714318d, y: 0.45556775290721274d), new NpgsqlTypes.NpgsqlPoint(x: 0.45851663132734743d, y: 0.9909375209341115d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18674742149966717d, y: 0.5950837284976572d), new NpgsqlTypes.NpgsqlPoint(x: 0.3124907039133067d, y: 0.5693208876790133d), new NpgsqlTypes.NpgsqlPoint(x: 0.6918289106797039d, y: 0.39568488324645623d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.816081833338051d, y: 0.4446617699890967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8784462097529285d, y: 0.7605919129172364d), new NpgsqlTypes.NpgsqlPoint(x: 0.47847833273113194d, y: 0.777216508929495d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9113363936917466d, y: 0.7112476355138496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5429902763570131d, y: 0.7583861889293084d), new NpgsqlTypes.NpgsqlPoint(x: 0.3219071249079153d, y: 0.9757678603856718d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.830857277337165d, y: 0.8547228725637974d), new NpgsqlTypes.NpgsqlPoint(x: 0.8397871156086912d, y: 0.6195145627797052d), new NpgsqlTypes.NpgsqlPoint(x: 0.1828211717436521d, y: 0.08676311060065978d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1694967238728725d, y: 0.028819588435506693d), new NpgsqlTypes.NpgsqlPoint(x: 0.7924352243345805d, y: 0.11266815070400171d), new NpgsqlTypes.NpgsqlPoint(x: 0.44940500018156015d, y: 0.5671685494132463d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09434528794317765d, y: 0.837525815497283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7445382503487858d, y: 0.44707297283228653d), new NpgsqlTypes.NpgsqlPoint(x: 0.15908173781755408d, y: 0.12696804861152922d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3012168305781828d, y: 0.6816279712642717d), new NpgsqlTypes.NpgsqlPoint(x: 0.7099233897826658d, y: 0.4961565500487225d), new NpgsqlTypes.NpgsqlPoint(x: 0.025752135608854143d, y: 0.43016585510846816d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8075189513924675d, y: 0.9272582497916142d), new NpgsqlTypes.NpgsqlPoint(x: 0.995190824242212d, y: 0.5196639380682482d), new NpgsqlTypes.NpgsqlPoint(x: 0.12164320770450598d, y: 0.0500598295544753d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7669482206661288d, y: 0.41867668627901966d), new NpgsqlTypes.NpgsqlPoint(x: 0.5875381674151525d, y: 0.6117178538407014d), new NpgsqlTypes.NpgsqlPoint(x: 0.25070076332354607d, y: 0.11294922487634917d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19244739139995726d, y: 0.7282114283605016d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096268774360425d, y: 0.30182302877298983d), new NpgsqlTypes.NpgsqlPoint(x: 0.4762702553933944d, y: 0.16007739984436997d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4466450019682342d, y: 0.7876537321178971d), new NpgsqlTypes.NpgsqlPoint(x: 0.19641512908524128d, y: 0.5071066332174529d), new NpgsqlTypes.NpgsqlPoint(x: 0.071671888762455d, y: 0.40601309589419476d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4330663229445979d, y: 0.8684027780646257d), new NpgsqlTypes.NpgsqlPoint(x: 0.42569305461582085d, y: 0.21693578298050908d), new NpgsqlTypes.NpgsqlPoint(x: 0.702997748552588d, y: 0.07935803415385057d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3304321969477897d, y: 0.362355872280388d), new NpgsqlTypes.NpgsqlPoint(x: 0.17320165607689386d, y: 0.8967146389906475d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040140548613072d, y: 0.5694429301852619d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17124643614258328d, y: 0.4615461043485838d), new NpgsqlTypes.NpgsqlPoint(x: 0.9376860780926976d, y: 0.41703905145077214d), new NpgsqlTypes.NpgsqlPoint(x: 0.7659072606912743d, y: 0.688526748937415d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3245411119831949d, y: 0.05925950714514061d), new NpgsqlTypes.NpgsqlPoint(x: 0.7939264114118423d, y: 0.4544183050430979d), new NpgsqlTypes.NpgsqlPoint(x: 0.6202519019565418d, y: 0.2591297956392008d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5455103860587462d, y: 0.09593778413591825d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227318638700136d, y: 0.5990385125761328d), new NpgsqlTypes.NpgsqlPoint(x: 0.7771979575481739d, y: 0.09786683913877725d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.362508840447775d, y: 0.222430384092266d), new NpgsqlTypes.NpgsqlPoint(x: 0.9145505622140078d, y: 0.9140913824598728d), new NpgsqlTypes.NpgsqlPoint(x: 0.4656011522030006d, y: 0.16697731034415741d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11280973289602614d, y: 0.08178103313393525d), new NpgsqlTypes.NpgsqlPoint(x: 0.9673760982493446d, y: 0.46274333121058664d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205861515182972d, y: 0.39310051807023283d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7193910166289437d, y: 0.03020294507165966d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881313580356532d, y: 0.5625265028569569d), new NpgsqlTypes.NpgsqlPoint(x: 0.623012034216548d, y: 0.09360012731227196d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9498778294271132d, y: 0.7375891469328775d), new NpgsqlTypes.NpgsqlPoint(x: 0.2899832892379558d, y: 0.09390233496723777d), new NpgsqlTypes.NpgsqlPoint(x: 0.927432025684586d, y: 0.8005465808583474d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6245524230466142d, y: 0.1496175311154767d), new NpgsqlTypes.NpgsqlPoint(x: 0.18340064756123997d, y: 0.5156190951253501d), new NpgsqlTypes.NpgsqlPoint(x: 0.36834743247044266d, y: 0.7723871586042048d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6599151279753761d, y: 0.15059170068753835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5721587919533134d, y: 0.3325109692829895d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470378443368003d, y: 0.6533784284581529d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19734915276349652d, y: 0.30780948175719647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7447538604205894d, y: 0.5664188440156633d), new NpgsqlTypes.NpgsqlPoint(x: 0.8784179523194879d, y: 0.4660823605386851d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4433917181333956d, y: 0.9530051050695841d), new NpgsqlTypes.NpgsqlPoint(x: 0.10949390522134095d, y: 0.4870528158710624d), new NpgsqlTypes.NpgsqlPoint(x: 0.45095079313478037d, y: 0.39039991209037583d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3350942541725097d, y: 0.814569883378246d), new NpgsqlTypes.NpgsqlPoint(x: 0.42217500512260864d, y: 0.12108842405748588d), new NpgsqlTypes.NpgsqlPoint(x: 0.4323629390747097d, y: 0.5634993674063625d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39244001306541465d, y: 0.09178816971234693d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505482460783266d, y: 0.39842945131044105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5177806648030177d, y: 0.9608672484462637d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19218757026667743d, y: 0.4543402893360807d), new NpgsqlTypes.NpgsqlPoint(x: 0.6093253559307861d, y: 0.1703077957316983d), new NpgsqlTypes.NpgsqlPoint(x: 0.16229688351151794d, y: 0.9911773308464973d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.764593265406309d, y: 0.08154813673608907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7012212417506092d, y: 0.8229334817119895d), new NpgsqlTypes.NpgsqlPoint(x: 0.11071371851082334d, y: 0.04393054902213822d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3064592755599438d, y: 0.20389640553618282d), new NpgsqlTypes.NpgsqlPoint(x: 0.6107503920760636d, y: 0.04830020507856825d), new NpgsqlTypes.NpgsqlPoint(x: 0.9279657393799369d, y: 0.9440939288023066d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04460132359732838d, y: 0.7124348433867277d), new NpgsqlTypes.NpgsqlPoint(x: 0.26712727418592785d, y: 0.36032035512832195d), new NpgsqlTypes.NpgsqlPoint(x: 0.12296085768549736d, y: 0.010119958655783079d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5545962832417821d, y: 0.48986357823670845d), new NpgsqlTypes.NpgsqlPoint(x: 0.22339219572993452d, y: 0.7120081588197427d), new NpgsqlTypes.NpgsqlPoint(x: 0.9435897039069724d, y: 0.845442961855235d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12831936607398187d, y: 0.7107792887991352d), new NpgsqlTypes.NpgsqlPoint(x: 0.45174299460504796d, y: 0.4786064324875263d), new NpgsqlTypes.NpgsqlPoint(x: 0.9991013924118273d, y: 0.03943105414131298d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22465549012549169d, y: 0.13605226987330532d), new NpgsqlTypes.NpgsqlPoint(x: 0.8338082973735197d, y: 0.9259433007746714d), new NpgsqlTypes.NpgsqlPoint(x: 0.6611190408549299d, y: 0.647465310075352d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.507362407594068d, y: 0.6607791910928907d), new NpgsqlTypes.NpgsqlPoint(x: 0.14685383586170775d, y: 0.1358108085643288d), new NpgsqlTypes.NpgsqlPoint(x: 0.585197461880417d, y: 0.9812543534316972d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2818392542556437d, y: 0.5492908080680551d), new NpgsqlTypes.NpgsqlPoint(x: 0.3709800293436154d, y: 0.4195165732426406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5351842553820909d, y: 0.9412901602323803d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7300801359963818d, y: 0.7510922926225749d), new NpgsqlTypes.NpgsqlPoint(x: 0.04094897989841373d, y: 0.29391285049608673d), new NpgsqlTypes.NpgsqlPoint(x: 0.8228689536689379d, y: 0.4641842363182236d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6088909867660693d, y: 0.7910381399737771d), new NpgsqlTypes.NpgsqlPoint(x: 0.8857569979519075d, y: 0.08027023161245328d), new NpgsqlTypes.NpgsqlPoint(x: 0.4843874954381503d, y: 0.4689035016230464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8956659196478655d, y: 0.5496195138201847d), new NpgsqlTypes.NpgsqlPoint(x: 0.5398485391322447d, y: 0.2675598238585537d), new NpgsqlTypes.NpgsqlPoint(x: 0.4498676958095986d, y: 0.8586437560495636d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3275306630796595d, y: 0.4364778232724926d), new NpgsqlTypes.NpgsqlPoint(x: 0.15398575833759354d, y: 0.5903327332524063d), new NpgsqlTypes.NpgsqlPoint(x: 0.820200999120201d, y: 0.3308738992250271d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6757509988399337d, y: 0.22003022675799366d), new NpgsqlTypes.NpgsqlPoint(x: 0.6546174216910313d, y: 0.5432643451071288d), new NpgsqlTypes.NpgsqlPoint(x: 0.03442880624076927d, y: 0.41934459457300777d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.590412134889493d, y: 0.9534478472654407d), new NpgsqlTypes.NpgsqlPoint(x: 0.5504391272585257d, y: 0.5692648826166844d), new NpgsqlTypes.NpgsqlPoint(x: 0.22578699430501148d, y: 0.545018653495361d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37952947768885315d, y: 0.578855500497038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5114819971961045d, y: 0.881349330057543d), new NpgsqlTypes.NpgsqlPoint(x: 0.4329430129806753d, y: 0.7362669907083279d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8849057240561974d, y: 0.28899345764480244d), new NpgsqlTypes.NpgsqlPoint(x: 0.10651814567386042d, y: 0.8778515452543839d), new NpgsqlTypes.NpgsqlPoint(x: 0.45856637886190066d, y: 0.06638925105487603d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7418762408696855d, y: 0.8085008839084901d), new NpgsqlTypes.NpgsqlPoint(x: 0.8773711340279435d, y: 0.09666464099782868d), new NpgsqlTypes.NpgsqlPoint(x: 0.35588644092052846d, y: 0.016735540679622907d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25650880036735013d, y: 0.2215664301553436d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345562392172142d, y: 0.6247359832735777d), new NpgsqlTypes.NpgsqlPoint(x: 0.22563629436108357d, y: 0.9913364762472064d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30531638669613403d, y: 0.2842042855727914d), new NpgsqlTypes.NpgsqlPoint(x: 0.9376195203913982d, y: 0.8340344173923689d), new NpgsqlTypes.NpgsqlPoint(x: 0.7092488560991047d, y: 0.04036821858880457d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6888079527799116d, y: 0.7591430103259322d), new NpgsqlTypes.NpgsqlPoint(x: 0.03189647861604328d, y: 0.12336622458001723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6180143256007627d, y: 0.41295866095026723d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4771482581664155d, y: 0.4234882247620778d), new NpgsqlTypes.NpgsqlPoint(x: 0.5802731141949109d, y: 0.8420645423586735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8341206885419555d, y: 0.9011083880306789d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8893339405519106d, y: 0.22964350931680444d), new NpgsqlTypes.NpgsqlPoint(x: 0.858639733927304d, y: 0.7773374561591141d), new NpgsqlTypes.NpgsqlPoint(x: 0.6489222986591395d, y: 0.5845872378060326d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5749929084275472d, y: 0.9929816463647043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6270554577097227d, y: 0.3536925706522617d), new NpgsqlTypes.NpgsqlPoint(x: 0.23550322536869184d, y: 0.9414574495875012d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9576174077345659d, y: 0.6150130958433055d), new NpgsqlTypes.NpgsqlPoint(x: 0.03929403148403399d, y: 0.3150176943525713d), new NpgsqlTypes.NpgsqlPoint(x: 0.23434594902093853d, y: 0.04477129088012921d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9533405090417345d, y: 0.07827381078670459d), new NpgsqlTypes.NpgsqlPoint(x: 0.46499316784530553d, y: 0.49057318405867023d), new NpgsqlTypes.NpgsqlPoint(x: 0.4641905487493073d, y: 0.668010553869895d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09810954745208311d, y: 0.8517974428702724d), new NpgsqlTypes.NpgsqlPoint(x: 0.1402942323640266d, y: 0.814734337465051d), new NpgsqlTypes.NpgsqlPoint(x: 0.7161270896624188d, y: 0.6700741365963068d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07477865268189166d, y: 0.3652106008508841d), new NpgsqlTypes.NpgsqlPoint(x: 0.10236457412995648d, y: 0.32253942824411475d), new NpgsqlTypes.NpgsqlPoint(x: 0.479481014129421d, y: 0.6105984234348105d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4988071551166817d, y: 0.7270501573529102d), new NpgsqlTypes.NpgsqlPoint(x: 0.509530388693688d, y: 0.20809110353992444d), new NpgsqlTypes.NpgsqlPoint(x: 0.9072863590950548d, y: 0.6018547661243032d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8664258689166043d, y: 0.5512993916561115d), new NpgsqlTypes.NpgsqlPoint(x: 0.1730988827602158d, y: 0.8748953639261818d), new NpgsqlTypes.NpgsqlPoint(x: 0.3532339931545867d, y: 0.8884705932304086d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8548443775791839d, y: 0.6064026110830639d), new NpgsqlTypes.NpgsqlPoint(x: 0.3218508784329551d, y: 0.6194961643693915d), new NpgsqlTypes.NpgsqlPoint(x: 0.26646215827514186d, y: 0.9724765408686623d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9169576373338479d, y: 0.4996617004402215d), new NpgsqlTypes.NpgsqlPoint(x: 0.739000097669054d, y: 0.6989462742378174d), new NpgsqlTypes.NpgsqlPoint(x: 0.46657982907794915d, y: 0.7049340662444151d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49738110833415805d, y: 0.6271892229310255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5178902845920377d, y: 0.037332723229642095d), new NpgsqlTypes.NpgsqlPoint(x: 0.9376509852235632d, y: 0.03172481956343087d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9341066919627216d, y: 0.31295260004298964d), new NpgsqlTypes.NpgsqlPoint(x: 0.7456506415455344d, y: 0.19481792796061093d), new NpgsqlTypes.NpgsqlPoint(x: 0.8597225185336788d, y: 0.6276997392045334d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23348646089796277d, y: 0.24369035914053438d), new NpgsqlTypes.NpgsqlPoint(x: 0.46139428174727126d, y: 0.13613388070538046d), new NpgsqlTypes.NpgsqlPoint(x: 0.2904557364815634d, y: 0.13139696446344318d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7326316614179509d, y: 0.4074159117074341d), new NpgsqlTypes.NpgsqlPoint(x: 0.11939044824949141d, y: 0.9164687606406047d), new NpgsqlTypes.NpgsqlPoint(x: 0.643661797275535d, y: 0.43272130563115496d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9840941536583947d, y: 0.25811656196413113d), new NpgsqlTypes.NpgsqlPoint(x: 0.4799612338982733d, y: 0.6357375582785411d), new NpgsqlTypes.NpgsqlPoint(x: 0.13623237932490384d, y: 0.5156529317461199d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26355250076340175d, y: 0.5480916650278589d), new NpgsqlTypes.NpgsqlPoint(x: 0.835586991347127d, y: 0.9655536151488825d), new NpgsqlTypes.NpgsqlPoint(x: 0.6960503441845414d, y: 0.1162932928429008d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.71732299602274d, y: 0.32636151506246514d), new NpgsqlTypes.NpgsqlPoint(x: 0.17158349467472533d, y: 0.6042620245776065d), new NpgsqlTypes.NpgsqlPoint(x: 0.058200355949330596d, y: 0.813435924987241d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04521957231625007d, y: 0.4970468251353657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7343588400215847d, y: 0.07047498340471758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480895042400867d, y: 0.9525448132416918d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8699043678609673d, y: 0.7409866536357292d), new NpgsqlTypes.NpgsqlPoint(x: 0.7643236163158518d, y: 0.5179632806509681d), new NpgsqlTypes.NpgsqlPoint(x: 0.07213470711212289d, y: 0.6702072897822401d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7886363424619406d, y: 0.6088990290311377d), new NpgsqlTypes.NpgsqlPoint(x: 0.29329931311065616d, y: 0.24153557973663597d), new NpgsqlTypes.NpgsqlPoint(x: 0.7038694550926938d, y: 0.3728852427295276d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002058220702920055d, y: 0.03447617997132013d), new NpgsqlTypes.NpgsqlPoint(x: 0.40478631220764594d, y: 0.5451242941912998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8302428652768791d, y: 0.5756696387621798d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32144319788292464d, y: 0.5290955789788866d), new NpgsqlTypes.NpgsqlPoint(x: 0.19905586072950876d, y: 0.08933631333090242d), new NpgsqlTypes.NpgsqlPoint(x: 0.7418989870094733d, y: 0.8303060953736429d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0072893138718969075d, y: 0.2342172820971734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6217147939346279d, y: 0.13065244391910935d), new NpgsqlTypes.NpgsqlPoint(x: 0.3176313198386329d, y: 0.28869730881908606d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9168454862417637d, y: 0.5280103456676826d), new NpgsqlTypes.NpgsqlPoint(x: 0.34798990511590744d, y: 0.12741984717681332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816258949169582d, y: 0.3193533809994774d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03907549113690356d, y: 0.029330186661063018d), new NpgsqlTypes.NpgsqlPoint(x: 0.17811982448264418d, y: 0.7042033315518333d), new NpgsqlTypes.NpgsqlPoint(x: 0.34613970630565294d, y: 0.022114780111729293d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34213888205353304d, y: 0.27642749036601966d), new NpgsqlTypes.NpgsqlPoint(x: 0.5741709023372867d, y: 0.6194512578488713d), new NpgsqlTypes.NpgsqlPoint(x: 0.013467772229139308d, y: 0.49365290001156037d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9023260988257896d, y: 0.2812723845170222d), new NpgsqlTypes.NpgsqlPoint(x: 0.3436198619004419d, y: 0.4521668649061312d), new NpgsqlTypes.NpgsqlPoint(x: 0.22695060687999757d, y: 0.41902152823892835d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8603635255928869d, y: 0.9883401206008751d), new NpgsqlTypes.NpgsqlPoint(x: 0.1851561142477106d, y: 0.9550880464772424d), new NpgsqlTypes.NpgsqlPoint(x: 0.7240812357400552d, y: 0.6093087388956586d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11532500185414196d, y: 0.9026489692997048d), new NpgsqlTypes.NpgsqlPoint(x: 0.26969048555762065d, y: 0.9702052628658945d), new NpgsqlTypes.NpgsqlPoint(x: 0.888711027349171d, y: 0.5819460163143761d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7678407563111479d, y: 0.3610060623712874d), new NpgsqlTypes.NpgsqlPoint(x: 0.7160442264135243d, y: 0.04507258402167613d), new NpgsqlTypes.NpgsqlPoint(x: 0.4222990607594195d, y: 0.40785516100069175d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3715068804378796d, y: 0.09337835354792068d), new NpgsqlTypes.NpgsqlPoint(x: 0.6832963345850582d, y: 0.8334461406180925d), new NpgsqlTypes.NpgsqlPoint(x: 0.510438136311888d, y: 0.4587027313157894d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2373231737474738d, y: 0.07719031658327058d), new NpgsqlTypes.NpgsqlPoint(x: 0.12092958215646343d, y: 0.44475626397870816d), new NpgsqlTypes.NpgsqlPoint(x: 0.6937095343164816d, y: 0.7324773508520156d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30575107276397717d, y: 0.2989021446231893d), new NpgsqlTypes.NpgsqlPoint(x: 0.09369096812233957d, y: 0.05748565280930806d), new NpgsqlTypes.NpgsqlPoint(x: 0.38095368760202974d, y: 0.7887762536350721d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1127486718640347d, y: 0.8244140226281592d), new NpgsqlTypes.NpgsqlPoint(x: 0.5001383631903421d, y: 0.16276186367574796d), new NpgsqlTypes.NpgsqlPoint(x: 0.6185907114410271d, y: 0.24015586860211657d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13398068190456647d, y: 0.32576311534795643d), new NpgsqlTypes.NpgsqlPoint(x: 0.7017763839532574d, y: 0.6867749758512269d), new NpgsqlTypes.NpgsqlPoint(x: 0.9037557054862748d, y: 0.42403364969395785d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14601816349271635d, y: 0.7820420230399017d), new NpgsqlTypes.NpgsqlPoint(x: 0.3492086412038351d, y: 0.7859400046109366d), new NpgsqlTypes.NpgsqlPoint(x: 0.37893755648210403d, y: 0.11257970446172205d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6383861130422046d, y: 0.10901698056726583d), new NpgsqlTypes.NpgsqlPoint(x: 0.21053252719340187d, y: 0.8195945984717455d), new NpgsqlTypes.NpgsqlPoint(x: 0.9326488086083109d, y: 0.2904555969677537d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40427767685240623d, y: 0.2011471956256019d), new NpgsqlTypes.NpgsqlPoint(x: 0.8207303774031683d, y: 0.6363144972508767d), new NpgsqlTypes.NpgsqlPoint(x: 0.06749989126474765d, y: 0.9140336956382327d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3219577724967053d, y: 0.039478941894154795d), new NpgsqlTypes.NpgsqlPoint(x: 0.6691948135275955d, y: 0.7271243426151472d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261374523823663d, y: 0.4380902056886187d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9721663359639067d, y: 0.21651085265344128d), new NpgsqlTypes.NpgsqlPoint(x: 0.454268918758699d, y: 0.03946743533361807d), new NpgsqlTypes.NpgsqlPoint(x: 0.5608010340461996d, y: 0.6020261807466312d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43442191166106325d, y: 0.13044654895821062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7414929968721469d, y: 0.08466298644189674d), new NpgsqlTypes.NpgsqlPoint(x: 0.23430381303560888d, y: 0.0752124277330446d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4036718526652302d, y: 0.21166969763038634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5982450858642511d, y: 0.13561841532735175d), new NpgsqlTypes.NpgsqlPoint(x: 0.592133728081078d, y: 0.3255740217213843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6169365987189521d, y: 0.8817882603092596d), new NpgsqlTypes.NpgsqlPoint(x: 0.05191371454829852d, y: 0.7225595955368845d), new NpgsqlTypes.NpgsqlPoint(x: 0.1802231761220947d, y: 0.07736339889579158d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6640572472690086d, y: 0.49982679927987583d), new NpgsqlTypes.NpgsqlPoint(x: 0.044497743719843275d, y: 0.5654968039938142d), new NpgsqlTypes.NpgsqlPoint(x: 0.6375510167827516d, y: 0.9412007220429822d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9052066966313848d, y: 0.5081492440609557d), new NpgsqlTypes.NpgsqlPoint(x: 0.30428469824673066d, y: 0.25639113397289814d), new NpgsqlTypes.NpgsqlPoint(x: 0.2823030038789397d, y: 0.3765676001828606d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.060984454604012917d, y: 0.5269019682357572d), new NpgsqlTypes.NpgsqlPoint(x: 0.13912664394338803d, y: 0.22137993426807567d), new NpgsqlTypes.NpgsqlPoint(x: 0.7711578288347885d, y: 0.4635238981121902d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7988970089253294d, y: 0.4898226144394092d), new NpgsqlTypes.NpgsqlPoint(x: 0.22154149877729434d, y: 0.5432517872845642d), new NpgsqlTypes.NpgsqlPoint(x: 0.27298125078898783d, y: 0.8266988909913728d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5636401990895372d, y: 0.7795805311611053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5060059222838266d, y: 0.3802406593248443d), new NpgsqlTypes.NpgsqlPoint(x: 0.8765055349259497d, y: 0.2730929050796541d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5692750934449783d, y: 0.46777532559465873d), new NpgsqlTypes.NpgsqlPoint(x: 0.4350740548532146d, y: 0.888608686790768d), new NpgsqlTypes.NpgsqlPoint(x: 0.36703250761770634d, y: 0.4430392061092059d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7536558739281087d, y: 0.677460861835072d), new NpgsqlTypes.NpgsqlPoint(x: 0.2725267129366884d, y: 0.02690682505148778d), new NpgsqlTypes.NpgsqlPoint(x: 0.33097880965879223d, y: 0.9558991564217848d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1353664750244956d, y: 0.5186217726503514d), new NpgsqlTypes.NpgsqlPoint(x: 0.5837892676625563d, y: 0.00925352896161269d), new NpgsqlTypes.NpgsqlPoint(x: 0.26940816106468246d, y: 0.18558100247416187d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9313296522537666d, y: 0.51828903937426d), new NpgsqlTypes.NpgsqlPoint(x: 0.12832076728898545d, y: 0.5830983346087493d), new NpgsqlTypes.NpgsqlPoint(x: 0.5029388288520007d, y: 0.905396031171244d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7671366330332463d, y: 0.22628977662417527d), new NpgsqlTypes.NpgsqlPoint(x: 0.49793697430541306d, y: 0.022170205179250946d), new NpgsqlTypes.NpgsqlPoint(x: 0.7813548780892695d, y: 0.929921599233117d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.760843284297023d, y: 0.2253593131879018d), new NpgsqlTypes.NpgsqlPoint(x: 0.22557997909598504d, y: 0.9798466774366159d), new NpgsqlTypes.NpgsqlPoint(x: 0.8823620381719628d, y: 0.9864168165733496d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.747744986579174d, y: 0.16091675708120723d), new NpgsqlTypes.NpgsqlPoint(x: 0.2531740246652525d, y: 0.536678047536059d), new NpgsqlTypes.NpgsqlPoint(x: 0.4129215646850225d, y: 0.00854411866353011d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4388571141306573d, y: 0.5827883426539544d), new NpgsqlTypes.NpgsqlPoint(x: 0.6276062794619389d, y: 0.13102181897741172d), new NpgsqlTypes.NpgsqlPoint(x: 0.10032187920639057d, y: 0.874579438330889d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5024517721436851d, y: 0.515078633271282d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652214335057518d, y: 0.19978535675504117d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800421528518482d, y: 0.2948146256324601d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8506676962642447d, y: 0.9980001038432855d), new NpgsqlTypes.NpgsqlPoint(x: 0.4717055865266957d, y: 0.7990502857683467d), new NpgsqlTypes.NpgsqlPoint(x: 0.6136237380607694d, y: 0.5952171788848585d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09796783947289167d, y: 0.5196111357644132d), new NpgsqlTypes.NpgsqlPoint(x: 0.22896800922429728d, y: 0.1484222183598609d), new NpgsqlTypes.NpgsqlPoint(x: 0.15613274478927963d, y: 0.2702266797389766d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21233796344791378d, y: 0.9195891309480453d), new NpgsqlTypes.NpgsqlPoint(x: 0.15564061535479146d, y: 0.6420825888029567d), new NpgsqlTypes.NpgsqlPoint(x: 0.254225906073707d, y: 0.2994836771129128d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3468599301091654d, y: 0.18425546865608067d), new NpgsqlTypes.NpgsqlPoint(x: 0.12008252889653492d, y: 0.9620589248376157d), new NpgsqlTypes.NpgsqlPoint(x: 0.06520272559284235d, y: 0.961675939081839d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9859934175549461d, y: 0.703694269050823d), new NpgsqlTypes.NpgsqlPoint(x: 0.01160705251452887d, y: 0.888724373743098d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569819998609389d, y: 0.6968441325096062d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4729229275406023d, y: 0.09721298359851305d), new NpgsqlTypes.NpgsqlPoint(x: 0.9887063992482037d, y: 0.5985790687876226d), new NpgsqlTypes.NpgsqlPoint(x: 0.11957493376469863d, y: 0.14766445751834145d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9599640735816743d, y: 0.23233367834622354d), new NpgsqlTypes.NpgsqlPoint(x: 0.6182993381988363d, y: 0.033420448738290975d), new NpgsqlTypes.NpgsqlPoint(x: 0.6984259228611613d, y: 0.7163913077397385d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8003442028347261d, y: 0.4492905461045624d), new NpgsqlTypes.NpgsqlPoint(x: 0.3291849243987348d, y: 0.684840848608621d), new NpgsqlTypes.NpgsqlPoint(x: 0.8219278372594127d, y: 0.8123622647640834d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3259055096042732d, y: 0.8290219285765968d), new NpgsqlTypes.NpgsqlPoint(x: 0.3042602215332352d, y: 0.3454619225428224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8396715203064824d, y: 0.1410721482041014d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2712935194180035d, y: 0.9320380499824112d), new NpgsqlTypes.NpgsqlPoint(x: 0.6125404484863931d, y: 0.511131047148384d), new NpgsqlTypes.NpgsqlPoint(x: 0.09148484492642195d, y: 0.8748577557555458d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.924364850159656d, y: 0.9443288888670673d), new NpgsqlTypes.NpgsqlPoint(x: 0.606406395199837d, y: 0.8729380586330112d), new NpgsqlTypes.NpgsqlPoint(x: 0.1975440368361694d, y: 0.10417745308717707d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22207759531748883d, y: 0.4247985050499328d), new NpgsqlTypes.NpgsqlPoint(x: 0.35128982477249293d, y: 0.0702698521156726d), new NpgsqlTypes.NpgsqlPoint(x: 0.1310658581900509d, y: 0.25678695351445646d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09365518153906294d, y: 0.6748165435471996d), new NpgsqlTypes.NpgsqlPoint(x: 0.33127401126486755d, y: 0.931102415722449d), new NpgsqlTypes.NpgsqlPoint(x: 0.32548271191590916d, y: 0.5814041125181695d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7695982286178156d, y: 0.006847412048521462d), new NpgsqlTypes.NpgsqlPoint(x: 0.48722926259531074d, y: 0.33169300167107896d), new NpgsqlTypes.NpgsqlPoint(x: 0.4056338478520386d, y: 0.5621502256630538d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4082035133397268d, y: 0.5227044922669533d), new NpgsqlTypes.NpgsqlPoint(x: 0.19533100611201926d, y: 0.1538437911247017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7523246508277557d, y: 0.30229206133693276d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5775511339957611d, y: 0.2615805320871539d), new NpgsqlTypes.NpgsqlPoint(x: 0.8614362977815991d, y: 0.02220033401612964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6212862493945605d, y: 0.04789370575293739d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8280304777156405d, y: 0.06393158302952917d), new NpgsqlTypes.NpgsqlPoint(x: 0.9459361732443126d, y: 0.8003723483490289d), new NpgsqlTypes.NpgsqlPoint(x: 0.06270858835748372d, y: 0.8011209513942246d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.676434462696444d, y: 0.05150025959388249d), new NpgsqlTypes.NpgsqlPoint(x: 0.8174269315277227d, y: 0.7745600536391841d), new NpgsqlTypes.NpgsqlPoint(x: 0.19260084703041547d, y: 0.2346041792236705d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7664063848747169d, y: 0.2555450110426023d), new NpgsqlTypes.NpgsqlPoint(x: 0.1449068633130055d, y: 0.934133082630978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236339139859876d, y: 0.5600190399435667d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41724413143277905d, y: 0.904170682753765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8765336726754588d, y: 0.7292504382110508d), new NpgsqlTypes.NpgsqlPoint(x: 0.4315315288396988d, y: 0.24806241778641325d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
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

                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathlistd1e2mi_id", 
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
                List<NpgsqlPathpathListD1E2M> models = null;

                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathListD1E2M> models = null;

                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[34], false);
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
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 4, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 134, query1, 157, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 20, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 151, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 141, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 132, query1, 13, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 118, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 38, query1, 156, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 4, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatch(connection, 170, 112))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models = await ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[12], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[13], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[14], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[15], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[16], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[17], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[18], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[19], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[20], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[21], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[22], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[23], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[24], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[25], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[26], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[27], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[28], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[29], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[30], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[31], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[32], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[33], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 13);
                var models =  ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[2], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[3], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[4], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[5], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[6], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[7], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[8], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[9], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[10], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[11], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[12], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[13], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[14], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[15], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[16], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[17], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[18], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[19], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[20], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[21], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[22], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[23], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[24], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[25], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[26], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[27], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[28], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[29], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[30], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[31], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[32], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[31],_testData[33], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[32],_testData[34], false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MI),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathListD1E2M),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
FROM public.binary_npgsqlpathpathlistd1e2m m
LEFT JOIN public.binary_npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models =  ((INpgsqlPathListpathListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI), typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models1 = new List<NpgsqlPathpathListD1E2MI>();
                var models2 = new List<NpgsqlPathpathListD1E2MI>();
                await ((INpgsqlPathListpathListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MI>();
                var models2 = new List<NpgsqlPathpathListD1E2MI>();
                ((INpgsqlPathListpathListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models = await ((INpgsqlPathListpathListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

