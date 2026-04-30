

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
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02459864980067583d, y: 0.8507534466883511d), new NpgsqlTypes.NpgsqlPoint(x: 0.8869104709776224d, y: 0.8576839808795076d), new NpgsqlTypes.NpgsqlPoint(x: 0.4854346151804314d, y: 0.8569407623381963d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9831045912582724d, y: 0.5587399910472225d), new NpgsqlTypes.NpgsqlPoint(x: 0.9415897363424056d, y: 0.9117857414615937d), new NpgsqlTypes.NpgsqlPoint(x: 0.2575562011013034d, y: 0.06776956222278041d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8594223307189657d, y: 0.8068248525039619d), new NpgsqlTypes.NpgsqlPoint(x: 0.7895232775900597d, y: 0.9997217094467198d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211990508336795d, y: 0.3385183271918283d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3179295526285556d, y: 0.6749954796000301d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873420763963295d, y: 0.9747057755442041d), new NpgsqlTypes.NpgsqlPoint(x: 0.767822653189644d, y: 0.46724937755267704d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9485240596230617d, y: 0.8722805118762538d), new NpgsqlTypes.NpgsqlPoint(x: 0.12065148229643996d, y: 0.8977092420156452d), new NpgsqlTypes.NpgsqlPoint(x: 0.6531995334367275d, y: 0.5191396426578578d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9976825954034271d, y: 0.8477328938203313d), new NpgsqlTypes.NpgsqlPoint(x: 0.16552110956830346d, y: 0.5719084406437115d), new NpgsqlTypes.NpgsqlPoint(x: 0.6254611021228359d, y: 0.8713152045623721d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1832801206191076d, y: 0.5996414017990213d), new NpgsqlTypes.NpgsqlPoint(x: 0.22067253187404645d, y: 0.8732137308450445d), new NpgsqlTypes.NpgsqlPoint(x: 0.1668128286523206d, y: 0.16054851700213768d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49540630534199825d, y: 0.3437128744002076d), new NpgsqlTypes.NpgsqlPoint(x: 0.13006596500372025d, y: 0.11346099024454581d), new NpgsqlTypes.NpgsqlPoint(x: 0.6643040946557225d, y: 0.16549483974376467d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03804411950136022d, y: 0.2253552898896134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605570781904647d, y: 0.36073290337893194d), new NpgsqlTypes.NpgsqlPoint(x: 0.26805775581745994d, y: 0.887021469998503d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6996305212896275d, y: 0.898761673042936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9887217999209623d, y: 0.8137260448562804d), new NpgsqlTypes.NpgsqlPoint(x: 0.47619784137641574d, y: 0.2703693220349417d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3610832835359641d, y: 0.7813944087357637d), new NpgsqlTypes.NpgsqlPoint(x: 0.035319590248960475d, y: 0.5095727505908721d), new NpgsqlTypes.NpgsqlPoint(x: 0.07686309512307887d, y: 0.30272703638793963d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5864284772641621d, y: 0.8208106571692697d), new NpgsqlTypes.NpgsqlPoint(x: 0.1814449367169506d, y: 0.9651794169427282d), new NpgsqlTypes.NpgsqlPoint(x: 0.1455624015044501d, y: 0.7217931986625424d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6208222272803386d, y: 0.542714667556879d), new NpgsqlTypes.NpgsqlPoint(x: 0.13607108421968062d, y: 0.42335392204272393d), new NpgsqlTypes.NpgsqlPoint(x: 0.37777894579622484d, y: 0.9057225238234887d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2562420611686326d, y: 0.7899130818986391d), new NpgsqlTypes.NpgsqlPoint(x: 0.4911757176300139d, y: 0.5844557112223913d), new NpgsqlTypes.NpgsqlPoint(x: 0.5777354509363464d, y: 0.582445155626686d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36906481698865523d, y: 0.04603931087921631d), new NpgsqlTypes.NpgsqlPoint(x: 0.7757220524872941d, y: 0.808894731219957d), new NpgsqlTypes.NpgsqlPoint(x: 0.0096131236740008d, y: 0.8948543334777164d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11838507705766876d, y: 0.1527336045543508d), new NpgsqlTypes.NpgsqlPoint(x: 0.5542433598684235d, y: 0.034312373333592494d), new NpgsqlTypes.NpgsqlPoint(x: 0.6849088123534609d, y: 0.38947391731664793d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7279802205369895d, y: 0.9948903787536201d), new NpgsqlTypes.NpgsqlPoint(x: 0.37235170743996815d, y: 0.8507387881742332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9140032371443552d, y: 0.819318618363206d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38550178786474565d, y: 0.2729636289931442d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599344750283795d, y: 0.5843894267920282d), new NpgsqlTypes.NpgsqlPoint(x: 0.3579584690171762d, y: 0.18527751516501734d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9606126753226845d, y: 0.858592122356968d), new NpgsqlTypes.NpgsqlPoint(x: 0.5619249540683411d, y: 0.861265880075051d), new NpgsqlTypes.NpgsqlPoint(x: 0.7099703161800325d, y: 0.2613862932028962d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45637426984585705d, y: 0.3484609187171497d), new NpgsqlTypes.NpgsqlPoint(x: 0.6482564666424385d, y: 0.38473765701674456d), new NpgsqlTypes.NpgsqlPoint(x: 0.5232801903310895d, y: 0.25766675853746934d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10756766331106427d, y: 0.7799797862227967d), new NpgsqlTypes.NpgsqlPoint(x: 0.5566005073016692d, y: 0.11285803078584211d), new NpgsqlTypes.NpgsqlPoint(x: 0.6452104526790283d, y: 0.403857011055056d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4332380273637624d, y: 0.9125057440756494d), new NpgsqlTypes.NpgsqlPoint(x: 0.044167493716240624d, y: 0.9881109880496965d), new NpgsqlTypes.NpgsqlPoint(x: 0.048468788856263045d, y: 0.7009237294747656d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06460510408402498d, y: 0.14283227860806125d), new NpgsqlTypes.NpgsqlPoint(x: 0.3563990697218109d, y: 0.3995019159124923d), new NpgsqlTypes.NpgsqlPoint(x: 0.9621922325096572d, y: 0.9528239806191138d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8858185215551637d, y: 0.8979387900014677d), new NpgsqlTypes.NpgsqlPoint(x: 0.22611415949038305d, y: 0.5283561031503974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7608511921606336d, y: 0.23571731790399497d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9266813188959131d, y: 0.7471680814219812d), new NpgsqlTypes.NpgsqlPoint(x: 0.10783185676686313d, y: 0.059444464351877335d), new NpgsqlTypes.NpgsqlPoint(x: 0.866931838521256d, y: 0.3097186105050864d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7163886164555725d, y: 0.3246944747856193d), new NpgsqlTypes.NpgsqlPoint(x: 0.2331560477423894d, y: 0.7307498288415991d), new NpgsqlTypes.NpgsqlPoint(x: 0.21657105107762642d, y: 0.19619629693733898d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7330056724795087d, y: 0.5853388019382944d), new NpgsqlTypes.NpgsqlPoint(x: 0.16539460523925886d, y: 0.36815790604350895d), new NpgsqlTypes.NpgsqlPoint(x: 0.41562643863254967d, y: 0.5112184924465002d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4167540614123556d, y: 0.8715085893301947d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317971065757764d, y: 0.2259805101040454d), new NpgsqlTypes.NpgsqlPoint(x: 0.13906299680982703d, y: 0.2953461684750168d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.765276156205041d, y: 0.1757833614052834d), new NpgsqlTypes.NpgsqlPoint(x: 0.8557067438346195d, y: 0.14041777046122894d), new NpgsqlTypes.NpgsqlPoint(x: 0.5798142587357217d, y: 0.10668708370169766d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7189528730039205d, y: 0.470733717819557d), new NpgsqlTypes.NpgsqlPoint(x: 0.7044154406344917d, y: 0.527860330400291d), new NpgsqlTypes.NpgsqlPoint(x: 0.5075905711500402d, y: 0.6375068727023919d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6814646887118319d, y: 0.5870447806015985d), new NpgsqlTypes.NpgsqlPoint(x: 0.7141088020074676d, y: 0.8506164014382613d), new NpgsqlTypes.NpgsqlPoint(x: 0.07148838739150387d, y: 0.003663942179027213d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6145035951018423d, y: 0.4151036203146975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7004750193464908d, y: 0.3380366501206261d), new NpgsqlTypes.NpgsqlPoint(x: 0.810519173351565d, y: 0.0478493482574186d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7492174240039161d, y: 0.08282106823544833d), new NpgsqlTypes.NpgsqlPoint(x: 0.4607118890332076d, y: 0.44839476981159954d), new NpgsqlTypes.NpgsqlPoint(x: 0.035280601987208726d, y: 0.004986805084666757d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3930792080004688d, y: 0.08547402632963474d), new NpgsqlTypes.NpgsqlPoint(x: 0.4588954966630555d, y: 0.664715470540585d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734619569248368d, y: 0.6187773393134908d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9921967392209594d, y: 0.005324021600039641d), new NpgsqlTypes.NpgsqlPoint(x: 0.15226397995676444d, y: 0.641046790696018d), new NpgsqlTypes.NpgsqlPoint(x: 0.811999610013245d, y: 0.37744537198638806d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.186970490442659d, y: 0.3451390272658863d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445902420550387d, y: 0.48907474339416235d), new NpgsqlTypes.NpgsqlPoint(x: 0.8039184259625222d, y: 0.4072848600430917d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05242960682683662d, y: 0.6540051456039441d), new NpgsqlTypes.NpgsqlPoint(x: 0.7280841902458326d, y: 0.3235259138441232d), new NpgsqlTypes.NpgsqlPoint(x: 0.41120849235484813d, y: 0.013456495131050072d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7915660423936159d, y: 0.31713392537543617d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658698824514379d, y: 0.3025998210127502d), new NpgsqlTypes.NpgsqlPoint(x: 0.20262808221924777d, y: 0.7590532800254641d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.020924390604592835d, y: 0.637678445829915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8226201046568399d, y: 0.3969892332592275d), new NpgsqlTypes.NpgsqlPoint(x: 0.6248126220866737d, y: 0.06339006986686535d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5791088269538268d, y: 0.08051917481617166d), new NpgsqlTypes.NpgsqlPoint(x: 0.2711816649658737d, y: 0.02297087085078975d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280291026919064d, y: 0.5966714906834759d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9483666360862204d, y: 0.0815083926080582d), new NpgsqlTypes.NpgsqlPoint(x: 0.3658433189403464d, y: 0.7893667029967026d), new NpgsqlTypes.NpgsqlPoint(x: 0.12744625125059217d, y: 0.21506375125784238d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26646137948321624d, y: 0.8217857933086082d), new NpgsqlTypes.NpgsqlPoint(x: 0.21035232645070356d, y: 0.3325405940947096d), new NpgsqlTypes.NpgsqlPoint(x: 0.2432442983367057d, y: 0.1638270432216954d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8524101590675304d, y: 0.7349472446556238d), new NpgsqlTypes.NpgsqlPoint(x: 0.37479408832497096d, y: 0.3391437933689445d), new NpgsqlTypes.NpgsqlPoint(x: 0.23232049218400597d, y: 0.40888883730243686d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05744966264379159d, y: 0.38755874561466863d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218018642544218d, y: 0.6520059825730906d), new NpgsqlTypes.NpgsqlPoint(x: 0.14032583574376734d, y: 0.4527141171674971d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7764866212124566d, y: 0.8313735673138906d), new NpgsqlTypes.NpgsqlPoint(x: 0.33163797993525135d, y: 0.030839282764375753d), new NpgsqlTypes.NpgsqlPoint(x: 0.9049167899901882d, y: 0.5844187084750271d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9940030656171911d, y: 0.10730223540824524d), new NpgsqlTypes.NpgsqlPoint(x: 0.6414348946165292d, y: 0.11443327117420443d), new NpgsqlTypes.NpgsqlPoint(x: 0.24046272567166682d, y: 0.4100934462070591d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1385693926270244d, y: 0.551966365519415d), new NpgsqlTypes.NpgsqlPoint(x: 0.934516422890904d, y: 0.2821732144530259d), new NpgsqlTypes.NpgsqlPoint(x: 0.42334715536448175d, y: 0.4805837881509515d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5374760474734952d, y: 0.04428091197793982d), new NpgsqlTypes.NpgsqlPoint(x: 0.8141924669766664d, y: 0.7306897572442836d), new NpgsqlTypes.NpgsqlPoint(x: 0.2952707957816366d, y: 0.40140205770473636d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06883610723370559d, y: 0.5993183803393771d), new NpgsqlTypes.NpgsqlPoint(x: 0.10936762356205487d, y: 0.5286791784034515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492863559825294d, y: 0.41229593243415974d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9592551798682959d, y: 0.4581849101229284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8562266904872021d, y: 0.7847016077023117d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494065746894296d, y: 0.6363108952022032d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6807287013767628d, y: 0.1887883053091759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7518981375441578d, y: 0.27626146334529267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521567493715938d, y: 0.2961149333263837d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5495078768634777d, y: 0.574134375758416d), new NpgsqlTypes.NpgsqlPoint(x: 0.0857148982473166d, y: 0.37002115515074196d), new NpgsqlTypes.NpgsqlPoint(x: 0.04981617275404826d, y: 0.5735716628694816d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.537173120879325d, y: 0.5067046851890215d), new NpgsqlTypes.NpgsqlPoint(x: 0.3708346786266943d, y: 0.6380888730956199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8265100258232031d, y: 0.2396935926044066d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012596703261538389d, y: 0.6682189705885695d), new NpgsqlTypes.NpgsqlPoint(x: 0.23282948416764637d, y: 0.8290058713835886d), new NpgsqlTypes.NpgsqlPoint(x: 0.8022539873431691d, y: 0.9625564455977903d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7004581450736705d, y: 0.05940171827957563d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249791462240789d, y: 0.17165473010600285d), new NpgsqlTypes.NpgsqlPoint(x: 0.8821973783317153d, y: 0.6069775985504776d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.827748312304319d, y: 0.42894467318692253d), new NpgsqlTypes.NpgsqlPoint(x: 0.3548502908208706d, y: 0.03236704527038714d), new NpgsqlTypes.NpgsqlPoint(x: 0.43565563270238494d, y: 0.6848365347913243d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09893652405689024d, y: 0.4071648976190936d), new NpgsqlTypes.NpgsqlPoint(x: 0.4371045338392888d, y: 0.5113947485817437d), new NpgsqlTypes.NpgsqlPoint(x: 0.4899205130266835d, y: 0.37409591339076254d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13124577494760337d, y: 0.4841161910294465d), new NpgsqlTypes.NpgsqlPoint(x: 0.9486122578328424d, y: 0.03707023885896632d), new NpgsqlTypes.NpgsqlPoint(x: 0.9022037660215679d, y: 0.38145102565209343d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9123363522903742d, y: 0.0019191555858091291d), new NpgsqlTypes.NpgsqlPoint(x: 0.48478417402576046d, y: 0.5230228072254309d), new NpgsqlTypes.NpgsqlPoint(x: 0.3809865392587447d, y: 0.4968031192273602d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8067156444303499d, y: 0.03791976558561483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9782995954747642d, y: 0.2301304334590336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973251554621738d, y: 0.5299717208226434d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30829747943973596d, y: 0.30784622059931943d), new NpgsqlTypes.NpgsqlPoint(x: 0.582333751632823d, y: 0.83605514395508d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623571845254821d, y: 0.08271280372934875d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14967016695411983d, y: 0.46372094674359443d), new NpgsqlTypes.NpgsqlPoint(x: 0.4557831141513685d, y: 0.5277739318141245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5640073869857283d, y: 0.7394356436590813d)),
    NullableValue = null,
},
    NullableValue = null,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03804411950136022d, y: 0.2253552898896134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605570781904647d, y: 0.36073290337893194d), new NpgsqlTypes.NpgsqlPoint(x: 0.26805775581745994d, y: 0.887021469998503d))));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2562420611686326d, y: 0.7899130818986391d), new NpgsqlTypes.NpgsqlPoint(x: 0.4911757176300139d, y: 0.5844557112223913d), new NpgsqlTypes.NpgsqlPoint(x: 0.5777354509363464d, y: 0.582445155626686d))));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9606126753226845d, y: 0.858592122356968d), new NpgsqlTypes.NpgsqlPoint(x: 0.5619249540683411d, y: 0.861265880075051d), new NpgsqlTypes.NpgsqlPoint(x: 0.7099703161800325d, y: 0.2613862932028962d))));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 85;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[29], false);
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
                parametr1.Value = 15;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 19, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[29], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 100, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 125, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[29], false);
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 47, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 8, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 23, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 15, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[29], false);
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 123, query1, 4, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 118, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 4, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[29], false);
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
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 90);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[3], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[4], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[5], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[6], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[7], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02459864980067583d, y: 0.8507534466883511d), new NpgsqlTypes.NpgsqlPoint(x: 0.8869104709776224d, y: 0.8576839808795076d), new NpgsqlTypes.NpgsqlPoint(x: 0.4854346151804314d, y: 0.8569407623381963d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9831045912582724d, y: 0.5587399910472225d), new NpgsqlTypes.NpgsqlPoint(x: 0.9415897363424056d, y: 0.9117857414615937d), new NpgsqlTypes.NpgsqlPoint(x: 0.2575562011013034d, y: 0.06776956222278041d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8594223307189657d, y: 0.8068248525039619d), new NpgsqlTypes.NpgsqlPoint(x: 0.7895232775900597d, y: 0.9997217094467198d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211990508336795d, y: 0.3385183271918283d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3179295526285556d, y: 0.6749954796000301d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873420763963295d, y: 0.9747057755442041d), new NpgsqlTypes.NpgsqlPoint(x: 0.767822653189644d, y: 0.46724937755267704d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9485240596230617d, y: 0.8722805118762538d), new NpgsqlTypes.NpgsqlPoint(x: 0.12065148229643996d, y: 0.8977092420156452d), new NpgsqlTypes.NpgsqlPoint(x: 0.6531995334367275d, y: 0.5191396426578578d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9976825954034271d, y: 0.8477328938203313d), new NpgsqlTypes.NpgsqlPoint(x: 0.16552110956830346d, y: 0.5719084406437115d), new NpgsqlTypes.NpgsqlPoint(x: 0.6254611021228359d, y: 0.8713152045623721d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1832801206191076d, y: 0.5996414017990213d), new NpgsqlTypes.NpgsqlPoint(x: 0.22067253187404645d, y: 0.8732137308450445d), new NpgsqlTypes.NpgsqlPoint(x: 0.1668128286523206d, y: 0.16054851700213768d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49540630534199825d, y: 0.3437128744002076d), new NpgsqlTypes.NpgsqlPoint(x: 0.13006596500372025d, y: 0.11346099024454581d), new NpgsqlTypes.NpgsqlPoint(x: 0.6643040946557225d, y: 0.16549483974376467d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03804411950136022d, y: 0.2253552898896134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605570781904647d, y: 0.36073290337893194d), new NpgsqlTypes.NpgsqlPoint(x: 0.26805775581745994d, y: 0.887021469998503d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6996305212896275d, y: 0.898761673042936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9887217999209623d, y: 0.8137260448562804d), new NpgsqlTypes.NpgsqlPoint(x: 0.47619784137641574d, y: 0.2703693220349417d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3610832835359641d, y: 0.7813944087357637d), new NpgsqlTypes.NpgsqlPoint(x: 0.035319590248960475d, y: 0.5095727505908721d), new NpgsqlTypes.NpgsqlPoint(x: 0.07686309512307887d, y: 0.30272703638793963d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5864284772641621d, y: 0.8208106571692697d), new NpgsqlTypes.NpgsqlPoint(x: 0.1814449367169506d, y: 0.9651794169427282d), new NpgsqlTypes.NpgsqlPoint(x: 0.1455624015044501d, y: 0.7217931986625424d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6208222272803386d, y: 0.542714667556879d), new NpgsqlTypes.NpgsqlPoint(x: 0.13607108421968062d, y: 0.42335392204272393d), new NpgsqlTypes.NpgsqlPoint(x: 0.37777894579622484d, y: 0.9057225238234887d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2562420611686326d, y: 0.7899130818986391d), new NpgsqlTypes.NpgsqlPoint(x: 0.4911757176300139d, y: 0.5844557112223913d), new NpgsqlTypes.NpgsqlPoint(x: 0.5777354509363464d, y: 0.582445155626686d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36906481698865523d, y: 0.04603931087921631d), new NpgsqlTypes.NpgsqlPoint(x: 0.7757220524872941d, y: 0.808894731219957d), new NpgsqlTypes.NpgsqlPoint(x: 0.0096131236740008d, y: 0.8948543334777164d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11838507705766876d, y: 0.1527336045543508d), new NpgsqlTypes.NpgsqlPoint(x: 0.5542433598684235d, y: 0.034312373333592494d), new NpgsqlTypes.NpgsqlPoint(x: 0.6849088123534609d, y: 0.38947391731664793d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7279802205369895d, y: 0.9948903787536201d), new NpgsqlTypes.NpgsqlPoint(x: 0.37235170743996815d, y: 0.8507387881742332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9140032371443552d, y: 0.819318618363206d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38550178786474565d, y: 0.2729636289931442d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599344750283795d, y: 0.5843894267920282d), new NpgsqlTypes.NpgsqlPoint(x: 0.3579584690171762d, y: 0.18527751516501734d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9606126753226845d, y: 0.858592122356968d), new NpgsqlTypes.NpgsqlPoint(x: 0.5619249540683411d, y: 0.861265880075051d), new NpgsqlTypes.NpgsqlPoint(x: 0.7099703161800325d, y: 0.2613862932028962d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45637426984585705d, y: 0.3484609187171497d), new NpgsqlTypes.NpgsqlPoint(x: 0.6482564666424385d, y: 0.38473765701674456d), new NpgsqlTypes.NpgsqlPoint(x: 0.5232801903310895d, y: 0.25766675853746934d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10756766331106427d, y: 0.7799797862227967d), new NpgsqlTypes.NpgsqlPoint(x: 0.5566005073016692d, y: 0.11285803078584211d), new NpgsqlTypes.NpgsqlPoint(x: 0.6452104526790283d, y: 0.403857011055056d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4332380273637624d, y: 0.9125057440756494d), new NpgsqlTypes.NpgsqlPoint(x: 0.044167493716240624d, y: 0.9881109880496965d), new NpgsqlTypes.NpgsqlPoint(x: 0.048468788856263045d, y: 0.7009237294747656d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06460510408402498d, y: 0.14283227860806125d), new NpgsqlTypes.NpgsqlPoint(x: 0.3563990697218109d, y: 0.3995019159124923d), new NpgsqlTypes.NpgsqlPoint(x: 0.9621922325096572d, y: 0.9528239806191138d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8858185215551637d, y: 0.8979387900014677d), new NpgsqlTypes.NpgsqlPoint(x: 0.22611415949038305d, y: 0.5283561031503974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7608511921606336d, y: 0.23571731790399497d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9266813188959131d, y: 0.7471680814219812d), new NpgsqlTypes.NpgsqlPoint(x: 0.10783185676686313d, y: 0.059444464351877335d), new NpgsqlTypes.NpgsqlPoint(x: 0.866931838521256d, y: 0.3097186105050864d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7163886164555725d, y: 0.3246944747856193d), new NpgsqlTypes.NpgsqlPoint(x: 0.2331560477423894d, y: 0.7307498288415991d), new NpgsqlTypes.NpgsqlPoint(x: 0.21657105107762642d, y: 0.19619629693733898d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7330056724795087d, y: 0.5853388019382944d), new NpgsqlTypes.NpgsqlPoint(x: 0.16539460523925886d, y: 0.36815790604350895d), new NpgsqlTypes.NpgsqlPoint(x: 0.41562643863254967d, y: 0.5112184924465002d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4167540614123556d, y: 0.8715085893301947d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317971065757764d, y: 0.2259805101040454d), new NpgsqlTypes.NpgsqlPoint(x: 0.13906299680982703d, y: 0.2953461684750168d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.765276156205041d, y: 0.1757833614052834d), new NpgsqlTypes.NpgsqlPoint(x: 0.8557067438346195d, y: 0.14041777046122894d), new NpgsqlTypes.NpgsqlPoint(x: 0.5798142587357217d, y: 0.10668708370169766d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7189528730039205d, y: 0.470733717819557d), new NpgsqlTypes.NpgsqlPoint(x: 0.7044154406344917d, y: 0.527860330400291d), new NpgsqlTypes.NpgsqlPoint(x: 0.5075905711500402d, y: 0.6375068727023919d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6814646887118319d, y: 0.5870447806015985d), new NpgsqlTypes.NpgsqlPoint(x: 0.7141088020074676d, y: 0.8506164014382613d), new NpgsqlTypes.NpgsqlPoint(x: 0.07148838739150387d, y: 0.003663942179027213d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6145035951018423d, y: 0.4151036203146975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7004750193464908d, y: 0.3380366501206261d), new NpgsqlTypes.NpgsqlPoint(x: 0.810519173351565d, y: 0.0478493482574186d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7492174240039161d, y: 0.08282106823544833d), new NpgsqlTypes.NpgsqlPoint(x: 0.4607118890332076d, y: 0.44839476981159954d), new NpgsqlTypes.NpgsqlPoint(x: 0.035280601987208726d, y: 0.004986805084666757d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3930792080004688d, y: 0.08547402632963474d), new NpgsqlTypes.NpgsqlPoint(x: 0.4588954966630555d, y: 0.664715470540585d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734619569248368d, y: 0.6187773393134908d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9921967392209594d, y: 0.005324021600039641d), new NpgsqlTypes.NpgsqlPoint(x: 0.15226397995676444d, y: 0.641046790696018d), new NpgsqlTypes.NpgsqlPoint(x: 0.811999610013245d, y: 0.37744537198638806d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.186970490442659d, y: 0.3451390272658863d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445902420550387d, y: 0.48907474339416235d), new NpgsqlTypes.NpgsqlPoint(x: 0.8039184259625222d, y: 0.4072848600430917d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05242960682683662d, y: 0.6540051456039441d), new NpgsqlTypes.NpgsqlPoint(x: 0.7280841902458326d, y: 0.3235259138441232d), new NpgsqlTypes.NpgsqlPoint(x: 0.41120849235484813d, y: 0.013456495131050072d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7915660423936159d, y: 0.31713392537543617d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658698824514379d, y: 0.3025998210127502d), new NpgsqlTypes.NpgsqlPoint(x: 0.20262808221924777d, y: 0.7590532800254641d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.020924390604592835d, y: 0.637678445829915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8226201046568399d, y: 0.3969892332592275d), new NpgsqlTypes.NpgsqlPoint(x: 0.6248126220866737d, y: 0.06339006986686535d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5791088269538268d, y: 0.08051917481617166d), new NpgsqlTypes.NpgsqlPoint(x: 0.2711816649658737d, y: 0.02297087085078975d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280291026919064d, y: 0.5966714906834759d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9483666360862204d, y: 0.0815083926080582d), new NpgsqlTypes.NpgsqlPoint(x: 0.3658433189403464d, y: 0.7893667029967026d), new NpgsqlTypes.NpgsqlPoint(x: 0.12744625125059217d, y: 0.21506375125784238d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26646137948321624d, y: 0.8217857933086082d), new NpgsqlTypes.NpgsqlPoint(x: 0.21035232645070356d, y: 0.3325405940947096d), new NpgsqlTypes.NpgsqlPoint(x: 0.2432442983367057d, y: 0.1638270432216954d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8524101590675304d, y: 0.7349472446556238d), new NpgsqlTypes.NpgsqlPoint(x: 0.37479408832497096d, y: 0.3391437933689445d), new NpgsqlTypes.NpgsqlPoint(x: 0.23232049218400597d, y: 0.40888883730243686d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05744966264379159d, y: 0.38755874561466863d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218018642544218d, y: 0.6520059825730906d), new NpgsqlTypes.NpgsqlPoint(x: 0.14032583574376734d, y: 0.4527141171674971d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7764866212124566d, y: 0.8313735673138906d), new NpgsqlTypes.NpgsqlPoint(x: 0.33163797993525135d, y: 0.030839282764375753d), new NpgsqlTypes.NpgsqlPoint(x: 0.9049167899901882d, y: 0.5844187084750271d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9940030656171911d, y: 0.10730223540824524d), new NpgsqlTypes.NpgsqlPoint(x: 0.6414348946165292d, y: 0.11443327117420443d), new NpgsqlTypes.NpgsqlPoint(x: 0.24046272567166682d, y: 0.4100934462070591d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1385693926270244d, y: 0.551966365519415d), new NpgsqlTypes.NpgsqlPoint(x: 0.934516422890904d, y: 0.2821732144530259d), new NpgsqlTypes.NpgsqlPoint(x: 0.42334715536448175d, y: 0.4805837881509515d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5374760474734952d, y: 0.04428091197793982d), new NpgsqlTypes.NpgsqlPoint(x: 0.8141924669766664d, y: 0.7306897572442836d), new NpgsqlTypes.NpgsqlPoint(x: 0.2952707957816366d, y: 0.40140205770473636d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06883610723370559d, y: 0.5993183803393771d), new NpgsqlTypes.NpgsqlPoint(x: 0.10936762356205487d, y: 0.5286791784034515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492863559825294d, y: 0.41229593243415974d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9592551798682959d, y: 0.4581849101229284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8562266904872021d, y: 0.7847016077023117d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494065746894296d, y: 0.6363108952022032d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6807287013767628d, y: 0.1887883053091759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7518981375441578d, y: 0.27626146334529267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521567493715938d, y: 0.2961149333263837d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5495078768634777d, y: 0.574134375758416d), new NpgsqlTypes.NpgsqlPoint(x: 0.0857148982473166d, y: 0.37002115515074196d), new NpgsqlTypes.NpgsqlPoint(x: 0.04981617275404826d, y: 0.5735716628694816d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.537173120879325d, y: 0.5067046851890215d), new NpgsqlTypes.NpgsqlPoint(x: 0.3708346786266943d, y: 0.6380888730956199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8265100258232031d, y: 0.2396935926044066d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012596703261538389d, y: 0.6682189705885695d), new NpgsqlTypes.NpgsqlPoint(x: 0.23282948416764637d, y: 0.8290058713835886d), new NpgsqlTypes.NpgsqlPoint(x: 0.8022539873431691d, y: 0.9625564455977903d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7004581450736705d, y: 0.05940171827957563d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249791462240789d, y: 0.17165473010600285d), new NpgsqlTypes.NpgsqlPoint(x: 0.8821973783317153d, y: 0.6069775985504776d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.827748312304319d, y: 0.42894467318692253d), new NpgsqlTypes.NpgsqlPoint(x: 0.3548502908208706d, y: 0.03236704527038714d), new NpgsqlTypes.NpgsqlPoint(x: 0.43565563270238494d, y: 0.6848365347913243d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09893652405689024d, y: 0.4071648976190936d), new NpgsqlTypes.NpgsqlPoint(x: 0.4371045338392888d, y: 0.5113947485817437d), new NpgsqlTypes.NpgsqlPoint(x: 0.4899205130266835d, y: 0.37409591339076254d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13124577494760337d, y: 0.4841161910294465d), new NpgsqlTypes.NpgsqlPoint(x: 0.9486122578328424d, y: 0.03707023885896632d), new NpgsqlTypes.NpgsqlPoint(x: 0.9022037660215679d, y: 0.38145102565209343d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9123363522903742d, y: 0.0019191555858091291d), new NpgsqlTypes.NpgsqlPoint(x: 0.48478417402576046d, y: 0.5230228072254309d), new NpgsqlTypes.NpgsqlPoint(x: 0.3809865392587447d, y: 0.4968031192273602d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8067156444303499d, y: 0.03791976558561483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9782995954747642d, y: 0.2301304334590336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973251554621738d, y: 0.5299717208226434d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30829747943973596d, y: 0.30784622059931943d), new NpgsqlTypes.NpgsqlPoint(x: 0.582333751632823d, y: 0.83605514395508d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623571845254821d, y: 0.08271280372934875d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14967016695411983d, y: 0.46372094674359443d), new NpgsqlTypes.NpgsqlPoint(x: 0.4557831141513685d, y: 0.5277739318141245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5640073869857283d, y: 0.7394356436590813d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02459864980067583d, y: 0.8507534466883511d), new NpgsqlTypes.NpgsqlPoint(x: 0.8869104709776224d, y: 0.8576839808795076d), new NpgsqlTypes.NpgsqlPoint(x: 0.4854346151804314d, y: 0.8569407623381963d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9831045912582724d, y: 0.5587399910472225d), new NpgsqlTypes.NpgsqlPoint(x: 0.9415897363424056d, y: 0.9117857414615937d), new NpgsqlTypes.NpgsqlPoint(x: 0.2575562011013034d, y: 0.06776956222278041d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8594223307189657d, y: 0.8068248525039619d), new NpgsqlTypes.NpgsqlPoint(x: 0.7895232775900597d, y: 0.9997217094467198d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211990508336795d, y: 0.3385183271918283d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3179295526285556d, y: 0.6749954796000301d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873420763963295d, y: 0.9747057755442041d), new NpgsqlTypes.NpgsqlPoint(x: 0.767822653189644d, y: 0.46724937755267704d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9485240596230617d, y: 0.8722805118762538d), new NpgsqlTypes.NpgsqlPoint(x: 0.12065148229643996d, y: 0.8977092420156452d), new NpgsqlTypes.NpgsqlPoint(x: 0.6531995334367275d, y: 0.5191396426578578d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9976825954034271d, y: 0.8477328938203313d), new NpgsqlTypes.NpgsqlPoint(x: 0.16552110956830346d, y: 0.5719084406437115d), new NpgsqlTypes.NpgsqlPoint(x: 0.6254611021228359d, y: 0.8713152045623721d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1832801206191076d, y: 0.5996414017990213d), new NpgsqlTypes.NpgsqlPoint(x: 0.22067253187404645d, y: 0.8732137308450445d), new NpgsqlTypes.NpgsqlPoint(x: 0.1668128286523206d, y: 0.16054851700213768d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49540630534199825d, y: 0.3437128744002076d), new NpgsqlTypes.NpgsqlPoint(x: 0.13006596500372025d, y: 0.11346099024454581d), new NpgsqlTypes.NpgsqlPoint(x: 0.6643040946557225d, y: 0.16549483974376467d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03804411950136022d, y: 0.2253552898896134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605570781904647d, y: 0.36073290337893194d), new NpgsqlTypes.NpgsqlPoint(x: 0.26805775581745994d, y: 0.887021469998503d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6996305212896275d, y: 0.898761673042936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9887217999209623d, y: 0.8137260448562804d), new NpgsqlTypes.NpgsqlPoint(x: 0.47619784137641574d, y: 0.2703693220349417d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3610832835359641d, y: 0.7813944087357637d), new NpgsqlTypes.NpgsqlPoint(x: 0.035319590248960475d, y: 0.5095727505908721d), new NpgsqlTypes.NpgsqlPoint(x: 0.07686309512307887d, y: 0.30272703638793963d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5864284772641621d, y: 0.8208106571692697d), new NpgsqlTypes.NpgsqlPoint(x: 0.1814449367169506d, y: 0.9651794169427282d), new NpgsqlTypes.NpgsqlPoint(x: 0.1455624015044501d, y: 0.7217931986625424d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6208222272803386d, y: 0.542714667556879d), new NpgsqlTypes.NpgsqlPoint(x: 0.13607108421968062d, y: 0.42335392204272393d), new NpgsqlTypes.NpgsqlPoint(x: 0.37777894579622484d, y: 0.9057225238234887d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2562420611686326d, y: 0.7899130818986391d), new NpgsqlTypes.NpgsqlPoint(x: 0.4911757176300139d, y: 0.5844557112223913d), new NpgsqlTypes.NpgsqlPoint(x: 0.5777354509363464d, y: 0.582445155626686d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36906481698865523d, y: 0.04603931087921631d), new NpgsqlTypes.NpgsqlPoint(x: 0.7757220524872941d, y: 0.808894731219957d), new NpgsqlTypes.NpgsqlPoint(x: 0.0096131236740008d, y: 0.8948543334777164d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11838507705766876d, y: 0.1527336045543508d), new NpgsqlTypes.NpgsqlPoint(x: 0.5542433598684235d, y: 0.034312373333592494d), new NpgsqlTypes.NpgsqlPoint(x: 0.6849088123534609d, y: 0.38947391731664793d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7279802205369895d, y: 0.9948903787536201d), new NpgsqlTypes.NpgsqlPoint(x: 0.37235170743996815d, y: 0.8507387881742332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9140032371443552d, y: 0.819318618363206d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38550178786474565d, y: 0.2729636289931442d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599344750283795d, y: 0.5843894267920282d), new NpgsqlTypes.NpgsqlPoint(x: 0.3579584690171762d, y: 0.18527751516501734d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9606126753226845d, y: 0.858592122356968d), new NpgsqlTypes.NpgsqlPoint(x: 0.5619249540683411d, y: 0.861265880075051d), new NpgsqlTypes.NpgsqlPoint(x: 0.7099703161800325d, y: 0.2613862932028962d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45637426984585705d, y: 0.3484609187171497d), new NpgsqlTypes.NpgsqlPoint(x: 0.6482564666424385d, y: 0.38473765701674456d), new NpgsqlTypes.NpgsqlPoint(x: 0.5232801903310895d, y: 0.25766675853746934d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10756766331106427d, y: 0.7799797862227967d), new NpgsqlTypes.NpgsqlPoint(x: 0.5566005073016692d, y: 0.11285803078584211d), new NpgsqlTypes.NpgsqlPoint(x: 0.6452104526790283d, y: 0.403857011055056d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4332380273637624d, y: 0.9125057440756494d), new NpgsqlTypes.NpgsqlPoint(x: 0.044167493716240624d, y: 0.9881109880496965d), new NpgsqlTypes.NpgsqlPoint(x: 0.048468788856263045d, y: 0.7009237294747656d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06460510408402498d, y: 0.14283227860806125d), new NpgsqlTypes.NpgsqlPoint(x: 0.3563990697218109d, y: 0.3995019159124923d), new NpgsqlTypes.NpgsqlPoint(x: 0.9621922325096572d, y: 0.9528239806191138d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8858185215551637d, y: 0.8979387900014677d), new NpgsqlTypes.NpgsqlPoint(x: 0.22611415949038305d, y: 0.5283561031503974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7608511921606336d, y: 0.23571731790399497d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9266813188959131d, y: 0.7471680814219812d), new NpgsqlTypes.NpgsqlPoint(x: 0.10783185676686313d, y: 0.059444464351877335d), new NpgsqlTypes.NpgsqlPoint(x: 0.866931838521256d, y: 0.3097186105050864d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7163886164555725d, y: 0.3246944747856193d), new NpgsqlTypes.NpgsqlPoint(x: 0.2331560477423894d, y: 0.7307498288415991d), new NpgsqlTypes.NpgsqlPoint(x: 0.21657105107762642d, y: 0.19619629693733898d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7330056724795087d, y: 0.5853388019382944d), new NpgsqlTypes.NpgsqlPoint(x: 0.16539460523925886d, y: 0.36815790604350895d), new NpgsqlTypes.NpgsqlPoint(x: 0.41562643863254967d, y: 0.5112184924465002d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4167540614123556d, y: 0.8715085893301947d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317971065757764d, y: 0.2259805101040454d), new NpgsqlTypes.NpgsqlPoint(x: 0.13906299680982703d, y: 0.2953461684750168d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.765276156205041d, y: 0.1757833614052834d), new NpgsqlTypes.NpgsqlPoint(x: 0.8557067438346195d, y: 0.14041777046122894d), new NpgsqlTypes.NpgsqlPoint(x: 0.5798142587357217d, y: 0.10668708370169766d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7189528730039205d, y: 0.470733717819557d), new NpgsqlTypes.NpgsqlPoint(x: 0.7044154406344917d, y: 0.527860330400291d), new NpgsqlTypes.NpgsqlPoint(x: 0.5075905711500402d, y: 0.6375068727023919d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6814646887118319d, y: 0.5870447806015985d), new NpgsqlTypes.NpgsqlPoint(x: 0.7141088020074676d, y: 0.8506164014382613d), new NpgsqlTypes.NpgsqlPoint(x: 0.07148838739150387d, y: 0.003663942179027213d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6145035951018423d, y: 0.4151036203146975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7004750193464908d, y: 0.3380366501206261d), new NpgsqlTypes.NpgsqlPoint(x: 0.810519173351565d, y: 0.0478493482574186d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7492174240039161d, y: 0.08282106823544833d), new NpgsqlTypes.NpgsqlPoint(x: 0.4607118890332076d, y: 0.44839476981159954d), new NpgsqlTypes.NpgsqlPoint(x: 0.035280601987208726d, y: 0.004986805084666757d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3930792080004688d, y: 0.08547402632963474d), new NpgsqlTypes.NpgsqlPoint(x: 0.4588954966630555d, y: 0.664715470540585d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734619569248368d, y: 0.6187773393134908d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9921967392209594d, y: 0.005324021600039641d), new NpgsqlTypes.NpgsqlPoint(x: 0.15226397995676444d, y: 0.641046790696018d), new NpgsqlTypes.NpgsqlPoint(x: 0.811999610013245d, y: 0.37744537198638806d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.186970490442659d, y: 0.3451390272658863d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445902420550387d, y: 0.48907474339416235d), new NpgsqlTypes.NpgsqlPoint(x: 0.8039184259625222d, y: 0.4072848600430917d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05242960682683662d, y: 0.6540051456039441d), new NpgsqlTypes.NpgsqlPoint(x: 0.7280841902458326d, y: 0.3235259138441232d), new NpgsqlTypes.NpgsqlPoint(x: 0.41120849235484813d, y: 0.013456495131050072d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7915660423936159d, y: 0.31713392537543617d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658698824514379d, y: 0.3025998210127502d), new NpgsqlTypes.NpgsqlPoint(x: 0.20262808221924777d, y: 0.7590532800254641d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.020924390604592835d, y: 0.637678445829915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8226201046568399d, y: 0.3969892332592275d), new NpgsqlTypes.NpgsqlPoint(x: 0.6248126220866737d, y: 0.06339006986686535d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5791088269538268d, y: 0.08051917481617166d), new NpgsqlTypes.NpgsqlPoint(x: 0.2711816649658737d, y: 0.02297087085078975d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280291026919064d, y: 0.5966714906834759d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9483666360862204d, y: 0.0815083926080582d), new NpgsqlTypes.NpgsqlPoint(x: 0.3658433189403464d, y: 0.7893667029967026d), new NpgsqlTypes.NpgsqlPoint(x: 0.12744625125059217d, y: 0.21506375125784238d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26646137948321624d, y: 0.8217857933086082d), new NpgsqlTypes.NpgsqlPoint(x: 0.21035232645070356d, y: 0.3325405940947096d), new NpgsqlTypes.NpgsqlPoint(x: 0.2432442983367057d, y: 0.1638270432216954d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8524101590675304d, y: 0.7349472446556238d), new NpgsqlTypes.NpgsqlPoint(x: 0.37479408832497096d, y: 0.3391437933689445d), new NpgsqlTypes.NpgsqlPoint(x: 0.23232049218400597d, y: 0.40888883730243686d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05744966264379159d, y: 0.38755874561466863d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218018642544218d, y: 0.6520059825730906d), new NpgsqlTypes.NpgsqlPoint(x: 0.14032583574376734d, y: 0.4527141171674971d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7764866212124566d, y: 0.8313735673138906d), new NpgsqlTypes.NpgsqlPoint(x: 0.33163797993525135d, y: 0.030839282764375753d), new NpgsqlTypes.NpgsqlPoint(x: 0.9049167899901882d, y: 0.5844187084750271d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9940030656171911d, y: 0.10730223540824524d), new NpgsqlTypes.NpgsqlPoint(x: 0.6414348946165292d, y: 0.11443327117420443d), new NpgsqlTypes.NpgsqlPoint(x: 0.24046272567166682d, y: 0.4100934462070591d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1385693926270244d, y: 0.551966365519415d), new NpgsqlTypes.NpgsqlPoint(x: 0.934516422890904d, y: 0.2821732144530259d), new NpgsqlTypes.NpgsqlPoint(x: 0.42334715536448175d, y: 0.4805837881509515d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5374760474734952d, y: 0.04428091197793982d), new NpgsqlTypes.NpgsqlPoint(x: 0.8141924669766664d, y: 0.7306897572442836d), new NpgsqlTypes.NpgsqlPoint(x: 0.2952707957816366d, y: 0.40140205770473636d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06883610723370559d, y: 0.5993183803393771d), new NpgsqlTypes.NpgsqlPoint(x: 0.10936762356205487d, y: 0.5286791784034515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492863559825294d, y: 0.41229593243415974d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9592551798682959d, y: 0.4581849101229284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8562266904872021d, y: 0.7847016077023117d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494065746894296d, y: 0.6363108952022032d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6807287013767628d, y: 0.1887883053091759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7518981375441578d, y: 0.27626146334529267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521567493715938d, y: 0.2961149333263837d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5495078768634777d, y: 0.574134375758416d), new NpgsqlTypes.NpgsqlPoint(x: 0.0857148982473166d, y: 0.37002115515074196d), new NpgsqlTypes.NpgsqlPoint(x: 0.04981617275404826d, y: 0.5735716628694816d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.537173120879325d, y: 0.5067046851890215d), new NpgsqlTypes.NpgsqlPoint(x: 0.3708346786266943d, y: 0.6380888730956199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8265100258232031d, y: 0.2396935926044066d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012596703261538389d, y: 0.6682189705885695d), new NpgsqlTypes.NpgsqlPoint(x: 0.23282948416764637d, y: 0.8290058713835886d), new NpgsqlTypes.NpgsqlPoint(x: 0.8022539873431691d, y: 0.9625564455977903d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7004581450736705d, y: 0.05940171827957563d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249791462240789d, y: 0.17165473010600285d), new NpgsqlTypes.NpgsqlPoint(x: 0.8821973783317153d, y: 0.6069775985504776d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.827748312304319d, y: 0.42894467318692253d), new NpgsqlTypes.NpgsqlPoint(x: 0.3548502908208706d, y: 0.03236704527038714d), new NpgsqlTypes.NpgsqlPoint(x: 0.43565563270238494d, y: 0.6848365347913243d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09893652405689024d, y: 0.4071648976190936d), new NpgsqlTypes.NpgsqlPoint(x: 0.4371045338392888d, y: 0.5113947485817437d), new NpgsqlTypes.NpgsqlPoint(x: 0.4899205130266835d, y: 0.37409591339076254d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13124577494760337d, y: 0.4841161910294465d), new NpgsqlTypes.NpgsqlPoint(x: 0.9486122578328424d, y: 0.03707023885896632d), new NpgsqlTypes.NpgsqlPoint(x: 0.9022037660215679d, y: 0.38145102565209343d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9123363522903742d, y: 0.0019191555858091291d), new NpgsqlTypes.NpgsqlPoint(x: 0.48478417402576046d, y: 0.5230228072254309d), new NpgsqlTypes.NpgsqlPoint(x: 0.3809865392587447d, y: 0.4968031192273602d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8067156444303499d, y: 0.03791976558561483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9782995954747642d, y: 0.2301304334590336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973251554621738d, y: 0.5299717208226434d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30829747943973596d, y: 0.30784622059931943d), new NpgsqlTypes.NpgsqlPoint(x: 0.582333751632823d, y: 0.83605514395508d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623571845254821d, y: 0.08271280372934875d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14967016695411983d, y: 0.46372094674359443d), new NpgsqlTypes.NpgsqlPoint(x: 0.4557831141513685d, y: 0.5277739318141245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5640073869857283d, y: 0.7394356436590813d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 0; i < 6; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInnerAsync(connection);
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

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 4; i < 10; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInner(connection);
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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0M>(15);

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
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

