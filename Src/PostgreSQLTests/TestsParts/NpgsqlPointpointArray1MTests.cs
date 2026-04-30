

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
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6308681946228275d, y: 0.17302595173221147d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6470062599165739d, y: 0.5192786710192238d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16166605056974426d, y: 0.06810019898062147d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7263923550340494d, y: 0.5719800680298655d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8446147860051365d, y: 0.633208651018108d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9333225856722727d, y: 0.728162230099723d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46044594588287713d, y: 0.7827298999680206d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8881500021231259d, y: 0.12395517750014218d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47835131574978706d, y: 0.5463589196511786d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9126997005957654d, y: 0.4495507946347347d),
new NpgsqlTypes.NpgsqlPoint(x: 0.882107117837136d, y: 0.22173098383791112d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8244514316790059d, y: 0.25163477234828935d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37857317851069594d, y: 0.4048005702179386d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3491534531467442d, y: 0.9747617832813095d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4967188218081249d, y: 0.1578307393577617d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2976246261303186d, y: 0.15750732357153652d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8903564966230969d, y: 0.6457144168587066d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9537590463667533d, y: 0.7452832289755366d),
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
new NpgsqlTypes.NpgsqlPoint(x: 0.4408938930460382d, y: 0.5869524787806321d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10285157378712717d, y: 0.9251354162573782d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3974165331022874d, y: 0.4976089001360813d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07114945724229971d, y: 0.778403188339385d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3172781782408205d, y: 0.6133608031244956d),
new NpgsqlTypes.NpgsqlPoint(x: 0.782083152080759d, y: 0.4588899662203175d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5262364126774528d, y: 0.5585440439523391d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.914550804201038d, y: 0.15986013593550774d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4122171491192026d, y: 0.3624142264595094d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7540205127815812d, y: 0.76681614704362d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7942176456961435d, y: 0.9682971012456351d),
new NpgsqlTypes.NpgsqlPoint(x: 0.503097504359905d, y: 0.37593253518074055d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5597348535847964d, y: 0.9267098683263785d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7861989088184569d, y: 0.6222708231829726d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8373667521271979d, y: 0.16320102463418185d),
new NpgsqlTypes.NpgsqlPoint(x: 0.842684803684135d, y: 0.6127200114245496d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4876714172980041d, y: 0.692021929450654d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6506503645824264d, y: 0.010875963799596655d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5342496886604041d, y: 0.03960905661099923d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09779587861434325d, y: 0.12370988515604664d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.676223067176656d, y: 0.5912722707542759d),
new NpgsqlTypes.NpgsqlPoint(x: 0.031560490174950884d, y: 0.5344384126021607d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6443288355054841d, y: 0.5823292285478604d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20848934367326954d, y: 0.3878823670939133d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0541019889728559d, y: 0.48295274543069566d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06811599870175877d, y: 0.5306950182821301d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3422608037958016d, y: 0.11960054213229199d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4844854303283167d, y: 0.6510214702882d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14949530130678856d, y: 0.4911304546601043d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22354009225897353d, y: 0.21830803837105828d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47636871831956495d, y: 0.029792819706141116d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3752084892304627d, y: 0.32468039525460857d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22500605921974148d, y: 0.9188537354218848d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8022569220606787d, y: 0.14661246094615388d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30337468789606525d, y: 0.9147397008174023d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6316529021648682d, y: 0.37015345166487923d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7532679541389087d, y: 0.9722574674221228d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7365447840473467d, y: 0.2001236742223077d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18272672556126401d, y: 0.8360313163538652d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13292203694036175d, y: 0.9042229894418015d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9885657273414501d, y: 0.4284552740272626d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3982961251361766d, y: 0.9495812175236243d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25283663010841384d, y: 0.26455157913011285d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44202985823787344d, y: 0.6766401981596841d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9496420604709965d, y: 0.25517431309294236d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8929312954311d, y: 0.9360618316159894d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1963170245563245d, y: 0.24604571776524464d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5855462599668542d, y: 0.2824291654282055d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16544032027680744d, y: 0.9672201223913971d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7032245888366551d, y: 0.036352571531730216d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45061012286670266d, y: 0.41346170599088183d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.025583608453647377d, y: 0.6208836511740723d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20155896138352136d, y: 0.6471116873853873d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3787517563623847d, y: 0.7699399835640822d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08661980693341798d, y: 0.3521313323202827d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4665249699915228d, y: 0.07197955064901551d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34688402136827845d, y: 0.037416202166982826d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39280297176122136d, y: 0.09155857789535604d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9083656978767515d, y: 0.9160273177999705d),
new NpgsqlTypes.NpgsqlPoint(x: 0.033990433200890235d, y: 0.6368942568248193d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44618265204969965d, y: 0.9838845169394496d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2923223812153276d, y: 0.406092466276337d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8657921879144757d, y: 0.6465680559282068d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7321062074414235d, y: 0.061659281891616846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7855764740037497d, y: 0.7463491530855728d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1998092091851874d, y: 0.8304915848752693d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3464815652951504d, y: 0.03279626517224965d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7551590312199066d, y: 0.921631031068819d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38165063049837766d, y: 0.2213274776209141d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7779473762791554d, y: 0.22729226107375955d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.010577919297199978d, y: 0.6653576769838624d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4372890207951968d, y: 0.23770019521949182d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2649493571351388d, y: 0.37569393100326576d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6276865205650596d, y: 0.5756750462882367d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8600795945767903d, y: 0.8131412463107284d),
new NpgsqlTypes.NpgsqlPoint(x: 0.122351995271199d, y: 0.8922315421321897d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27741734331802603d, y: 0.0719416977585221d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6907571316188603d, y: 0.20444560104328924d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04245353025837073d, y: 0.6348197873801364d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8596960767265781d, y: 0.8536185284195277d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15620478349684896d, y: 0.5672896192549639d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2175417256633556d, y: 0.36415712301364533d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7354513476811827d, y: 0.45686480590353806d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12000560806928173d, y: 0.4284492691074938d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47420268415831457d, y: 0.03601503832850639d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7632359341665671d, y: 0.9201885249727213d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17713110981104963d, y: 0.1615723631526519d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5490267403626875d, y: 0.8377392349011625d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5820775713987536d, y: 0.31679535176902696d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9033474754113262d, y: 0.8823511092430933d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22040205979984284d, y: 0.7218561805518213d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7221386934830848d, y: 0.14248688066080473d),
new NpgsqlTypes.NpgsqlPoint(x: 0.419893368285327d, y: 0.021367150540805402d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8577191091310439d, y: 0.5461583251805211d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2887657189317039d, y: 0.6610792762372756d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9904248355200631d, y: 0.34609983071131545d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5437878125017545d, y: 0.09259101931039093d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7144240796660715d, y: 0.01486239052561289d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2212580766089296d, y: 0.3653224133626831d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16131664568301274d, y: 0.22570090140525945d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.746666758489297d, y: 0.09568175087419173d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5678881696208736d, y: 0.4703246875087841d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2207211958425661d, y: 0.6820013576335398d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47143033986076077d, y: 0.2528503921843057d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5556323494132922d, y: 0.8734567969884737d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08284543857629467d, y: 0.997542089846655d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10661509074504794d, y: 0.5144038969540836d),
new NpgsqlTypes.NpgsqlPoint(x: 0.667133666517292d, y: 0.905253761731553d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7371206529923967d, y: 0.842736142728118d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10297841261518526d, y: 0.7410252987631565d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8922078844568301d, y: 0.8462021697921288d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33036510135874253d, y: 0.23203976999097098d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6668957042726512d, y: 0.8715125807057695d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15645940125189473d, y: 0.49620873210726024d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46566395117870385d, y: 0.06238589622654411d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7606553314582591d, y: 0.760890364128433d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04032051708359574d, y: 0.29920273645205053d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41219525458511985d, y: 0.7423196087919961d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34993787437873924d, y: 0.0026422475611749263d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07544140586640813d, y: 0.3189291568778734d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4902132557966967d, y: 0.12941926447219165d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1909869075981384d, y: 0.09611991849966783d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08314236050723878d, y: 0.7793866204459191d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38602682938598176d, y: 0.2204323432299078d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6348518215674138d, y: 0.4401246300547069d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22000696664575758d, y: 0.6422466953932906d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6577022826933697d, y: 0.3351082620340262d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9041225747614623d, y: 0.8244016836774741d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8995347967861119d, y: 0.9720611453377744d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1230930933866593d, y: 0.7171067372310856d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26406556479870347d, y: 0.6700388306457291d),
new NpgsqlTypes.NpgsqlPoint(x: 0.658432916253056d, y: 0.7957286879139387d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8963151780881359d, y: 0.8415069662371867d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9773948307995942d, y: 0.032639729814262d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21158826766623773d, y: 0.8333313963078292d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11886268151331636d, y: 0.5176504570496623d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16878663726155851d, y: 0.038047981744612325d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8618190021630979d, y: 0.5187824180543401d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5478520965830317d, y: 0.13157934620256428d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9417834103008782d, y: 0.9149170578744692d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34321293789395857d, y: 0.9413738319211201d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7336610075856017d, y: 0.8450558709046516d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8590579283714472d, y: 0.8277579637546224d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04454193791331296d, y: 0.7639241514812632d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04830069447436425d, y: 0.2411914596654834d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6892965677002215d, y: 0.883402430145169d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3414684392511712d, y: 0.28168494044084746d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7441823992987934d, y: 0.8581791903831089d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15664226311779839d, y: 0.04860419615570455d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7038673161129549d, y: 0.640529681421774d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6237964973240901d, y: 0.584896290850109d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6043293690848482d, y: 0.23674562570961288d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8967432327417377d, y: 0.6378272603683147d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15778499004936442d, y: 0.10702845852415743d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7688191121725059d, y: 0.16401084212212325d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5767572566927415d, y: 0.5727960774388923d),
new NpgsqlTypes.NpgsqlPoint(x: 0.271459901153868d, y: 0.46469947370672193d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6211118857087224d, y: 0.27831166998495815d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7173316284682681d, y: 0.1378224949731921d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15364728192037314d, y: 0.18510345573228526d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1714624811220441d, y: 0.0579120672992125d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12963570128360835d, y: 0.7386216072052236d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5089957159172463d, y: 0.8774494739097582d),
new NpgsqlTypes.NpgsqlPoint(x: 0.970140890451587d, y: 0.5034104374673511d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9521080833251425d, y: 0.6831373640773452d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4665264807559584d, y: 0.523603408630758d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7890482033090549d, y: 0.9244824815907284d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6896997996795966d, y: 0.1602198291740744d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9314305641830963d, y: 0.6429362892468632d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9092037576073028d, y: 0.5583797986999274d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5594792527769706d, y: 0.5257749108089562d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9701336090780783d, y: 0.8330335384336034d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23726921069467177d, y: 0.7960127056875126d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5213140060168606d, y: 0.8599395216579749d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5810926683189409d, y: 0.8336628532821402d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8587693212299206d, y: 0.7793672199820897d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10951981720545467d, y: 0.5198329719739895d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8674656379622828d, y: 0.5008530215440795d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7105999216501858d, y: 0.9487933182275732d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9344747530654137d, y: 0.717973603148773d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9271802600522153d, y: 0.4217311267439806d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08587868930887865d, y: 0.5717115412157604d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8247938244333209d, y: 0.8062629123282828d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36526218016416334d, y: 0.4328620108292458d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3391829060459639d, y: 0.6645918919426466d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11257846107415825d, y: 0.2735430554999385d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12952143920966863d, y: 0.7575466093932339d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7906535786034589d, y: 0.33405066672865513d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8790277185155936d, y: 0.08523276133323021d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4019330987757327d, y: 0.08335661362417368d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17320790467734504d, y: 0.45577311461334835d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6283426705641623d, y: 0.6042072447915601d),
new NpgsqlTypes.NpgsqlPoint(x: 0.952598498011664d, y: 0.008759694093650516d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07028142667657d, y: 0.6535508531259501d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24101121712612705d, y: 0.4350569306160442d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9441517867478338d, y: 0.36614578917306473d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5543007016689395d, y: 0.6107103451021835d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28075486630710667d, y: 0.6906057532550951d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4937489862801676d, y: 0.39555559730407497d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3408551463154462d, y: 0.027231832479261087d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48654722223076363d, y: 0.05593160703696709d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7307222685553277d, y: 0.7507068470440921d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19186170053298013d, y: 0.2735917296324706d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2756245654495403d, y: 0.2277608324461814d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5001988383199759d, y: 0.4180958538894419d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9533311404224235d, y: 0.5448629843593048d),
new NpgsqlTypes.NpgsqlPoint(x: 0.856459507147158d, y: 0.8525006992912787d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2563545194110691d, y: 0.31106148673874146d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10656971770497314d, y: 0.0536611748340432d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4490626451801625d, y: 0.7812153975380076d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31915800518621285d, y: 0.019510115409046014d),
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
new NpgsqlTypes.NpgsqlPoint(x: 0.17553132064759724d, y: 0.5683571143625069d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5836203177628102d, y: 0.1648779626253838d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8526530240214248d, y: 0.6275572466103536d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05707216676994453d, y: 0.25219679377687343d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.750081153376293d, y: 0.04964168860021689d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6932887739605696d, y: 0.686583696664516d),
new NpgsqlTypes.NpgsqlPoint(x: 0.880142651648076d, y: 0.1841662479707421d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.00014365954217632204d, y: 0.9120185250660026d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9690589716423532d, y: 0.11149392156011695d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3672424560202424d, y: 0.1068962456529905d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8607619578681766d, y: 0.33301635332288493d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2858884657920999d, y: 0.8063845124849643d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6353806710144967d, y: 0.06890837263294947d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9538723714059469d, y: 0.23395459004070018d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1355627333512559d, y: 0.502360001270992d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6066423248875451d, y: 0.7262696572277572d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9178724770527323d, y: 0.4808059351587506d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5026980544275801d, y: 0.7914142223254766d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15078897955458348d, y: 0.7929231837555325d),
new NpgsqlTypes.NpgsqlPoint(x: 0.647071806616998d, y: 0.6366119260218193d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4661530504885518d, y: 0.6558460473165012d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.713639994765447d, y: 0.41952352471735155d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9009109794562558d, y: 0.37812884575886896d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5245572336408961d, y: 0.6532065571703018d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9385435709609689d, y: 0.02377188416608944d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8487026595642638d, y: 0.8398826039976067d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9551254681117536d, y: 0.5296188129059018d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1049791465991523d, y: 0.7350656169146821d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24530501556778495d, y: 0.36549807136038603d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17628359313446595d, y: 0.821872591126368d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10990199526945599d, y: 0.8612078997422441d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3261997151184812d, y: 0.7172148256852711d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30871361446155454d, y: 0.9064297532928162d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9513428637161621d, y: 0.3899655517265054d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9137680483619781d, y: 0.8521616669989187d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5080911795414933d, y: 0.3030127413020418d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8941954002043092d, y: 0.781298570284907d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8408145396509333d, y: 0.5687325834695215d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2333875041697433d, y: 0.6342001368611437d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6144511659584396d, y: 0.97193426118821d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9371052925597269d, y: 0.9356739759216973d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7317259084536208d, y: 0.26237556620748714d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14613479595874235d, y: 0.02351509902331328d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5362784409815414d, y: 0.4306614626801313d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5397264444700844d, y: 0.3082012940413733d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7197483236870169d, y: 0.8402466593222538d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9912454680158089d, y: 0.8187705955520755d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4758794119577445d, y: 0.9813335631548741d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33146967584621057d, y: 0.1852565511933223d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8362450130765637d, y: 0.0005505803194412184d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5641044709899723d, y: 0.14616419522737412d),
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlPoint(x: 0.0541019889728559d, y: 0.48295274543069566d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06811599870175877d, y: 0.5306950182821301d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3422608037958016d, y: 0.11960054213229199d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4844854303283167d, y: 0.6510214702882d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3752084892304627d, y: 0.32468039525460857d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22500605921974148d, y: 0.9188537354218848d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8022569220606787d, y: 0.14661246094615388d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30337468789606525d, y: 0.9147397008174023d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9496420604709965d, y: 0.25517431309294236d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8929312954311d, y: 0.9360618316159894d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1963170245563245d, y: 0.24604571776524464d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7321062074414235d, y: 0.061659281891616846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7855764740037497d, y: 0.7463491530855728d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1998092091851874d, y: 0.8304915848752693d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3464815652951504d, y: 0.03279626517224965d),
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
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
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[34], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 143;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 129, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 48, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 128, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 95, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[32],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 127, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[34], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 138, query1, 6, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 25, query1, 138, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[34], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 20, query1, 90, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 166, 20))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 11, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[34], false);
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
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[29], false);NpgsqlPointpointArray1M.AssertModel(models[24],_testData[30], false);NpgsqlPointpointArray1M.AssertModel(models[25],_testData[31], false);NpgsqlPointpointArray1M.AssertModel(models[26],_testData[32], false);NpgsqlPointpointArray1M.AssertModel(models[27],_testData[33], false);NpgsqlPointpointArray1M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[29], false);NpgsqlPointpointArray1M.AssertModel(models[24],_testData[30], false);NpgsqlPointpointArray1M.AssertModel(models[25],_testData[31], false);NpgsqlPointpointArray1M.AssertModel(models[26],_testData[32], false);NpgsqlPointpointArray1M.AssertModel(models[27],_testData[33], false);NpgsqlPointpointArray1M.AssertModel(models[28],_testData[34], false);
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
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
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

